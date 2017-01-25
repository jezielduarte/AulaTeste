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
            this.Consulta = new System.Windows.Forms.TabPage();
            this.GrpPesquisar = new System.Windows.Forms.GroupBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.LblCidade = new System.Windows.Forms.Label();
            this.TxtCnpjCpf = new System.Windows.Forms.TextBox();
            this.TxtNome = new System.Windows.Forms.TextBox();
            this.TxtCodigo = new System.Windows.Forms.TextBox();
            this.RdbCnpjCpf = new System.Windows.Forms.RadioButton();
            this.RdbNome = new System.Windows.Forms.RadioButton();
            this.RdbCodigo = new System.Windows.Forms.RadioButton();
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
            this.TabClientes.Location = new System.Drawing.Point(12, 28);
            this.TabClientes.Name = "TabClientes";
            this.TabClientes.SelectedIndex = 0;
            this.TabClientes.Size = new System.Drawing.Size(685, 458);
            this.TabClientes.TabIndex = 0;
            // 
            // Cadastro
            // 
            this.Cadastro.Location = new System.Drawing.Point(4, 22);
            this.Cadastro.Name = "Cadastro";
            this.Cadastro.Padding = new System.Windows.Forms.Padding(3);
            this.Cadastro.Size = new System.Drawing.Size(677, 432);
            this.Cadastro.TabIndex = 0;
            this.Cadastro.Text = "Cadastro";
            this.Cadastro.UseVisualStyleBackColor = true;
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
            this.GrpPesquisar.Controls.Add(this.comboBox1);
            this.GrpPesquisar.Controls.Add(this.LblCidade);
            this.GrpPesquisar.Controls.Add(this.TxtCnpjCpf);
            this.GrpPesquisar.Controls.Add(this.TxtNome);
            this.GrpPesquisar.Controls.Add(this.TxtCodigo);
            this.GrpPesquisar.Controls.Add(this.RdbCnpjCpf);
            this.GrpPesquisar.Controls.Add(this.RdbNome);
            this.GrpPesquisar.Controls.Add(this.RdbCodigo);
            this.GrpPesquisar.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GrpPesquisar.Location = new System.Drawing.Point(6, 6);
            this.GrpPesquisar.Name = "GrpPesquisar";
            this.GrpPesquisar.Size = new System.Drawing.Size(658, 67);
            this.GrpPesquisar.TabIndex = 2;
            this.GrpPesquisar.TabStop = false;
            this.GrpPesquisar.Text = "Pesquisar por:";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(416, 40);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(236, 21);
            this.comboBox1.TabIndex = 7;
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
            // TxtCnpjCpf
            // 
            this.TxtCnpjCpf.Location = new System.Drawing.Point(286, 40);
            this.TxtCnpjCpf.Name = "TxtCnpjCpf";
            this.TxtCnpjCpf.Size = new System.Drawing.Size(124, 21);
            this.TxtCnpjCpf.TabIndex = 5;
            // 
            // TxtNome
            // 
            this.TxtNome.Location = new System.Drawing.Point(67, 40);
            this.TxtNome.Name = "TxtNome";
            this.TxtNome.Size = new System.Drawing.Size(213, 21);
            this.TxtNome.TabIndex = 4;
            // 
            // TxtCodigo
            // 
            this.TxtCodigo.Location = new System.Drawing.Point(6, 40);
            this.TxtCodigo.Name = "TxtCodigo";
            this.TxtCodigo.Size = new System.Drawing.Size(55, 21);
            this.TxtCodigo.TabIndex = 3;
            // 
            // RdbCnpjCpf
            // 
            this.RdbCnpjCpf.AutoSize = true;
            this.RdbCnpjCpf.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbCnpjCpf.Location = new System.Drawing.Point(286, 20);
            this.RdbCnpjCpf.Name = "RdbCnpjCpf";
            this.RdbCnpjCpf.Size = new System.Drawing.Size(68, 17);
            this.RdbCnpjCpf.TabIndex = 2;
            this.RdbCnpjCpf.TabStop = true;
            this.RdbCnpjCpf.Text = "Cnpj/Cpf";
            this.RdbCnpjCpf.UseVisualStyleBackColor = true;
            // 
            // RdbNome
            // 
            this.RdbNome.AutoSize = true;
            this.RdbNome.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbNome.Location = new System.Drawing.Point(70, 20);
            this.RdbNome.Name = "RdbNome";
            this.RdbNome.Size = new System.Drawing.Size(52, 17);
            this.RdbNome.TabIndex = 1;
            this.RdbNome.TabStop = true;
            this.RdbNome.Text = "Nome";
            this.RdbNome.UseVisualStyleBackColor = true;
            // 
            // RdbCodigo
            // 
            this.RdbCodigo.AutoSize = true;
            this.RdbCodigo.Font = new System.Drawing.Font("Tahoma", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RdbCodigo.Location = new System.Drawing.Point(6, 20);
            this.RdbCodigo.Name = "RdbCodigo";
            this.RdbCodigo.Size = new System.Drawing.Size(58, 17);
            this.RdbCodigo.TabIndex = 0;
            this.RdbCodigo.TabStop = true;
            this.RdbCodigo.Text = "Código";
            this.RdbCodigo.UseVisualStyleBackColor = true;
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
            this.TbrCrud.Location = new System.Drawing.Point(0, 0);
            this.TbrCrud.Name = "TbrCrud";
            this.TbrCrud.Size = new System.Drawing.Size(709, 25);
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
            // 
            // FrmCadCliente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(709, 498);
            this.Controls.Add(this.TbrCrud);
            this.Controls.Add(this.TabClientes);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "FrmCadCliente";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cadastro de Clientes";
            this.TabClientes.ResumeLayout(false);
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
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label LblCidade;
        private System.Windows.Forms.TextBox TxtCnpjCpf;
        private System.Windows.Forms.TextBox TxtNome;
        private System.Windows.Forms.TextBox TxtCodigo;
        private System.Windows.Forms.RadioButton RdbCnpjCpf;
        private System.Windows.Forms.RadioButton RdbNome;
        private System.Windows.Forms.RadioButton RdbCodigo;
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
    }
}