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
    if (isset ($_POST['acao'])){
      $nome = @$_POST['nome'];
      $email = @$_POST['email'];
      echo $nome;
      echo '<br>';
      echo $email;
    }

  ?>
  <form method ="post">
    <input type="text" name= "nome">
    <input type="text" name= "email">
    <input type="submit" name= "acao" value= "enviar">
  </form>

  

</body>
</html>