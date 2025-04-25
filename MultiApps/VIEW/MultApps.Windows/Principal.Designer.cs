﻿namespace MultApps.Windows
{
    partial class Principal
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
            this.menuStripPrincipal = new System.Windows.Forms.MenuStrip();
            this.calculadorasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCalculadoraImc = new System.Windows.Forms.ToolStripMenuItem();
            this.menuCalculadoraAposentadoria = new System.Windows.Forms.ToolStripMenuItem();
            this.appsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuAppCarteirinha = new System.Windows.Forms.ToolStripMenuItem();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.statusLabelUsuario = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStripPrincipal.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripPrincipal
            // 
            this.menuStripPrincipal.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.calculadorasToolStripMenuItem,
            this.appsToolStripMenuItem});
            this.menuStripPrincipal.Location = new System.Drawing.Point(0, 0);
            this.menuStripPrincipal.Name = "menuStripPrincipal";
            this.menuStripPrincipal.Size = new System.Drawing.Size(800, 24);
            this.menuStripPrincipal.TabIndex = 1;
            this.menuStripPrincipal.Text = "menuStrip1";
            // 
            // calculadorasToolStripMenuItem
            // 
            this.calculadorasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuCalculadoraImc,
            this.menuCalculadoraAposentadoria});
            this.calculadorasToolStripMenuItem.Name = "calculadorasToolStripMenuItem";
            this.calculadorasToolStripMenuItem.Size = new System.Drawing.Size(87, 20);
            this.calculadorasToolStripMenuItem.Text = "Calculadoras";
            // 
            // menuCalculadoraImc
            // 
            this.menuCalculadoraImc.Name = "menuCalculadoraImc";
            this.menuCalculadoraImc.Size = new System.Drawing.Size(231, 22);
            this.menuCalculadoraImc.Text = "Calculadora de IMC";
            this.menuCalculadoraImc.Click += new System.EventHandler(this.menuCalculadoraImc_Click);
            // 
            // menuCalculadoraAposentadoria
            // 
            this.menuCalculadoraAposentadoria.Name = "menuCalculadoraAposentadoria";
            this.menuCalculadoraAposentadoria.Size = new System.Drawing.Size(231, 22);
            this.menuCalculadoraAposentadoria.Text = "Calculadora de aposentadoria";
            this.menuCalculadoraAposentadoria.Click += new System.EventHandler(this.menuCalculadoraAposentadoria_Click);
            // 
            // appsToolStripMenuItem
            // 
            this.appsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuAppCarteirinha});
            this.appsToolStripMenuItem.Name = "appsToolStripMenuItem";
            this.appsToolStripMenuItem.Size = new System.Drawing.Size(46, 20);
            this.appsToolStripMenuItem.Text = "Apps";
            // 
            // menuAppCarteirinha
            // 
            this.menuAppCarteirinha.Name = "menuAppCarteirinha";
            this.menuAppCarteirinha.Size = new System.Drawing.Size(157, 22);
            this.menuAppCarteirinha.Text = "App Carteirinha";
            this.menuAppCarteirinha.Click += new System.EventHandler(this.menuAppCarteirinha_Click);
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.statusLabelUsuario});
            this.statusStrip1.Location = new System.Drawing.Point(0, 425);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 25);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // statusLabelUsuario
            // 
            this.statusLabelUsuario.Font = new System.Drawing.Font("Segoe UI", 11F);
            this.statusLabelUsuario.Name = "statusLabelUsuario";
            this.statusLabelUsuario.Size = new System.Drawing.Size(151, 20);
            this.statusLabelUsuario.Text = "toolStripStatusLabel1";
            // 
            // Principal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.menuStripPrincipal);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripPrincipal;
            this.Name = "Principal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Principal";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Shown += new System.EventHandler(this.Principal_Shown);
            this.menuStripPrincipal.ResumeLayout(false);
            this.menuStripPrincipal.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripPrincipal;
        private System.Windows.Forms.ToolStripMenuItem calculadorasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuCalculadoraImc;
        private System.Windows.Forms.ToolStripMenuItem menuCalculadoraAposentadoria;
        private System.Windows.Forms.ToolStripMenuItem appsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem menuAppCarteirinha;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel statusLabelUsuario;
    }
}