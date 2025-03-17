using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _02ExemploPOO.Models
{
    public class Diretor : Professor
    {
        public Diretor(string nome) : base(nome)
        {

        }

        public override void Apresentar()
        {
            Console.WriteLine($"Olá meu nome é {Nome}, sou Diretor, tenho {Idade} anos e meu salário é: {Salario}");
        }
    }
}