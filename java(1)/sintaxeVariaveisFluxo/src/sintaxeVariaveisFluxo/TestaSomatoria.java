package sintaxeVariaveisFluxo;

public class TestaSomatoria {
	public static void main(String[] args) {
		
		int contador = 0;
		int total = 0;
		
		while (contador <= 10 ) {
			total += contador;
			contador ++;
			System.out.println("Total igual a " + total);
			System.out.println("Contador igual a " + contador);
			
		}
	}

}
