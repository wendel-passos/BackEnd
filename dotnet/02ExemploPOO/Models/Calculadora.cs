using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _02ExemploPOO.Models.Interfaces;

namespace _02ExemploPOO.Models
{
    public class Calculadora : ICalculadora
    {
        public int Multiplicar(int num1, int num2)
        {
           return num1 * num2;
        }

        public int Somar(int num1, int num2)
        {
            return num1 + num2;
        }

        public int Subtarir(int num1, int num2)
        {
            return num1 - num2;
        }
    }
}