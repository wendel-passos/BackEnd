<?php

    class ClientePessoaFisica extends Cliente{

        public string $nome;
        public int $cpf;

        public function verInformacaoUsuario () : string {

            $dados = "<strong>Endereço da pessoa física</strong><br>";
            $dados .= "Endereço: {$this->logradouro}<br>"; //. Serve para concatenar string na msm variavel
            $dados .= "Bairro: {$this->bairro}<br>"; //. Serve para concatenar string na msm variavel
            $dados .= "Nome: {$this->nome}<br>"; //. Serve para concatenar string na msm variavel
            $dados .= "CPF: {$this->cpf}<br>"; //. Serve para concatenar string na msm variavel

            return  "<p>$dados</p> <hr>";
            

        }
    }

?>