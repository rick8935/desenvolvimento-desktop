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
    public partial class FrmCarteirinha : Form
    {
        public FrmCarteirinha()
        {
            InitializeComponent();
        }

        private void btnGerarCarteirinha_Click(object sender, EventArgs e)
        {
            lblResultadoNome.Text = txtNome.Text;

            var dataNascimento = int.Parse(txtDataNascimento.Text);
            var dataAtual = DateTime.Now.Year;
            var idade = dataAtual - dataNascimento;

            lblResultadoIdade.Text = "Idade: " + Convert.ToString(idade);

            var textoOriginal = txtCPF.Text;
            var textoOculto = OcultarTexto(textoOriginal);
            lblResultadoCPF.Text = textoOculto;


            if (idade < 12)
            {
                picBoxCarteirinha.Load("https://yt3.googleusercontent.com/GscnxhDVZNpA4jPMHapR6S0hu13OTpGOI3CB27v1KsqQBua6GuSuNosMFO7FO2FdckGhH7c-=s900-c-k-c0x00ffffff-no-rj");

                lblCarteirinha.Text = "Carteirinha azul";
                lblCarteirinha.ForeColor = Color.Blue;
            }
            else if (idade < 18)
            {
                picBoxCarteirinha.Load("https://cdn-icons-png.flaticon.com/512/4440/4440953.png");

                lblCarteirinha.Text = "Carteirinha amarela";
                lblCarteirinha.ForeColor = Color.Yellow;
            }
            else if (idade < 60)
            {
                picBoxCarteirinha.Load("https://cdn-icons-png.flaticon.com/512/4203/4203158.png");

                lblCarteirinha.Text = "Carteirinha roxa";
                lblCarteirinha.ForeColor = Color.Purple;
            }
            else
            {
                picBoxCarteirinha.Load("https://cdn-icons-png.freepik.com/512/1761/1761366.png");

                lblCarteirinha.Text = "Carteirinha verde";
                lblCarteirinha.ForeColor = Color.Green;
            }
        }

        static string OcultarTexto(string texto)
        {
            string parteVisivel1 = texto.Substring(3, 3); // Pega a parte do meio
            string parteVisivel2 = texto.Substring(6, 3); // Pega a última parte

            return "***." + parteVisivel1 + "." + parteVisivel2 + ".***";
        }

    }
}