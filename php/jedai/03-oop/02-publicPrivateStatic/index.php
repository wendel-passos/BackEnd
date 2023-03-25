<?php
  include ('exemplo.php');

  //instacia de objeto
  $exemplo1 = new exemplo();

  //Atributo privado não existe fora da classe 
  //$exemplo->var1 = 'Ola';

  //atributo publico existe fora da classe
  $exemplo1->var2 = 'Teste<br>';
  echo $exemplo1->var2;

  //atribuindo metodo do objeto na variavel
  echo $exemplo1->metodo2();

  // Nova instancia
  $exemplo2 = new exemplo ();
  $exemplo2->var2 = 'Fechar<br>';
  echo $exemplo2->var2 ;

  //Utilizando variavel estatica da classe exemplo 
  echo exemplo::$var3;

  //Atribuindo outro valor para a variavel estatica da classe exemplo
  exemplo::$var3 = 'Alteracao do estatico';
  echo exemplo::$var3 = '<br>Alteracao do estatico</br>';

  //Utilizando medodo estatico da classe exemplo
  echo exemplo::metodo();
  echo '<br>';

  //Utilizando metodo que utilza passagem de parametro 
  $exemplo3 = new exemplo();
  $exemplo3->setVar1('Alterei o valor da variavel da classe');
  echo $exemplo3->pegaVar1();

?>