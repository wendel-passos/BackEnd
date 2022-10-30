
public class TestaReferencia {
	
	public static void main(String[] args) {
		
		Conta primeiraConta = new Conta ();
		primeiraConta.saldo = 1000.00;
		
		Conta segundaConta = new Conta ();
		
		//Atribuir a mesma referência de objeto 
		segundaConta = primeiraConta;
		
		System.out.println(primeiraConta.saldo);
		System.out.println(segundaConta.saldo);
		
		if (primeiraConta == segundaConta) {
			System.out.println("Sao as mesmas contas " + "Conta 1 = "+ primeiraConta + " Conta 2 = " +segundaConta);
		}else {
			System.out.println("Contas diferentes " + "Conta 1 = "+ primeiraConta + " Conta 2 = " +segundaConta);
		}
		
		
	}
	

}
