import pandas as pd
import os

# === IndicadoresRotulagem.py ===

print(f"[INFO] Lendo dados para geração dos Indicadores Rotulados..")

BASE_DIR = os.path.dirname(os.path.abspath(__file__))
caminho_csv = os.path.abspath(os.path.join(BASE_DIR, "..", "Dados", "dados_indicadores_completos.csv"))
data_set_rotulado_csv = os.path.abspath(os.path.join(BASE_DIR, "..", "Dados", "dataset_rotulado.csv"))
# === Carregar dados com indicadores ===
df = pd.read_csv(caminho_csv)

# === Calcular retornos futuros (1 período à frente) ===
df['retorno'] = df['close'].pct_change().shift(-1)

# === Definir os limiares pelos percentis 33% e 66% ===
limiar_venda = df['retorno'].quantile(0.33)
limiar_compra = df['retorno'].quantile(0.66)

# === Aplicar rótulos com base nos percentis ===
def rotulo_personalizado(retorno):
    if retorno >= limiar_compra:
        return 'Comprar'
    elif retorno <= limiar_venda:
        return 'Vender'
    else:
        return 'Manter'

df['acao'] = df['retorno'].apply(rotulo_personalizado)

# === Limpeza final ===
df_final = df.dropna().reset_index(drop=True)
df_final.to_csv(data_set_rotulado_csv, index=False)
print(f"[OK] Dataset rotulado salvo com {len(df_final)} registros: dataset_rotulado.csv")
