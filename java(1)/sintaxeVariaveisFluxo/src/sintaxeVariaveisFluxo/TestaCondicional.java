package sintaxeVariaveisFluxo;

public class TestaCondicional {
	public static void main(String[] args) {
		System.out.println("Testando condicionais");
		int idade = 20;
		int quantidadePessoas = 3;
		if (idade >= 100) {
			System.out.println("Voce tem mais de 18 anos");
			System.out.println("Seja bem vindo");
		}
		else {
			if (quantidadePessoas > 1){
				System.out.println("Voce está acompannado, por isso pode processeguir. "
						+ "Seja bem vindo");
				
			}
			System.out.println("Voce nao e maior de idade");
		}
	}

}
