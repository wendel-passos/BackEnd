<?php

//Classe final não pode ser herdada, por isso comentei o "final"
/*final*/ class filha
{
  public function mostrarOla()
  {
    echo 'Ola Mundo!!<br>';
  }
  protected function mostrarTeste()
  {
    echo 'Testandoooo protected<br>';
  }
}

//Extends serve para receber herança de outro objeto (Classe)
class pai extends filha
{
  public function mostrarTchaw()
  {
    echo 'mostrarTchaw<br>';
    //esse this serve para habilitar o uso da função protected mostrarTeste da classe filha;
    $this->mostrarTeste();
  }
  public function mostrarTeste()
  {
    //O parent tem o objetivo de utilizar a função herdada do objeto filha
    parent::mostrarTeste();
    echo '<br>';
    echo 'Alterei o mostrar teste protected para uma nova função<br>';
  }
}

$pai = new pai;
$pai->mostrarTchaw();
$pai->mostrarOla();
//$pai ->mostrarTeste();


$filha = new filha();
$filha->mostrarOla();
