namespace Apresentacao
{
    partial class FrmCadCliente
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmCadCliente));
            this.TabClientes = new System.Windows.Forms.TabControl();
            this.Cadastro = new System.Windows.Forms.TabPage();
            this.label17 = new System.Windows.Forms.Label();
            this.TxtDadosAdicionais = new System.Windows.Forms.TextBox();
            this.label16 = new System.Windows.Forms.Label();
            this.TxtLimite = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.TxtTel_Contato2 = new System.Windows.Forms.TextBox();
            this.TxtTel_Fone2 = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.TxtTel_Fone1 = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.TxtTel_Contato1 = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.TxtEnd_Cep = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.TxtEnd_Bairro = new System.Windows.Forms.TextBox();
            this.CboEnd_Cidade = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.CboEnd_Uf = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.TxtEnd_Complemento = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.TxtEnd_Numero = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.TxtEnd_Endereco = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.TxtCnpjCpf = new System.Windows.Forms.TextBox();
            this.GrpPessoa = new System.Windows.Forms.GroupBox();
            this.OptPessoaJuridica = new System.Windows.Forms.RadioButton();
            this.OptPessoaFisica = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.TxtRazaoSocial = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.Consulta = new System.Windows.Forms.TabPage();
            this.GrpPesquisar = new System.Windows.Forms.GroupBox();
            this.LblCnpjCpf = new System.Windows.Forms.Label();
            this.LblNome = new System.Windows.Forms.Label();
            this.LblCodigo = new System.Windows.Forms.Label();
            this.CboCidadePesquisa = new System.Windows.Forms.ComboBox();
            this.LblCidade = new System.Windows.Forms.Label();
            this.TxtCnpjCpfPesquisa = new System.Windows.Forms.TextBox();
            this.TxtNomePesquisa = new System.Windows.Forms.TextBox();
            this.TxtCodigoPesquisa = new System.Windows.Forms.TextBox();
            this.LblTotaliza = new System.Windows.Forms.Label();
            this.DtgClientes = new System.Windows.Forms.DataGridView();
            this.Codigo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nome = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cnpj = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cpf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Uf = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cidade = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Bairro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefone = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DataCadastro = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TbrCrud = new System.Windows.Forms.ToolStrip();
            this.Incluir = new System.Windows.Forms.ToolStripButton();
            this.Alterar = new System.Windows.Forms.ToolStripButton();
            this.Excluir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.Salvar = new System.Windows.Forms.ToolStripButton();
            this.Desfazer = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.Consultar = new System.Windows.Forms.ToolStripButton();
            this.Imprimir = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.Fechar = new System.Windows.Forms.ToolStripButton();
            this.TabClientes.SuspendLayout();
            this.Cadastro.SuspendLayout();
            this.GrpPessoa.SuspendLayout();
            this.Consulta.SuspendLayout();
            this.GrpPesquisar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgClientes)).BeginInit();
            this.TbrCrud.SuspendLayout();
            this.SuspendLayout();
            // 
            // TabClientes
            // 
            this.TabClientes.Controls.Add(this.Cadastro);
            this.TabClientes.Controls.Add(this.Consulta);
            this.TabClientes.Location = new System.Drawing.Point(12, 12);
            this.TabClientes.Name = "TabClientes";
            this.TabClientes.SelectedIndex = 0;
            this.TabClientes.Size = new System.Drawing.Size(685, 458);
            this.TabClientes.TabIndex = 0;
            // 
            // Cadastro
            // 
            this.Cadastro.Controls.Add(this.label17);
            this.Cadastro.Controls.Add(this.TxtDadosAdicionais);
            this.Cadastro.Controls.Add(this.label16);
            this.Cadastro.Controls.Add(this.TxtLimite);
            this.Cadastro.Controls.Add(this.label15);
            this.Cadastro.Controls.Add(this.TxtTel_Contato2);
            this.Cadastro.Controls.Add(this.TxtTel_Fone2);
            this.Cadastro.Controls.Add(this.label14);
            this.Cadastro.Controls.Add(this.label13);
            this.Cadastro.Controls.Add(this.TxtTel_Fone1);
            this.Cadastro.Controls.Add(this.label12);
            this.Cadastro.Controls.Add(this.TxtTel_Contato1);
            this.Cadastro.Controls.Add(this.label11);
            this.Cadastro.Controls.Add(this.TxtEnd_Cep);
            this.Cadastro.Controls.Add(this.label10);
            this.Cadastro.Controls.Add(this.TxtEnd_Bairro);
            this.Cadastro.Controls.Add(this.CboEnd_Cidade);
            this.Cadastro.Controls.Add(this.label9);
            this.Cadastro.Controls.Add(this.CboEnd_Uf);
            this.Cadastro.Controls.Add(this.label8);
            this.Cadastro.Controls.Add(this.label7);
            this.Cadastro.Controls.Add(this.TxtEnd_Complemento);
            this.Cadastro.Controls.Add(this.label6);
            this.Cadastro.Controls.Add(this.TxtEnd_Numero);
            this.Cadastro.Controls.Add(this.label5);
            this.Cadastro.Controls.Add(this.TxtEnd_Endereco);
            this.Cadastro.Controls.Add(this.label4);
            this.Cadastro.Controls.Add(this.TxtCnpjCpf);
            this.Cadastro.Controls.Add(this.GrpPessoa);
            this.Cadastro.Controls.Add(this.label3);
            this.Cadastro.Controls.Add(this.TxtRazaoSocial);
            this.Cadastro.Controls.Add(this.label2);
            this.Cadastro.Controls.Add(this.label1);
            this.Cadastro.Controls.Add(this.TxtNome);
            this.Cadastro.Controls.Add(this.TxtCodigo);
            this.Cadastro.Location = new System.Drawing.Point(4, 22);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Padding = new System.Windows.Forms.Padding(3);
            this.Cadastro.Size = new System.Drawing.Size(677, 432);
            this.Cadastro.TabIndex = 0;
            this.Cadastro.Text = "Cadastro";
            this.Cadastro.UseVisualStyleBackColor = true;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 236);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(89, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Dados Adicionais";
            // 
            // TxtDadosAdicionais
            // 
            this.TxtDadosAdicionais.Location = new System.Drawing.Point(22, 252);
            this.TxtDadosAdicionais.Multiline = true;
            this.TxtDadosAdicionais.Name = "TxtDadosAdicionais";
            this.TxtDadosAdicionais.Size = new System.Drawing.Size(636, 160);
            this.TxtDadosAdicionais.TabIndex = 36;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(566, 189);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(34, 13);
            this.label16.TabIndex = 35;
            this.label16.Text = "Limite";
            // 
            // TxtLimite
            // 
            this.TxtLimite.Location = new System.Drawing.Point(566, 205);
            this.TxtLimite.Name = "TxtLimite";
            this.TxtLimite.Size = new System.Drawing.Size(92, 20);
            this.TxtLimite.TabIndex = 34;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(293, 189);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(44, 13);
            this.label15.TabIndex = 33;
            this.label15.Text = "Contato";
            // 
            // TxtTel_Contato2
            // 
            this.TxtTel_Contato2.Location = new System.Drawing.Point(293, 205);
            this.TxtTel_Contato2.Name = "TxtTel_Contato2";
            this.TxtTel_Contato2.Size = new System.Drawing.Size(190, 20);
            this.TxtTel_Contato2.TabIndex = 32;
            // 
            // TxtTel_Fone2
            // 
            this.TxtTel_Fone2.Location = new System.Drawing.Point(489, 205);
            this.TxtTel_Fone2.Name = "TxtTel_Fone2";
            this.TxtTel_Fone2.Size = new System.Drawing.Size(71, 20);
            this.TxtTel_Fone2.TabIndex = 31;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(486, 189);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(31, 13);
            this.label14.TabIndex = 30;
            this.label14.Text = "Fone";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(216, 189);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(31, 13);
            this.label13.TabIndex = 28;
            this.label13.Text = "Fone";
            // 
            // TxtTel_Fone1
            // 
            this.TxtTel_Fone1.Location = new System.Drawing.Point(216, 205);
            this.TxtTel_Fone1.Name = "TxtTel_Fone1";
            this.TxtTel_Fone1.Size = new System.Drawing.Size(71, 20);
            this.TxtTel_Fone1.TabIndex = 27;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(22, 189);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(44, 13);
            this.label12.TabIndex = 26;
            this.label12.Text = "Contato";
            // 
            // TxtTel_Contato1
            // 
            this.TxtTel_Contato1.Location = new System.Drawing.Point(22, 205);
            this.TxtTel_Contato1.Name = "TxtTel_Contato1";
            this.TxtTel_Contato1.Size = new System.Drawing.Size(190, 20);
            this.TxtTel_Contato1.TabIndex = 25;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(22, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(26, 13);
            this.label11.TabIndex = 24;
            this.label11.Text = "Cep";
            // 
            // TxtEnd_Cep
            // 
            this.TxtEnd_Cep.Location = new System.Drawing.Point(22, 111);
            this.TxtEnd_Cep.Name = "TxtEnd_Cep";
            this.TxtEnd_Cep.Size = new System.Drawing.Size(71, 20);
            this.TxtEnd_Cep.TabIndex = 23;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(468, 143);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(34, 13);
            this.label10.TabIndex = 22;
            this.label10.Text = "Bairro";
            // 
            // TxtEnd_Bairro
            // 
            this.TxtEnd_Bairro.Location = new System.Drawing.Point(468, 159);
            this.TxtEnd_Bairro.Name = "TxtEnd_Bairro";
            this.TxtEnd_Bairro.Size = new System.Drawing.Size(190, 20);
            this.TxtEnd_Bairro.TabIndex = 21;
            // 
            // CboEnd_Cidade
            // 
            this.CboEnd_Cidade.FormattingEnabled = true;
            this.CboEnd_Cidade.Location = new System.Drawing.Point(268, 159);
            this.CboEnd_Cidade.Name = "CboEnd_Cidade";
            this.CboEnd_Cidade.Size = new System.Drawing.Size(194, 21);
            this.CboEnd_Cidade.TabIndex = 20;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(268, 143);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(40, 13);
            this.label9.TabIndex = 19;
            this.label9.Text = "Cidade";
            // 
            // CboEnd_Uf
            // 
            this.CboEnd_Uf.FormattingEnabled = true;
            this.CboEnd_Uf.Location = new System.Drawing.Point(219, 159);
            this.CboEnd_Uf.Name = "CboEnd_Uf";
            this.CboEnd_Uf.Size = new System.Drawing.Size(40, 21);
            this.CboEnd_Uf.TabIndex = 18;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(219, 143);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(18, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Uf";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 143);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 15;
            this.label7.Text = "Complemento";
            // 
            // TxtEnd_Complemento
            // 
            this.TxtEnd_Complemento.Location = new System.Drawing.Point(22, 159);
            this.TxtEnd_Complemento.Name = "TxtEnd_Complemento";
            this.TxtEnd_Complemento.Size = new System.Drawing.Size(190, 20);
            this.TxtEnd_Complemento.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(602, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(44, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Número";
            // 
            // TxtEnd_Numero
            // 
            this.TxtEnd_Numero.Location = new System.Drawing.Point(602, 111);
            this.TxtEnd_Numero.Name = "TxtEnd_Numero";
            this.TxtEnd_Numero.Size = new System.Drawing.Size(56, 20);
            this.TxtEnd_Numero.TabIndex = 12;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(96, 95);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 13);
            this.label5.TabIndex = 11;
            this.label5.Text = "Endereço";
            // 
            // TxtEnd_Endereco
            // 
            this.TxtEnd_Endereco.Location = new System.Drawing.Point(99, 111);
            this.TxtEnd_Endereco.Name = "TxtEnd_Endereco";
            this.TxtEnd_Endereco.Size = new System.Drawing.Size(497, 20);
            this.TxtEnd_Endereco.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(494, 51);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(55, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Cnpj / Cpf";
            // 
            // TxtCnpjCpf
            // 
            this.TxtCnpjCpf.Location = new System.Drawing.Point(497, 67);
            this.TxtCnpjCpf.Name = "TxtCnpjCpf";
            this.TxtCnpjCpf.Size = new System.Drawing.Size(161, 20);
            this.TxtCnpjCpf.TabIndex = 8;
            // 
            // GrpPessoa
            // 
            this.GrpPessoa.Controls.Add(this.OptPessoaJuridica);
            this.GrpPessoa.Controls.Add(this.OptPessoaFisica);
            this.GrpPessoa.Location = new System.Drawing.Point(497, 8);
            this.GrpPessoa.Name = "GrpPessoa";
            this.GrpPessoa.Size = new System.Drawing.Size(161, 40);
            this.GrpPessoa.TabIndex = 7;
            this.GrpPessoa.TabStop = false;
            this.GrpPessoa.Text = "Natureza";
            // 
            // OptPessoaJuridica
            // 
            this.OptPessoaJuridica.AutoSize = true;
            this.OptPessoaJuridica.Location = new System.Drawing.Point(81, 16);
            this.OptPessoaJuridica.Name = "OptPessoaJuridica";
            this.OptPessoaJuridica.Size = new System.Drawing.Size(63, 17);
            this.OptPessoaJuridica.TabIndex = 8;
            this.OptPessoaJuridica.TabStop = true;
            this.OptPessoaJuridica.Text = "Jurídica";
            this.OptPessoaJuridica.UseVisualStyleBackColor = true;
            // 
            // OptPessoaFisica
            // 
            this.OptPessoaFisica.AutoSize = true;
            this.OptPessoaFisica.Location = new System.Drawing.Point(6, 16);
            this.OptPessoaFisica.Name = "OptPessoaFisica";
            this.OptPessoaFisica.Size = new System.Drawing.Size(54, 17);
            this.OptPessoaFisica.TabIndex = 7;
            this.OptPessoaFisica.TabStop = true;
            this.OptPessoaFisica.Text = "Física";
            this.OptPessoaFisica.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(70, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Razão Social";
            // 
            // TxtRazaoSocial
            // 
            this.TxtRazaoSocial.Location = new System.Drawing.Point(22, 67);
            this.TxtRazaoSocial.Name = "TxtRazaoSocial";
            this.TxtRazaoSocial.Size = new System.Drawing.Size(469, 20);
            this.TxtRazaoSocial.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(68, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Nome";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Código";
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(71, 24);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(420, 20);
            this.TxtNome.TabIndex = 1;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(22, 24);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(43, 20);
            this.TxtCodigo.TabIndex = 0;
            // 
            // Consulta
            // 
            this.Consulta.Controls.Add(this.GrpPesquisar);
            this.Consulta.Controls.Add(this.LblTotaliza);
            this.Consulta.Controls.Add(this.DtgClientes);
            this.Consulta.Location = new System.Drawing.Point(4, 22);
            this.Consulta.Name = "Consulta";
            this.Consulta.Padding = new System.Windows.Forms.Padding(3);
            this.Consulta.Size = new System.Drawing.Size(677, 432);
            this.Consulta.TabIndex = 1;
            this.Consulta.Text = "Consulta";
            this.Consulta.UseVisualStyleBackColor = true;
            // 
            // GrpPesquisar
            // 
            this.GrpPesquisar.Controls.Add(this.LblCnpjCpf);
            this.GrpPesquisar.Controls.Add(this.LblNome);
            this.GrpPesquisar.Controls.Add(this.LblCodigo);
            this.GrpPesquisar.Controls.Add(this.CboCidadePesquisa);
            this.GrpPesquisar.Controls.Add(this.LblCidade);
            this.GrpPesquisar.Controls.Add(this.TxtCnpjCpfPesquisa);
            this.GrpPesquisar.Controls.Add(this.TxtNomePesquisa);
            this.GrpPesquisar.Controls.Add(this.TxtCodigoPesquisa);
            this.GrpPesquisar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpPesquisar.Location = new System.Drawing.Point(6, 6);
            this.GrpPesquisar.Name = "GrpPesquisar";
            this.GrpPesquisar.Size = new System.Drawing.Size(658, 67);
            this.GrpPesquisar.TabIndex = 2;
            this.GrpPesquisar.TabStop = false;
            this.GrpPesquisar.Text = "Pesquisar por:";
            // 
            // LblCnpjCpf
            // 
            this.LblCnpjCpf.AutoSize = true;
            this.LblCnpjCpf.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCnpjCpf.Location = new System.Drawing.Point(286, 24);
            this.LblCnpjCpf.Name = "LblCnpjCpf";
            this.LblCnpjCpf.Size = new System.Drawing.Size(56, 13);
            this.LblCnpjCpf.TabIndex = 10;
            this.LblCnpjCpf.Text = "Cnpj / Cpf";
            // 
            // LblNome
            // 
            this.LblNome.AutoSize = true;
            this.LblNome.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblNome.Location = new System.Drawing.Point(64, 24);
            this.LblNome.Name = "LblNome";
            this.LblNome.Size = new System.Drawing.Size(34, 13);
            this.LblNome.TabIndex = 9;
            this.LblNome.Text = "Nome";
            // 
            // LblCodigo
            // 
            this.LblCodigo.AutoSize = true;
            this.LblCodigo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCodigo.Location = new System.Drawing.Point(6, 24);
            this.LblCodigo.Name = "LblCodigo";
            this.LblCodigo.Size = new System.Drawing.Size(40, 13);
            this.LblCodigo.TabIndex = 8;
            this.LblCodigo.Text = "Código";
            // 
            // CboCidadePesquisa
            // 
            this.CboCidadePesquisa.FormattingEnabled = true;
            this.CboCidadePesquisa.Location = new System.Drawing.Point(416, 40);
            this.CboCidadePesquisa.Name = "CboCidadePesquisa";
            this.CboCidadePesquisa.Size = new System.Drawing.Size(236, 21);
            this.CboCidadePesquisa.TabIndex = 7;
            // 
            // LblCidade
            // 
            this.LblCidade.AutoSize = true;
            this.LblCidade.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblCidade.Location = new System.Drawing.Point(413, 21);
            this.LblCidade.Name = "LblCidade";
            this.LblCidade.Size = new System.Drawing.Size(40, 13);
            this.LblCidade.TabIndex = 6;
            this.LblCidade.Text = "Cidade";
            // 
            // TxtCnpjCpfPesquisa
            // 
            this.TxtCnpjCpfPesquisa.Location = new System.Drawing.Point(286, 40);
            this.TxtCnpjCpfPesquisa.Name = "TxtCnpjCpfPesquisa";
            this.TxtCnpjCpfPesquisa.Size = new System.Drawing.Size(124, 21);
            this.TxtCnpjCpfPesquisa.TabIndex = 5;
            // 
            // TxtNomePesquisa
            // 
            this.TxtNomePesquisa.Location = new System.Drawing.Point(67, 40);
            this.TxtNomePesquisa.Name = "TxtNomePesquisa";
            this.TxtNomePesquisa.Size = new System.Drawing.Size(213, 21);
            this.TxtNomePesquisa.TabIndex = 4;
            // 
            // TxtCodigoPesquisa
            // 
            this.TxtCodigoPesquisa.Location = new System.Drawing.Point(6, 40);
            this.TxtCodigoPesquisa.Name = "TxtCodigoPesquisa";
            this.TxtCodigoPesquisa.Size = new System.Drawing.Size(55, 21);
            this.TxtCodigoPesquisa.TabIndex = 3;
            // 
            // LblTotaliza
            // 
            this.LblTotaliza.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LblTotaliza.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTotaliza.Location = new System.Drawing.Point(6, 411);
            this.LblTotaliza.Name = "LblTotaliza";
            this.LblTotaliza.Size = new System.Drawing.Size(658, 18);
            this.LblTotaliza.TabIndex = 1;
            this.LblTotaliza.Text = " (999999) Cliente(s) Cadastrado(s).";
            // 
            // DtgClientes
            // 
            this.DtgClientes.BackgroundColor = System.Drawing.SystemColors.Info;
            this.DtgClientes.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DtgClientes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DtgClientes.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Codigo,
            this.Nome,
            this.Cnpj,
            this.Cpf,
            this.Uf,
            this.Cidade,
            this.Bairro,
            this.Telefone,
            this.EMail,
            this.DataCadastro});
            this.DtgClientes.Location = new System.Drawing.Point(6, 79);
            this.DtgClientes.Name = "DtgClientes";
            this.DtgClientes.Size = new System.Drawing.Size(658, 331);
            this.DtgClientes.TabIndex = 0;
            // 
            // Codigo
            // 
            this.Codigo.HeaderText = "Código";
            this.Codigo.Name = "Codigo";
            this.Codigo.Width = 50;
            // 
            // Nome
            // 
            this.Nome.HeaderText = "Nome";
            this.Nome.Name = "Nome";
            this.Nome.Width = 150;
            // 
            // Cnpj
            // 
            this.Cnpj.HeaderText = "Cnpj";
            this.Cnpj.Name = "Cnpj";
            this.Cnpj.Width = 80;
            // 
            // Cpf
            // 
            this.Cpf.HeaderText = "Cpf";
            this.Cpf.Name = "Cpf";
            this.Cpf.Width = 80;
            // 
            // Uf
            // 
            this.Uf.HeaderText = "Uf";
            this.Uf.Name = "Uf";
            this.Uf.Width = 30;
            // 
            // Cidade
            // 
            this.Cidade.HeaderText = "Cidade";
            this.Cidade.Name = "Cidade";
            this.Cidade.Width = 70;
            // 
            // Bairro
            // 
            this.Bairro.HeaderText = "Bairro";
            this.Bairro.Name = "Bairro";
            this.Bairro.Width = 70;
            // 
            // Telefone
            // 
            this.Telefone.HeaderText = "Telefone";
            this.Telefone.Name = "Telefone";
            this.Telefone.Width = 70;
            // 
            // EMail
            // 
            this.EMail.HeaderText = "E-Mail";
            this.EMail.Name = "EMail";
            this.EMail.Width = 70;
            // 
            // DataCadastro
            // 
            this.DataCadastro.HeaderText = "Cadastro";
            this.DataCadastro.Name = "DataCadastro";
            this.DataCadastro.Width = 70;
            // 
            // TbrCrud
            // 
            this.TbrCrud.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.TbrCrud.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.TbrCrud.Dock = System.Windows.Forms.DockStyle.None;
            this.TbrCrud.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.TbrCrud.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.Incluir,
            this.Alterar,
            this.Excluir,
            this.toolStripSeparator2,
            this.Salvar,
            this.Desfazer,
            this.toolStripSeparator1,
            this.Consultar,
            this.Imprimir,
            this.toolStripSeparator3,
            this.Fechar});
            this.TbrCrud.Location = new System.Drawing.Point(452, 0);
            this.TbrCrud.Name = "TbrCrud";
            this.TbrCrud.Size = new System.Drawing.Size(245, 25);
            this.TbrCrud.TabIndex = 1;
            // 
            // Incluir
            // 
            this.Incluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Incluir.Image = ((System.Drawing.Image)(resources.GetObject("Incluir.Image")));
            this.Incluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Incluir.Name = "Incluir";
            this.Incluir.Size = new System.Drawing.Size(23, 22);
            this.Incluir.Text = "Incluir";
            // 
            // Alterar
            // 
            this.Alterar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Alterar.Image = ((System.Drawing.Image)(resources.GetObject("Alterar.Image")));
            this.Alterar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Alterar.Name = "Alterar";
            this.Alterar.Size = new System.Drawing.Size(23, 22);
            this.Alterar.Text = "Alterar";
            // 
            // Excluir
            // 
            this.Excluir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Excluir.Image = ((System.Drawing.Image)(resources.GetObject("Excluir.Image")));
            this.Excluir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Excluir.Name = "Excluir";
            this.Excluir.Size = new System.Drawing.Size(23, 22);
            this.Excluir.Text = "Excluir";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 25);
            // 
            // Salvar
            // 
            this.Salvar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Salvar.Image = ((System.Drawing.Image)(resources.GetObject("Salvar.Image")));
            this.Salvar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Salvar.Name = "Salvar";
            this.Salvar.Size = new System.Drawing.Size(23, 22);
            this.Salvar.Text = "Salvar";
            this.Salvar.Click += new System.EventHandler(this.Salvar_Click);
            // 
            // Desfazer
            // 
            this.Desfazer.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Desfazer.Image = ((System.Drawing.Image)(resources.GetObject("Desfazer.Image")));
            this.Desfazer.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Desfazer.Name = "Desfazer";
            this.Desfazer.Size = new System.Drawing.Size(23, 22);
            this.Desfazer.Text = "Desfazer";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
            // 
            // Consultar
            // 
            this.Consultar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Consultar.Image = ((System.Drawing.Image)(resources.GetObject("Consultar.Image")));
            this.Consultar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Consultar.Name = "Consultar";
            this.Consultar.Size = new System.Drawing.Size(23, 22);
            this.Consultar.Text = "Consultar";
            // 
            // Imprimir
            // 
            this.Imprimir.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Imprimir.Image = ((System.Drawing.Image)(resources.GetObject("Imprimir.Image")));
            this.Imprimir.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Imprimir.Name = "Imprimir";
            this.Imprimir.Size = new System.Drawing.Size(23, 22);
            this.Imprimir.Text = "Imprimir";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 25);
            // 
            // Fechar
            // 
            this.Fechar.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.Fechar.Image = ((System.Drawing.Image)(resources.GetObject("Fechar.Image")));
            this.Fechar.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.Fechar.Name = "Fechar";
            this.Fechar.Size = new System.Drawing.Size(23, 22);
            this.Fechar.Text = "Fechar";
            this.Fechar.Click += new System.EventHandler(this.Fechar_Click);
            // 
            // FrmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 480);
            this.Controls.Add(this.TbrCrud);
            this.Controls.Add(this.TabClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.TabClientes.ResumeLayout(false);
            this.Cadastro.ResumeLayout(false);
            this.Cadastro.PerformLayout();
            this.GrpPessoa.ResumeLayout(false);
            this.GrpPessoa.PerformLayout();
            this.Consulta.ResumeLayout(false);
            this.GrpPesquisar.ResumeLayout(false);
            this.GrpPesquisar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DtgClientes)).EndInit();
            this.TbrCrud.ResumeLayout(false);
            this.TbrCrud.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TabControl TabClientes;
        private System.Windows.Forms.TabPage Cadastro;
        private System.Windows.Forms.TabPage Consulta;
        private System.Windows.Forms.ToolStrip TbrCrud;
        private System.Windows.Forms.ToolStripButton Incluir;
        private System.Windows.Forms.ToolStripButton Alterar;
        private System.Windows.Forms.ToolStripButton Excluir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton Salvar;
        private System.Windows.Forms.ToolStripButton Desfazer;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripButton Consultar;
        private System.Windows.Forms.ToolStripButton Imprimir;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton Fechar;
        private System.Windows.Forms.GroupBox GrpPesquisar;
        private System.Windows.Forms.Label LblTotaliza;
        private System.Windows.Forms.DataGridView DtgClientes;
        private System.Windows.Forms.ComboBox CboCidadePesquisa;
        private System.Windows.Forms.Label LblCidade;
        private System.Windows.Forms.TextBox TxtCnpjCpfPesquisa;
        private System.Windows.Forms.TextBox TxtNomePesquisa;
        private System.Windows.Forms.TextBox TxtCodigoPesquisa;
        private System.Windows.Forms.DataGridViewTextBoxColumn Codigo;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nome;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cnpj;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cpf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Uf;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cidade;
        private System.Windows.Forms.DataGridViewTextBoxColumn Bairro;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefone;
        private System.Windows.Forms.DataGridViewTextBoxColumn EMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn DataCadastro;
        private System.Windows.Forms.Label LblCnpjCpf;
        private System.Windows.Forms.Label LblNome;
        private System.Windows.Forms.Label LblCodigo;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox TxtRazaoSocial;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TxtCnpjCpf;
        private System.Windows.Forms.GroupBox GrpPessoa;
        private System.Windows.Forms.RadioButton OptPessoaJuridica;
        private System.Windows.Forms.RadioButton OptPessoaFisica;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox TxtEnd_Endereco;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox TxtEnd_Complemento;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox TxtEnd_Numero;
        private System.Windows.Forms.ComboBox CboEnd_Cidade;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox CboEnd_Uf;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox TxtEnd_Cep;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TxtEnd_Bairro;
        private System.Windows.Forms.TextBox TxtTel_Fone2;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TxtTel_Fone1;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox TxtTel_Contato1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TxtTel_Contato2;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox TxtDadosAdicionais;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox TxtLimite;
    }
}