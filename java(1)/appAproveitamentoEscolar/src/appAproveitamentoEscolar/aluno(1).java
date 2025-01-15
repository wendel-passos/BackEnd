/**
*
*Autores:
*         Nome: David Alves P. Silva RA: 233089
*		   Nome: Silvio Lucas dos Santos RA: 228787
*		   Nome: Wendel Eduardo Romualdo Passos RA: 228111 
*		   Nome: Yago Gomes Cardoso RA: 219748
*		   
*IDE: Eclipse	  
*/
package appAproveitamentoEscolar;

public class Aluno {

	// Atributos
	float a1, a2, a3, a4;
	float menorNota;

	// Regra de negócio
	final float MEDIA = 6.0f;

	// Construtor da classe
	public Aluno() {
		a1 = a2 = a3 = a4 = 0.0f;
	}
	
	// Construtor da classe
	public Aluno(float a1, float a2, float a3, float a4) {
		this.a1 = a1;
		this.a2 = a2;
		this.a3 = a3;
		this.a4 = a4;
	}

	// Métodos
	public boolean validadorNotas(){
		// Retorno é utilizado para verificar se a nota de entrada é válida.
		return (a1 == 0 || a1 == 0.5 || a1 == 1 || a1 == 1.5 || a1 == 2 || a1 == 2.5 || a1 == 3 || a1 == 3.5 || a1 == 4
				|| a1 == 4.5 || a1 == 5 || a1 == 5.5 || a1 == 6.0 || a1 == 6.5 || a1 == 7.0 || a1 == 7.5 || a1 == 8.0
				|| a1 == 8.5 || a1 == 9.0 || a1 == 9.5 || a1 == 10)
				&& (a1 >= 0 && a1 <= 10)
				&& (a2 == 0 || a2 == 0.5 || a2 == 1 || a2 == 1.5 || a2 == 2 || a2 == 2.5 || a2 == 3 || a2 == 3.5
						|| a2 == 4 || a2 == 4.5 || a2 == 5 || a2 == 5.5 || a2 == 6.0 || a2 == 6.5 || a2 == 7.0
						|| a2 == 7.5 || a2 == 8.0 || a2 == 8.5 || a2 == 9.0 || a2 == 9.5 || a2 == 10)
				&& (a2 >= 0 && a2 <= 10)
				&& (a3 == 0 || a3 == 0.5 || a3 == 1 || a3 == 1.5 || a3 == 2 || a3 == 2.5 || a3 == 3 || a3 == 3.5
						|| a3 == 4 || a3 == 4.5 || a3 == 5 || a3 == 5.5 || a3 == 6.0 || a3 == 6.5 || a3 == 7.0
						|| a3 == 7.5 || a3 == 8.0 || a3 == 8.5 || a3 == 9.0 || a3 == 9.5 || a3 == 10)
				&& (a3 >= 0 && a3 <= 10)
				&& (a4 == 0 || a4 == 0.5 || a4 == 1 || a4 == 1.5 || a4 == 2 || a4 == 2.5 || a4 == 3 || a4 == 3.5
						|| a4 == 4 || a4 == 4.5 || a4 == 5 || a4 == 5.5 || a4 == 6.0 || a4 == 6.5 || a4 == 7.0
						|| a4 == 7.5 || a4 == 8.0 || a4 == 8.5 || a4 == 9.0 || a4 == 9.5 || a4 == 10)
				&& (a4 >= 0 && a4 <= 10);
	}

	public float menorNotaDesconsiderada() {
		// Variavel armazena a menor das quatro notas obtidas pelo aluno
		menorNota = Math.min(a1, Math.min(a2, Math.min(a3, a4)));
		return menorNota;
	}

	public String notasConsideradasMedia() {
		// Método utilizado para saber qual foi a menor nota do aluno
		menorNotaDesconsiderada();

		// Condição para indicar quais notas serão utilizadas no cálculo da media
		if (menorNota == a1) {
			return (a2 + " - " + a3 + " - " + a4);
		}
		if (menorNota == a2) {
			return (a1 + " - " + a3 + " - " + a4);
		}
		if (menorNota == a3) {
			return (+a1 + " - " + a2 + " - " + a4);
		} else {
			return (+a1 + " - " + a2 + " - " + a3);
		}
	}

	public double mediaNotas() {
		// Método utilizado para saber qual foi a menor nota do aluno
		menorNotaDesconsiderada();

		// Condição para descartar a menor nota e realizar o calculo da média com
		// retonrno de duas casas decimais.
		if (menorNota == a1) {
			return Math.round(((a2 + a3 + a4) / 3) * 100) / 100.0;
		} else if (menorNota == a2) {
			return Math.round(((a1 + a3 + a4) / 3) * 100) / 100.0;
		} else if (menorNota == a3) {
			return Math.round(((a2 + a1 + a4) / 3) * 100) / 100.0;
		} else {
			return Math.round(((a2 + a3 + a1) / 3) * 100) / 100.0;
		}
	}

	public String situacao() {
		return (mediaNotas() >= MEDIA) ? "Aprovado" : "Reprovado";
	}
	
	public String toString() {
		String mostrar = "";
		mostrar += "\nNotas Obtidas:  " + notasConsideradasMedia();
		mostrar += "\nMedia do Aluno: " + mediaNotas();
		mostrar += "\nSituacao:       " + situacao();
		return mostrar;
	}
}
