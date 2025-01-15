public class Fluxo {

	public static void main(String[] args) {
		System.out.println("Ini do main");
		// Tratamento de exceção
		try {
			metodo1();
		} catch (Exception ex) { // | é o operador lógico "OU" para exceções.
			String msg = ex.getMessage();
			System.out.println("Exception " + msg);
			ex.printStackTrace();
		}
		System.out.println("Fim do main");
	}

	private static void metodo1() {
		System.out.println("Ini do metodo1");
		metodo2();

		System.out.println("Fim do metodo1");
	}

	private static void metodo2() {
		System.out.println("Chamando metodo 2");
		//metodo2();
		throw new NullPointerException ("Excecao !!!!!!!!");
		//ystem.out.println("Fim do metodo 2");
	}
}