import pandas as pd
from xgboost import XGBClassifier
from sklearn.model_selection import TimeSeriesSplit, cross_val_score
from sklearn.preprocessing import LabelEncoder
from sklearn.metrics import classification_report
from imblearn.over_sampling import SMOTE
import joblib
import os

# === Treinamento.py ===

print(f"[INFO] Executando o treinamento..")

# === Carregar dados ===
BASE_DIR = os.path.dirname(os.path.abspath(__file__))
caminho_csv = os.path.abspath(os.path.join(BASE_DIR, "..", "Dados", "dataset_rotulado.csv"))
df = pd.read_csv(caminho_csv)

# === Verificar se a coluna de data/hora existe e remover ===
colunas_remover = ['timestamp', 'date', 'time']
for col in colunas_remover:
    if col in df.columns:
        df = df.drop(col, axis=1)

# === Codificar a coluna 'acao' ===
le = LabelEncoder()
df['acao'] = le.fit_transform(df['acao'])  # 'Comprar' → 0, 'Manter' → 1, 'Vender' → 2 (exemplo)

# === Separar features e target ===
X = df.drop('acao', axis=1)
y = df['acao']

# === Aplicar SMOTE para balanceamento ===
smote = SMOTE(random_state=42)
X_res, y_res = smote.fit_resample(X, y)

# === Treinamento com validação (TimeSeriesSplit) ===
model = XGBClassifier(n_estimators=100, learning_rate=0.1, max_depth=6, random_state=42)
tscv = TimeSeriesSplit(n_splits=5)
scores = cross_val_score(model, X_res, y_res, cv=tscv, scoring='accuracy')
print(f"Acurácia média (TimeSeriesSplit): {scores.mean():.4f}")

# === Treinamento final do modelo ===
model.fit(X_res, y_res)
joblib.dump(model, os.path.abspath(os.path.join(BASE_DIR, "..", "Modelos", "modelo_sol_xgb_percentil.pkl")))
print("[OK] Modelo salvo como modelo_sol_xgb_percentil.pkl")

# === Salvar o LabelEncoder ===
joblib.dump(le, (os.path.join(BASE_DIR, "..", "Modelos", "label_encoder_acao.pkl")))
print("[OK] LabelEncoder salvo como label_encoder_acao.pkl")

# === Avaliação em todo o conjunto balanceado ===
y_pred = model.predict(X_res)
print("\nRelatório de Classificação (dados balanceados):")
print(classification_report(y_res, y_pred, target_names=le.classes_))
