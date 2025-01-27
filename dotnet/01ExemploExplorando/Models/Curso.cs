using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01ExemploExplorando.Models
{
    public class Curso
    {
        public string Nome { get; set; }
        public List<Pessoa> Alunos { get; set; }

        public void AdicionarAluno (Pessoa aluno)
        {
            Alunos.Add(aluno);
        }

        public int ObterQuantidadeDeAlunosMatriculados ()
        {
            int quantidade = Alunos.Count;
            return quantidade; 
        }

        public bool RemoverAluno (Pessoa aluno)
        {
           return Alunos.Remove(aluno);
        }

        public void ListarAlunos ()
        {
            Console.WriteLine($"Alunos do curso de {Nome}:");
            int cont = 1;
            foreach (Pessoa aluno in Alunos)
            
            {       
                //Console.WriteLine($"N°:{cont} Aluno: {aluno.NomeCompleto} Idade:{aluno.Idade}"  );
                string texto = $"N°{cont++} | Aluno: {aluno.NomeCompleto} - Idade: {aluno.Idade}";
                Console.WriteLine(texto);
            }
        }
    }
}