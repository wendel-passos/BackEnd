<?php
    class ChequeComum extends Cheque{

        public function calcularJuros () : string {

            $valorComJuros = (0.02 *$this->valor) + $this->valor;
            //$valorConvertidoReal = parent::converterReal($this->valor);//usando o parent
            $valorConvertidoReal = $this->converterReal($valorComJuros);//usando o pseudo this
            return "Valor do cheque R$: {$valorConvertidoReal} <br> Tipo: {$this->tipo}<br>";
        }
       
    }
?>