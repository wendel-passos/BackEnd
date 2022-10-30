
public class CriaConta {
	
	public static void main(String[] args) {
		
		//Instanciado atributos da classe conta no objeto criaConta
		Conta primeiraConta = new Conta();
		primeiraConta.saldo = 200;
		primeiraConta.agencia = 25;
		primeiraConta.titular = "Camila Passos";
		primeiraConta.numero = 0123;
		System.out.println(primeiraConta.saldo);
		System.out.println(primeiraConta.agencia);
		
		//Instanciado atributos da classe conta no segundo objeto criaConta
		Conta segundaConta = new Conta ();
		segundaConta.saldo = 100;
		System.out.println(segundaConta.saldo);
		
		if (primeiraConta == segundaConta) {
			System.out.println("Sao as mesmas contas " + "Conta 1 = "+ primeiraConta + " Conta 2 = " +segundaConta);
		}else {
			System.out.println("Contas diferentes " + "Conta 1 = "+ primeiraConta + " Conta 2 = " +segundaConta);
		}
		
	}

}
