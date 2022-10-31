
public class TesteGetSet {
	
	public static void main(String[] args) {
		Conta conta = new Conta (123, 880);
		
		//conta.numero = 1337;
		//Com o método set a atribuição do valor do número da conta é feito utilizando o método set
		conta.setNumero(23423);
		System.out.println(conta.getNumero());
		
		
		Cliente wendel = new Cliente ();
		wendel.setNome("Wendel Passos");
		wendel.setProfissao("Atleta");
		wendel.setCpf("45632334565");
		conta.setTitular(wendel);
		
		//Exibir o nome do titular da conta
		System.out.println(conta.getTitular().getNome());
		
		conta.getTitular().setProfissao("Programador");
		System.out.println(conta.getTitular().getProfissao());
		
		//Mesmo resultado em duas linhas
		Cliente titularDaConta = conta.getTitular();//Atribuindo o nome em uma variável
		System.out.println(conta.getTitular().getProfissao());
		
		
		//Os atributos estão alocados no mesmo endereço porque pertencem ao mesmo cliente
		System.out.println("\n" + wendel);
		System.out.println(titularDaConta);
		System.out.println(conta.getTitular());
		
		
		//Instanciando um novo cliente e conta
		Conta conta2 = new Conta (123, 889);
		Cliente amanda = new Cliente ();
		conta2.setTitular(amanda);
		//Nesse caso o atributo é alocado em outro endereço porque foi instanciado um novo cliente 
		System.out.println("\n" + conta2.getTitular());
		
	}	

}
