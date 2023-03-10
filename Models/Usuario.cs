namespace EvandroStore.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Senha { get; set; }
        public string CEP { get; set; }
        public decimal Saldo { get; set; }
        public Endereco Endereco { get; set; }
        public int EnderecoId { get; set; }
        public Pedido Pedidos { get; set; }
    }
}
