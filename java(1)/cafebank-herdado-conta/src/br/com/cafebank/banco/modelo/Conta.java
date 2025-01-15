package br.com.cafebank.banco.modelo;

/**
 * Classe representa a moldura de uma conta
 * 
 * @author WPassos
 *
 */
//Criação da classe conta
public abstract class Conta implements AutoCloseable {

	// Em classes não é utilizado o main

	// Atributos da classe
	protected double saldo; // Protected torna o atributo visivel para classes de outros pacotes que são
							// classes filhas
	private int agencia;
	private int numero;
	private Cliente titular;
	private static int totalContasCriadas;// O Static serve para poder ser compartilhados com as instâncias dos objetos

	/**
	 * Construtor para instanciar a classe
	 * @param agencia
	 * @param numero
	 */
	// Contrutores
	public Conta(int agencia, int numero) {

		if (agencia < 1) {
			throw new IllegalArgumentException("Agencia inválida");
		}
		if (numero < 1) {
			throw new IllegalArgumentException("Numero da conta inválido");
		} else {
			this.agencia = agencia;
			this.numero = numero;
			System.out.println("Criando conta " + this.numero + " Agencia " + this.agencia);
			Conta.totalContasCriadas++; // Para o atributo da classe é utilizado o nome da classe no atributo
			System.out.println("Total de contas criadas = " + Conta.totalContasCriadas);
		}

	}

	public Conta(int numero) {
		agencia = 7770;
		this.numero = numero;

		Conta.totalContasCriadas++; // Para o atributo da classe é utilizado o nome da classe no atributo
		System.out.println("Total de contas criadas = " + Conta.totalContasCriadas);
		if (numero < 0) {
			System.out.println("Valores não podem ser negativos");
			return;
		}
		// this.numero = numero;
		System.out.println("Criando conta " + this.numero + " Agencia " + this.agencia);
	}

	@Override
	public void close() {
		// TODO Auto-generated method stub
		System.out.println("Fechando conexao");
	}

	// Métodos da classe
	public abstract void depositar(double valor);

	public void saca(double valor) throws SaldoInsuficienteException {

		if (this.saldo < valor) {
			throw new SaldoInsuficienteException("Saldo: " + this.saldo + " Valor: " + valor);
		}
		this.saldo -= valor;
	}

	public void transferir(double valor, Conta destino) throws SaldoInsuficienteException {
		this.saca(valor);
		destino.depositar(valor);
	}

	public double getSaldo() {
		return this.saldo;
	}

	public double getNumero() {
		return this.numero;
	}

	// Void não retorna nada, neste caso está sendo utilizado para alterar o
	// atributo número da conta
	public void setNumero(int numero) {
		if (numero < 0) {
			System.out.println("Valor invalido !");
			return;
		}
		this.numero = numero;
	}

	public double getAgencia() {
		return this.agencia;
	}

	// Void não retorna nada, neste caso está sendo utilizado para alterar o
	// atributo número da conta
	public void setAgencia(int agencia) {
		if (agencia < 0) {
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
	
	//Sobrescrevendo o ToString para refinar para o projeto
	
	@Override
	public String toString() {
		// TODO Auto-generated method stub
		return "Numero: " + this.getNumero() + " Agencia: " + this.getAgencia();
	}


}
