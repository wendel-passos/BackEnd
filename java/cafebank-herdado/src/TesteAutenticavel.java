
public class TesteAutenticavel {
	
	public static void main(String[] args) {
		
		Autenticavel g = new Gerente ();
		g.setSenha(222);
		
		Autenticavel adm = new Administrador ();
		adm.setSenha(222);
		
		Autenticavel cliente = new Cliente ();
		cliente.setSenha(222);
		
//		Teste para verificar se um funcionario não autenticavel consegue utilizar o polimorfismo
//		Autenticavel designer = new Designer();
//		designer.setSenha(222);
		
		
		SistemaInterno si = new SistemaInterno();
		si.autentica(g);
		si.autentica(adm);
		si.autentica(cliente);
		//si.autentica(designer);
		
		
	}
	

}
