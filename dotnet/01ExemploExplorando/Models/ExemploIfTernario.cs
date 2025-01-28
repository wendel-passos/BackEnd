using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01ExemploExplorando.Models
{
    public class ExemploIfTernario
    {
        public void Ternario ()
        {
            int numero = 0;
            for (int cont = 0; cont <=10; cont++)
            {
                bool ehPar = false;
                ehPar = numero % 2 == 0;
                Console.WriteLine($"Número {numero} é " + (ehPar ? "par" : "ímpar"));
                numero++;
            }

        }
    }
}