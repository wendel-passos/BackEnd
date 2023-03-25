<?php

    class ClientePessoaJuridica extends Cliente{

        public string $nomeFantasia;
        public int $cnpj;

        public function verInformacaoEmpresa() : string {

            $dados = "<strong>Endereço da pessoa juridíca</strong><br>";
            $dados .= "Endereço: {$this->logradouro}<br>"; //. Serve para concatenar string na msm variavel
            $dados .= "Bairro: {$this->bairro}<br>"; //. Serve para concatenar string na msm variavel
            $dados .= "Nome Fantasia: {$this->nomeFantasia}<br>"; //. Serve para concatenar string na msm variavel
            $dados .= "CNPJ: {$this->cnpj}<br>"; //. Serve para concatenar string na msm variavel

            return  "<p>$dados</p> <hr>";
            return  "<p>$dados</p> <hr>";
            

        }
    }

?>