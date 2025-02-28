using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02ExemploPOO.Models
{
    public class ContaCorrente
    {
        public ContaCorrente(int numeroConta, decimal saldoInicial)
        {
            NumeroConta = numeroConta;
            saldo = saldoInicial;
        }
        public int NumeroConta { get; set; }
        private decimal saldo;

        public void Sacar(Decimal valor)
        {
            if (saldo >= valor)
            {
                saldo -= valor;
                Console.WriteLine($"Saque de {valor} realizado com sucesso");
            }
            else
            {
                Console.WriteLine($"Saque de {valor} excede o saldo em conta: {saldo}");
            }

        }

        public void ExibirSaldo()
        {
            Console.WriteLine($"Saldo disponível: {saldo}");
        }
    }
}