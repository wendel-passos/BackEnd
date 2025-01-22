using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estruturaDeRepeticao.Models
{
    public class Tabuada
    {
        public void MontarTabuadaComFor ()   
        {
            int valor = 0;
            Console.WriteLine ("Digite o valor que deseja");
            valor = Convert.ToInt32 (Console.ReadLine());

            for (int contador = 0; contador <= 10; contador ++)
            {
                Console.WriteLine ($"{valor} X {contador} = {valor * contador}");
            }
        }
        public void MontarTabuadaComWhile ()   
        {
            int valor = 0, contador = 0;
            Console.WriteLine ("Digite o valor que deseja");
            valor = Convert.ToInt32 (Console.ReadLine());

            while (contador <= 10)
            {
                Console.WriteLine ($"{valor} X {contador} = {valor * contador}");
                contador ++;
            }
        }
        public void MontarTabuadaComDoWhile ()   
        {
            int valor = 0;

            do
            {
            Console.WriteLine ("Digite o valor que deseja (0 Para finalizar)");
            valor = Convert.ToInt32 (Console.ReadLine());

            if (valor == 0) 
            {
            Console.WriteLine("Programa finalizado.");
            break;
            }

            Console.WriteLine ($"Tabuada do {valor}");

            for (int contador = 0; contador <= 10; contador ++)
            {
                Console.WriteLine ($"{valor} X {contador} = {valor * contador}");
            }
            }
            while (valor != 0);

        }
    }
}