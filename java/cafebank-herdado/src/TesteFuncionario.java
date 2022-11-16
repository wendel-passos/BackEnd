
public class TesteFuncionario {

	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		Funcionario wendel  = new Funcionario ();
		wendel.setNome("Wendel Passos");
		wendel.setCpf("12356745678");
		wendel.setSalario(5000.50);
		
		System.out.println(wendel.getNome());
		System.out.println(wendel.getSalario());
		System.out.println(wendel.getBonificacao());
		

	}

}
