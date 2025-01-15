package br.com.cafebank.banco.teste;

import br.com.cafebank.banco.modelo.Conta;
import br.com.cafebank.banco.modelo.ContaCorrente;
import br.com.cafebank.banco.modelo.ContaPoupanca;

public class TesteArrayReferencias {
	// Array []
	public static void main(String[] args) {
		// TODO Auto-generated method stub

		Conta[] contas = new Conta[5];
		ContaCorrente cc1 = new ContaCorrente(111, 112);
		cc1.depositar(100);
		contas[0] = cc1; // Referencia da conta armazenada na posição 0 do array

		ContaPoupanca cc2 = new ContaPoupanca(111, 113);
		cc2.depositar(100);
		contas[1] = cc2; // Referencia da conta armazenada na posição 1 do array
		
		System.out.println(contas[1].getSaldo());
		
		Conta ref = contas[0];
		
		System.out.println(ref);

	}

}
