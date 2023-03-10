namespace EvandroStore.Models
{
    public class DetalhePedido
    {
        public int Id { get; set; }
        public Produto Produto { get; set; }
        public int ProdutoId { get; set; }
        public int Quantidade { get; set; }
        public Pedido Pedido { get; set; }
        public int PedidoId { get; set; }
    }
}
