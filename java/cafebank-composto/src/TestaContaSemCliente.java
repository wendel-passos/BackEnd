
public class TestaContaSemCliente {
	public static void main(String[] args) {
		Conta contaDoJose = new Conta ();
		
		System.out.println(contaDoJose.getSaldo());
		
		//Associando novo objeto na classe cliente
		contaDoJose.titular = new Cliente();
		
		contaDoJose.titular.nome = "Jose Mairan";
		System.out.println(contaDoJose.titular);
		System.out.println(contaDoJose.titular.nome);
	}
}
