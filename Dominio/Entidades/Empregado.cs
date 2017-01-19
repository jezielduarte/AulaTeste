using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    public class Empregado
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
