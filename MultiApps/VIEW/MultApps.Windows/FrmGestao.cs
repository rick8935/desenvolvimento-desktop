using MultiApps.Models.Entidades;
using MultiApps.Models.Enum;
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
    public partial class FrmGestao : Form
    {
        public FrmGestao()
        {
            InitializeComponent();
            var status = new[] { "inativo", "ativo" };
            var filtros = new[] { "todos", "ativos", "inativos" };
            cmbStatus.Items.AddRange(status);
            cmbFiltro.Items.AddRange(filtros);

            cmbStatus.SelectedIndex = 1;
            cmbFiltro.SelectedIndex = 0;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            var produto = new GestaoProdutos();

            produto.Nome = txtNomeProduto.Text;
            produto.Categoria = txtCategoria.Text;
            produto.Descricao = txtDescricaoProduto.Text;
            produto.ImagemLink = txtLinkImagem.Text;
            produto.Preco = txtPreco.Text;
            produto.Estoque = txtEstoque.Text;
            produto.Status = (StatusEnum)cmbStatus.SelectedIndex;

        }
    }
}
