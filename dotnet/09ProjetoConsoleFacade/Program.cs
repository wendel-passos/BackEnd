using _09ProjetoConsoleFacade.Facades;
using _09ProjetoConsoleFacade.Services;

var clienteService = new ClienteService();
var produtoService = new ProdutoService();
var pedidoService = new PedidoService();

var pedidoFacade = new PedidoFacade(clienteService, produtoService, pedidoService);

Console.WriteLine("Processando pedido...");
pedidoFacade.ProcessarPedido(1, 100);
Console.WriteLine("Pedido processado com sucesso.");
Console.WriteLine("Aperte qualquer tecla para sair...");