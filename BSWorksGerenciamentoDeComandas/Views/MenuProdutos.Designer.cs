namespace BSWorksGerenciamentoDeComandas.Views
{
    partial class MenuProdutos
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
            this.btnRemover = new System.Windows.Forms.Button();
            this.grbRemover = new System.Windows.Forms.GroupBox();
            this.lblRemover = new System.Windows.Forms.Label();
            this.btnCadastrar = new System.Windows.Forms.Button();
            this.grbCadastrar = new System.Windows.Forms.GroupBox();
            this.lblIdCategoriaCad = new System.Windows.Forms.Label();
            this.txbPrecoCad = new System.Windows.Forms.TextBox();
            this.txbIdCadastroCad = new System.Windows.Forms.TextBox();
            this.txbNomeCad = new System.Windows.Forms.TextBox();
            this.lblId_RespCadastroCad = new System.Windows.Forms.Label();
            this.lblPrecoCad = new System.Windows.Forms.Label();
            this.lblNomeCad = new System.Windows.Forms.Label();
            this.dgvProdutos = new System.Windows.Forms.DataGridView();
            this.btnSair = new System.Windows.Forms.Button();
            this.lblInformacao = new System.Windows.Forms.Label();
            this.lblTitulo = new System.Windows.Forms.Label();
            this.btnEditar = new System.Windows.Forms.Button();
            this.grbEditar = new System.Windows.Forms.GroupBox();
            this.txbPrecoEdi = new System.Windows.Forms.TextBox();
            this.txbNomeEdi = new System.Windows.Forms.TextBox();
            this.lblIdCategoriaEdi = new System.Windows.Forms.Label();
            this.lblPrecoEdi = new System.Windows.Forms.Label();
            this.lblNomeEdi = new System.Windows.Forms.Label();
            this.cmbIdCategoriaEdi = new System.Windows.Forms.ComboBox();
            this.cmbIdCategoriaCad = new System.Windows.Forms.ComboBox();
            this.grbRemover.SuspendLayout();
            this.grbCadastrar.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).BeginInit();
            this.grbEditar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnRemover
            // 
            this.btnRemover.BackColor = System.Drawing.Color.Firebrick;
            this.btnRemover.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRemover.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRemover.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.btnRemover.Location = new System.Drawing.Point(334, 19);
            this.btnRemover.Name = "btnRemover";
            this.btnRemover.Size = new System.Drawing.Size(84, 31);
            this.btnRemover.TabIndex = 1;
            this.btnRemover.Text = "Remover";
            this.btnRemover.UseVisualStyleBackColor = false;
            this.btnRemover.Click += new System.EventHandler(this.btnRemover_Click);
            // 
            // grbRemover
            // 
            this.grbRemover.Controls.Add(this.btnRemover);
            this.grbRemover.Controls.Add(this.lblRemover);
            this.grbRemover.Enabled = false;
            this.grbRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbRemover.Location = new System.Drawing.Point(147, 437);
            this.grbRemover.Name = "grbRemover";
            this.grbRemover.Size = new System.Drawing.Size(424, 59);
            this.grbRemover.TabIndex = 16;
            this.grbRemover.TabStop = false;
            this.grbRemover.Text = "Remover:";
            // 
            // lblRemover
            // 
            this.lblRemover.AutoSize = true;
            this.lblRemover.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRemover.ForeColor = System.Drawing.Color.Firebrick;
            this.lblRemover.Location = new System.Drawing.Point(6, 27);
            this.lblRemover.Name = "lblRemover";
            this.lblRemover.Size = new System.Drawing.Size(134, 16);
            this.lblRemover.TabIndex = 0;
            this.lblRemover.Text = "ID - Nome Produto";
            // 
            // btnCadastrar
            // 
            this.btnCadastrar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCadastrar.Location = new System.Drawing.Point(132, 145);
            this.btnCadastrar.Name = "btnCadastrar";
            this.btnCadastrar.Size = new System.Drawing.Size(185, 28);
            this.btnCadastrar.TabIndex = 6;
            this.btnCadastrar.Text = "Cadastrar";
            this.btnCadastrar.UseVisualStyleBackColor = true;
            this.btnCadastrar.Click += new System.EventHandler(this.btnCadastrar_Click);
            // 
            // grbCadastrar
            // 
            this.grbCadastrar.Controls.Add(this.cmbIdCategoriaCad);
            this.grbCadastrar.Controls.Add(this.lblIdCategoriaCad);
            this.grbCadastrar.Controls.Add(this.txbPrecoCad);
            this.grbCadastrar.Controls.Add(this.txbIdCadastroCad);
            this.grbCadastrar.Controls.Add(this.txbNomeCad);
            this.grbCadastrar.Controls.Add(this.lblId_RespCadastroCad);
            this.grbCadastrar.Controls.Add(this.lblPrecoCad);
            this.grbCadastrar.Controls.Add(this.lblNomeCad);
            this.grbCadastrar.Controls.Add(this.btnCadastrar);
            this.grbCadastrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbCadastrar.Location = new System.Drawing.Point(13, 240);
            this.grbCadastrar.Name = "grbCadastrar";
            this.grbCadastrar.Size = new System.Drawing.Size(335, 191);
            this.grbCadastrar.TabIndex = 14;
            this.grbCadastrar.TabStop = false;
            this.grbCadastrar.Text = "Cadastro:";
            // 
            // lblIdCategoriaCad
            // 
            this.lblIdCategoriaCad.AutoSize = true;
            this.lblIdCategoriaCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCategoriaCad.Location = new System.Drawing.Point(18, 118);
            this.lblIdCategoriaCad.Name = "lblIdCategoriaCad";
            this.lblIdCategoriaCad.Size = new System.Drawing.Size(83, 16);
            this.lblIdCategoriaCad.TabIndex = 19;
            this.lblIdCategoriaCad.Text = "Id Categoria:";
            // 
            // txbPrecoCad
            // 
            this.txbPrecoCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecoCad.Location = new System.Drawing.Point(132, 87);
            this.txbPrecoCad.Name = "txbPrecoCad";
            this.txbPrecoCad.Size = new System.Drawing.Size(185, 22);
            this.txbPrecoCad.TabIndex = 18;
            // 
            // txbIdCadastroCad
            // 
            this.txbIdCadastroCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbIdCadastroCad.Location = new System.Drawing.Point(132, 59);
            this.txbIdCadastroCad.Name = "txbIdCadastroCad";
            this.txbIdCadastroCad.Size = new System.Drawing.Size(185, 22);
            this.txbIdCadastroCad.TabIndex = 17;
            // 
            // txbNomeCad
            // 
            this.txbNomeCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeCad.Location = new System.Drawing.Point(132, 33);
            this.txbNomeCad.Name = "txbNomeCad";
            this.txbNomeCad.Size = new System.Drawing.Size(185, 22);
            this.txbNomeCad.TabIndex = 16;
            // 
            // lblId_RespCadastroCad
            // 
            this.lblId_RespCadastroCad.AutoSize = true;
            this.lblId_RespCadastroCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblId_RespCadastroCad.Location = new System.Drawing.Point(18, 62);
            this.lblId_RespCadastroCad.Name = "lblId_RespCadastroCad";
            this.lblId_RespCadastroCad.Size = new System.Drawing.Size(79, 16);
            this.lblId_RespCadastroCad.TabIndex = 15;
            this.lblId_RespCadastroCad.Text = "Id Cadastro:";
            // 
            // lblPrecoCad
            // 
            this.lblPrecoCad.AutoSize = true;
            this.lblPrecoCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoCad.Location = new System.Drawing.Point(18, 90);
            this.lblPrecoCad.Name = "lblPrecoCad";
            this.lblPrecoCad.Size = new System.Drawing.Size(46, 16);
            this.lblPrecoCad.TabIndex = 14;
            this.lblPrecoCad.Text = "Preço:";
            // 
            // lblNomeCad
            // 
            this.lblNomeCad.AutoSize = true;
            this.lblNomeCad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeCad.Location = new System.Drawing.Point(18, 36);
            this.lblNomeCad.Name = "lblNomeCad";
            this.lblNomeCad.Size = new System.Drawing.Size(47, 16);
            this.lblNomeCad.TabIndex = 13;
            this.lblNomeCad.Text = "Nome:";
            // 
            // dgvProdutos
            // 
            this.dgvProdutos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProdutos.Location = new System.Drawing.Point(13, 33);
            this.dgvProdutos.Name = "dgvProdutos";
            this.dgvProdutos.Size = new System.Drawing.Size(678, 173);
            this.dgvProdutos.TabIndex = 13;
            this.dgvProdutos.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            this.dgvProdutos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvProdutos_CellContentClick);
            // 
            // btnSair
            // 
            this.btnSair.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btnSair.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSair.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSair.Location = new System.Drawing.Point(643, 536);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(48, 26);
            this.btnSair.TabIndex = 12;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = false;
            // 
            // lblInformacao
            // 
            this.lblInformacao.AutoSize = true;
            this.lblInformacao.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblInformacao.Location = new System.Drawing.Point(10, 546);
            this.lblInformacao.Name = "lblInformacao";
            this.lblInformacao.Size = new System.Drawing.Size(154, 16);
            this.lblInformacao.TabIndex = 11;
            this.lblInformacao.Text = "Você está logado como ";
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Monospac821 BT", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitulo.Location = new System.Drawing.Point(14, 11);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(259, 19);
            this.lblTitulo.TabIndex = 10;
            this.lblTitulo.Text = "Gerenciamento de Produtos";
            this.lblTitulo.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // btnEditar
            // 
            this.btnEditar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditar.Location = new System.Drawing.Point(129, 145);
            this.btnEditar.Name = "btnEditar";
            this.btnEditar.Size = new System.Drawing.Size(185, 28);
            this.btnEditar.TabIndex = 6;
            this.btnEditar.Text = "Editar";
            this.btnEditar.UseVisualStyleBackColor = true;
            this.btnEditar.Click += new System.EventHandler(this.btnEditar_Click);
            // 
            // grbEditar
            // 
            this.grbEditar.Controls.Add(this.cmbIdCategoriaEdi);
            this.grbEditar.Controls.Add(this.txbPrecoEdi);
            this.grbEditar.Controls.Add(this.txbNomeEdi);
            this.grbEditar.Controls.Add(this.lblIdCategoriaEdi);
            this.grbEditar.Controls.Add(this.lblPrecoEdi);
            this.grbEditar.Controls.Add(this.lblNomeEdi);
            this.grbEditar.Controls.Add(this.btnEditar);
            this.grbEditar.Enabled = false;
            this.grbEditar.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grbEditar.Location = new System.Drawing.Point(356, 240);
            this.grbEditar.Name = "grbEditar";
            this.grbEditar.Size = new System.Drawing.Size(335, 191);
            this.grbEditar.TabIndex = 15;
            this.grbEditar.TabStop = false;
            this.grbEditar.Text = "Editar:";
            // 
            // txbPrecoEdi
            // 
            this.txbPrecoEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbPrecoEdi.Location = new System.Drawing.Point(129, 112);
            this.txbPrecoEdi.Name = "txbPrecoEdi";
            this.txbPrecoEdi.Size = new System.Drawing.Size(185, 22);
            this.txbPrecoEdi.TabIndex = 12;
            // 
            // txbNomeEdi
            // 
            this.txbNomeEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txbNomeEdi.Location = new System.Drawing.Point(129, 52);
            this.txbNomeEdi.Name = "txbNomeEdi";
            this.txbNomeEdi.Size = new System.Drawing.Size(185, 22);
            this.txbNomeEdi.TabIndex = 10;
            // 
            // lblIdCategoriaEdi
            // 
            this.lblIdCategoriaEdi.AutoSize = true;
            this.lblIdCategoriaEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblIdCategoriaEdi.Location = new System.Drawing.Point(15, 83);
            this.lblIdCategoriaEdi.Name = "lblIdCategoriaEdi";
            this.lblIdCategoriaEdi.Size = new System.Drawing.Size(83, 16);
            this.lblIdCategoriaEdi.TabIndex = 9;
            this.lblIdCategoriaEdi.Text = "Id Categoria:";
            // 
            // lblPrecoEdi
            // 
            this.lblPrecoEdi.AutoSize = true;
            this.lblPrecoEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPrecoEdi.Location = new System.Drawing.Point(16, 115);
            this.lblPrecoEdi.Name = "lblPrecoEdi";
            this.lblPrecoEdi.Size = new System.Drawing.Size(46, 16);
            this.lblPrecoEdi.TabIndex = 8;
            this.lblPrecoEdi.Text = "Preço:";
            // 
            // lblNomeEdi
            // 
            this.lblNomeEdi.AutoSize = true;
            this.lblNomeEdi.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNomeEdi.Location = new System.Drawing.Point(15, 55);
            this.lblNomeEdi.Name = "lblNomeEdi";
            this.lblNomeEdi.Size = new System.Drawing.Size(47, 16);
            this.lblNomeEdi.TabIndex = 7;
            this.lblNomeEdi.Text = "Nome:";
            // 
            // cmbIdCategoriaEdi
            // 
            this.cmbIdCategoriaEdi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdCategoriaEdi.FormattingEnabled = true;
            this.cmbIdCategoriaEdi.Location = new System.Drawing.Point(129, 80);
            this.cmbIdCategoriaEdi.Name = "cmbIdCategoriaEdi";
            this.cmbIdCategoriaEdi.Size = new System.Drawing.Size(185, 26);
            this.cmbIdCategoriaEdi.TabIndex = 13;
            // 
            // cmbIdCategoriaCad
            // 
            this.cmbIdCategoriaCad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbIdCategoriaCad.FormattingEnabled = true;
            this.cmbIdCategoriaCad.Location = new System.Drawing.Point(132, 115);
            this.cmbIdCategoriaCad.Name = "cmbIdCategoriaCad";
            this.cmbIdCategoriaCad.Size = new System.Drawing.Size(185, 26);
            this.cmbIdCategoriaCad.TabIndex = 14;
            // 
            // MenuProdutos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(700, 572);
            this.Controls.Add(this.grbRemover);
            this.Controls.Add(this.grbEditar);
            this.Controls.Add(this.grbCadastrar);
            this.Controls.Add(this.dgvProdutos);
            this.Controls.Add(this.btnSair);
            this.Controls.Add(this.lblInformacao);
            this.Controls.Add(this.lblTitulo);
            this.Name = "MenuProdutos";
            this.Text = "MenuProdutos";
            this.grbRemover.ResumeLayout(false);
            this.grbRemover.PerformLayout();
            this.grbCadastrar.ResumeLayout(false);
            this.grbCadastrar.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProdutos)).EndInit();
            this.grbEditar.ResumeLayout(false);
            this.grbEditar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btnRemover;
        private System.Windows.Forms.GroupBox grbRemover;
        private System.Windows.Forms.Label lblRemover;
        private System.Windows.Forms.Button btnCadastrar;
        private System.Windows.Forms.GroupBox grbCadastrar;
        private System.Windows.Forms.DataGridView dgvProdutos;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Label lblInformacao;
        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Button btnEditar;
        private System.Windows.Forms.GroupBox grbEditar;
        private System.Windows.Forms.TextBox txbPrecoEdi;
        private System.Windows.Forms.TextBox txbNomeEdi;
        private System.Windows.Forms.Label lblIdCategoriaEdi;
        private System.Windows.Forms.Label lblPrecoEdi;
        private System.Windows.Forms.Label lblNomeEdi;
        private System.Windows.Forms.TextBox txbPrecoCad;
        private System.Windows.Forms.TextBox txbIdCadastroCad;
        private System.Windows.Forms.TextBox txbNomeCad;
        private System.Windows.Forms.Label lblId_RespCadastroCad;
        private System.Windows.Forms.Label lblPrecoCad;
        private System.Windows.Forms.Label lblNomeCad;
        private System.Windows.Forms.Label lblIdCategoriaCad;
        private System.Windows.Forms.ComboBox cmbIdCategoriaEdi;
        private System.Windows.Forms.ComboBox cmbIdCategoriaCad;
    }
}