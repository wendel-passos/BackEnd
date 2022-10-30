public class Programa {
	
	public static void main(String[] args) {
		
		exercicioPoo exercicio = new exercicioPoo ();
		
		System.out.println("Insira a primeira nota : \n");
		exercicio.A1 = exercicio.ler.nextInt();
		
		System.out.println("Insira a primeira nota : \n");
		exercicio.A2 = exercicio.ler.nextInt();
		
		
		exercicio.calculaNota();
		exercicio.media();
		exercicio.printaNota();
		
		
		System.out.println(Math.min(exercicio.A1, exercicio.A2));
		
		
	}

	
	
}
