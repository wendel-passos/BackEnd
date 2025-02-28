using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioAnosMesesDias.Models
{
    public class AnoMesDia
    {
        public void ConversorAnoMesDia()
        {
            Console.WriteLine("Digite a quantidade de dias");
            int dias = Convert.ToInt32(Console.ReadLine());
            var anos = dias / 365    ;
            dias = dias % 365     ;
            var meses = dias / 30    ;
            dias = dias % 30    ;
            
            Console.WriteLine($"{anos} ano(s)");
            Console.WriteLine($"{meses} mes(es)");
            Console.WriteLine($"{dias} dia(s)");
        }
    }
}