<!DOCTYPE html>
<html lang="en">
<head>
    <meta charset="UTF-8">
    <meta http-equiv="X-UA-Compatible" content="IE=edge">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
    <title>Document</title>
</head>
<body>
    <?php
        require './Usuarios.php'; //Importação do arquivo
        $usuario = new Usuarios(); //Instaciando objeto
        //$msg = $usuario->cadastrar("Wendel","teste@gmail.com",18);
        $result_usuarios = $usuario->listar();

         foreach($result_usuarios as $row_usuario){
            //var_dump($row_usuario); // imprime o Array
            extract($row_usuario);
            echo "ID: $id <br>";// Com extract utiliza essa forma para imprimir o ID no Array
            echo "Nome: $nome <br>";// Com extract utiliza essa forma para imprimir o ID no Array
            echo "Email: $email <br>";// Com extract utiliza essa forma para imprimir o ID no Array
            echo "<hr>";
            //echo "Id do usuário ". $row_usuario ['id']. "<br>";//Sem o extract utiliza essa forma para imprimir o ID no Array
         }
       
    ?>
</body>
</html>