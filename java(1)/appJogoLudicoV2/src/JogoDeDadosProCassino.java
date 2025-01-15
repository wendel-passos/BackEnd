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
    
    public String jogar (){
        String saida;
        int resultado = jogarDados();
        saida = "Primeira Jogada = " + resultado;
        switch (resultado){
            case 2:  
            case 3:
            case 12: saida += "\tPerdeu";
                break;
            case 7:
            case 11: saida += "\tGanhou";
                break;
            default : saida += "\tContinua jogando";
                saida += continuar (resultado);
                break;
        }
        return saida;
    }
    public String continuar (int ponto){
        String saida = "\tPonto = " +ponto;
        while (true){
            int novaJogada = jogarDados ();
            saida += "\nNova Jogada = " + novaJogada;
            if (novaJogada == ponto){
                saida += "\t Ganhou!";
                break;
            }else if (novaJogada == 7){
                saida += "\t Perdeu";
                break;
            }
        }
        return saida;
    }
}
