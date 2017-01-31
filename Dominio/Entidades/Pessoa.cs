using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    [Table("Pessoas")]
    public class Pessoa
    {
        public Pessoa()
        {
            Enderecos = new List<Endereco>();
            Telefones = new List<Telefone>();
        }
        public int Id { get; set; }

        public string Nome { get; set; }

        public DateTime DataCadastro { get; set; }

        protected TipoPessoa Tipo { get; set; }

        public NaturezaJuridica Natureza { get; set; }

        public virtual ICollection<Telefone> Telefones { get; set; }

        public virtual ICollection<Endereco> Enderecos { get; set; }
        
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
