namespace MultApps.Windows
{
    partial class FrmGestao
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
            this.lblTitulo = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.cmbFiltro = new System.Windows.Forms.ComboBox();
            this.cmbCategoria = new System.Windows.Forms.ComboBox();
            this.btnNovoProduto = new System.Windows.Forms.Button();
            this.btnAtualizarGrid = new System.Windows.Forms.Button();
            this.lblProdutoImagem = new System.Windows.Forms.Label();
            this.lblProdutoId = new System.Windows.Forms.Label();
            this.lblProdutoNome = new System.Windows.Forms.Label();
            this.lblProdutoCategoria = new System.Windows.Forms.Label();
            this.lblProdutoPreco = new System.Windows.Forms.Label();
            this.lblProdutoEstoque = new System.Windows.Forms.Label();
            this.lblProdutoStatus = new System.Windows.Forms.Label();
            this.lbl = new System.Windows.Forms.Label();
            this.lblRegistrarNome = new System.Windows.Forms.Label();
            this.lblRegistrarCategoria = new System.Windows.Forms.Label();
            this.lblRegistrarPreco = new System.Windows.Forms.Label();
            this.lblRegistrarEstoque = new System.Windows.Forms.Label();
            this.lblLinkImagem = new System.Windows.Forms.Label();
            this.txtNomeProduto = new System.Windows.Forms.TextBox();
            this.txtCategoria = new System.Windows.Forms.TextBox();
            this.txtPreco = new System.Windows.Forms.TextBox();
            this.txtEstoque = new System.Windows.Forms.TextBox();
            this.txtLinkImagem = new System.Windows.Forms.TextBox();
            this.txtDescricaoProduto = new System.Windows.Forms.TextBox();
            this.lblDescricao = new System.Windows.Forms.Label();
            this.cmbStatus = new System.Windows.Forms.ComboBox();
            this.lblStatusProduto = new System.Windows.Forms.Label();
            this.btnSalvar = new System.Windows.Forms.Button();
            this.btnLimpar = new System.Windows.Forms.Button();
            this.btnExcluir = new System.Windows.Forms.Button();
            this.lblResultadoId = new System.Windows.Forms.Label();
            this.lblResultadoNome = new System.Windows.Forms.Label();
            this.lblResultadoCategoria = new System.Windows.Forms.Label();
            this.lblResultadoPreco = new System.Windows.Forms.Label();
            this.lblResultadoEstoque = new System.Windows.Forms.Label();
            this.lblResultadoStatus = new System.Windows.Forms.Label();
            this.picBoxImagem = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImagem)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitulo
            // 
            this.lblTitulo.AutoSize = true;
            this.lblTitulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lblTitulo.Location = new System.Drawing.Point(21, 18);
            this.lblTitulo.Name = "lblTitulo";
            this.lblTitulo.Size = new System.Drawing.Size(234, 29);
            this.lblTitulo.TabIndex = 0;
            this.lblTitulo.Text = "Gestão de produtos";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.lblStatus.Location = new System.Drawing.Point(22, 64);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(54, 17);
            this.lblStatus.TabIndex = 1;
            this.lblStatus.Text = "Status";
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCategoria.Location = new System.Drawing.Point(212, 64);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(80, 17);
            this.lblCategoria.TabIndex = 3;
            this.lblCategoria.Text = "Categoria";
            // 
            // cmbFiltro
            // 
            this.cmbFiltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cmbFiltro.FormattingEnabled = true;
            this.cmbFiltro.Location = new System.Drawing.Point(26, 87);
            this.cmbFiltro.Name = "cmbFiltro";
            this.cmbFiltro.Size = new System.Drawing.Size(156, 28);
            this.cmbFiltro.TabIndex = 4;
            // 
            // cmbCategoria
            // 
            this.cmbCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.25F);
            this.cmbCategoria.FormattingEnabled = true;
            this.cmbCategoria.Location = new System.Drawing.Point(216, 87);
            this.cmbCategoria.Name = "cmbCategoria";
            this.cmbCategoria.Size = new System.Drawing.Size(156, 28);
            this.cmbCategoria.TabIndex = 5;
            // 
            // btnNovoProduto
            // 
            this.btnNovoProduto.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnNovoProduto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.btnNovoProduto.Location = new System.Drawing.Point(403, 87);
            this.btnNovoProduto.Name = "btnNovoProduto";
            this.btnNovoProduto.Size = new System.Drawing.Size(162, 28);
            this.btnNovoProduto.TabIndex = 6;
            this.btnNovoProduto.Text = "+ Novo Produto";
            this.btnNovoProduto.UseVisualStyleBackColor = false;
            // 
            // btnAtualizarGrid
            // 
            this.btnAtualizarGrid.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnAtualizarGrid.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.btnAtualizarGrid.Location = new System.Drawing.Point(593, 86);
            this.btnAtualizarGrid.Name = "btnAtualizarGrid";
            this.btnAtualizarGrid.Size = new System.Drawing.Size(162, 28);
            this.btnAtualizarGrid.TabIndex = 7;
            this.btnAtualizarGrid.Text = "Atualizar Grid";
            this.btnAtualizarGrid.UseVisualStyleBackColor = false;
            // 
            // lblProdutoImagem
            // 
            this.lblProdutoImagem.AutoSize = true;
            this.lblProdutoImagem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.lblProdutoImagem.Location = new System.Drawing.Point(23, 153);
            this.lblProdutoImagem.Name = "lblProdutoImagem";
            this.lblProdutoImagem.Size = new System.Drawing.Size(66, 17);
            this.lblProdutoImagem.TabIndex = 8;
            this.lblProdutoImagem.Text = "Imagem";
            // 
            // lblProdutoId
            // 
            this.lblProdutoId.AutoSize = true;
            this.lblProdutoId.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.lblProdutoId.Location = new System.Drawing.Point(111, 153);
            this.lblProdutoId.Name = "lblProdutoId";
            this.lblProdutoId.Size = new System.Drawing.Size(24, 17);
            this.lblProdutoId.TabIndex = 9;
            this.lblProdutoId.Text = "ID";
            // 
            // lblProdutoNome
            // 
            this.lblProdutoNome.AutoSize = true;
            this.lblProdutoNome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.lblProdutoNome.Location = new System.Drawing.Point(168, 153);
            this.lblProdutoNome.Name = "lblProdutoNome";
            this.lblProdutoNome.Size = new System.Drawing.Size(50, 17);
            this.lblProdutoNome.TabIndex = 10;
            this.lblProdutoNome.Text = "Nome";
            // 
            // lblProdutoCategoria
            // 
            this.lblProdutoCategoria.AutoSize = true;
            this.lblProdutoCategoria.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.lblProdutoCategoria.Location = new System.Drawing.Point(298, 153);
            this.lblProdutoCategoria.Name = "lblProdutoCategoria";
            this.lblProdutoCategoria.Size = new System.Drawing.Size(80, 17);
            this.lblProdutoCategoria.TabIndex = 11;
            this.lblProdutoCategoria.Text = "Categoria";
            // 
            // lblProdutoPreco
            // 
            this.lblProdutoPreco.AutoSize = true;
            this.lblProdutoPreco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.lblProdutoPreco.Location = new System.Drawing.Point(445, 153);
            this.lblProdutoPreco.Name = "lblProdutoPreco";
            this.lblProdutoPreco.Size = new System.Drawing.Size(52, 17);
            this.lblProdutoPreco.TabIndex = 12;
            this.lblProdutoPreco.Text = "Preço";
            // 
            // lblProdutoEstoque
            // 
            this.lblProdutoEstoque.AutoSize = true;
            this.lblProdutoEstoque.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.lblProdutoEstoque.Location = new System.Drawing.Point(558, 153);
            this.lblProdutoEstoque.Name = "lblProdutoEstoque";
            this.lblProdutoEstoque.Size = new System.Drawing.Size(67, 17);
            this.lblProdutoEstoque.TabIndex = 13;
            this.lblProdutoEstoque.Text = "Estoque";
            // 
            // lblProdutoStatus
            // 
            this.lblProdutoStatus.AutoSize = true;
            this.lblProdutoStatus.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.lblProdutoStatus.Location = new System.Drawing.Point(670, 153);
            this.lblProdutoStatus.Name = "lblProdutoStatus";
            this.lblProdutoStatus.Size = new System.Drawing.Size(54, 17);
            this.lblProdutoStatus.TabIndex = 14;
            this.lblProdutoStatus.Text = "Status";
            // 
            // lbl
            // 
            this.lbl.AutoSize = true;
            this.lbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.25F);
            this.lbl.Location = new System.Drawing.Point(20, 254);
            this.lbl.Name = "lbl";
            this.lbl.Size = new System.Drawing.Size(340, 29);
            this.lbl.TabIndex = 15;
            this.lbl.Text = "Cadastro/Edição de produtos";
            // 
            // lblRegistrarNome
            // 
            this.lblRegistrarNome.AutoSize = true;
            this.lblRegistrarNome.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.lblRegistrarNome.Location = new System.Drawing.Point(23, 397);
            this.lblRegistrarNome.Name = "lblRegistrarNome";
            this.lblRegistrarNome.Size = new System.Drawing.Size(133, 17);
            this.lblRegistrarNome.TabIndex = 16;
            this.lblRegistrarNome.Text = "Nome do produto";
            // 
            // lblRegistrarCategoria
            // 
            this.lblRegistrarCategoria.AutoSize = true;
            this.lblRegistrarCategoria.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.lblRegistrarCategoria.Location = new System.Drawing.Point(289, 397);
            this.lblRegistrarCategoria.Name = "lblRegistrarCategoria";
            this.lblRegistrarCategoria.Size = new System.Drawing.Size(80, 17);
            this.lblRegistrarCategoria.TabIndex = 17;
            this.lblRegistrarCategoria.Text = "Categoria";
            // 
            // lblRegistrarPreco
            // 
            this.lblRegistrarPreco.AutoSize = true;
            this.lblRegistrarPreco.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.lblRegistrarPreco.Location = new System.Drawing.Point(555, 397);
            this.lblRegistrarPreco.Name = "lblRegistrarPreco";
            this.lblRegistrarPreco.Size = new System.Drawing.Size(52, 17);
            this.lblRegistrarPreco.TabIndex = 18;
            this.lblRegistrarPreco.Text = "Preço";
            // 
            // lblRegistrarEstoque
            // 
            this.lblRegistrarEstoque.AutoSize = true;
            this.lblRegistrarEstoque.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.lblRegistrarEstoque.Location = new System.Drawing.Point(23, 482);
            this.lblRegistrarEstoque.Name = "lblRegistrarEstoque";
            this.lblRegistrarEstoque.Size = new System.Drawing.Size(67, 17);
            this.lblRegistrarEstoque.TabIndex = 19;
            this.lblRegistrarEstoque.Text = "Estoque";
            // 
            // lblLinkImagem
            // 
            this.lblLinkImagem.AutoSize = true;
            this.lblLinkImagem.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.lblLinkImagem.Location = new System.Drawing.Point(289, 482);
            this.lblLinkImagem.Name = "lblLinkImagem";
            this.lblLinkImagem.Size = new System.Drawing.Size(122, 17);
            this.lblLinkImagem.TabIndex = 20;
            this.lblLinkImagem.Text = "Link da imagem";
            // 
            // txtNomeProduto
            // 
            this.txtNomeProduto.Location = new System.Drawing.Point(26, 435);
            this.txtNomeProduto.Name = "txtNomeProduto";
            this.txtNomeProduto.Size = new System.Drawing.Size(153, 20);
            this.txtNomeProduto.TabIndex = 21;
            // 
            // txtCategoria
            // 
            this.txtCategoria.Location = new System.Drawing.Point(292, 435);
            this.txtCategoria.Name = "txtCategoria";
            this.txtCategoria.Size = new System.Drawing.Size(153, 20);
            this.txtCategoria.TabIndex = 22;
            // 
            // txtPreco
            // 
            this.txtPreco.Location = new System.Drawing.Point(558, 435);
            this.txtPreco.Name = "txtPreco";
            this.txtPreco.Size = new System.Drawing.Size(153, 20);
            this.txtPreco.TabIndex = 23;
            // 
            // txtEstoque
            // 
            this.txtEstoque.Location = new System.Drawing.Point(22, 522);
            this.txtEstoque.Name = "txtEstoque";
            this.txtEstoque.Size = new System.Drawing.Size(153, 20);
            this.txtEstoque.TabIndex = 24;
            // 
            // txtLinkImagem
            // 
            this.txtLinkImagem.Location = new System.Drawing.Point(292, 522);
            this.txtLinkImagem.Name = "txtLinkImagem";
            this.txtLinkImagem.Size = new System.Drawing.Size(153, 20);
            this.txtLinkImagem.TabIndex = 25;
            // 
            // txtDescricaoProduto
            // 
            this.txtDescricaoProduto.Location = new System.Drawing.Point(26, 352);
            this.txtDescricaoProduto.Name = "txtDescricaoProduto";
            this.txtDescricaoProduto.Size = new System.Drawing.Size(695, 20);
            this.txtDescricaoProduto.TabIndex = 26;
            // 
            // lblDescricao
            // 
            this.lblDescricao.AutoSize = true;
            this.lblDescricao.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.lblDescricao.Location = new System.Drawing.Point(23, 312);
            this.lblDescricao.Name = "lblDescricao";
            this.lblDescricao.Size = new System.Drawing.Size(83, 17);
            this.lblDescricao.TabIndex = 27;
            this.lblDescricao.Text = "Descrição";
            // 
            // cmbStatus
            // 
            this.cmbStatus.FormattingEnabled = true;
            this.cmbStatus.Location = new System.Drawing.Point(556, 521);
            this.cmbStatus.Name = "cmbStatus";
            this.cmbStatus.Size = new System.Drawing.Size(153, 21);
            this.cmbStatus.TabIndex = 28;
            // 
            // lblStatusProduto
            // 
            this.lblStatusProduto.AutoSize = true;
            this.lblStatusProduto.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.lblStatusProduto.Location = new System.Drawing.Point(553, 482);
            this.lblStatusProduto.Name = "lblStatusProduto";
            this.lblStatusProduto.Size = new System.Drawing.Size(54, 17);
            this.lblStatusProduto.TabIndex = 29;
            this.lblStatusProduto.Text = "Status";
            // 
            // btnSalvar
            // 
            this.btnSalvar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnSalvar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.btnSalvar.Location = new System.Drawing.Point(771, 352);
            this.btnSalvar.Name = "btnSalvar";
            this.btnSalvar.Size = new System.Drawing.Size(91, 47);
            this.btnSalvar.TabIndex = 30;
            this.btnSalvar.Text = "Salvar";
            this.btnSalvar.UseVisualStyleBackColor = false;
            this.btnSalvar.Click += new System.EventHandler(this.btnSalvar_Click);
            // 
            // btnLimpar
            // 
            this.btnLimpar.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnLimpar.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.btnLimpar.Location = new System.Drawing.Point(771, 420);
            this.btnLimpar.Name = "btnLimpar";
            this.btnLimpar.Size = new System.Drawing.Size(91, 47);
            this.btnLimpar.TabIndex = 31;
            this.btnLimpar.Text = "Limpar";
            this.btnLimpar.UseVisualStyleBackColor = false;
            // 
            // btnExcluir
            // 
            this.btnExcluir.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnExcluir.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.btnExcluir.Location = new System.Drawing.Point(771, 495);
            this.btnExcluir.Name = "btnExcluir";
            this.btnExcluir.Size = new System.Drawing.Size(91, 47);
            this.btnExcluir.TabIndex = 32;
            this.btnExcluir.Text = "Excluir";
            this.btnExcluir.UseVisualStyleBackColor = false;
            // 
            // lblResultadoId
            // 
            this.lblResultadoId.AutoSize = true;
            this.lblResultadoId.Location = new System.Drawing.Point(111, 181);
            this.lblResultadoId.Name = "lblResultadoId";
            this.lblResultadoId.Size = new System.Drawing.Size(13, 13);
            this.lblResultadoId.TabIndex = 33;
            this.lblResultadoId.Text = "1";
            // 
            // lblResultadoNome
            // 
            this.lblResultadoNome.AutoSize = true;
            this.lblResultadoNome.Location = new System.Drawing.Point(169, 181);
            this.lblResultadoNome.Name = "lblResultadoNome";
            this.lblResultadoNome.Size = new System.Drawing.Size(13, 13);
            this.lblResultadoNome.TabIndex = 34;
            this.lblResultadoNome.Text = "1";
            // 
            // lblResultadoCategoria
            // 
            this.lblResultadoCategoria.AutoSize = true;
            this.lblResultadoCategoria.Location = new System.Drawing.Point(298, 181);
            this.lblResultadoCategoria.Name = "lblResultadoCategoria";
            this.lblResultadoCategoria.Size = new System.Drawing.Size(13, 13);
            this.lblResultadoCategoria.TabIndex = 35;
            this.lblResultadoCategoria.Text = "1";
            // 
            // lblResultadoPreco
            // 
            this.lblResultadoPreco.AutoSize = true;
            this.lblResultadoPreco.Location = new System.Drawing.Point(445, 181);
            this.lblResultadoPreco.Name = "lblResultadoPreco";
            this.lblResultadoPreco.Size = new System.Drawing.Size(13, 13);
            this.lblResultadoPreco.TabIndex = 36;
            this.lblResultadoPreco.Text = "1";
            // 
            // lblResultadoEstoque
            // 
            this.lblResultadoEstoque.AutoSize = true;
            this.lblResultadoEstoque.Location = new System.Drawing.Point(558, 181);
            this.lblResultadoEstoque.Name = "lblResultadoEstoque";
            this.lblResultadoEstoque.Size = new System.Drawing.Size(13, 13);
            this.lblResultadoEstoque.TabIndex = 37;
            this.lblResultadoEstoque.Text = "1";
            // 
            // lblResultadoStatus
            // 
            this.lblResultadoStatus.AutoSize = true;
            this.lblResultadoStatus.Location = new System.Drawing.Point(670, 181);
            this.lblResultadoStatus.Name = "lblResultadoStatus";
            this.lblResultadoStatus.Size = new System.Drawing.Size(13, 13);
            this.lblResultadoStatus.TabIndex = 38;
            this.lblResultadoStatus.Text = "1";
            // 
            // picBoxImagem
            // 
            this.picBoxImagem.Location = new System.Drawing.Point(26, 181);
            this.picBoxImagem.Name = "picBoxImagem";
            this.picBoxImagem.Size = new System.Drawing.Size(50, 48);
            this.picBoxImagem.TabIndex = 39;
            this.picBoxImagem.TabStop = false;
            // 
            // FrmGestao
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 625);
            this.Controls.Add(this.picBoxImagem);
            this.Controls.Add(this.lblResultadoStatus);
            this.Controls.Add(this.lblResultadoEstoque);
            this.Controls.Add(this.lblResultadoPreco);
            this.Controls.Add(this.lblResultadoCategoria);
            this.Controls.Add(this.lblResultadoNome);
            this.Controls.Add(this.lblResultadoId);
            this.Controls.Add(this.btnExcluir);
            this.Controls.Add(this.btnLimpar);
            this.Controls.Add(this.btnSalvar);
            this.Controls.Add(this.lblStatusProduto);
            this.Controls.Add(this.cmbStatus);
            this.Controls.Add(this.lblDescricao);
            this.Controls.Add(this.txtDescricaoProduto);
            this.Controls.Add(this.txtLinkImagem);
            this.Controls.Add(this.txtEstoque);
            this.Controls.Add(this.txtPreco);
            this.Controls.Add(this.txtCategoria);
            this.Controls.Add(this.txtNomeProduto);
            this.Controls.Add(this.lblLinkImagem);
            this.Controls.Add(this.lblRegistrarEstoque);
            this.Controls.Add(this.lblRegistrarPreco);
            this.Controls.Add(this.lblRegistrarCategoria);
            this.Controls.Add(this.lblRegistrarNome);
            this.Controls.Add(this.lbl);
            this.Controls.Add(this.lblProdutoStatus);
            this.Controls.Add(this.lblProdutoEstoque);
            this.Controls.Add(this.lblProdutoPreco);
            this.Controls.Add(this.lblProdutoCategoria);
            this.Controls.Add(this.lblProdutoNome);
            this.Controls.Add(this.lblProdutoId);
            this.Controls.Add(this.lblProdutoImagem);
            this.Controls.Add(this.btnAtualizarGrid);
            this.Controls.Add(this.btnNovoProduto);
            this.Controls.Add(this.cmbCategoria);
            this.Controls.Add(this.cmbFiltro);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblTitulo);
            this.Name = "FrmGestao";
            this.Text = "FrmGestao";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxImagem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitulo;
        private System.Windows.Forms.Label lblStatus;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.ComboBox cmbFiltro;
        private System.Windows.Forms.ComboBox cmbCategoria;
        private System.Windows.Forms.Button btnNovoProduto;
        private System.Windows.Forms.Button btnAtualizarGrid;
        private System.Windows.Forms.Label lblProdutoImagem;
        private System.Windows.Forms.Label lblProdutoId;
        private System.Windows.Forms.Label lblProdutoNome;
        private System.Windows.Forms.Label lblProdutoCategoria;
        private System.Windows.Forms.Label lblProdutoPreco;
        private System.Windows.Forms.Label lblProdutoEstoque;
        private System.Windows.Forms.Label lblProdutoStatus;
        private System.Windows.Forms.Label lbl;
        private System.Windows.Forms.Label lblRegistrarNome;
        private System.Windows.Forms.Label lblRegistrarCategoria;
        private System.Windows.Forms.Label lblRegistrarPreco;
        private System.Windows.Forms.Label lblRegistrarEstoque;
        private System.Windows.Forms.Label lblLinkImagem;
        private System.Windows.Forms.TextBox txtNomeProduto;
        private System.Windows.Forms.TextBox txtCategoria;
        private System.Windows.Forms.TextBox txtPreco;
        private System.Windows.Forms.TextBox txtEstoque;
        private System.Windows.Forms.TextBox txtLinkImagem;
        private System.Windows.Forms.TextBox txtDescricaoProduto;
        private System.Windows.Forms.Label lblDescricao;
        private System.Windows.Forms.ComboBox cmbStatus;
        private System.Windows.Forms.Label lblStatusProduto;
        private System.Windows.Forms.Button btnSalvar;
        private System.Windows.Forms.Button btnLimpar;
        private System.Windows.Forms.Button btnExcluir;
        private System.Windows.Forms.Label lblResultadoId;
        private System.Windows.Forms.Label lblResultadoNome;
        private System.Windows.Forms.Label lblResultadoCategoria;
        private System.Windows.Forms.Label lblResultadoPreco;
        private System.Windows.Forms.Label lblResultadoEstoque;
        private System.Windows.Forms.Label lblResultadoStatus;
        private System.Windows.Forms.PictureBox picBoxImagem;
    }
}