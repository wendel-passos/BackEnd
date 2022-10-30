

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author biblioteca
 */
public class appJogoLudico {
    public static void main(String[] args) {
        Dado d = new Dado (6);
        
        for ( int i = 1; i <= 10; i++){
            int x = d.rolar();
            System.out.println (x);
        }     
        
        
    //}  */
    
    JogoDeDadosProCassino jg = new JogoDeDadosProCassino();
    for (int i = 1; i <= 10; i++){
        System.out.println (jg.jogarDados());
    }
    }
            
  }     
    

