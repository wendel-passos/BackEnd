package br.com.cafebank.banco.teste;
import br.com.cafebank.banco.modelo.Conta;
import br.com.cafebank.banco.modelo.ContaCorrente;

public class TesteSaca {
	public static void main(String[] args) {
		Conta conta = new ContaCorrente (123, 321);
		
		conta.depositar(200.00);
		try {
			conta.saca(500.00);
		} catch (Exception ex) {
			System.out.println("EX: " + ex.getMessage());
		}
		
		System.out.println(conta.getSaldo());
	}
}
