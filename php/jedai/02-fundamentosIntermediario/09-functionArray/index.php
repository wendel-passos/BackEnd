<?php

  //Unir mais de um array
  $arr1 = array ('chave1'=>'Wendel','chave2'=>'Sandy');
  $arr2 = array ('chave3'=>25,'chave4'=>20);
  $resultado = array_merge ($arr1,$arr2);
  print_r ($resultado);
  echo '<br>';

  //Realizar a interseção de chaves que se repetem no array
  $arr3 = array ('chave1'=>'Wendel','chave2'=>'Sandy');
  $arr4 = array ('chave1'=>25,'chave2'=>20);
  $resultado1 = array_intersect_key($arr3,$arr4);
  print_r ($resultado1);
  echo "<br>";

  //Remover tags html do array
  $arr = array ('Wendel', '<h1>Passos</h1>');
  print_r(array_map('strip_tags',$arr));


?>