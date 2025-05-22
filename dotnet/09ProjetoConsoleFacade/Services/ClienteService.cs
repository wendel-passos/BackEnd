using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace _09ProjetoConsoleFacade.Services
{
    public class ClienteService
    {
        public void ValidarCliente(int clienteId)
        {
            Console.WriteLine($"Cliente {clienteId} validado.");
        }
    }
}