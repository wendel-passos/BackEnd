import pandas as pd
import numpy as np
import os

# === Indicadores.py === #

BASE_DIR = os.path.dirname(os.path.abspath(__file__))
leituraArquivo = os.path.abspath(os.path.join(BASE_DIR, "..", "Dados", "dados_SOLUSDT.csv"))
criacaoArquivo = os.path.abspath(os.path.join(BASE_DIR, "..", "Dados", "dados_indicadores_completos.csv"))



# === Carrega os dados ===
print(f"[INFO] Lendo dados para geração dos Indicadores..")
df = pd.read_csv(leituraArquivo)
df['close'] = df['close'].astype(float)

# === Médias móveis ===
df['SMA_10'] = df['close'].rolling(10).mean()
df['SMA_30'] = df['close'].rolling(30).mean()
df['EMA_12'] = df['close'].ewm(span=12, adjust=False).mean()
df['EMA_26'] = df['close'].ewm(span=26, adjust=False).mean()

# === Bollinger Bands ===
df['STD_20'] = df['close'].rolling(20).std()
df['Upper_BB'] = df['SMA_10'] + 2 * df['STD_20']
df['Lower_BB'] = df['SMA_10'] - 2 * df['STD_20']

# === RSI ===
delta = df['close'].diff()
ganho = delta.clip(lower=0)
perda = -delta.clip(upper=0)
media_ganho = ganho.rolling(14).mean()
media_perda = perda.rolling(14).mean()
rs = media_ganho / media_perda
df['RSI'] = 100 - (100 / (1 + rs))

# === MACD ===
df['MACD'] = df['EMA_12'] - df['EMA_26']
df['MACD_signal'] = df['MACD'].ewm(span=9, adjust=False).mean()
df['MACD_hist'] = df['MACD'] - df['MACD_signal']

# === Estocástico (Stochastic Oscillator) ===
df['14-high'] = df['high'].rolling(14).max()
df['14-low'] = df['low'].rolling(14).min()
df['Stoch_K'] = 100 * ((df['close'] - df['14-low']) / (df['14-high'] - df['14-low']))
df['Stoch_D'] = df['Stoch_K'].rolling(3).mean()

# === CCI ===
tp = (df['high'] + df['low'] + df['close']) / 3
df['CCI'] = (tp - tp.rolling(20).mean()) / (0.015 * tp.rolling(20).std())

# === ROC ===
df['ROC'] = df['close'].pct_change(periods=10)

# === ATR ===
df['H-L'] = df['high'] - df['low']
df['H-C'] = abs(df['high'] - df['close'].shift(1))
df['L-C'] = abs(df['low'] - df['close'].shift(1))
df['TR'] = df[['H-L', 'H-C', 'L-C']].max(axis=1)
df['ATR'] = df['TR'].rolling(14).mean()

# === Momentum ===
df['Momentum'] = df['close'] - df['close'].shift(10)

# === OBV ===
obv = [0]
for i in range(1, len(df)):
    if df['close'][i] > df['close'][i - 1]:
        obv.append(obv[-1] + df['volume'][i])
    elif df['close'][i] < df['close'][i - 1]:
        obv.append(obv[-1] - df['volume'][i])
    else:
        obv.append(obv[-1])
df['OBV'] = obv

# === Z-Score ===
df['Z_Score'] = (df['close'] - df['close'].rolling(20).mean()) / df['close'].rolling(20).std()

# === Williams %R ===
df['Williams_%R'] = -100 * ((df['14-high'] - df['close']) / (df['14-high'] - df['14-low']))

# === Money Flow Index (MFI) ===
tp = (df['high'] + df['low'] + df['close']) / 3
money_flow = tp * df['volume']
positive_flow = []
negative_flow = []
for i in range(1, len(tp)):
    if tp[i] > tp[i - 1]:
        positive_flow.append(money_flow[i])
        negative_flow.append(0)
    elif tp[i] < tp[i - 1]:
        positive_flow.append(0)
        negative_flow.append(money_flow[i])
    else:
        positive_flow.append(0)
        negative_flow.append(0)
positive_mf = pd.Series(positive_flow).rolling(14).sum()
negative_mf = pd.Series(negative_flow).rolling(14).sum()
mfi = 100 * (positive_mf / (positive_mf + negative_mf))
df['MFI'] = mfi.reset_index(drop=True)

# === Volume Oscillator ===
ema_vol_12 = df['volume'].ewm(span=12, adjust=False).mean()
ema_vol_26 = df['volume'].ewm(span=26, adjust=False).mean()
df['Volume_Osc'] = ((ema_vol_12 - ema_vol_26) / ema_vol_26) * 100

# === Limpeza ===
df_final = df.dropna().reset_index(drop=True)

# === Salvamento ===
df_final.to_csv(criacaoArquivo, index=False)
print(f"[OK] Arquivo salvo com {len(df_final)} registros: dados_indicadores_completos.csv")
