from binance.client import Client
import pandas as pd
import numpy as np
import joblib
import time
import logging
from datetime import datetime
import os

# === CONFIGURAÇÃO DO LOGGER ===
BASE_DIR = os.path.dirname(os.path.abspath(__file__))
os.path.abspath(os.path.join(BASE_DIR, "..", "Log", "registro_ordens.log"))

logging.basicConfig(
    filename=os.path.abspath(os.path.abspath(os.path.join(BASE_DIR, "..", "Log", "registro_ordens.log"))),  # Caminho: Log/registro_ordens.log
    level=logging.INFO,
    format='[%(asctime)s] %(message)s',
    datefmt='%Y-%m-%d %H:%M:%S'
)

# === CONFIGURAÇÕES DO BOT ===
API_KEY = 'Nnmy9AgWEQNCkmilZYbd4sqIdb0Rl6PaPeUiTf4eQnSqUs155jytuGvDBcfmcibJ'
API_SECRET = 'ObcoIzsBKl3pAZKdptS59yxw7YdKcIlpjbUbISnHQtmvLzF0ZAzbSUyGJgTFYSsQ'
SYMBOL = 'SOLUSDT'
INTERVAL = Client.KLINE_INTERVAL_5MINUTE
QUANTIDADE = 1
POSICAO_ATUAL = 'neutro'
BASE_DIR = os.path.dirname(os.path.abspath(__file__))

# === INICIAR CLIENTE BINANCE TESTNET ===
testnet_url = 'https://testnet.binance.vision/api'
client = Client(API_KEY, API_SECRET)
client.API_URL = testnet_url

# === CARREGAR MODELO E LABEL ENCODER ===
modelo = joblib.load(os.path.abspath(os.path.join(BASE_DIR, "..", "Modelos", "modelo_sol_xgb_percentil.pkl")))
le = joblib.load(os.path.abspath(os.path.join(BASE_DIR, "..", "Modelos", "label_encoder_acao.pkl")))


# === FUNÇÕES AUXILIARES ===

def calcular_indicadores(df):
    df['SMA_10'] = df['close'].rolling(window=10).mean()
    df['SMA_30'] = df['close'].rolling(window=30).mean()
    df['EMA_12'] = df['close'].ewm(span=12, adjust=False).mean()
    df['EMA_26'] = df['close'].ewm(span=26, adjust=False).mean()
    df['STD_20'] = df['close'].rolling(window=20).std()
    df['Upper_BB'] = df['EMA_26'] + (2 * df['STD_20'])
    df['Lower_BB'] = df['EMA_26'] - (2 * df['STD_20'])
    delta = df['close'].diff()
    ganho = np.where(delta > 0, delta, 0)
    perda = np.where(delta < 0, -delta, 0)
    ganho_rolado = pd.Series(ganho).rolling(14).mean()
    perda_rolada = pd.Series(perda).rolling(14).mean()
    rs = ganho_rolado / perda_rolada
    df['RSI'] = 100 - (100 / (1 + rs))
    df['MACD'] = df['EMA_12'] - df['EMA_26']
    df['MACD_signal'] = df['MACD'].ewm(span=9, adjust=False).mean()
    df['MACD_hist'] = df['MACD'] - df['MACD_signal']
    df['14-high'] = df['high'].rolling(window=14).max()
    df['14-low'] = df['low'].rolling(window=14).min()
    df['Stoch_K'] = 100 * ((df['close'] - df['14-low']) / (df['14-high'] - df['14-low']))
    df['Stoch_D'] = df['Stoch_K'].rolling(window=3).mean()
    df['CCI'] = (df['close'] - df['close'].rolling(20).mean()) / (0.015 * df['close'].rolling(20).std())
    df['ROC'] = df['close'].pct_change(periods=10) * 100
    df['H-L'] = df['high'] - df['low']
    df['H-C'] = df['high'] - df['close']
    df['L-C'] = df['low'] - df['close']
    df['TR'] = df[['H-L', 'H-C', 'L-C']].max(axis=1)
    df['ATR'] = df['TR'].rolling(window=14).mean()
    df['Momentum'] = df['close'] - df['close'].shift(10)
    df['OBV'] = (np.sign(df['close'].diff()) * df['volume']).fillna(0).cumsum()
    df['Z_Score'] = (df['close'] - df['close'].rolling(20).mean()) / df['close'].rolling(20).std()
    df['Williams_%R'] = -100 * ((df['14-high'] - df['close']) / (df['14-high'] - df['14-low']))
    df['MFI'] = df['close'] * df['volume']
    df['Volume_Osc'] = df['volume'].pct_change()
    df['retorno'] = df['close'].pct_change()
    return df

