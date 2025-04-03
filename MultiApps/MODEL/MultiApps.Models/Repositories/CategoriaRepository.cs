using Dapper;
using MultiApps.Models.Entidades;
using MySql.Data.MySqlClient;
using System.Data;

namespace MultiApps.Models.Repositories
{
    public class CategoriaRepository
    {
        public string connectionString = "Server=localhost;Database=multiapps_dev;Uid=root;Pwd=root";

        public bool cadastrarCategoria(Categoria categoria)
        {
            using (IDbConnection db = new MySqlConnection(connectionString))
            {
                var comandoSql = @"INSERT INTO categoria (nome, status) VALUES (@nome, @status)";

                var parametro = new DynamicParameters();
                parametro.Add("@nome", categoria.Nome);
                parametro.Add("@status", categoria.Status);
                            
                var resultado = db.Execute(comandoSql, parametro);
                return resultado > 0;
            }
        }
    }
}
