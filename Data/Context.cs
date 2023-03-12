using EvandroStore.Models;
using Microsoft.EntityFrameworkCore;

namespace EvandroStore.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Endereco> Enderecos { get; set; }
        public DbSet<Pedido> Pedidos { get; set; }
        public DbSet<DetalhePedido> DetalhesPedidos { get; set; }
        public DbSet<Produto> Produtos { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.Entity<Usuario>().HasKey(m => m.Id);
            builder.Entity<Endereco>().HasKey(m => m.Id);
            builder.Entity<Pedido>().HasKey(m => m.Id);
            builder.Entity<DetalhePedido>().HasKey(m => m.Id);
            builder.Entity<Produto>().HasKey(m => m.Id);
            base.OnModelCreating(builder);
        }
    }
}
