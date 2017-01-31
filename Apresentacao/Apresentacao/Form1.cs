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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var cliConsulta = new ServicoCliente().GetAll();

            Cliente cliente = new Cliente()
            {
                Nome   = "Rouberto CLaudio",
                Cnpj = "131545642132",
                Cpf = "123145456",
                DadosAdicionais = "muitos dados",
                DataCadastro = DateTime.Now,
                Limite = 1000,
                Natureza = NaturezaJuridica.PessoaFisica,
                RazaoSocial = "tem razao",
                Tipo = TipoPessoa.Fornecedor

            };
            cliente.Telefones.Add(new Telefone()
            {
                Contato = "Mauricio matar",
                Numero = "123156465"
            });
            cliente.Telefones.Add(new Telefone()
            {
                Contato = "Mauricio matar",
                Numero = "123156465"
            });
            cliente.Telefones.Add(new Telefone()
            {
                Contato = "Mauricio matar",
                Numero = "123156465"
            });
            cliente.Enderecos.Add(new Endereco()
            {
                Bairro = "Mauricio matar",
                Numero = "123156465",
                Cep = "1231215",
                _Endereco = "teste de endereco",
                Uf = "CE",
                Cidade = "ceara",
            });

            new ServicoCliente().Add(cliente); 

        }
    }
}
