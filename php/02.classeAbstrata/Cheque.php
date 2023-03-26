<?php
   abstract class Cheque {

        //PHP versão < 8
        //public float $valor;
        //public string $tipo;

        // public function __construct(float $valor, string $tipo){

        //     $this->valor = $valor;
        //     $this->tipo = $tipo;

        // }

        //PHP versão 8

        public function __construct(public float $valor, public string $tipo){
         
        }

        // public function verValor () : string {
        //     return "Valor do cheque: {$this->valor} <br> Tipo: {$this->tipo}";
        // }

        public function converterReal (float $valor): string {
            return number_format($valor,'2',',','.');
        }
       
    }
?>