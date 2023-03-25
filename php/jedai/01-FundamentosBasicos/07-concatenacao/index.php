<?php
  //variáveis
  $frase = 'Meu nome é ';
  $nome = 'Wendel ';
  $idade = 100;
  $nomedaclasse = 'box';
  //constante
  define ('NOME','CONSTANTE');

  //Exemplo1 com vírgula
  echo $frase,$nome,'tenho ',$idade,' ',$nomedaclasse,' ',NOME,'<br/>';
  //Exemplo2 com ponto
  echo $frase.$nome.'tenho '.$idade.' '.$nomedaclasse.' '.NOME.'<br/>';
  //Exemplo3 com aspas duplas
  echo "$frase $nome tenho $idade $nomedaclasse " ,NOME,'<br/>';
?>