namespace MultApps.Windows
{
    partial class FrmAposentadoria
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
            this.lblDataDeNascimento = new System.Windows.Forms.Label();
            this.lblSexoBiologico = new System.Windows.Forms.Label();
            this.lblTempoContribuicao = new System.Windows.Forms.Label();
            this.txtTempoContribuicao = new System.Windows.Forms.TextBox();
            this.cmbSexoBiologico = new System.Windows.Forms.ComboBox();
            this.txtDataNascimento = new System.Windows.Forms.TextBox();
            this.btnCalcular = new System.Windows.Forms.Button();
            this.lblResultado = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblDataDeNascimento
            // 
            this.lblDataDeNascimento.AutoSize = true;
            this.lblDataDeNascimento.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDataDeNascimento.Location = new System.Drawing.Point(33, 85);
            this.lblDataDeNascimento.Name = "lblDataDeNascimento";
            this.lblDataDeNascimento.Size = new System.Drawing.Size(282, 33);
            this.lblDataDeNascimento.TabIndex = 0;
            this.lblDataDeNascimento.Text = "Data de nascimento:";
            // 
            // lblSexoBiologico
            // 
            this.lblSexoBiologico.AutoSize = true;
            this.lblSexoBiologico.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSexoBiologico.Location = new System.Drawing.Point(33, 239);
            this.lblSexoBiologico.Name = "lblSexoBiologico";
            this.lblSexoBiologico.Size = new System.Drawing.Size(213, 33);
            this.lblSexoBiologico.TabIndex = 1;
            this.lblSexoBiologico.Text = "Sexo biológico:";
            // 
            // lblTempoContribuicao
            // 
            this.lblTempoContribuicao.AutoSize = true;
            this.lblTempoContribuicao.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTempoContribuicao.Location = new System.Drawing.Point(33, 408);
            this.lblTempoContribuicao.Name = "lblTempoContribuicao";
            this.lblTempoContribuicao.Size = new System.Drawing.Size(440, 33);
            this.lblTempoContribuicao.TabIndex = 2;
            this.lblTempoContribuicao.Text = "Tempo de contribuição em anos:";
            // 
            // txtTempoContribuicao
            // 
            this.txtTempoContribuicao.Location = new System.Drawing.Point(39, 498);
            this.txtTempoContribuicao.Name = "txtTempoContribuicao";
            this.txtTempoContribuicao.Size = new System.Drawing.Size(100, 20);
            this.txtTempoContribuicao.TabIndex = 4;
            // 
            // cmbSexoBiologico
            // 
            this.cmbSexoBiologico.FormattingEnabled = true;
            this.cmbSexoBiologico.Items.AddRange(new object[] {
            "Masculino",
            "Feminino"});
            this.cmbSexoBiologico.Location = new System.Drawing.Point(39, 321);
            this.cmbSexoBiologico.Name = "cmbSexoBiologico";
            this.cmbSexoBiologico.Size = new System.Drawing.Size(121, 21);
            this.cmbSexoBiologico.TabIndex = 5;
            // 
            // txtDataNascimento
            // 
            this.txtDataNascimento.Location = new System.Drawing.Point(39, 169);
            this.txtDataNascimento.Name = "txtDataNascimento";
            this.txtDataNascimento.Size = new System.Drawing.Size(100, 20);
            this.txtDataNascimento.TabIndex = 6;
            // 
            // btnCalcular
            // 
            this.btnCalcular.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalcular.Location = new System.Drawing.Point(395, 85);
            this.btnCalcular.Name = "btnCalcular";
            this.btnCalcular.Size = new System.Drawing.Size(78, 65);
            this.btnCalcular.TabIndex = 7;
            this.btnCalcular.Text = "Calcular";
            this.btnCalcular.UseVisualStyleBackColor = true;
            this.btnCalcular.Click += new System.EventHandler(this.btnCalcular_Click);
            // 
            // lblResultado
            // 
            this.lblResultado.AutoSize = true;
            this.lblResultado.Location = new System.Drawing.Point(541, 272);
            this.lblResultado.Name = "lblResultado";
            this.lblResultado.Size = new System.Drawing.Size(0, 13);
            this.lblResultado.TabIndex = 8;
            // 
            // FrmAposentadoria
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 567);
            this.Controls.Add(this.lblResultado);
            this.Controls.Add(this.btnCalcular);
            this.Controls.Add(this.txtDataNascimento);
            this.Controls.Add(this.cmbSexoBiologico);
            this.Controls.Add(this.txtTempoContribuicao);
            this.Controls.Add(this.lblTempoContribuicao);
            this.Controls.Add(this.lblSexoBiologico);
            this.Controls.Add(this.lblDataDeNascimento);
            this.Name = "FrmAposentadoria";
            this.Text = "Calculo de aposentadoria";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDataDeNascimento;
        private System.Windows.Forms.Label lblSexoBiologico;
        private System.Windows.Forms.Label lblTempoContribuicao;
        private System.Windows.Forms.TextBox txtTempoContribuicao;
        private System.Windows.Forms.ComboBox cmbSexoBiologico;
        private System.Windows.Forms.TextBox txtDataNascimento;
        private System.Windows.Forms.Button btnCalcular;
        private System.Windows.Forms.Label lblResultado;
    }
}