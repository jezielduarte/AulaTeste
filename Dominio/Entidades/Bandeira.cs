
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    [Table("Bandeiras")]
    public class Bandeira
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public ICollection<Cartao> Cartoes { get; set; }



    }
}
