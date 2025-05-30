﻿using Dapper;
using MultiApps.Models.Entidades;
using MultiApps.Models.Enum;
using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace MultiApps.Models.Repositories
{
    public class UsuarioRepository
    {
        public string ConnectionString = "Server=localhost;Database=cadastro_dev; Uid=root;Pwd=root";

        public bool CadastrarUsuario(Usuario usuario)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"INSERT INTO usuario (nome, cpf, email, senha, status)
                                   VALUES (@Nome, @Cpf, @Email, @Senha, @Status)";

                var parametros = new DynamicParameters();
                parametros.Add("@Nome", usuario.Nome);
                parametros.Add("@Cpf", usuario.Cpf);
                parametros.Add("@Email", usuario.Email);
                parametros.Add("@Senha", usuario.Senha);
                parametros.Add("@Status", usuario.Status);

                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;
            }
        }
        public List<Usuario> ListarTodosUsuarios()
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id, nome, cpf, email, senha, data_cadastro AS DataCadastro, data_ultimoacesso AS DataUltimoAcesso, status AS Status FROM usuario";
                var resultado = db.Query<Usuario>(comandoSql).ToList();
                return resultado;
            }
        }

        public bool DeletarUsuario(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"DELETE FROM usuario WHERE id = @Id";

                var parametros = new DynamicParameters();
                parametros.Add("@Id", id);

                var resultado = db.Execute(comandoSql, parametros);
                return resultado > 0;
            }
        }

        public bool AtualizarUsuario(Usuario usuario)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"UPDATE usuario SET nome = @Nome, cpf = @Cpf, email = @Email, senha = @Senha, status = @Status WHERE id = @Id";

                var parametros = new DynamicParameters();
                parametros.Add("@Id", usuario.Id);
                parametros.Add("@Nome", usuario.Nome);
                parametros.Add("@Cpf", usuario.Cpf);
                parametros.Add("@Email", usuario.Email);
                parametros.Add(@"Senha", usuario.Senha);
                parametros.Add("@Status", usuario.Status);

                var resposta = db.Execute(comandoSql, parametros);
                return resposta > 0;
            }
        }

        public Usuario ObterUsuario(int id)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id, nome, cpf, email, senha, data_cadastro AS DataCadastro, data_ultimoacesso AS DataUltimoAcesso, status AS Status FROM usuario WHERE id = @Id";
                var parametros = new DynamicParameters();
                parametros.Add("@Id", id);

                var resultado = db.Query<Usuario>(comandoSql, parametros).FirstOrDefault();
                return resultado;
            }
        }

        public List<Usuario> FiltrarUsuariosAtivos()
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var usuario = new Usuario();

                var comandoSql = @"SELECT id, nome, cpf, email, senha, data_cadastro AS DataCadastro, data_ultimoacesso AS DataUltimoAcesso, status AS Status 
                           FROM usuario 
                           WHERE status = 'ativo'";

                var resultado = db.Query<Usuario>(comandoSql).ToList();
                return resultado;
            }
        }

        public bool EmailJaExiste(string email)
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = "SELECT COUNT(*) FROM usuario WHERE email = @Email";
                var parametros = new DynamicParameters();
                parametros.Add("@Email", email);
                var resultado = db.ExecuteScalar<int>(comandoSql, parametros);
                return resultado > 0;
            }
        }

        public DataTable ListarUsuarios()
        {
            using (IDbConnection db = new MySqlConnection(ConnectionString))
            {
                var comandoSql = @"SELECT id AS Id, 
                                          nome AS Nome, 
                                          cpf AS Cpf, 
                                          email AS Email, 
                                          data_cadastro AS DataCadastro,
                                          data_alteracao AS DataAlteracao,
                                          data_ultimoacesso AS DataUltimoAcesso     
                                   FROM usuario";
                var usuarios = db.Query<Usuario>(comandoSql).ToList();
                // Converte a lista de usuários para um DataTable
                var dataTable = new DataTable();
                dataTable.Columns.Add("Id", typeof(int));
                dataTable.Columns.Add("Nome", typeof(string));
                dataTable.Columns.Add("Cpf", typeof(string));
                dataTable.Columns.Add("Email", typeof(string));
                dataTable.Columns.Add("Data Cadastro", typeof(DateTime));
                dataTable.Columns.Add("Data Alteracao", typeof(DateTime));
                dataTable.Columns.Add("Data Ultimo Acesso", typeof(DateTime));
                foreach (var usuario in usuarios)
                {
                    dataTable.Rows.Add(usuario.Id,
                        usuario.Nome,
                        usuario.Cpf,
                        usuario.Email,
                        usuario.DataCriacao,
                        usuario.DataAlteracao,
                        usuario.DataUltimoAcesso);
                }
                return dataTable;
            }
        }

            public DataTable ListarUsuariosPorStatus(int status)
            {
                using (IDbConnection db = new MySqlConnection(ConnectionString))
                {
                    var comandoSql = @"SELECT id AS Id, 
                                          nome AS Nome, 
                                          cpf AS Cpf, 
                                          email AS Email, 
                                          data_cadastro AS DataCadastro,
                                          data_alteracao AS DataAlteracao,
                                          data_ultimoacesso AS DataUltimoAcesso     
                                   FROM usuario
                                   WHERE status = @Status";

                    var parametros = new DynamicParameters();
                    parametros.Add("@Status", status);

                    var usuarios = db.Query<Usuario>(comandoSql, parametros).ToList();
                    // Converte a lista de usuários para um DataTable
                    var dataTable = new DataTable();
                    dataTable.Columns.Add("Id", typeof(int));
                    dataTable.Columns.Add("Nome", typeof(string));
                    dataTable.Columns.Add("Cpf", typeof(string));
                    dataTable.Columns.Add("Email", typeof(string));
                    dataTable.Columns.Add("Data Cadastro", typeof(DateTime));
                    dataTable.Columns.Add("Data Alteracao", typeof(DateTime));
                    dataTable.Columns.Add("Data Ultimo Acesso", typeof(DateTime));
                    foreach (var usuario in usuarios)
                    {
                        dataTable.Rows.Add(usuario.Id,
                            usuario.Nome,
                            usuario.Cpf,
                            usuario.Email,
                            usuario.DataCriacao,
                            usuario.DataAlteracao,
                            usuario.DataUltimoAcesso);
                    }
                    return dataTable;
                }
            }

            public Usuario ObterUsuarioPorEmail(string email)
            {
                using (IDbConnection db = new MySqlConnection(ConnectionString))
                {
                    var comandoSql = @"SELECT 
                                        id AS Id, 
                                        nome AS Nome,
                                        email AS Email,
                                        senha AS Senha,
                                        status AS Status
                                        FROM usuario 
                                        WHERE email = @Email";
                    var parametros = new DynamicParameters();
                    parametros.Add("@Email", email);
                    var resultado = db.Query<Usuario>(comandoSql, parametros).FirstOrDefault();
                    return resultado;
                }
            }

            public bool AtualizarSenha(string novaSenha, string email)
            {
                using (IDbConnection db = new MySqlConnection(ConnectionString))
                {
                    var comandoSql = @"UPDATE usuario
                                       SET senha = @Senha
                                       WHERE email = @Email";
                    
                    var parametros = new DynamicParameters();
                    parametros.Add("@Senha", novaSenha);
                    parametros.Add("@Email", email);

                    var resposta = db.Execute(comandoSql, parametros);
                    return resposta > 0;
                }
            }
        }
    }
