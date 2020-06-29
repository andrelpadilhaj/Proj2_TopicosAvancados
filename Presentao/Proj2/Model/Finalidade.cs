using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace Proj2.Model
{
    public class Finalidade
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public string Origem { get; set; }

        public string GetCoreData
        {
            get
            {
                return $"{this.Descricao} - {this.Origem}";
            }
        }

        public bool Save()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PresentaoDB")))
            {
                try
                {
                    connection.Execute($"INSERT INTO FINALIDADE (DESCRICAO, ORIGEM) " +
                                       $"VALUES ('{ this.Descricao }', " +
                                       $"'{ this.Origem }');");
                    return true;
                } catch(SqlException e)
                {
                    System.Console.WriteLine(e);
                    return false;
                }
            }
        }

        public List<Finalidade> Find()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PresentaoDB")))
            {
                return connection.Query<Finalidade>($"SELECT Id, Descricao, Origem " +
                                                    $"FROM FINALIDADE;").ToList();
            }
        }

        public List<Finalidade> Find(int Id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PresentaoDB")))
            {
                return connection.Query<Finalidade>($"SELECT Id, Descricao, Origem " +
                                                    $"FROM FINALIDADE" +
                                                    $"WHERE Id = { Id };").ToList();
            }
        }

        public List<Finalidade> Find(string descricao)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PresentaoDB")))
            {
                return connection.Query<Finalidade>($"SELECT Id, Descricao, Origem " +
                                                    $"FROM FINALIDADE " +
                                                    $"WHERE Descricao LIKE '%{ descricao }%';").ToList();
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
                                       $"WHERE Finalidade = { this.Id }");
                    connection.Execute($"DELETE FROM FINALIDADE " +
                                       $"WHERE Id = { this.Id }");
                    return true;
                } catch (SqlException)
                {
                    return false;
                }
            }
        }
    }
}