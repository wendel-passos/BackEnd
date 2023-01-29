package br.com.cafebank.banco.especial;

import br.com.cafebank.banco.modelo.Conta;

public class ContaEspecial extends Conta {

	
	public ContaEspecial (int agencia, int numero) {
		super(agencia, numero);//Chamada de construtor na classe mãe
	}
	@Override
	public void depositar(double valor) {
		// TODO Auto-generated method stub
		super.saldo += valor;

	}

}
