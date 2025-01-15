package br.com.cafebank.banco.modelo;

/**
 * Classe que representa um cliente no banco.
 * @author WPassos
 *
 */

public class Cliente {
	private String nome;
	private String cpf;
	private String profissao;
	
	public String getNome() {
		return nome;
	}
	public void setNome(String nome) {
		this.nome = nome;
	}
	public String getCpf() {
		return cpf;
	}
	public void setCpf(String cpf) {
		this.cpf = cpf;
	}
	public String getProfissao() {
		return profissao;
	}
	public void setProfissao(String profissao) {
		this.profissao = profissao;
	}
/**
 * Customização do toString para cliente
 */

//	@Override
//	public String toString() {
//		// TODO Auto-generated method stub
//
//		return "Nome do cliente: " + this.getNome();
//	}

	
	

}
