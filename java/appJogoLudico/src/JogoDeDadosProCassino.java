/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author biblioteca
 */
public class JogoDeDadosProCassino {
    //Atributos
    Dado d1, d2;
    //Construtor
    JogoDeDadosProCassino (){
        this.d1 = new Dado ();
        this.d2 = new Dado ();
    }
    //Métodos
    public int jogarDados (){
        return d1.rolar () + d2.rolar();
    }
}
