package br.com.cafebank.banco.teste;
import br.com.cafebank.banco.modelo.CalculadorImposto;
import br.com.cafebank.banco.modelo.ContaCorrente;
import br.com.cafebank.banco.modelo.SeguroVida;

public class TesteTributavel {
	
	public static void main(String[] args) {
		
		ContaCorrente cc = new ContaCorrente (222,333);
		
		cc.depositar(100);
		
		
		SeguroVida seguro = new SeguroVida();
		
		CalculadorImposto calc = new CalculadorImposto();
		calc.registra(cc);
		calc.registra(seguro);
		
		
		System.out.println(calc.getTotalImposto());
		
	}

}
