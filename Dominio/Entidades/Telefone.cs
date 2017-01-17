using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Telefone
    {
        public int PessoaId { get; set; }

        public string Contato { get; set; }

        public int Numero { get; set; }

        public virtual Pessoa Pessoa { get; set; }
    }
}
