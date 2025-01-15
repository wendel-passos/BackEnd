/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */

/**
 *
 * @author Wendel Passos
 */
public class Aluno {
    // Estado 
    float a1, a2;
    float a3;
    
    //Regra de negócio
    final float MEDIA = 6.0f;
    
    //Construtor da classe 
    public Aluno (){
        a1 = a2 = 0.0f;
        a3 = 0.0f;
    }
    
    //Construtor da classe com assinatura diferente
    public Aluno (float a1, float a2, float a3){
        
        //Operador de autoreferência this para atribuir o valor do parâmetro nos atributos
        this.a1 = a1;
        this.a2 = a2;
        this.a3 = a3;
    }
    
    //Comportamento ´- Métodos
    public float mediaNotas () {
        return a1 + a2;
    }
    
    public float maior(){
        return (a1 >= a2)? a1 : a2; //Operador ternario
    }
    
    public float mediaFinal (){
        
        boolean a3Valida = a3 > a1 || a3 > a2;
        
        if (mediaNotas ()  >= MEDIA || !a3Valida){
            return mediaNotas ();
        } else {
            return maior () + a3;
        }  
    }
            
    public String situacao (){
        return (mediaFinal () >= MEDIA)?"Aprovado":"Reprovado";//Operador ternario
    }
    

    @Override
    public String toString(){
        String mostrar = "Situação do Aluno";
        mostrar += "\na1 = " + a1;
        mostrar += "\na2 = " + a2;
        mostrar += "\nMédia parcial = " + mediaNotas();
        mostrar += "\na3  = " + a3;
        mostrar += "\nMédia final   = " + mediaFinal();
        mostrar += "\nSituação      : " + situacao();
        return mostrar;
    }
}
