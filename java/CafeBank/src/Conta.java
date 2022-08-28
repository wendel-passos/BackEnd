//Criação da classe conta
public class Conta {

	// Em classes não é utilizado o main

	// Atributos da classe
	double saldo;
	int agencia;
	int numero;
	String titular;

	// Métodos da classe
	public void depositar (double valor) {
		this.saldo += valor;
	}
	
	public boolean saca (double valor) {
		if (this.saldo >= valor && valor >= 0) {
			
			this.saldo -= valor;
			return true;
			
		} else {
			
			return false;
		}	
	}
	
	public boolean transferir (double valor, Conta destino) {
		
		if (this.saldo >= valor && valor > 0) {
	
			saca (valor); //Reutilização do método sacar
			destino.depositar (valor); //Reutilização do método sacar
			return true;
			
		} else {
			
			return false;
		}
	}	

}
