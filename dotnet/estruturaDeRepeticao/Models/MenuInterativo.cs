using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace estruturaDeRepeticao.Models
{
    public class MenuInterativo
    {
        public void Montar (){

        string opcao;
        bool exibirMenu = true;

        while (exibirMenu)
        {
            Console.Clear ();
            Console.WriteLine ("Digite a sua opção");
            Console.WriteLine ("1 - Cadastro de cliente");
            Console.WriteLine ("2 - Buscar cliente");
            Console.WriteLine ("3 - Apagar cliente");
            Console.WriteLine ("4 - Encerrar");

#pragma warning disable CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.
            opcao = Console.ReadLine();
#pragma warning restore CS8600 // Conversão de literal nula ou possível valor nulo em tipo não anulável.

                switch (opcao)
                {
                case "1":
                    Console.WriteLine ("Cadastro de cliente");
                    break;
                 case "2":
                    Console.WriteLine ("Buscar cliente");
                    break;
                 case "3":
                    Console.WriteLine ("Apagar cliente");
                    break;
                 case "4":
                    Console.WriteLine ("Encerrar");
                    //Environment.Exit (0); Programa finaliza nessa linha
                    exibirMenu = false;
                    break;
                }
            }
        }
    }
}