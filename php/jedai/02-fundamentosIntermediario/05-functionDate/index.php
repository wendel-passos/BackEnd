<?php
  //Formato de datas 

  //Definição de zona
  date_default_timezone_set ('America/Sao_Paulo');

  //Atribuição de variável com a data atual
  $data = date ('d/m/Y H:i:s');

  //Atribuição de variável com a data atual, acresentando mais tempo em segundos
  $data1 = date ('d/m/Y H:i:s',time()+(60*100));

  echo $data.'<br>';
  echo $data1;
?>