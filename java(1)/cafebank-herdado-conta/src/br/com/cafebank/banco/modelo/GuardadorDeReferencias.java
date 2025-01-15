package br.com.cafebank.banco.modelo;

public class GuardadorDeReferencias {
	
	private Object [] referencias;
	private int referenciaGuardada = 0;
	
	//Construtor
	public GuardadorDeReferencias () {
		this.referencias = new Object [10];
	}
	
	public void adiciona (Conta ref) {
		
		this.referencias[this.referenciaGuardada] = ref;
		referenciaGuardada++;
	}

	public int getReferenciaGuardada() {
		return referenciaGuardada;
	}

	public Object getReferencia(int i) {
		// TODO Auto-generated method stub
		return this.referencias[i];
	}

}
