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
        public int Id { get; set; }

        public int PessoaId { get; set; }

        public string Contato { get; set; }

        public string Numero { get; set; }

        public Pessoa Pessoa { get; set; }
    }
}
