package br.com.cafebank.banco.modelo;

public class CalculadorImposto {
	
	private double totalImposto;

	public void registra (Tributavel tributavel) {
		double valor = tributavel.getValorImposto();
		this.totalImposto += valor;
	}

	public double getTotalImposto() {
		return totalImposto;
	}
}
