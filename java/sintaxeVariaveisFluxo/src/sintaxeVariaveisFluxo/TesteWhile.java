package sintaxeVariaveisFluxo;

public class TesteWhile {
	public static void main(String[] args) {
		//variável no escopo main
		int contador = 0;
		
		while (contador <=10) {
			System.out.println(contador);
			contador ++;
		}
		
		//A variavel continua disponível porque ela foi declarada no escopo main
		System.out.println(contador);
	}

}
