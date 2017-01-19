using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio.Entidades;
using Servicos;

namespace Apresentacao
{
    public partial class Testar : Form
    {
        public Testar()
        {
            InitializeComponent();
        }

        private void btnTestar_Click(object sender, EventArgs e)
        {
            Fornecedor fornecedor = new Fornecedor();
            fornecedor.Nome = "CIRO GOMES";
            fornecedor.CNPJ = "124562214254";
            fornecedor.RazaoSocial = "CIRO GOMES FALADOR";
            fornecedor.Tipo = TipoPessoa.Fornecedor;
            fornecedor.DataCadastro = DateTime.Now;
            fornecedor.Natureza = NaturezaJuridica.PessoaJuridica;

            //Criando Lista de Telefones
            List<Telefone> telefones = new List<Telefone>();
            telefones.Add(new Telefone()
            {
                Numero = "85996523548",
                Contato = "CIRO"
            });
            fornecedor.Telefones = telefones;

            new ServicoFornecedor().Add(fornecedor);

        }
    }
}
