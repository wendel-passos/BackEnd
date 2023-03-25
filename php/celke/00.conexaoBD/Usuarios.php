<?php

require './Conn.php';//Importando classe de conexão com o BD
class Usuarios{

    public string $nome;
    public string $email;
    public int $idade;
    public $connect;

    public function cadastrar ($nome,$email,$idade) : string {

        $this->nome = $nome;
        $this->email= $email;
        $this->idade= $idade;
        return "Usuario Cadastrado com sucesso! Nome: {$this->nome} email: ".$this->email." Idade: {$this->idade} <br>";
    }

    public function listar () {

        $conn = new Conn();
        $this->connect = $conn->conectar();

        $query_usuarios = "SELECT id,nome,email FROM usuarios ORDER BY id LIMIT 40";//query utilizada para consulta no BD
        $result_usuarios = $this->connect->prepare($query_usuarios);
        $result_usuarios->execute();
        return $result_usuarios->fetchAll();
        // return "Listado com sucesso! <br> ";
        
    }
}