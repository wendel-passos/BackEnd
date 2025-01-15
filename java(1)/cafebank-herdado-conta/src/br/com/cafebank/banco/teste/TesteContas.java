package br.com.cafebank.banco.teste;
import br.com.cafebank.banco.especial.ContaEspecial;
import br.com.cafebank.banco.modelo.Conta;
import br.com.cafebank.banco.modelo.ContaCorrente;
import br.com.cafebank.banco.modelo.ContaPoupanca;
import br.com.cafebank.banco.modelo.SaldoInsuficienteException;

public class TesteContas {
	
	public static void main(String[] args) {
		
		Conta cp = new ContaPoupanca (222,222);
		cp.depositar(200.0);
		
		try (ContaCorrente cc = new ContaCorrente (111,111)){
			cc.depositar(100.0);
			try {
				cc.transferir(10, cp);
				System.out.println(cc.getSaldo());
			} catch (SaldoInsuficienteException e) {
				// TODO Auto-generated catch block
				e.printStackTrace();
			}
		} catch (IllegalArgumentException ex) {
			System.out.println("Erro: O codigo da conta e/ou agencia nao podem ser negativos.");
			
		};
		
//		ContaEspecial ce = new ContaEspecial (121,211);
//		ce.getSaldo(); // Não é possível acessar o atributo saldo porque ele só está visivel para as classes filhas
//		System.out.println(cp.getSaldo());
		
		
		
	}

}
