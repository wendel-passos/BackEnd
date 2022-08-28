package sintaxeVariaveisFluxo;

/*Após assistir as aulas de aninhamento de laços de repetição e sobre o comando break,
 *  Fernando decidiu criar um código como forma de treinamento que imprime na tela o seguinte:
1
12
123
1234
12345
*/

public class ExercicioFor {
	
	public static void main(String[] args) {
		
		for(int linha = 1; linha <= 5; linha++) {
            for (int coluna = 1; coluna <= linha; coluna++) {
               
                System.out.print( coluna );
            }
            System.out.println();
        }
	}

}
