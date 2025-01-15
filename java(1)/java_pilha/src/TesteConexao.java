
public class TesteConexao {
	public static void main(String[] args) {

//		try atualizado 
		try (Conexao conexao = new Conexao()){
			conexao.leDados();
		} catch (IllegalStateException ex) {
			System.out.println("Erro de conexao");
		}
		
//		Criação do try antigo
		/*Conexao con = null;
		try {
			con = new Conexao();
			con.leDados();
			con.fecha();
		} catch (IllegalStateException ex) {
			System.out.println("Erro de conexao");
		} finally {
			con.fecha();
		}*/

	}
}
