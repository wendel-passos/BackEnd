import os
import shutil
from datetime import datetime

print("[INFO] Iniciando rotina de aprendizado contínuo...")

# Executa os scripts
os.system('python ColetaDados.py')
os.system('python Indicadores.py')
os.system('python IndicadoresRotulagem.py')
os.system('python Treinamento.py')

# Backup do modelo treinado com timestamp
timestamp = datetime.now().strftime('%Y%m%d_%H%M')

BASE_DIR = os.path.dirname(os.path.abspath(__file__))
origem_modelo = os.path.abspath(os.path.join(BASE_DIR, "..", "Modelos", "modelo_sol_xgb_percentil.pkl"))  
destino_backup = os.path.abspath(os.path.join(BASE_DIR, "..", "Modelos_backup", f"modelo_sol_xgb_percentil_{timestamp}.pkl"))  

if os.path.exists(origem_modelo):
    shutil.copy(origem_modelo, destino_backup)
    print(f"[OK] Backup do modelo salvo como {destino_backup}")
else:
    print(f"[ERRO] Modelo não encontrado em: {origem_modelo}")
