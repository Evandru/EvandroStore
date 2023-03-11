namespace EvandroStore.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public Usuario Usuario { get; set; } = null!;
        public DateTime Hora_Pedido { get; set; }
        public ICollection<DetalhePedido> DetalhesPedido { get; set; } = null!;
    }
}
