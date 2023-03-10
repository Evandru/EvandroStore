namespace EvandroStore.Models
{
    public class Pedido
    {
        public int Id { get; set; }
        public Usuario Usuario { get; set; }
        public int UsuarioId { get; set; }
        public DateTime Hora_Pedido { get; set; }
        public List<DetalhePedido> DetalhesPedido { get; set; }
    }
}
