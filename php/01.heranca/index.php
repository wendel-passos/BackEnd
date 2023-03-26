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
        require './Clientes.php';
        require './ClientePessoaFisica.php';
        require './ClientePessoaJuridica.php';

        $cliente  = new Cliente ();
        $cliente->logradouro = 'Rua das guerras';
        $cliente->bairro = 'Barra Azul';
        $msg = $cliente->verEndereco();
        echo $msg;
        echo "<hr>";

        $clientePf = new ClientePessoaFisica();
        $clientePf->logradouro = 'Rua Nova';
        $clientePf->bairro = 'Dos Vermelhos';
        $clientePf->nome = 'Wendel';
        $clientePf->cpf = 10345032405;
        $msg = $clientePf->verInformacaoUsuario();
        echo $msg;

        $clientePj = new ClientePessoaJuridica();
        $clientePj->logradouro = 'Rua das empresas';
        $clientePj->bairro = 'Dos Azuis';
        $clientePj->nomeFantasia = 'Veda Tudo';
        $clientePj->cnpj = 12932001121;
        $msg = $clientePj->verInformacaoEmpresa();
        echo $msg;

    ?>
    
</body>
</html>