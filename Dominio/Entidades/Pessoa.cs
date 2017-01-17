using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Pessoa
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataCadastro { get; set; }

        public TipoPessoa Tipo { get; set; }

        public NaturezaJuridica Natureza { get; set; }

        public IEnumerable<Telefone> Telefones { get; set; }
        
    }

    public enum TipoPessoa
    {
        Cliente,
        Fornecedor,
        Empregado
    }

    public enum NaturezaJuridica
    {
        PessoaFisica,
        PessoaJuridica,
    }
}
