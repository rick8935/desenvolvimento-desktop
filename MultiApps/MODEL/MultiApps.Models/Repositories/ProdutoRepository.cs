using Dapper;
using MultiApps.Models.Entidades;
using MultiApps.Models.Entidades.Abstract;
using MultiApps.Models.Enum;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiApps.Models.Repositories
{
    public class ProdutoRepository
    {
        public string ConnectionString = "Server=localhost;Database=gestao_produtos; Uid=root;Pwd=root";


        public bool AdicionarProduto(GestaoProdutos produto)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"INSERT INTO produto (nome, categoria, preco, quantidade_estoque, imagem, descricao, status)
                                   VALUES (@Nome, @Categoria, @Preco, @Estoque, @ImagemLink, @Descricao, @Status)";

                var parametros = new DynamicParameters();
                parametros.Add("@Nome", produto.Nome);
                parametros.Add("@Categoria", produto.Categoria);
                parametros.Add("@Preco", produto.Preco);
                parametros.Add("@Estoque", produto.Estoque);
                parametros.Add("@ImagemLink", produto.ImagemLink);
                parametros.Add("@Descricao", produto.Descricao);
                parametros.Add("@Status", produto.Status);

                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;
            }
        }

        public bool AtualizarProduto(GestaoProdutos produto)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"UPDATE produto SET nome = @Nome, categoria = @Categoria, preco = @Preco, quantidade_estoque = @Estoque, imagem = @ImagemLink,
                                   descricao = @Descricao, status = @Status
                                   WHERE id = @Id";

                var parametros = new DynamicParameters();
                parametros.Add("@Id", produto.Id);
                parametros.Add("@Nome", produto.Nome);
                parametros.Add("@Categoria", produto.Categoria);
                parametros.Add("@Preco", produto.Preco);
                parametros.Add("@Estoque", produto.Estoque);
                parametros.Add("@ImagemLink", produto.ImagemLink);
                parametros.Add("@Descricao", produto.Descricao);
                parametros.Add("@Status", produto.Status);

                var resposta = db.Execute(comandoSql, parametros);
                return resposta > 0;

            }
        }

        public bool DeletarProduto(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"DELETE FROM produto WHERE id = @Id";
                var parametros = new DynamicParameters();
                parametros.Add("@Id", id);

                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;
            }
        }

        public GestaoProdutos ObterProduto(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT nome, categoria, preco, quantidade_estoque AS Estoque, imagem, descricao, status AS Status FROM produto WHERE id = @Id";
                var parametros = new DynamicParameters();
                parametros.Add("@Id", id);

                var resultado = db.Query<GestaoProdutos>(comandoSql, parametros).FirstOrDefault();
                return resultado;
            }
        }

        public DataTable ListarProdutos()
        {
            using IDbConnection db = new MySqlConnection(ConnectionString);
            {
                var comandoSql = @"SELECT id, nome, categoria, preco, quantidade_estoque AS Estoque, imagem AS ImagemLink, descricao, status AS Status FROM produto";
                var produtos = db.Query<GestaoProdutos>(comandoSql).ToList();

                var dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("Nome", typeof(string));
                dataTable.Columns.Add("Categoria", typeof(string));
                dataTable.Columns.Add("Preço", typeof(string));
                dataTable.Columns.Add("Estoque", typeof(string));
                dataTable.Columns.Add("Imagem", typeof(string));
                dataTable.Columns.Add("Descrição", typeof(string));

                foreach (var produto in produtos)
                {
                    dataTable.Rows.Add(produto.Id,
                        produto.Nome,
                        produto.Categoria,
                        produto.Preco,
                        produto.Estoque,
                        produto.ImagemLink,
                        produto.Descricao);
                }
                return dataTable;
            }
        }

        public DataTable ListarProdutosPorStatus(int status)
        {
            using IDbConnection db = new MySqlConnection(ConnectionString);
            {
                var comandoSql = @"SELECT id, nome, categoria, preco, quantidade_estoque AS Estoque, imagem, descricao
                FROM produto WHERE status = @Status";

                var parametros = new DynamicParameters();
                parametros.Add("@Status", status);
                var produtos = db.Query<GestaoProdutos>(comandoSql, parametros).ToList();

                var dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("Nome", typeof(string));
                dataTable.Columns.Add("Categoria", typeof(string));
                dataTable.Columns.Add("Preço", typeof(string));
                dataTable.Columns.Add("Estoque", typeof(string));
                dataTable.Columns.Add("Imagem", typeof(string));
                dataTable.Columns.Add("Descrição", typeof(string));

                foreach (var produto in produtos)
                {
                    dataTable.Rows.Add(produto.Id,
                        produto.Nome,
                        produto.Categoria,
                        produto.Preco,
                        produto.Estoque,
                        produto.ImagemLink,
                        produto.Descricao);
                }
                return dataTable;
            }
        }

        public DataTable ListarProdutosPorCategoria(string categoria)
        {
            using IDbConnection db = new MySqlConnection(ConnectionString);
            {
                var comandoSql = @"SELECT id, nome, categoria, preco, quantidade_estoque AS Estoque, imagem, descricao, status AS Status FROM produto WHERE categoria = @Categoria";
                var parametros = new DynamicParameters();
                parametros.Add("@Categoria", categoria);
                var produtos = db.Query<GestaoProdutos>(comandoSql, parametros).ToList();

                var dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("Nome", typeof(string));
                dataTable.Columns.Add("Categoria", typeof(string));
                dataTable.Columns.Add("Preço", typeof(string));
                dataTable.Columns.Add("Estoque", typeof(string));
                dataTable.Columns.Add("Imagem", typeof(string));
                dataTable.Columns.Add("Descrição", typeof(string));

                foreach (var produto in produtos)
                {
                    dataTable.Rows.Add(produto.Id,
                        produto.Nome,
                        produto.Categoria,
                        produto.Preco,
                        produto.Estoque,
                        produto.ImagemLink,
                        produto.Descricao);
                }
                return dataTable;
            }
        }

        public List<string> ListarCategorias()
        {
            using IDbConnection db = new MySqlConnection(ConnectionString);
            {
                return db.Query<string>("SELECT DISTINCT categoria FROM produto").ToList();
            }
        }
    }
}
