using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace MultApps.Windows
{
    public partial class FrmAposentadoria : Form
    {
        public FrmAposentadoria()
        {
            InitializeComponent();
        }

        private void btnCalcular_Click(object sender, EventArgs e)
        {
            int idadeAposentadoria = 0;

            var dataNascimento = int.Parse(txtDataNascimento.Text);
            var dataAtual = DateTime.Now.Year;
            var idade = dataAtual - dataNascimento;

            var tempoContribuicao = int.Parse(txtTempoContribuicao.Text);
            var tempoContribuicaoMinimo = 15;

            var sexoSelecionado = cmbSexoBiologico.Items.ToString();

            if (tempoContribuicao < tempoContribuicaoMinimo && idade < idadeAposentadoria)
            {
                lblResultado.Text = "Não está qualificado";
            }
            else
            {
                lblResultado.Text = "Está qualificado";
            }

        }

    }
}