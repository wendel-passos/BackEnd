using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01ExemploExplorando.Models
{
    public class ExemploFila
    {
        public void FilaDeInteiros ()
        {
            Queue<int> fila = new ();

            fila.Enqueue(2);
            fila.Enqueue(4);
            fila.Enqueue(6);
            fila.Enqueue(8);

            foreach (int item in fila)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine($"Removendo o elemento: {fila.Dequeue()}");
            fila.Enqueue(10);

            foreach (int item in fila)
            {
                Console.WriteLine(item);
            }

        }
    }
}