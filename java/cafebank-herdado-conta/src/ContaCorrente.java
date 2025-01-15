
public class ContaCorrente extends Conta implements Tributavel {
	
	
	//Construtor
	public ContaCorrente(int agencia, int numero) {
		super(agencia, numero);//Chamada de construtor na classe mãe
	}
	
	@Override
	public boolean saca(double valor) {
		// TODO Auto-generated method stub
		double taxaSaque = 0.20;
		double valorSacar = valor + taxaSaque;
		return super.saca(valorSacar);
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

}
