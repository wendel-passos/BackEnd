<?php

  //Exemplo de funcao Switch
  $nome = 'Julia';
  switch($nome) {
    case 'Wendel':
      echo 'Ola Wendel';
      break;
    case 'Julia':
      echo 'Olá Julia';
      break;
  }
  echo '<br>';

  //Exemplo de aplicação do continue
  for ($i = 0; $i<= 20; $i++){
    if ( $i % 2 == 0 ){
      continue;
    }
    echo $i;
    echo '<br>';
  }

  //Exemplo de aplicação do break
  for ($i = 0; $i<= 20; $i++){
    if ($i == 0){
      continue;
    } if ( $i == 11){
        break;
      } 
    echo $i;
  }
?>