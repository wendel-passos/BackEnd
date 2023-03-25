<?php
  class exemplo{
    private $var1;
    public $var2;

    public static $var3 = 'Estatico';

    private function metodo1 (){
      echo 'metodo privado';
    }
    public function metodo2 (){
      echo 'metodo publico <br>';
    }

    public static function metodo(){
      echo 'Metodo estatico';
    }

    //metodo que utiliza parametro e atribui o valor na variavel da classe
    public function setVar1 ($parametro){
      $this->var1 = $parametro;
    }
    //
    public function pegaVar1 (){
      return $this->var1;
    }
  }

?>