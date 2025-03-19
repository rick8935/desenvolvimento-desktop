namespace MultApps.Windows
{
    partial class FrmCarteirinha
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
            this.lblNome = new System.Windows.Forms.Label();
            this.lblDataNascimento = new System.Windows.Forms.Label();
            this.lblCpf = new System.Windows.Forms.Label();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.txtCPF = new System.Windows.Forms.TextBox();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.btnGerarCarteirinha = new System.Windows.Forms.Button();
            this.picBoxCarteirinha = new System.Windows.Forms.PictureBox();
            this.lblResultadoNome = new System.Windows.Forms.Label();
            this.lblResultadoCPF = new System.Windows.Forms.Label();
            this.lblResultadoIdade = new System.Windows.Forms.Label();
            this.lblCarteirinha = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCarteirinha)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNome
            // 
            this.lblNome.AutoSize = true;
            this.lblNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNome.Location = new System.Drawing.Point(59, 57);
            this.lblNome.Name = "lblNome";
            this.lblNome.Size = new System.Drawing.Size(68, 25);
            this.lblNome.TabIndex = 0;
            this.lblNome.Text = "Nome";
            // 
            // lblDataNascimento
            // 
            this.lblDataNascimento.AutoSize = true;
            this.lblDataNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataNascimento.Location = new System.Drawing.Point(59, 348);
            this.lblDataNascimento.Name = "lblDataNascimento";
            this.lblDataNascimento.Size = new System.Drawing.Size(196, 25);
            this.lblDataNascimento.TabIndex = 1;
            this.lblDataNascimento.Text = "Ano de nascimento";
            // 
            // lblCpf
            // 
            this.lblCpf.AutoSize = true;
            this.lblCpf.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCpf.Location = new System.Drawing.Point(59, 207);
            this.lblCpf.Name = "lblCpf";
            this.lblCpf.Size = new System.Drawing.Size(54, 25);
            this.lblCpf.TabIndex = 2;
            this.lblCpf.Text = "CPF";
            // 
            // txtNome
            // 
            this.txtNome.Location = new System.Drawing.Point(64, 104);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(100, 20);
            this.txtNome.TabIndex = 3;
            // 
            // txtCPF
            // 
            this.txtCPF.Location = new System.Drawing.Point(64, 249);
            this.txtCPF.Name = "txtCPF";
            this.txtCPF.Size = new System.Drawing.Size(100, 20);
            this.txtCPF.TabIndex = 4;
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(64, 389);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtDataNascimento.TabIndex = 5;
            // 
            // btnGerarCarteirinha
            // 
            this.btnGerarCarteirinha.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.btnGerarCarteirinha.Font = new System.Drawing.Font("Microsoft YaHei UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGerarCarteirinha.Location = new System.Drawing.Point(64, 455);
            this.btnGerarCarteirinha.Name = "btnGerarCarteirinha";
            this.btnGerarCarteirinha.Size = new System.Drawing.Size(198, 48);
            this.btnGerarCarteirinha.TabIndex = 6;
            this.btnGerarCarteirinha.Text = "GERAR CARTEIRINHA";
            this.btnGerarCarteirinha.UseVisualStyleBackColor = false;
            this.btnGerarCarteirinha.Click += new System.EventHandler(this.btnGerarCarteirinha_Click);
            // 
            // picBoxCarteirinha
            // 
            this.picBoxCarteirinha.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.picBoxCarteirinha.Location = new System.Drawing.Point(348, 57);
            this.picBoxCarteirinha.Name = "picBoxCarteirinha";
            this.picBoxCarteirinha.Size = new System.Drawing.Size(191, 187);
            this.picBoxCarteirinha.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBoxCarteirinha.TabIndex = 7;
            this.picBoxCarteirinha.TabStop = false;
            // 
            // lblResultadoNome
            // 
            this.lblResultadoNome.AutoSize = true;
            this.lblResultadoNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoNome.Location = new System.Drawing.Point(345, 289);
            this.lblResultadoNome.Name = "lblResultadoNome";
            this.lblResultadoNome.Size = new System.Drawing.Size(0, 20);
            this.lblResultadoNome.TabIndex = 8;
            // 
            // lblResultadoCPF
            // 
            this.lblResultadoCPF.AutoSize = true;
            this.lblResultadoCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoCPF.Location = new System.Drawing.Point(344, 376);
            this.lblResultadoCPF.Name = "lblResultadoCPF";
            this.lblResultadoCPF.Size = new System.Drawing.Size(0, 20);
            this.lblResultadoCPF.TabIndex = 9;
            // 
            // lblResultadoIdade
            // 
            this.lblResultadoIdade.AutoSize = true;
            this.lblResultadoIdade.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResultadoIdade.Location = new System.Drawing.Point(345, 470);
            this.lblResultadoIdade.Name = "lblResultadoIdade";
            this.lblResultadoIdade.Size = new System.Drawing.Size(0, 20);
            this.lblResultadoIdade.TabIndex = 10;
            // 
            // lblCarteirinha
            // 
            this.lblCarteirinha.AutoSize = true;
            this.lblCarteirinha.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarteirinha.Location = new System.Drawing.Point(344, 19);
            this.lblCarteirinha.Name = "lblCarteirinha";
            this.lblCarteirinha.Size = new System.Drawing.Size(0, 25);
            this.lblCarteirinha.TabIndex = 11;
            // 
            // FrmCarteirinha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(605, 552);
            this.Controls.Add(this.lblCarteirinha);
            this.Controls.Add(this.lblResultadoIdade);
            this.Controls.Add(this.lblResultadoCPF);
            this.Controls.Add(this.lblResultadoNome);
            this.Controls.Add(this.picBoxCarteirinha);
            this.Controls.Add(this.btnGerarCarteirinha);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.txtCPF);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.lblCpf);
            this.Controls.Add(this.lblDataNascimento);
            this.Controls.Add(this.lblNome);
            this.Name = "FrmCarteirinha";
            this.Text = "Carteirinha";
            ((System.ComponentModel.ISupportInitialize)(this.picBoxCarteirinha)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNome;
        private System.Windows.Forms.Label lblDataNascimento;
        private System.Windows.Forms.Label lblCpf;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.TextBox txtCPF;
        private System.Windows.Forms.TextBox txtDataNascimento;
        private System.Windows.Forms.Button btnGerarCarteirinha;
        private System.Windows.Forms.PictureBox picBoxCarteirinha;
        private System.Windows.Forms.Label lblResultadoNome;
        private System.Windows.Forms.Label lblResultadoCPF;
        private System.Windows.Forms.Label lblResultadoIdade;
        private System.Windows.Forms.Label lblCarteirinha;
    }
}