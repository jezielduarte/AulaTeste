using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dominio.Entidades
{
    [Table("Produtos")]
    public class Produto
    {
        public Produto()
        {
            Variacoes = new List<ProdutoVariacoes>();
        }
        public int id { get; set; }
        public string Referencia { get; set; }
        public string Descricao { get; set; }
        public virtual Unidade Und { get; set; }
        public virtual Colecao Colecao { get; set; }
        public virtual Marca Marca { get; set; }
        public virtual ICollection<ProdutoVariacoes> Variacoes { get; set; }
        public decimal Estoque 
        {
            get
            {
                decimal estoque = 0;
                foreach (ProdutoVariacoes item in Variacoes)
                {
                    estoque += item.Estoque;
                }
                return estoque;
            }
        }

    }
}
