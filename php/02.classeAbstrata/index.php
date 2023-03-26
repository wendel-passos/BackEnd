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
        require './Cheque.php';
        require './ChequeComum.php';
        require './ChequeEspecial.php';


        //Classe abstrata não pode ser instanciada
        // $cheque = new Cheque (1000, "C");
        // $msg = $cheque->verValor();
        // echo $msg;
        // echo "<hr>";

        $chequeComum = new ChequeComum (50030443.75, "C");
        $msgChequeComum = $chequeComum->calcularJuros();
        echo $msgChequeComum;
        echo "<hr>";

        $chequeEspecial = new ChequeEspecial (200232.25, "D");
        $msgChequeEspecial = $chequeEspecial->calcularJuros();
        echo $msgChequeEspecial;
        echo "<hr>";
    ?>
    
</body>
</html>