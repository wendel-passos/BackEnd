
import java.util.Random;

/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author biblioteca
 */
public class Dado {
    //Atributos (Estado)
    final int numLados;
    
    //Construtor da classe 
    public Dado (){
         this.numLados = 6;
    }
    
    //Construtor da classe 
    public Dado (int numLados){
         this.numLados = numLados;
    }
    //Comportamento (Funções)
    public int jogar (){
        return(int)(Math.random()*numLados + 1);
    }
    public int rolar (){
        Random r = new Random ();
        return r.nextInt(numLados)+1;
    }
    
    
}