def pegar_dados():
    try:
        klines = client.get_klines(symbol=SYMBOL, interval=INTERVAL, limit=100)
        df = pd.DataFrame(klines, columns=[
            'timestamp', 'open', 'high', 'low', 'close', 'volume',
            'close_time', 'quote_asset_volume', 'number_of_trades',
            'taker_buy_base_volume', 'taker_buy_quote_volume', 'ignore'
        ])
        df = df.astype({'open': float, 'high': float, 'low': float, 'close': float, 'volume': float})
        df = calcular_indicadores(df)
        return df.dropna()
    except Exception as e:
        logging.error(f"[ERRO] Falha ao obter dados: {e}")
        return None

def executar_ordem(tipo):
    try:
        agora = datetime.now().strftime("%Y-%m-%d %H:%M:%S")
        if tipo == 'comprar':
            ordem = client.order_market_buy(symbol=SYMBOL, quantity=QUANTIDADE)
        elif tipo == 'vender':
            ordem = client.order_market_sell(symbol=SYMBOL, quantity=QUANTIDADE)
        else:
            return None
        preco_exec = float(ordem['fills'][0]['price'])
        print(f"[{agora}] [INFO] {tipo.upper()} executada a {preco_exec:.2f} USDT")
        return preco_exec
    except Exception as e:
        logging.error(f"[ERRO] Falha ao executar ordem: {e}")
        return None

# === LOOP DO BOT ===
ULTIMO_PRECO_COMPRA = None
features_modelo = modelo.get_booster().feature_names
LUCRO_TOTAL = 0.0  # Variável para totalizar lucros e perdas

while True:
    dados = pegar_dados()
    

    if dados is None or len(dados) < 30:
        print("[DEBUG] Dados insuficientes ou erro na coleta. Aguardando novo ciclo...")
        time.sleep(60)
        continue

    entrada = dados[features_modelo].iloc[-1:].copy()
    previsao = modelo.predict(entrada)[0]
    acao_prevista = le.inverse_transform([int(previsao)])[0]
    preco_atual = dados.iloc[-1]['close']

    print(f"[IA] Ação sugerida: {acao_prevista.upper()} | Preço: {preco_atual:.2f} | Posição atual: {POSICAO_ATUAL}")
    logging.info(f"[IA] Ação sugerida: {acao_prevista.upper()} | Preço: {preco_atual:.2f} | Posição atual: {POSICAO_ATUAL}")

    if acao_prevista == 'Comprar' and POSICAO_ATUAL == 'neutro':
        preco = executar_ordem('comprar')
        if preco:
            logging.info(f"[BOT] COMPRA a {preco:.2f} USDT")
            ULTIMO_PRECO_COMPRA = preco
            POSICAO_ATUAL = 'comprado'

    elif acao_prevista == 'Vender' and POSICAO_ATUAL == 'comprado':
        preco = executar_ordem('vender')
        if preco and ULTIMO_PRECO_COMPRA:
            lucro = preco - ULTIMO_PRECO_COMPRA
            LUCRO_TOTAL += lucro  # Atualiza o total de lucros/perdas
            logging.info(f"[BOT] VENDA a {preco:.2f} USDT | Lucro da operação: {lucro:.2f} USDT | Lucro total: {LUCRO_TOTAL:.2f}")
            print(f"[BOT] VENDA a {preco:.2f} USDT | Lucro da operação: {lucro:.2f} USDT | Lucro total: {LUCRO_TOTAL:.2f}")
        POSICAO_ATUAL = 'neutro'

    elif acao_prevista == 'Manter':
        print("[BOT] Decisão do modelo: manter posição.")
        logging.info("[BOT] Decisão do modelo: manter posição.")

    else:
        print("[BOT] Nenhuma ação tomada neste ciclo.")
    print(f"[BOT] Posição atual: {POSICAO_ATUAL} | Último preço de compra: {ULTIMO_PRECO_COMPRA:.2f} USDT" if ULTIMO_PRECO_COMPRA else "[BOT] Posição neutra, sem compras registradas.")
    print(f"[BOT] Lucro/Prejuízo total acumulado: {LUCRO_TOTAL:.2f} USDT")
    logging.info(f"[BOT] Posição atual: {POSICAO_ATUAL} | Último preço de compra: {ULTIMO_PRECO_COMPRA:.2f} USDT" if ULTIMO_PRECO_COMPRA else "[BOT] Posição neutra, sem compras registradas.")
    logging.info(f"[BOT] Lucro/Prejuízo total acumulado: {LUCRO_TOTAL:.2f} USDT")
    time.sleep(60)
