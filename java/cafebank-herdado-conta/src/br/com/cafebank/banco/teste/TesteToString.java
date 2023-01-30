package br.com.cafebank.banco.teste;

import br.com.cafebank.banco.modelo.ContaCorrente;
import br.com.cafebank.banco.modelo.ContaPoupanca;

public class TesteToString {
	
	public static void main(String[] args) {
		
		ContaCorrente cc = new ContaCorrente(10, 144);
		System.out.println(cc);
		
		ContaPoupanca cp = new ContaPoupanca(20, 255);
		System.out.println(cp);
	}

}
