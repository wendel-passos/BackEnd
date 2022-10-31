//Criação da classe conta
public class Conta {

	// Em classes não é utilizado o main

	// Atributos da classe
	private double saldo;
	private int agencia;
	private int numero;
	private Cliente titular;
	//O Static serve para poder ser compartilhados com as instâncias dos objetos
	private static int totalContasCriadas;
	
	//Contrutores 
	public Conta(int agencia, int numero){
		Conta.totalContasCriadas++; //Para o atributo da classe é utilizado o nome da classe no atributo
		System.out.println("Total de contas criadas = "+Conta.totalContasCriadas);
		if (agencia < 0 || numero < 0) {
			System.out.println("Valores não podem ser negativos");
			return;
		}
		this.agencia = agencia;
		this.numero = numero;
		System.out.println("Criando conta " + this.numero + " Agencia " + this.agencia);
		
	}
	public Conta(int numero){
		this (7770, numero);
		Conta.totalContasCriadas++; //Para o atributo da classe é utilizado o nome da classe no atributo
		System.out.println("Total de contas criadas = "+Conta.totalContasCriadas);
		if ( numero < 0) {
			System.out.println("Valores não podem ser negativos");
			return;
		}
		//this.numero = numero;
		System.out.println("Criando conta " + this.numero + " Agencia " + this.agencia);
	}
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
	
	public double  getSaldo () {
		return this.saldo;
	}
	
	public double  getNumero () {
		return this.numero;
	}
	
	//Void não retorna nada, neste caso está sendo utilizado para alterar o atributo número da conta
	public void setNumero (int numero) {
		if (numero < 0 ) {
			System.out.println("Valor invalido !");
			return;
		}
		this.numero = numero;
	}
	
	public double  getAgencia () {
		return this.agencia;
	}
	
	//Void não retorna nada, neste caso está sendo utilizado para alterar o atributo número da conta
	public void setAgencia (int agencia) {
		if (agencia < 0 ) {
			System.out.println("Valor invalido !");
			return;
		}
		this.agencia = agencia;
	}
	
	public void setTitular(Cliente titular) {
		this.titular = titular;
	}

	public Cliente getTitular() {
		return titular;
	}
	
	public static int getTotalContasCriadas() {
		return totalContasCriadas;
	}

}
