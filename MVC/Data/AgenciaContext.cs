using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using MinhaViagem_V1.Models;

namespace MinhaViagem_V1.Data
{
    public class AgenciaContext : DbContext
    {
        public AgenciaContext(DbContextOptions<AgenciaContext> options) : base(options)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
        public DbSet<Passagem> Passagens { get; set; }
        public DbSet<Destino> Destinos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Cliente>().ToTable("Cliente");
            modelBuilder.Entity<Passagem>().ToTable("Passagem");
            modelBuilder.Entity<Destino>().ToTable("Destino");
        }
    }
}
