using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01ExemploExplorando.Models
{
    public class ExemploPilha
    {
        public void PilhaDeInteiro ()
        {
            Stack<int> pilha = new();
            pilha.Push(4);
            pilha.Push(6);
            pilha.Push(8);
            pilha.Push(10);

            foreach (int item in pilha)
            {
                Console.WriteLine($"Totais de números na pilha: {item}");
            }

            pilha.Pop();
            
            foreach (int item in pilha)
            {
                Console.WriteLine($"Totais de números na pilha: {item}");
            }
        }
    }
}