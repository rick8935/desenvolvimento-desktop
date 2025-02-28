namespace MultiApps.Windows
{
    partial class FrmCalculadoraIMC
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.lblSelecione = new System.Windows.Forms.Label();
            this.chkAdulto = new System.Windows.Forms.CheckBox();
            this.chkCrianca = new System.Windows.Forms.CheckBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.Controls.Add(this.chkCrianca);
            this.panel1.Controls.Add(this.chkAdulto);
            this.panel1.Controls.Add(this.lblSelecione);
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(792, 330);
            this.panel1.TabIndex = 0;
            // 
            // lblSelecione
            // 
            this.lblSelecione.AutoSize = true;
            this.lblSelecione.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelecione.Location = new System.Drawing.Point(17, 20);
            this.lblSelecione.Name = "lblSelecione";
            this.lblSelecione.Size = new System.Drawing.Size(113, 25);
            this.lblSelecione.TabIndex = 0;
            this.lblSelecione.Text = "Selecione:";
            // 
            // chkAdulto
            // 
            this.chkAdulto.AutoSize = true;
            this.chkAdulto.Checked = true;
            this.chkAdulto.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkAdulto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkAdulto.ForeColor = System.Drawing.Color.Orange;
            this.chkAdulto.Location = new System.Drawing.Point(22, 48);
            this.chkAdulto.Name = "chkAdulto";
            this.chkAdulto.Size = new System.Drawing.Size(83, 28);
            this.chkAdulto.TabIndex = 1;
            this.chkAdulto.Text = "Adulto";
            this.chkAdulto.UseVisualStyleBackColor = true;
            this.chkAdulto.CheckedChanged += new System.EventHandler(this.chkAdulto_CheckedChanged);
            // 
            // chkCrianca
            // 
            this.chkCrianca.AutoSize = true;
            this.chkCrianca.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkCrianca.ForeColor = System.Drawing.SystemColors.InfoText;
            this.chkCrianca.Location = new System.Drawing.Point(111, 48);
            this.chkCrianca.Name = "chkCrianca";
            this.chkCrianca.Size = new System.Drawing.Size(93, 28);
            this.chkCrianca.TabIndex = 2;
            this.chkCrianca.Text = "Criança";
            this.chkCrianca.UseVisualStyleBackColor = true;
            this.chkCrianca.CheckedChanged += new System.EventHandler(this.chkCrianca_CheckedChanged);
            // 
            // FrmCalculadoraIMC
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gold;
            this.ClientSize = new System.Drawing.Size(816, 354);
            this.Controls.Add(this.panel1);
            this.Name = "FrmCalculadoraIMC";
            this.Text = "FrmCalculadoraIMC";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lblSelecione;
        private System.Windows.Forms.CheckBox chkCrianca;
        private System.Windows.Forms.CheckBox chkAdulto;
    }
}