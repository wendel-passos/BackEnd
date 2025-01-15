package sintaxeVariaveisFluxo;
/*
 * Utilize um laço do tipo for para imprimir todos os múltiplos de 3, entre 1 e 100.
 */
public class ExercicioNumeroImpar {
	public static void main(String[] args) {
		
		for (int cont = 1; cont <= 100; cont++)
		
			if(cont % 3 == 0) {
			 System.out.print(cont + " ");
			}
		
	}

}
