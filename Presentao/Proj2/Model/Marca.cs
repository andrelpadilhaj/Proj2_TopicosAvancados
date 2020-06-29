using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace Proj2.Model
{
    public class Marca
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public string GetCoreData
        {
            get
            {
                return $"{Descricao}";
            }
        }

        public bool Save()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PresentaoDB")))
            {
                try
                {
                    connection.Execute($"INSERT INTO MARCA (DESCRICAO) " +
                                       $"VALUES ('{ this.Descricao }');");
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }

        public void FindAll()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PresentaoDB")))
            {

            }
        }

        public List<Marca> Find()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PresentaoDB")))
            {
                return connection.Query<Marca>($"SELECT Id, Descricao " +
                                               $"FROM MARCA;").ToList();
            }
        }

        public List<Marca> Find(int Id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PresentaoDB")))
            {
                return connection.Query<Marca>($"SELECT Id, Descricao " +
                                               $"FROM MARCA " +
                                               $"WHERE Id = { Id };").ToList();
            }
        }

        public List<Marca> Find(string descricao)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PresentaoDB")))
            {
                return connection.Query<Marca>($"SELECT Id, Descricao " +
                                               $"FROM MARCA " +
                                               $"WHERE Descricao = '{ descricao }';").ToList();
            }
        }

        public bool Update()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PresentaoDB")))
            {
                try
                {
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }

        public bool Delete()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PresentaoDB")))
            {
                try
                {
                    connection.Execute($"DELETE FROM PRESENTE " +
                                       $"WHERE Marca = { this.Id }");
                    connection.Execute($"DELETE FROM MARCA " +
                                       $"WHERE Id = { this.Id }");
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }
    }
}