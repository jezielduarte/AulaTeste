﻿using System;
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
    public partial class FrmCadCliente : Form
    {
        public FrmCadCliente()
        {
            InitializeComponent();
        }

        private void Salvar_Click(object sender, EventArgs e)
        {
            Cliente _cliente = new Cliente();

            _cliente.RazaoSocial = TxtRazaoSocial.Text;
            _cliente.Cnpj = TxtCnpjCpf.Text;
            _cliente.Limite = Convert.ToDecimal("0" + TxtLimite.Text);
            _cliente.DadosAdicionais = TxtDadosAdicionais.Text;
            //ENTIDADE PESSOA
            _cliente.Nome = TxtNome.Text;
            _cliente.DataCadastro = DateTime.Now;
            _cliente.Natureza = NaturezaJuridica.PessoaFisica; //Natureza = OptPessoaFisica.Checked = true ? NaturezaJuridica.PessoaFisica : NaturezaJuridica.PessoaJuridica,
            _cliente.Telefones.Add(new Telefone
            {
                Contato = TxtTel_Contato1.Text,
                Numero = TxtTel_Fone1.Text
            });
            _cliente.Telefones.Add(new Telefone
            {
                Contato = TxtTel_Contato2.Text,
                Numero = TxtTel_Fone2.Text
            });
            
            _cliente.Enderecos.Add(new Endereco
            {
                Cep = TxtEnd_Cep.Text,
                _Endereco = TxtEnd_Endereco.Text,
                Numero = TxtEnd_Numero.Text,
                Complemento = TxtEnd_Complemento.Text,
                Bairro = TxtEnd_Bairro.Text,
                Cidade=CboEnd_Cidade.Text,
                Uf = CboEnd_Uf.Text
            });
            
            new ServicoCliente().Add(_cliente);

        }

        private void Fechar_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Deseja Sair do Formulário ?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                this.Close();
            }
        }

        private void Incluir_Click(object sender, EventArgs e)
        {

        }

    }
}
