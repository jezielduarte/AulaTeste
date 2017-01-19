<<<<<<< .mineusing System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class PlanoDeConta
    {
        public int Id { get; set; }
        public int ContaContabil { get; set; } //CAMPO COM MASCARA #.###.####
        public string Descricao { get; set; }
        public int CodigoReduzido { get; set; } //CAMPO COM FORMATAÇÃO NUMÉRICA "000000"
        public Natureza Natureza { get; set; } //CAMPO PARA DEFINIR SE A CONTA É CRÉDITO OU DÉBITO ("C" OU "D")
        public Tipo Tipo { get; set; } //CAMPO PARA DEFINIR SE A CONTA É TOTALIZADORA ("T" OU "N")

    }

    public enum Natureza
    {
        C,
        D
    }

    public enum Tipo
    {
        T,
        N
    }
}
=======
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    [Table("PlanodeContas")]
    public class PlanoDeConta
    {
        public int Id { get; set; }

    }
}
>>>>>>> .theirs