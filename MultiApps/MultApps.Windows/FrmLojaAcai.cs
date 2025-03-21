using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MultApps.Windows
{
    public partial class FrmLojaAcai : Form
    {
        public FrmLojaAcai()
        {
            InitializeComponent();
        }

        public class PedidoItem
        {
            public string Nome { get; set; }
            public int Quantidade { get; set; }
            public decimal Preco { get; set; }

            public PedidoItem(string nome, int quantidade, decimal preco)
            {
                Nome = nome;
                Quantidade = quantidade;
                Preco = preco;
            }

            public override string ToString()
            {
                return $"{Nome} - R$ {Preco:F2}";
            }
        }

        public class ValorTotal
        {
            public decimal Total { get; set; }

            public ValorTotal(decimal total)
            {
                Total = total;
            }

            public override string ToString()
            {
                return $"R${Total}";
            }
        }

        private void btnRemover_Click(object sender, EventArgs e)
        {
            if (listBoxPedidos.SelectedItem != null)
            {
                listBoxPedidos.Items.Remove(listBoxPedidos.SelectedItem);
            }
            else
            {
                MessageBox.Show("Selecione um item para remover.");
            }
        }

        private void btnSelecionar1_Click(object sender, EventArgs e)
        {
            listBoxPedidos.Items.Add(new PedidoItem("Açaí 300ml", 1, 15.00m));
            listBoxPedidos.Visible = true;

            listBoxPrecoTotal.Items.Add(new ValorTotal(15.00m));
            listBoxPrecoTotal.Visible = true;

        }

        private void btnSelecionar2_Click(object sender, EventArgs e)
        {
            listBoxPedidos.Items.Add(new PedidoItem("Açaí 500ml", 1, 20.00m));
            listBoxPedidos.Visible = true;
        }

        private void btnSelecionar3_Click(object sender, EventArgs e)
        {
            listBoxPedidos.Items.Add(new PedidoItem("Açaí 700ml", 1, 25.00m));
            listBoxPedidos.Visible = true;
        }

        private void btnSelecionar4_Click(object sender, EventArgs e)
        {
            listBoxPedidos.Items.Add(new PedidoItem("Açaí 1L", 1, 35.00m));
            listBoxPedidos.Visible = true;
        }

        private void btnRemoverComplemento1_Click(object sender, EventArgs e)
        {
            int valorAtual = Convert.ToInt32(lblQuantidadeGranola.Text);
            int novoValor = valorAtual - 1;
            lblQuantidadeGranola.Text = novoValor.ToString();

            listBoxPedidos.Items.Remove(new PedidoItem("Granola", 1, 3.00m));
        }

        private void btnAdicionarComplemento1_Click(object sender, EventArgs e)
        {
            int valorAtual = Convert.ToInt32(lblQuantidadeGranola.Text);
            int novoValor = valorAtual + 1;
            lblQuantidadeGranola.Text = novoValor.ToString();

            listBoxPedidos.Items.Add(new PedidoItem("Granola", 1, 3.00m));
        }

    }
}