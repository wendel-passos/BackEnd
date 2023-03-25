<?php

  $nome1 = '2';
  $nome2 = '10';

  //condição para saber se é igual 
  if ($nome1 == $nome2){
    echo 'Verdade ';
  }
  //condição para saber se o valor é igual e o tipo também
  if ($nome1 === $nome2) { 
    echo 'Nome e tipo são iguais';
  }
  //condição para saber se o valor é diferente
  elseif ($nome1 != $nome2) { 
    echo 'Falso, valores são diferentes';
  }
  //condição para saber se o valor e tipo são iguais
  elseif ($nome1 !== $nome2) { 
    echo ' Valores são iguais, mas o tipo é diferente';
  }
  else{
    echo 'Falso';
  }
?>