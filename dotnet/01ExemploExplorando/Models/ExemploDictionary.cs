using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01ExemploExplorando.Models
{
    public class ExemploDictionary
    {
        public void DictionaryDeString ()
        {
            Dictionary<string, string> estados = new();

            estados.Add("SP", "São Paulo");
            estados.Add("BA", "Bahia");
            estados.Add("MG", "Minas Gerais");

            foreach (var item in estados)
            {
                Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            }

            Console.WriteLine($"Removendo SP");
            estados.Remove("SP");
            //estados["BA"] = "Bahia alterado";
            foreach (var item in estados)
            {
                Console.WriteLine($"Chave: {item.Key}, Valor: {item.Value}");
            }

            string chave = "BA";

            if (estados.ContainsKey(chave))
            {
                Console.WriteLine($"Chave '{chave}' já existe");
            }
            else
            {
                Console.WriteLine($"Essa chave '{chave}' não existe");
            }

        }
    }
}