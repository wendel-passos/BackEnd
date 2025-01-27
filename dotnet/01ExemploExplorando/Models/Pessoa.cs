using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01ExemploExplorando.Models
{
    public class Pessoa
    {
        public Pessoa (){}
        public Pessoa (string nome, string sobrenome, int idade)
        {
            Nome = nome;
            Sobrenome = sobrenome;
            Idade = idade;
        }

        private string _Nome;
        private string _Sobrenome;
        private int _Idade;
        public string Nome
        {
            get => _Nome;
            
            set
            {
                if (value =="")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _Nome = value;
            }
        }
        public string Sobrenome 
        { 
            get => _Sobrenome;
            set
            {
                if (value =="")
                {
                    throw new ArgumentException("O nome não pode ser vazio");
                }
                _Sobrenome = value;
            }}
        public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

       
        public int Idade 
        {
            get => _Idade;
            set
            {
                if (value <=0)
                {
                    throw new ArgumentException("Idade tem que ser maior do que 0");
                }
                _Idade = value;   
            }
        }


        public void Apresentar ()
        {
            Console.WriteLine($"Nome:{NomeCompleto} Idade: {Idade}");
        }
    }
}