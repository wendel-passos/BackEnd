package br.com.cafebank.banco.teste;

public class TesteArrayPrimitivo {
	//Array []
	public static void main(String[] args) {
		// TODO Auto-generated method stub
		
		int idades [] = new int [5];
		idades [0] = 29;
		int idade1 = idades [0];
		
		System.out.println(idade1);
		System.out.println(idades.length);
		
		for (int i = 0; i < idades.length; i++) {
			
			idades [i] = i * 2;
			System.out.println(idades [i]);
			
		}

	}

}
