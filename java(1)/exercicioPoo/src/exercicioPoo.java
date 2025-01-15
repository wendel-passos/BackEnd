import java.util.Scanner;

public class exercicioPoo {
	
	Scanner ler = new Scanner (System.in);
	int  A1;
	int  A2;
	int  Media;
	
	public int calculaNota () {
		Media = A1 + A2;
		return Media;
	}
	
	public int media() {
		Media = Media/2;
		return Media;
	}
	
	public void printaNota() {
		
		if (Media  >= 6) {
			System.out.println("Aprovado ! Nota : " + Media);
		} else {
			System.out.println("Reprovado ! Nota : " + Media);
		}
	}

}
