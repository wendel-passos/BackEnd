//Gerente herdando métodos da classe Funcionario e é um autenticavel
public class Gerente extends Funcionario implements Autenticavel{
	
	private Autenticacao autenticacao;
	
	public double getBonificacao() { 
		System.out.println("Chamando bonificacao Gerente");
		return  super.getSalario();
	}

	

	public Gerente() {
		this.autenticacao = new Autenticacao();
	}

	@Override
	public void setSenha(int senha) {
		this.autenticacao.setSenha(senha);

	}

	@Override
	public boolean autentica(int senha) {
		return this.autenticacao.autentica(senha);
	}
}

