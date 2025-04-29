using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _05ExemploMvcPratico.Models;
using Microsoft.EntityFrameworkCore;

namespace _05ExemploMvcPratico.Context
{
    public class TarefaContext : DbContext
    {
        public TarefaContext(DbContextOptions<TarefaContext> options) : base(options)
        {

        }
        public DbSet<Tarefa>Tarefas { get; set; }
    }
}
