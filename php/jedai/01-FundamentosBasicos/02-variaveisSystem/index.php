<?php

  //Variável de sistema para verificar o nome do servidor
  echo $_SERVER["SERVER_NAME"],"<BR>";

  //Variável de sistema para verificar A raíz do arquivo
  echo $_SERVER["DOCUMENT_ROOT"],"<BR>";

  //Printar array com as variáveis de sistema
  echo '<pre>';
  print_r ($_SERVER);
  echo 'pre/>;'
?>