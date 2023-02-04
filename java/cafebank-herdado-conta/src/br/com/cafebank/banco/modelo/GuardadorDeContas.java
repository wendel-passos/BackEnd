package br.com.cafebank.banco.modelo;

public class GuardadorDeContas {
	
	private Conta [] referencias;
	private int referenciaGuardada = 0;
	
	//Construtor
	public GuardadorDeContas () {
		this.referencias = new Conta [10];
	}
	
	public void adiciona (Conta ref) {
		
		this.referencias[this.referenciaGuardada] = ref;
		referenciaGuardada++;
	}

	public int getReferenciaGuardada() {
		return referenciaGuardada;
	}

	public Conta getReferencia(int i) {
		// TODO Auto-generated method stub
		return this.referencias[i];
	}

}
