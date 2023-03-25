<?php

  $nome = 'Teste funcao subtring';

  //Funcao utilizada para selecionar a posição de uma string 
  echo substr ($nome, 0, 5);

  // Trasformar variável em array
  $nome1 = 'Wendel Eduardo Amanda Santos';
  $nomes = explode (' ',$nome1);
  print_r ($nomes);
  echo '<br>';

  //Funcao para exibir toda a string da variavel com separadores
  $nomes = implode (' - ', $nomes);
  echo "$nomes<br>";

  //Funcao para tratar tags HTML
  $conteudo = '<h1>Wendel</h1> Outra coisa';
  echo strip_tags($conteudo);
  echo '<br>';

  //Funcao para exibir tags HTML 
  echo htmlentities('<h2></h2>');
 




?>