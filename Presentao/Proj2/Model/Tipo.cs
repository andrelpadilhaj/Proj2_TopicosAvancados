using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace Proj2.Model
{
    public class Tipo
    {
        public int Id { get; set; }
        public string Descricao { get; set; }

        public bool Save()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PresentaoDB")))
            {
                try
                {
                    connection.Execute($"INSERT INTO TIPO (DESCRICAO) " +
                                       $"VALUES ('{ this.Descricao }');");
                    return true;
                }
                catch (SqlException)
                {
                    return false;
                }
            }
        }

        public List<Tipo> Find()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PresentaoDB")))
            {
                return connection.Query<Tipo>($"SELECT Id, Descricao " +
                                              $"FROM TIPO;").ToList();
            }
        }

        public List<Tipo> Find(int Id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PresentaoDB")))
            {
                return connection.Query<Tipo>($"SELECT Id, Descricao " +
                                              $"FROM TIPO " +
                                              $"WHERE Id = { Id };").ToList();
            }
        }

        public List<Tipo> Find(string descricao)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PresentaoDB")))
            {
                return connection.Query<Tipo>($"SELECT Id, Descricao " +
                                              $"FROM TIPO " +
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
                                       $"WHERE TIPO = { this.Id };");
                    connection.Execute($"DELETE FROM TIPO " +
                                       $"WHERE Id = { this.Id };");
                    return true;
                }
                catch (SqlException e)
                {
                    return false;
                }
            }
        }
    }
}