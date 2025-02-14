using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01ExemploExplorando.Models
{
    public class TiposAnonimos
    {
        public void ExemplosAnonimo()
        {
            var anonimo = new { Nome = "Teste", Sobrenome = "Teste", Idade = 26 };
            Console.WriteLine($"Nome: {anonimo.Nome} Sobrenome: {anonimo.Sobrenome}, Idade: {anonimo.Idade}");
        }
    }
}