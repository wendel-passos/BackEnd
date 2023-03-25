<?php
  //Objeto pessoa
  class Pessoa{
    //atributos
    private $nome = 'Wendel';
    private $idade = 25;
    private $peso = '100kg';
    
    //metodo privado
    private function crescer (){
      echo 'Estou crescendo';
      
    }

    //metodo publico
    public function comer(){
      $this -> crescer();
      echo '<br>';
      echo 'Estou comendo';
    }
  }

  //instanciando objeto
  $pessoa = new Pessoa;
  $pessoa2 = new Pessoa;

  //utilizadno metodo do objeto na variavel
  $pessoa->comer();

?>
