using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    [Table("Pessoas")]
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
