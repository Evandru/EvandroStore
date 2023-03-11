using EvandroStore.Models;
using Microsoft.EntityFrameworkCore;

namespace EvandroStore.Data
{
    public class Context : DbContext
    {
        public Context(DbContextOptions<Context> options) : base(options) { }
        DbSet<Usuario> Usuarios { get; set; }
        DbSet<Endereco> Enderecos { get; set; }
        DbSet<Pedido> Pedidos { get; set; }
        DbSet<DetalhePedido> DetalhesPedidos { get; set; }
        DbSet<Produto> Produtos { get; set; }
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
