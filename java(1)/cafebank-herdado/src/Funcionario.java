//A partir do momento que uma classe é abstrata ela não pode mais ser instanciada
public abstract class Funcionario { 
	
	private String nome;
	private String cpf;
	private double salario; //É possível utilizar o protected para deixar o atributo visível para os filhos 

	//Método sem corpo, deve ser implementado nas classes filhas
	public abstract double getBonificacao();
	
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
	public double getSalario() {
		return salario;
	}
	public void setSalario(double salario) {
		this.salario = salario;
	}
	
	
}
