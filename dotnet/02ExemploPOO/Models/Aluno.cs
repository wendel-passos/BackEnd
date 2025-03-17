using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02ExemploPOO.Models
{
    /// <summary>
    /// Aluno herdando a Classe pessoa
    /// </summary>
    public class Aluno : Pessoa
    {
        public int Nota { get; set; }
        /// <summary>
        /// Método override da Classe Pessoa
        /// </summary>
        public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}, sou Aluno, tenho {Idade} anos e minha nota foi: {Nota}");
        }
    }
}