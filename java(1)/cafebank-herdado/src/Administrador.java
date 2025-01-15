
public class Administrador extends Funcionario implements Autenticavel {
	
	private Autenticacao autenticacao;
	
	@Override
	public double getBonificacao() {
		// TODO Auto-generated method stub
		return 50;
	}
	
	
	public Administrador() {
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


