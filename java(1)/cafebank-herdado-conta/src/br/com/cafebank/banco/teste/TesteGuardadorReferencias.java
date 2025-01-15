package br.com.cafebank.banco.teste;

import br.com.cafebank.banco.modelo.Conta;
import br.com.cafebank.banco.modelo.ContaCorrente;
import br.com.cafebank.banco.modelo.GuardadorDeContas;

public class TesteGuardadorReferencias {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		GuardadorDeContas guardador = new GuardadorDeContas ();
		
		Conta cc = new ContaCorrente (111,222);
		guardador.adiciona(cc);
		
		Conta cc2 = new ContaCorrente (111,333);
		guardador.adiciona(cc2);
		
		System.out.println(guardador.getReferenciaGuardada());
		
		Conta ref = (Conta) guardador.getReferencia(1);
		System.out.println(ref.getNumero());
		

	}

}
