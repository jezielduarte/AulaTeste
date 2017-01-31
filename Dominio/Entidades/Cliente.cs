using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    [Table("Clientes")]
    public class Cliente: Pessoa
    {
        public Cliente()
        {
            Tipo = TipoPessoa.Cliente;
        }
        public string RazaoSocial { get; set; }
        public string Cnpj { get; set; }
        public string Cpf { get; set; }
        public decimal Limite { get; set; }
        public string DadosAdicionais { get; set; }
    }
}
