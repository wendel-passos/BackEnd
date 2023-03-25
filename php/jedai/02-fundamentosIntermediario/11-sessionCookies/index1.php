<?php
  //verificar se existe alguma sessão aberta 
  // if (isset ($_SESSION['nome'])){
  //   echo $_SESSION['nome'];
  // }
  //Limpar sessão
  session_start ();
  unset ($_SESSION['nome']);
  //destruir todas as sessões
  session_destroy ();
?>