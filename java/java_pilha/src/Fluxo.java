public class Fluxo {

	public static void main(String[] args) {
		System.out.println("Ini do main");
		//Tratamento de exceção
		try {
			metodo1();
		} catch (ArithmeticException | NullPointerException ex) { // | é o operador lógico "OU" para exceções.
			//String msg = ex.getMessage();
			//System.out.println("Exception" + msg);
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
		System.out.println("Ini do metodo2");
		for (int i = 1; i <= 5; i++) {
			System.out.println(i);
			//int a = i / 0; // Teste exceção divisão por zero
			//Conta c = null; // Teste exceção  Instanciando objeto null
			//c.deposita(); // Teste exceção  Instanciando objeto null
			System.out.println("Fim do metodo2");
		}
	}
}