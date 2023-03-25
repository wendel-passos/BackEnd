<?php

  //Funcao pra printar nome, deve ser passado o paramentro do nome que desaja ser exibido
  function mostrarNome ($nome){
    echo "<h2> $nome</h2><br>";
  }
  //Funcao soma dois numeros
  function somaDoisNumeros ($num1, $num2){
    echo $num1+$num2."<br>";
  }
  //Funcao retorna string
  function retornaString (){
    return 'Teste<br>';
  }
  //funcao com retoro verdadeiro
  function verdadeiro(){
    return true;
  }
  //chamando as funções
  mostrarNome('Carla');
  somaDoisNumeros (2,6);
  echo retornaString ();
  echo verdadeiro ();
?>