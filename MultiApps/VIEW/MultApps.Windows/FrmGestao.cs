using MultApps.Models.Repositories;
using MultiApps.Models.Entidades;
using MultiApps.Models.Enum;
using MultiApps.Models.Repositories;
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
            CarregarProdutos();
            var status = new[] { "inativo", "ativo" };
            var filtros = new[] { "todos", "ativos", "inativos" };
            cmbStatus.Items.AddRange(status);
            cmbFiltro.Items.AddRange(filtros);

            cmbStatus.SelectedIndex = 1;
            cmbFiltro.SelectedIndex = 0;
        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {
            try
            {
                if(TemCamposEmBranco())
                {
                    return;
                }

                var produto = new GestaoProdutos();

                produto.Nome = txtNomeProduto.Text;
                produto.Categoria = txtCategoria.Text;
                produto.Descricao = txtDescricaoProduto.Text;
                produto.ImagemLink = txtLinkImagem.Text;
                produto.Preco = txtPreco.Text;
                produto.Estoque = txtEstoque.Text;
                produto.Status = (StatusEnum)cmbStatus.SelectedIndex;

                var produtoRepository = new ProdutoRepository();
            }
            catch (Exception exception)
            {
                MessageBox.Show(Convert.ToString(exception));
                throw;
            }      
        }

        private bool TemCamposEmBranco()
        {
            if (string.IsNullOrEmpty(txtNomeProduto.Text))
            {
                MessageBox.Show("Campo nome é obrigatório");
                txtNomeProduto.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(txtCategoria.Text))
            {
                MessageBox.Show("Campo categoria é obrigatório");
                txtCategoria.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(txtEstoque.Text))
            {
                MessageBox.Show("Campo estoque é obrigatório");
                txtEstoque.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(txtPreco.Text))
            {
                MessageBox.Show("Campo preço é obrigatório");
                txtPreco.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(txtLinkImagem.Text))
            {
                MessageBox.Show("Campo imagem é obrigatório");
                txtLinkImagem.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(txtDescricaoProduto.Text))
            {
                MessageBox.Show("Campo descrição é obrigatório");
                txtDescricaoProduto.Focus();
                return true;
            }
            return false;
        }

        private void btnExcluir_Click(object sender, EventArgs e)
        {
            var produtoRepository = new ProdutoRepository();
            var produtoId = int.Parse(txtId.Text);

            var sucesso = produtoRepository.DeletarProduto(produtoId);

            if (sucesso)
            {
                MessageBox.Show("Produto excluido com sucesso");
                CarregarProdutos();
            }
            else
            {
                MessageBox.Show("Não foi possivel excluir o produto " + txtNomeProduto);
            }

            btnExcluir.Enabled = false;
        }

        private void btnLimpar_Click(object sender, EventArgs e)
        {
            txtNomeProduto.Text = string.Empty;
            txtCategoria.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtEstoque.Text = string.Empty;
            txtDescricaoProduto.Text = string.Empty;
            txtLinkImagem.Text = string.Empty;
            txtId.Text = string.Empty;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show($"Houve um erro ao clicar duas vezes sobre o Grid");
                return;
            }

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            var produtoId = (int)row.Cells[0].Value;

            var produtoRepository = new ProdutoRepository();
            var produto = produtoRepository.ObterProduto(produtoId);

            if (produto == null)
            {
                MessageBox.Show($"Usuario: #{produtoId} não encontrado");
                return;
            }

            txtId.Text = produtoId.ToString();
            txtNomeProduto.Text = produto.Nome;
            txtCategoria.Text = produto.Categoria;
            txtLinkImagem.Text = produto.ImagemLink;
            txtEstoque.Text = produto.Estoque;
            txtPreco.Text = produto.Preco;
            txtDescricaoProduto.Text = produto.Descricao;
            cmbStatus.SelectedIndex = (int)produto.Status;

            btnSalvar.Text = "Atualizar produto";
            btnExcluir.Enabled = true;
        }

        private void CarregarProdutos()
        {
            var produtoRepository = new ProdutoRepository();

            var listaProdutos = produtoRepository.ListarProdutos();
            dataGridView1.DataSource = listaProdutos;
        }

        private void LimparCampos()
        {
            txtNomeProduto.Text = string.Empty;
            txtCategoria.Text = string.Empty;
            txtPreco.Text = string.Empty;
            txtEstoque.Text = string.Empty;
            txtDescricaoProduto.Text = string.Empty;
            txtLinkImagem.Text = string.Empty;
            txtId.Text = string.Empty;
        }

        private void cmbFiltro_SelectedIndexChanged(object sender, EventArgs e)
        {
            var produtoRepository = new ProdutoRepository();

            switch (cmbFiltro.SelectedIndex)
            {
                case 0:
                    CarregarProdutos();
                    break;
                case 1:
                    var produtosAtivos = produtoRepository.ListarProdutosPorStatus(1);
                    dataGridView1.DataSource = produtosAtivos;
                    break;
                case 2:
                    var produtosInativos = produtoRepository.ListarProdutosPorStatus(0);
                    dataGridView1.DataSource = produtosInativos;
                    break;
            }
        }

        private void cmbCategoria_SelectedIndexChanged(object sender, EventArgs e)
        {
            var produtoRepository = new ProdutoRepository();
            var categoriaSelecionada = cmbCategoria.SelectedIndex.ToString();

            dataGridView1.DataSource = produtoRepository.ListarProdutosPorCategoria(categoriaSelecionada);
        }

        private void FrmGestao_Load(object sender, EventArgs e)
        {
            var produto = new GestaoProdutos();

            var categoriaFiltro = new[] { produto.Categoria };
            cmbCategoria.Items.AddRange(categoriaFiltro);
        }
    }
}
