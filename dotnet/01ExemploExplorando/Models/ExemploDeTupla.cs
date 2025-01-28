using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01ExemploExplorando.Models
{
    public class ExemploDeTupla
    {
        public void TuplaNaVariavel()
        {
            (int Id, string Nome, string Sobremome) tupla = (1, "Wendel", "Passos");
            Console.WriteLine($"ID: {tupla.Id} Nome: {tupla.Nome} Sobrenome: {tupla.Sobremome}");
}

        public void TuplaChamandoClasse()
        {
            ValueTuple<int, string, string> outroExemploTupla = (2, "Solange", "Passos");
            Console.WriteLine($"ID: {outroExemploTupla.Item1} Nome: {outroExemploTupla.Item2} Sobrenome: {outroExemploTupla.Item3}");
        }

        public void TuplaNaVariavelDeInicializacao()
        {
            var outroExemploTuplaVar = Tuple.Create(3, "Yasmin", "Passos");
            Console.WriteLine($"ID: {outroExemploTuplaVar.Item1} Nome: {outroExemploTuplaVar.Item2} Sobrenome: {outroExemploTuplaVar.Item3}");
        }
    }
}