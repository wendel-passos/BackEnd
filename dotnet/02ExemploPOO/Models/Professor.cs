using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02ExemploPOO.Models
{
    /// <summary>
    /// Professor herda da classe Pessoa
    /// </summary>
    public class Professor : Pessoa
    {
        public Professor(string nome) : base(nome)
        {
            
        }
        public decimal Salario { get; set; }
        /// <summary>
        /// Método override da Classe Pessoa
        /// </summary>
        public  override  void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}, sou Professor, tenho {Idade} anos e meu salário é: {Salario}");
        }
    }
}