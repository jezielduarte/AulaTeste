using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Dominio.Entidades
{
    public class ProdutoVariacoes
    {
        public int id { get; set; }

        public string Descricao { get; set; }

        public Cor Cor { get; set; }

        public Tamanho Tam { get; set; }

        public Produto Produto { get; set; }

        protected decimal Entradas { get; set; }

        protected decimal Saidas { get; set; }

        public decimal Estoque { get { Entradas - Saidas } }

        public void AdicionarEstoque(decimal valor)
        {
            Entradas += valor;
        }

        public void ConsumirEstoque(decimal valor)
        {
            Entradas -= valor;
        }

    }
}
