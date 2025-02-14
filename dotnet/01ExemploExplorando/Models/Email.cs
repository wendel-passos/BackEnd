using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _01ExemploExplorando.Models
{
    public class Email
    {
        
        public void ReceberEmail()
        {
            //A virgula na variavel serve para permitir valores nulos
            bool? desejaReceberEmail = null;

            //Hasvalue server para identificar se a variável está null | Value é para identificar se o valor é verdadeiro
            if (desejaReceberEmail.HasValue && desejaReceberEmail.Value)
            {
                Console.WriteLine("Optou em receber e-mail");
            }
            else
            {
                Console.WriteLine("Não optou em receber e-mail");
            }
        }
    }
}