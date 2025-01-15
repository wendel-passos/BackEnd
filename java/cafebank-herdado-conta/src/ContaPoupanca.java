
public class ContaPoupanca extends Conta {
	
	public ContaPoupanca (int agencia, int conta){
		super (agencia,conta);//Chamada de construtor na classe mãe
	}
	
	@Override
	public void depositar(double valor) {
		 super.saldo += valor;
	}

}
