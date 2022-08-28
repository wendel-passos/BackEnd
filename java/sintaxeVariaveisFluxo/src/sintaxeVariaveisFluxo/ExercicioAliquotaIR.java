package sintaxeVariaveisFluxo;

/*O João gostaria de criar um programa sobre Imposto de Renda (IR) e verificou as regras de alíquota. Ele descobriu no site da receita:

De 1900.0 até 2800.0, o IR é de 7.5% e pode deduzir na declaração o valor de R$ 142
De 2800.01 até 3751.0, o IR é de 15% e pode deduzir R$ 350
De 3751.01 até 4664.00, o IR é de 22.5% e pode deduzir R$ 636 */

public class ExercicioAliquotaIR {

	public static void main(String[] args) {

		double salario = 1500.00;

		if (salario < 1900.00) {
			System.out.println("Isento de imposto");
		} else if (salario > 1900.00 && salario <= 2800.00) {
			System.out.println("IR de 7.5% e pode ser deduzido o valor de R$ 142");
		} else if (salario > 2800.01 && salario <= 3751.00) {
			System.out.println("IR de 15% e pode deduzir R$ 350");
		} else if (salario > 3751.01) {
			System.out.println("IR de 22.5% e pode deduzir R$ 636");
		}

	}
}
