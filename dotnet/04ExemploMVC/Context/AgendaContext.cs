using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using _04ExemploMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace _04ExemploMVC.Context
{
    public class AgendaContext : DbContext
    {
        public AgendaContext(DbContextOptions<AgendaContext> options) : base(options)
        {

        }
        
        public DbSet<Contato>Contatos { get; set; }
    }
}