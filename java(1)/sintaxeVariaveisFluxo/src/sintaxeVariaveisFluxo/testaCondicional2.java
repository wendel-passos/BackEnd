package sintaxeVariaveisFluxo;

public class testaCondicional2 {
	public static void main(String[] args) {
		System.out.println("Testando condicionais");
		int idade = 18;
		int quantidadePessoas = 1;
		boolean validador = quantidadePessoas >= 2;

		System.out.println("Validador para identificar se esta acompanhado = " + validador);
		System.out.println("Idade = " + idade);

		// CONDICIONAL COM OPERADOR LOGICO OU
		if (idade >= 18 || validador) {
			System.out.println("Seja bem vindo");
		} else {

			System.out.println("Infelizmente voce nao pode entrar");
		}

	}

}
