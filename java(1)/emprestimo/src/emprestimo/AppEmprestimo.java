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

import java.util.Scanner;

public class AppEmprestimo {

	public static void main(String[] args) {
		
		// Interface texto com o usuário
		Scanner sc = new Scanner(System.in);
		CalculoEmprestimo a = new CalculoEmprestimo();
		double valorMensal, total, taxaMensal;
		double n;
		System.out.print("Valor: ");
		a.total =  sc.nextDouble();
		System.out.print("Taxa Anual: ");
		a.taxaAnual = sc.nextDouble();
		System.out.print("Tempo (anos): ");
		a.tempoEmprestimo =  sc.nextDouble();

		System.out.printf("Prestação R$ %.2f" , a.calculoDoJuro());

	}

}