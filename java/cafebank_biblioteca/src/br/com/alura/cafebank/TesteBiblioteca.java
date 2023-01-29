package br.com.alura.cafebank;

import br.com.cafebank.banco.modelo.Conta;
import br.com.cafebank.banco.modelo.ContaCorrente;

public class TesteBiblioteca {
	
	public static void main(String[] args) {
		
		Conta c = new ContaCorrente (123, 321);
		
		c.depositar(200.30);
		
		System.out.println(c.getSaldo());
	}

}
