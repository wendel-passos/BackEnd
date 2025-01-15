/**
 * 
 */
package sintaxeVariaveisFluxo;

/**
 * @author wendel
 *
 */
public class TesteCaracteres {

	/**
	 * @param args
	 */
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		//Tipo de dado char para declarar somente um caracter
		char letra = 'a';
		System.out.println (letra);
		
		char letraUnicode = 65;
		System.out.println(letraUnicode);
		
		//Necessário utilizar o cast para somar número para obter novo unicodde
		letraUnicode = (char) (letraUnicode + 1);
		System.out.println(letraUnicode);
		
		//------------------------------------//
		
		String palavra = "Teste variavel do tipo string";
		System.out.println(palavra);
		
		palavra = palavra + ' ' + 2022;
		System.out.println(palavra);
		
		
		
	}

}
