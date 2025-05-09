using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

using Microsoft.EntityFrameworkCore;

namespace _07ExemploProjetoRH.Models
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options)
            : base(options)
        {
        }

        public DbSet<Funcionario> Funcionarios { get; set; }
        public DbSet<FuncionarioLog> FuncionariosLog { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<FuncionarioLog>()
                .HasKey(f => f.Id);

            modelBuilder.Entity<FuncionarioLog>()
                .HasOne<Funcionario>()                        // Um log está ligado a um funcionário
                .WithMany()                                  // Um funcionário pode ter vários logs (se quiser, use WithMany("FuncionarioLogs"))
                .HasForeignKey(f => f.FuncionarioId)         // Define a FK
                .OnDelete(DeleteBehavior.Cascade);          // Se quiser deletar os logs ao deletar o funcionário

            base.OnModelCreating(modelBuilder);
        }

    }
}
