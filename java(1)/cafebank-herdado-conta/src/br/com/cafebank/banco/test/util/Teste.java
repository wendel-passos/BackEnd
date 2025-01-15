package br.com.cafebank.banco.test.util;

import java.util.ArrayList;

import br.com.cafebank.banco.modelo.Conta;
import br.com.cafebank.banco.modelo.ContaCorrente;
import br.com.cafebank.banco.modelo.ContaPoupanca;

public class Teste {

	public static void main(String[] args) {
		// TODO Auto-generated method stub

		// <Nome da Classe> O (<> Generics) serve para tipificar qual tipo de objeto o Array irá
		// armazenar
		
		ArrayList<Conta> lista = new ArrayList();

		Conta cc = new ContaCorrente(111, 111);
		lista.add(cc);

		Conta cc2 = new ContaCorrente(111, 222);
		lista.add(cc2);

		System.out.println(lista.size());
		Conta ref = lista.get(0);
		System.out.println(ref.getNumero());

		// lista.remove(0);
		System.out.println(lista.size());

		Conta cc3 = new ContaCorrente(111, 333);
		lista.add(cc3);

		Conta cc4 = new ContaPoupanca(111, 444);
		lista.add(cc4);

//		Para testar essa parte precisa descomentar o metodo ToString da classe cliente
//		Foi adicionado a tipagem no array. Não é permitido adicionar o Objeto Cliente no array mais
//		Cliente cliente = new Cliente ();
//		cliente.setNome("Wendy");

//		lista.add(cliente);

		for (int i = 0; i < lista.size(); i++) {
			System.out.println(lista.get(i));
		}

		System.out.println("------------------------");

		// For simplificado para Arrays
		for (Conta oRef : lista) {
			System.out.println(oRef);
		}

	}

}
