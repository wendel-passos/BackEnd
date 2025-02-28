using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioTempoFabricarPresentes.Models
{
    public class ValidaTempo
    {
        public void TempoConfeccaoPresentes()
        {
            Console.WriteLine("Tempo para fim do expediente");
            string[] line1 =  Console.ReadLine().Split();
            int finalExpediente = int.Parse(line1[0]);

            // Lê a segunda linha (tempo necessário para cada presente)
            Console.WriteLine("Tempo para confecção dos dois presentes");
            string[] line2 = Console.ReadLine().Split();
            int presente1 = int.Parse(line2[0]);
            int presente2 = int.Parse(line2[1]);

            // Calcula o tempo total necessário para fabricar os dois presentes
            int totalNecessario = presente1 + presente2;

            // Verifica se o tempo necessário é menor ou igual ao tempo restante
            if (totalNecessario > finalExpediente)
            {
                Console.WriteLine("Deixa para amanha!");
            }
            else
            {
                Console.WriteLine("Farei hoje!");
            }  
        }
    }
}