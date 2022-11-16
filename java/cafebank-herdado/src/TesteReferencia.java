
public class TesteReferencia {
	
	public static void main(String[] args) {
		
		Funcionario gerente = new Gerente (); //Objeto com outro tipo de refência. Introdução ao Polimorfismo 
		gerente.setNome("Wendel");
		String nome = gerente.getNome();
//		gerente.autentica();
		gerente.setSalario(5000.00);
		
		
		Funcionario funcionario = new Funcionario (); //Objeto com outro tipo de refência. Introdução ao Polimorfismo 
		funcionario.setSalario(2000.00);
		
		Funcionario editorVideo = new EditorVideo(); 
		editorVideo.setSalario(2500.00);
		 
		Funcionario designer = new Designer(); 
		designer.setSalario(2500.00);
		
		ControleBonificacao controle = new ControleBonificacao();  //Objeto com outro tipo de refência. Introdução ao Polimorfismo 
		controle.registra(gerente);
		controle.registra(funcionario);
		controle.registra(editorVideo);
		controle.registra(designer);
		System.out.println(controle.getSoma());
		
	}

}
