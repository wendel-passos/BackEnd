<?php

class Conn{

    public $host = "localhost";
    public $user = "root";
    public $pass =  "";
    public $dbname = "celke";
    public $port = 3306;
    public $connect = null;

    public function conectar () {

        try {

            $this->connect = new PDO("mysql:host=".$this->host . ";port=" . $this->port . ";dbname=" . $this->dbname, $this->user,$this->pass);//Função utilizada para realizar a conexão com o BD
            echo "Conexão efetuada com sucesso <br> <br>";
            return $this->connect;

        } catch (Exception $err){
            echo "Erro ao conectar no banco de dados!";
            return false;
        }
    }

}