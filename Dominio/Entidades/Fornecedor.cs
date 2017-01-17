using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Fornecedor : Pessoa
    {
        public string RazaoSocial { get; set; }

        public string CPF { get; set; }

        public string CNPJ { get; set; }

        public string DadosAdicionais { get; set; }
    }
}
