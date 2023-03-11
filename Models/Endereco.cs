namespace EvandroStore.Models
{
    public class Endereco
    {
        public int Id { get; set; }
        public string Logradouro { get; set; }
        public string Bairro { get; set; }
        public string Cidade { get; set; }
        public string UF { get; set; }
        public int DDD { get; set; }
        public int IdUsuario { get; set; }
        public Usuario Usuario { get; set; } = null!;
    }
}
