using System;
using System.Collections.Generic;
using System.Data;
using System.Globalization;
using System.Linq;
using System.Threading.Tasks;

namespace _01ExemploExplorando.Models
{
    public class Formatacao
    {       
        /// <summary>
        /// Formata valor monetário para o formato definido na máquina
        /// </summary>
        /// <param name="valor"></param>           
        public void ValorMonetario (decimal valor)
        {
            Console.WriteLine($"{valor:C}");
        }

        /// <summary>
        /// Formata valor monetário para o formato da cultura definida
        /// </summary>
        /// <param name="valor"></param>           
        public void ValorMonetarioCultura (decimal valor)
        {
            CultureInfo.DefaultThreadCurrentCulture = new("pt-br");
            Console.WriteLine($"{valor.ToString("C",CultureInfo.CreateSpecificCulture("en-US")):C}");
        }

        /// <summary>
        /// Formata para percentual
        /// </summary>
        /// <param name="valor"></param>   
        public void Porcentagem  (double valor)
        {
            Console.WriteLine(valor.ToString("P"));
        }

        /// <summary>
        /// Formata utilizando concatenacao
        /// </summary>
        /// <param name="valor"></param>   
        public void ConcatenacaoPersonalizada  (double valor)
        {
            Console.WriteLine(valor.ToString("##-##--##--##"));
        }
        /// <summary>
        /// Formata data
        /// </summary>
        public void FormatacaoData ()
        {
            DateTime data = DateTime.Now;
            Console.WriteLine(data.ToString("dd/MM/yyyy HH:mm"));
        }

        /// <summary>
        /// Realiza validação antes da formatação de data
        /// </summary>
        /// <param name="dataString"></param>   
        public void FormatacaoDataValidada (string dataString)
        {

            bool sucesso = DateTime.TryParseExact(dataString, "yyyy-MM-dd HH:mm", CultureInfo.InvariantCulture, DateTimeStyles.None, out DateTime data);
            Console.WriteLine(data);

            if (sucesso)
            {
                Console.WriteLine($"Sucesso na conversão e formatação de data! Data: {data}");
            }
            else
            {
                Console.WriteLine ($"Falha na convesão de data: {dataString}");
            }
        }
    }
}