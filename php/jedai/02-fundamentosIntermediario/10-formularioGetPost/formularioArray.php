<!DOCTYPE html>
<html lang="pt-br">
<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Document</title>
</head>
<body>
  <?php
    // metodo get
    /*
    if (isset ($_GET['acao'])){
      $nome = @$_GET['nome'];
      $email = @$_GET['email'];
      echo $nome;
      echo '<br>';
      echo $email;
    }
    */

    // metodo post

    //Criação de array para receber formulario
    if (isset ($_POST['acao'])){
      foreach ( $_POST['valor'] as $key => $value) {
        echo $key;
        echo  '=>';
        echo $value;
        echo '<hr>';
      }
    }

  ?>
  <form method ="post">
    <input type="text" name= "valor[]">
    <input type="text" name= "valor[]">
    <input type="submit" name= "acao" value= "enviar">
  </form>


</body>
</html>