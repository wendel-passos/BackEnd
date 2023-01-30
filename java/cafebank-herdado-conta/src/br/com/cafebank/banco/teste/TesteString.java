package br.com.cafebank.banco.teste;

/**
 * Funções essenciais da classe String
 * 
 * @author WPassos
 *
 */
public class TesteString {

	public static void main(String[] args) {

		String nome = "CAfe BAnk"; // object literal
		String alteracao = nome.replace("A", "a");
		// alteracao = nome.replace('A', 'a'); Para o primitivo char utiliza-se somente
		// aspas simples

		System.out.println(nome);
		System.out.println(alteracao);
		System.out.println(alteracao.contains("afe") + " Validacao de conteudo");

		char letra = alteracao.charAt(2);
		System.out.println(letra);

		int posicao = alteracao.indexOf("fe");
		System.out.println(posicao);

		String sub = alteracao.substring(0);
		System.out.println(sub);

		int tamanho = alteracao.length();
		System.out.println(tamanho);

		String vazio = "";
		System.out.println(vazio.isEmpty());

		String trim = " Arrumar vazio no inicio e no fim ";
		System.out.println(trim.trim());

		String nomes = "ALURA";
		CharSequence cs = new StringBuilder("al");

		nome = nome.replace("AL", cs);

		System.out.println(nomes);

	}

}
