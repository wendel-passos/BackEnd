using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _09ProjetoConsoleFacade.Services
{
    public class PedidoService
    {
        public void CriarPedido(int clienteId, int produtoId)
        {
            Console.WriteLine($"Pedido criado para Cliente {clienteId} com Produto {produtoId}.");
        }
    }
}