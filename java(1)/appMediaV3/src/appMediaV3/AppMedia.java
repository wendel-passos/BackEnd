package appMediaV3;

import java.util.Scanner;

public class AppMedia {

    /**
     * @param args the command line arguments
     */
    public static void main(String[] args) {
        // TODO code application logic here
       
        Aluno aluno; // = new Aluno (2.5f, 3.0f, 1.5f);
        //aluno.a1 = 2.0f;
        //aluno.a2 = 1.0f; 
        //aluno.a3 = 6.0f;
        	
            //Interface texto com o usuário 
    Scanner scan = new Scanner (System.in);
    System.out.print ("Nota A1 ");
    float  a1 = scan.nextFloat();
    System.out.print ("Nota A2 ");
    float a2 = scan.nextFloat();
    
    System.out.print ("Fez a A3 (S/N) ?");
    char opcao = scan.next().charAt (0);
    switch (opcao){
        case 'S':
        case 's':System.out.print ("Nota A3 ");
                    float  a3 = scan.nextFloat();
                    aluno = new Aluno (a1,a2,a3);
                    break;
        default : aluno = new Aluno(a1,a2);
        }
        
        System.out.println (aluno);
        
        
        
    }
    
    
    
}
