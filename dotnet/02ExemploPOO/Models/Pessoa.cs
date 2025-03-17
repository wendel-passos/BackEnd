using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02ExemploPOO.Models
{
    public class Pessoa
    {
        public string ?Nome { get; set; }
        public int Idade { get; set; }

        /// <summary>
        /// Virtual significa que o Método apresentar pode ser override pelas classes filhas
        /// </summary>
        public virtual void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome} e tenho {Idade} anos");
        }
    }
}