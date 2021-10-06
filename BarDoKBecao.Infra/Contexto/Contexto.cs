
using BarDoKBecao.Entidades;
using BarDoKBecao.Infra.Mapping;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace BarDoKBecao.Infra.Contexto
{
    public class Contexto : DbContext
    {
        public Contexto(DbContextOptions<Contexto> op) : base(op)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Mapping();
        }

        public DbSet<Pedido> Pedido { get; set; }

        public DbSet<ItemPedido> ItemPedido { get; set; }

        public DbSet<Mesa> Mesas { get; set; }

        public DbSet<Cliente> Cliente { get; set; }

        public DbSet<Produto> Produto { get; set; }



    }
}
