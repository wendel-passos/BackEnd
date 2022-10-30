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
package emprestimo;

public class CalculoEmprestimo {
	// Atributos
	public double valorMensal, total, taxaMensal, taxaAnual;
	public double tempoEmprestimo;
	
	// Métodos
	public double calculoDoJuro() {

		taxaMensal = (taxaAnual / 100) / 12;
		tempoEmprestimo = tempoEmprestimo * 12;
		if (taxaMensal != 0.0) {
			// ( 1+taxaMensal)*n)
			return valorMensal = total * (taxaMensal * (Math.pow((taxaMensal + 1), tempoEmprestimo)))
					/ ((Math.pow((taxaMensal + 1), tempoEmprestimo)) - 1);
		} else
			return total / tempoEmprestimo;
	}

}
