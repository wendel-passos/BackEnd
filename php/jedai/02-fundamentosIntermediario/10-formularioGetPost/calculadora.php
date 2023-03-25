<!DOCTYPE html>
<html lang="pt-br">
<head>
  <meta charset="UTF-8">
  <meta http-equiv="X-UA-Compatible" content="IE=edge">
  <meta name="viewport" content="width=device-width, initial-scale=1.0">
  <title>Document</title>
</head>
<body>

  <form method ="post">
    <input type="text" name= "numero1">
    <input type="text" name= "numero2">
    <input type="submit" name= "acao" value= "calcular">
  </form>

  <?php
    // metodo post
    if (isset ($_POST['acao'])){
      echo $_POST ['numero1'] + $_POST ['numero2'];
    }
  ?>

</body>
</html>