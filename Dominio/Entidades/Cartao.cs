
using System.ComponentModel.DataAnnotations.Schema;


namespace Dominio.Entidades
{
    [Table("Cartoes")]
    public class Cartao
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public TipoCartao TipoCartao { get; set; }

        public int BandeiraId { get; set; }

        public Bandeira Bandeira { get; set; }

    }
    public enum TipoCartao
    {
        Credito,
        Debito
    }
}
