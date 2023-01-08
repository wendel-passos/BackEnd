
public class TesteContas {
	
	public static void main(String[] args) {
				
		ContaCorrente cc = new ContaCorrente (111,111);
		cc.depositar(100.0);
		
		Conta cp = new ContaPoupanca (222,222);
		cp.depositar(200.0);
		
		cc.transferir(10, cp);
		
		System.out.println(cc.getSaldo());
		System.out.println(cp.getSaldo());
		
		
	}

}
