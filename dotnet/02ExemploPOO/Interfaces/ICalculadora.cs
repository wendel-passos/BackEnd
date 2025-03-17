using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02ExemploPOO.Models.Interfaces
{
    public interface ICalculadora
    {
        int Somar (int num1, int num2);
        int Subtarir (int num1, int num2);
        int Multiplicar (int num1, int num2);
        int Dividir(int num1, int num2)
        {
            return num1 / num2;
        }
    }
}