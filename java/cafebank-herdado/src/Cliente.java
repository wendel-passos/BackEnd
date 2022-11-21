//Gerente herdando métodos da classe Funcionario
public class Cliente implements Autenticavel {

	private Autenticacao autenticacao;

	public Cliente() {
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
