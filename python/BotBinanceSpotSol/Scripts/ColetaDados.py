from binance.client import Client
import pandas as pd
import os
from datetime import datetime, timedelta

# === ColetaDados.py === #

API_KEY = ''
API_SECRET = ''
SYMBOL = 'SOLUSDT'
INTERVAL = Client.KLINE_INTERVAL_5MINUTE
DATA_INICIO_PADRAO = '01 Jan, 2020'
BASE_DIR = os.path.dirname(os.path.abspath(__file__))
arquivo = os.path.abspath(os.path.join(BASE_DIR, "..", "Dados", "dados_SOLUSDT.csv"))

client = Client(API_KEY, API_SECRET)

def baixar_dados_incremental(symbol, interval):

    if os.path.exists(arquivo):
        df_existente = pd.read_csv(arquivo)
        df_existente['timestamp'] = pd.to_datetime(df_existente['timestamp'])
        ultima_data = df_existente['timestamp'].max()
        data_inicio = (ultima_data + timedelta(minutes=5)).strftime('%d %b, %Y %H:%M:%S')
        print(f"[INFO] Atualizando dados desde {data_inicio}...")
    else:
        df_existente = pd.DataFrame()
        data_inicio = DATA_INICIO_PADRAO
        print(f"[INFO] Baixando dados desde {data_inicio} (inicial)...")

    klines = client.get_historical_klines(symbol=symbol, interval=interval, start_str=data_inicio)

    if not klines:
        print("[INFO] Nenhum novo dado encontrado.")

    df_novo = pd.DataFrame(klines, columns=[
        'timestamp', 'open', 'high', 'low', 'close', 'volume',
        'close_time', 'quote_asset_volume', 'number_of_trades',
        'taker_buy_base_volume', 'taker_buy_quote_volume', 'ignore'
    ])
    df_novo['timestamp'] = pd.to_datetime(df_novo['timestamp'], unit='ms')
    df_novo[['open', 'high', 'low', 'close', 'volume']] = df_novo[['open', 'high', 'low', 'close', 'volume']].astype(float)
    df_novo = df_novo[['timestamp', 'open', 'high', 'low', 'close', 'volume']]

    if not df_existente.empty:
        df_final = pd.concat([df_existente, df_novo])
        df_final = df_final.drop_duplicates(subset='timestamp').reset_index(drop=True)
    else:
        df_final = df_novo

    df_final.to_csv(arquivo, index=False)
    print(f"[OK] Dados atualizados salvos em {arquivo} ({len(df_final)} registros).")

if __name__ == "__main__":
    baixar_dados_incremental(SYMBOL, INTERVAL)
