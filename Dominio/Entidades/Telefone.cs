
namespace Dominio.Entidades
{
    public class Telefone
    {
        public int Id { get; set; }

        public int PessoaId { get; set; }

        public string Contato { get; set; }

        public string Numero { get; set; }

        public Pessoa Pessoa { get; set; }
    }
}
