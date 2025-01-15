
public class TestaMetodo {

	public static void main(String[] args) {

		Conta conta = new Conta();
		conta.saldo = 250.00;

		// Invocando médoto depositar
		conta.depositar(100);
		conta.saca(100);
		System.out.println(conta.saldo);

		// validando método saca
		boolean conseguiuSacar = conta.saca(100);
		System.out.println(conseguiuSacar);
		
		// Novo objeto conta
		Conta contaMarcela = new Conta ();
		contaMarcela.saldo = 10000.00;
		// Testando método de trasnferencia
		contaMarcela.transferir(400.00, conta);
		
		//Variável booleana para validar se a transferencia foi realizada com sucesso
		boolean sucessoTransferencia = contaMarcela.transferir(400.00, conta);
		
		System.out.println(conta.saldo);
		System.out.println(contaMarcela.saldo);
		System.out.println(sucessoTransferencia);
		
	}
}
