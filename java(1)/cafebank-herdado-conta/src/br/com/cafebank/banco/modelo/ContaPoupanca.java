package br.com.cafebank.banco.modelo;
public class ContaPoupanca extends Conta {
	
	public ContaPoupanca (int agencia, int conta){
		super (agencia,conta);//Chamada de construtor na classe mãe
	}
	
	@Override
	public void depositar(double valor) {
		 super.saldo += valor;
	}
	
	//Sobrescrevendo o ToString para refinar para o projeto
	
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		return "Conta Poupanca: "   + super.toString();
	}


}
