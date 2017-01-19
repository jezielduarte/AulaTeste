using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Dominio.Entidades
{
    [Table("Empregados")]
    public class Empregado : Pessoa
    {
        public string Pis { get; set; }
        public string CtpsNumero { get; set; }
        public string CtpsSerie { get; set; }
        public string ContaFgts { get; set; }
        public DateTime OpcaoFgts { get; set; }
        public DateTime Admissao { get; set; }
        public decimal Salario { get; set; }
    }
}
