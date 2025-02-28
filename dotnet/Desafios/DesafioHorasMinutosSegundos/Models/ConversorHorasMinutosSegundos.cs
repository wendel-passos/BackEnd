using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DesafioHorasMinutosSegundos.Models
{
    public class ConversorHorasMinutosSegundos
    {
        public void ConverterHoraMinutosSegundos()
        {
            Console.WriteLine("Entrada");
            var timeInSeconds = Convert.ToInt32(Console.ReadLine());
            //TODO: Implementar a formula para calcular as horas.
            var hours = timeInSeconds / 3600;
            //TODO: Implementar a formula para calcular as horas.
            var minutes = (timeInSeconds % 3600) / 60;
            var seconds = (timeInSeconds % 3600) % 60;

            Console.WriteLine($"{hours}:{minutes}:{seconds}");
        }
    }
}