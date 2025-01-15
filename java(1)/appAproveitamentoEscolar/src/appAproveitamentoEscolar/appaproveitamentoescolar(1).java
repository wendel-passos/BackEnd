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

import java.util.Scanner;

public class AppAproveitamentoEscolar {

	public static void main(String[] args) {
		Aluno aluno = new Aluno();

		// Interface texto com o usuário
		Scanner ler = new Scanner(System.in);
		String apresentacao = "";
		apresentacao += "-------------------------------------";
		apresentacao += "\n     APP APROVEITAMENTO ESCOLAR    ";
		apresentacao += "\n-------------------------------------";
		apresentacao += "\n            RESTRICOES                ";
		apresentacao += "\n-Valor das notas vao de 0 ate 10";
		apresentacao += "\n-Notas sao dadas de 0,5 em 0,5 pontos";
		apresentacao += "\n--------------------------------------";
		System.out.println(apresentacao);

		System.out.println("Insira a nota da A1:");
		aluno.a1 = ler.nextFloat();
		while (!aluno.validadorNotas()) {
			System.out.println("Nota invalida. Insira a nota da A1:");
			aluno.a1 = ler.nextFloat();
		}

		System.out.println("Insira a nota da A2:");
		aluno.a2 = ler.nextFloat();
		while (!aluno.validadorNotas()) {
			System.out.println("Nota invalida. Insira a nota da A2:");
			aluno.a2 = ler.nextFloat();
		}

		System.out.println("Insira a nota da A3:");
		aluno.a3 = ler.nextFloat();
		while (!aluno.validadorNotas()) {
			System.out.println("Nota invalida. Insira a nota da A3:");
			aluno.a3 = ler.nextFloat();
		}

		System.out.println("Insira a nota da A4:");
		aluno.a4 = ler.nextFloat();
		while (!aluno.validadorNotas()) {
			System.out.println("Nota invalida. Insira a nota da A4:");
			aluno.a4 = ler.nextFloat();

		}
		System.out.println(aluno);

	}

}
