
public class TestaSacaNegativo {
	
	
	public static void main(String[] args) {
		
		Conta conta = new Conta ();
		
		conta.depositar(100);
		conta.saca(300);
		System.out.println(conta.getSaldo());
		
		//Quando setado direto no atributo está permitindo o saldo da CC ficar negativo 
		//conta.saldo = conta.saldo -300;
		//System.out.println(conta.retornaSaldo());
		
	}  
	

}
