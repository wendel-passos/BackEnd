package sintaxeVariaveisFluxo;

public class TesteValores {
	
	public static void main(String[] args) {
		
		int valor1 = 10;
		int valor2 = 20;
		valor2 = valor1;
		valor1 = 100;
		
		//Neste caso o valor continua sendo 10 porque o valor1 foi atribuído ao valor 2 antes da alteração da variável valor1
		System.out.println (valor2);
	}

}
 