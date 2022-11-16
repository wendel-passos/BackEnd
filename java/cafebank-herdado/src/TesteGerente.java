
public class TesteGerente {
	
	public static void main(String[] args) {
		
		Gerente gerente = new Gerente();
		gerente.setNome("Serrano Finado");
		gerente.setCpf("123456789");
		gerente.setSalario(10000.35);
		
		System.out.println(gerente.getNome());
		System.out.println(gerente.getCpf());
		System.out.println(gerente.getSalario());
		System.out.println(gerente.getBonificacao());
		gerente.setSenha(123);
		boolean autenticou = gerente.autentica(123);
		System.out.println(autenticou);
	}
}
