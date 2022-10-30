package appBingo;

import java.util.Scanner;

public class AppBingo {

	public static void main(String[] args) {

		Cartela cartela;
		Scanner tcd = new Scanner(System.in);

		System.out.println("Digite 1 para preecher a cartela");
		int iniciar = tcd.nextInt();

		if (iniciar == 1) {
			cartela = new Cartela();
			cartela.initializeBalls();
			cartela.createColumn();
			cartela.showCard();

			System.out.println("Digite 2 para girar o globo");
			int resp = tcd.nextInt();

			if (resp == 2) {

				Globo globo = new Globo(75);
				// int x = globo.rolar();
				// System.out.println("Bola " + x);
				globo.checkBall();

				System.out.println("Digite 2 para girar o globo");
				resp = tcd.nextInt();
				while (resp == 2) {
					globo.checkBall();
					System.out.println("Digite 2 para girar o globo");
					resp = tcd.nextInt();
				}

			} else {
				System.out.println("Número inválido");
			}

		} else {
			System.out.println("Número inválido");
		}

	}

}