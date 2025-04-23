using MultApps.Models.Repositories;
using MultApps.Windows;
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
    public partial class FrmCadastro : Form
    {
        public FrmCadastro()
        {
            InitializeComponent();
            var status = new[] { "inativo", "ativo" };
            var filtros = new[] { "todos", "ativos", "inativos" };
            cmbStatus.Items.AddRange(status);
            cmbFiltrar.Items.AddRange(filtros);
            
            cmbStatus.SelectedIndex = 1;

            CarregarTodosUsuarios();
        }

        private void btnCadastrar_Click(object sender, EventArgs e)
        {
            try
            {
                if (TemCamposEmBranco())
                {
                    return;
                }
                var usuario = new Usuario();
                usuario.Nome = txtNome.Text;
                usuario.Cpf = txtCpf.Text;
                usuario.Email = txtEmail.Text;
                usuario.Senha = txtSenha.Text;
                usuario.Status = (StatusEnum)cmbStatus.SelectedIndex;

                var usuarioRepository = new UsuarioRepository();

                var emailExistente = usuarioRepository.EmailJaExiste(usuario.Email);
                if(emailExistente)
                {
                    MessageBox.Show($"O email {usuario.Email} já está cadastrado.");
                }

                if (string.IsNullOrEmpty(txtId.Text))
                {
                    var resultado = usuarioRepository.CadastrarUsuario(usuario);
                    if (resultado)
                    {
                        MessageBox.Show("Categoria cadastrada com sucesso");
                    }
                    else
                    {
                        MessageBox.Show("Erro ao cadastrar categoria");
                    }
                }
                else
                {
                    usuario.Id = int.Parse(txtId.Text);
                    var resultado = usuarioRepository.AtualizarUsuario(usuario);

                    if (resultado)
                    {
                        MessageBox.Show("Categoria atualizada com sucesso");
                        btnCadastrar.Text = "Cadastrar";
                    }
                    else
                    {
                        MessageBox.Show("Erro ao atualizar categoria");
                    }
                }

                CarregarTodosUsuarios();
            }
            catch (Exception)
            {

                throw;
            }
        }

        private bool TemCamposEmBranco()
        {
            if (string.IsNullOrEmpty(txtNome.Text))
            {
                MessageBox.Show("Campo nome é obrigatório");
                txtNome.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Campo email é obrigatório");
                txtEmail.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(txtCpf.Text))
            {
                MessageBox.Show("Campo CPF é obrigatório");
                txtCpf.Focus();
                return true;
            }
            if (string.IsNullOrEmpty(txtSenha.Text))
            {
                MessageBox.Show("Campo senha é obrigatório");
                txtSenha.Focus();
                return true;
            }
            return false; 
        }

        private void btnDeletar_Click(object sender, EventArgs e)
        {
            var usuarioId = int.Parse(txtId.Text);

            var usuarioRepository = new UsuarioRepository();
            var sucesso = usuarioRepository.DeletarUsuario(usuarioId);

            if (sucesso)
            {
                MessageBox.Show("Categoria deletada com sucesso");
                CarregarTodosUsuarios();
            }
            else
            {
                MessageBox.Show("Não foi possível deletar a categoria" + txtNome.Text);
            }

            btnDeletar.Enabled = false;
        }

        private void dataGridView1_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridView1.Columns[e.ColumnIndex].DataPropertyName == "Status")
            {
                if (e.Value != null)
                {
                    StatusEnum status = (StatusEnum)e.Value;
                    switch (status)
                    {
                        case StatusEnum.Inativo:
                            e.CellStyle.ForeColor = Color.Gray;
                            break;
                        case StatusEnum.Ativo:
                            e.CellStyle.ForeColor = Color.Blue;
                            break;
                        case StatusEnum.Todos:
                            e.CellStyle.ForeColor = Color.Red;
                            break;
                    }
                }
            }
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex < 0)
            {
                MessageBox.Show($"Houve um erro ao clicar duas vezes sobre o Grid");
                return;
            }

            DataGridViewRow row = dataGridView1.Rows[e.RowIndex];

            var usuarioId = (int)row.Cells[0].Value;

            var usuarioRepository = new UsuarioRepository();
            var usuario = usuarioRepository.ObterUsuario(usuarioId);

            if (usuario == null)
            {
                MessageBox.Show($"Usuario: #{usuarioId} não encontrado");
                return;
            }

            txtId.Text = usuarioId.ToString();
            txtNome.Text = usuario.Nome;
            txtSenha.Text = "*****";
            txtEmail.Text = usuario.Email;
            txtCpf.Text = usuario.Cpf;
            cmbStatus.SelectedIndex = (int)usuario.Status;
            txtDataCadastro.Text = usuario.DataCadastro.ToString("dd/MM/yyyy HH:mm");
            txtUltimoAcesso.Text = usuario.DataUltimoAcesso.ToString("dd/MM/yyyy HH:mm");

            btnCadastrar.Text = "Atualizar cadastro";
            btnDeletar.Enabled = true;
        }

        private void FrmCadastro_Load(object sender, EventArgs e)
        {
            CarregarTodosUsuarios();
        }

        private void CarregarTodosUsuarios()
        {
            var usuarioRepository = new UsuarioRepository();

            var listaUsuario = usuarioRepository.ListarUsuarios();
            dataGridView1.DataSource = listaUsuario;
        }

        private void LimparCampos()
        {
            txtCpf.Text = string.Empty;
            txtNome.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtSenha.Text = string.Empty;
            cmbStatus.SelectedIndex = 1;
            txtDataCadastro.Text = string.Empty;
            txtUltimoAcesso.Text = string.Empty;
        }
    }
}
