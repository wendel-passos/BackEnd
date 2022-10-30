
public class TestaBanco {
	
	public static void main(String[] args) {
		Cliente wendel = new Cliente ();
		wendel.nome = "Wendel Passos";
		wendel.cpf = "23456454678";
		wendel.profissao = "Javeiro";
		
		
		Conta contaDoWendel = new Conta ();
		contaDoWendel.depositar(1000);
		//Associação do objeto wendel com o atributo titular da classe conta
		contaDoWendel.titular = wendel;
		
		//Quando feita e referencia é possível utilizar os métodos da classe Cliente por meio do titula.atributo da classe cliente
		System.out.println(contaDoWendel.titular.nome);
		System.out.println(contaDoWendel.titular);
		System.out.println(wendel);
		System.out.println(contaDoWendel.saldo);
	}
}
