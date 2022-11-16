//Gerente herdando métodos da classe Funcionario
public class Gerente extends Funcionario {
	
	private String nome;
	private String cpf;
	private int senha;
	
	public void setSenha(int senha) {
		this.senha = senha;
	}
	
	public boolean autentica (int senha) {
		if (this.senha == senha ) {
			return true;
		} else {
			return false;
		}
	}
	
	public double getBonificacao() { 
		System.out.println("Chamando bonificacao Gerente");
		return super.getBonificacao() + super.getSalario();
	}
	 
}
