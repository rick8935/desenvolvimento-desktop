using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void menuCalculadoraImc_Click(object sender, EventArgs e)
        {
            var Form = new FrmCalculadoraIMC();
            Form.MdiParent = this;
            Form.Show();
        }

        private void Principal_Shown(object sender, EventArgs e)
        {
            var loading = new SplashScreen();
            loading.ShowDialog();
        }

        private void menuCalculadoraAposentadoria_Click(object sender, EventArgs e)
        {
            var Form = new FrmAposentadoria();
            Form.MdiParent = this;
            Form.Show();
        }

        private void menuAppCarteirinha_Click(object sender, EventArgs e)
        {
            var Form = new FrmCarteirinha();
            Form.MdiParent = this;
            Form.Show();
        }
    }
}