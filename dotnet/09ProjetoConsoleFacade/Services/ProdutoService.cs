using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _09ProjetoConsoleFacade.Services
{
    public class ProdutoService
    {
        public void VerificarEstoque(int produtoId)
        {
            Console.WriteLine($"Estoque do produto {produtoId} verificado.");
        }
    }
}