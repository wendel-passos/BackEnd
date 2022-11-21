
public class SistemaInterno {
	
	private int senha = 222;
	
	public void autentica (Autenticavel fa) {
		boolean autenticou = fa.autentica(this.senha);
		if (autenticou) {
			System.out.println("Bem vindo");
		} else {
			System.out.println("Senha incorreta!");
		}
	}

}
