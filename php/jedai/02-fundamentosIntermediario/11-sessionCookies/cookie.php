<?php
  session_start ();
  //declarar cookie
  //setcookie ('nome', 'Wendel',time() + (60*60*24), '/');

  //destruir cookie negativando o tempo de vida
  setcookie ('nome', 'Wendel',time() - (60*60*24), '/');
  echo $_COOKIE['nome'];
?>