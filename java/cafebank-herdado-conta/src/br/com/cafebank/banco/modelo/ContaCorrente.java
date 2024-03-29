package br.com.cafebank.banco.modelo;
public class ContaCorrente extends Conta implements Tributavel {
	
	
	//Construtor
	public ContaCorrente(int agencia, int numero) {
		super(agencia, numero);//Chamada de construtor na classe mãe
	}
	
	@Override
	public void saca(double valor) throws SaldoInsuficienteException {
		// TODO Auto-generated method stub
		double taxaSaque = 0.20;
		double valorSacar = valor + taxaSaque;
		super.saca(valorSacar);
	}

	@Override
	public void depositar(double valor) {
		 super.saldo += valor;
	}

	@Override
	public double getValorImposto() {
		// TODO Auto-generated method stub
		return super.saldo * 0.01;
	}
	
	//Sobrescrevendo o ToString para refinar para o projeto
	
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		return "Conta Corrente: " + super.toString();
	}

}
