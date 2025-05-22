using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _09ProjetoConsoleFacade.Services;

namespace _09ProjetoConsoleFacade.Facades
{
    public class PedidoFacade
    {
            private readonly ClienteService _clienteService;
            private readonly ProdutoService _produtoService;
            private readonly PedidoService _pedidoService;

            public PedidoFacade(ClienteService clienteService, ProdutoService produtoService, PedidoService pedidoService)
            {
                _clienteService = clienteService;
                _produtoService = produtoService;
                _pedidoService = pedidoService;
            }

            public void ProcessarPedido(int clienteId, int produtoId)
            {
                _clienteService.ValidarCliente(clienteId);
                _produtoService.VerificarEstoque(produtoId);
                _pedidoService.CriarPedido(clienteId, produtoId);
            }
    } 
}
