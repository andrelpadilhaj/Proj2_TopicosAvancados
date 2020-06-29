using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace Proj2.Model
{
    public class Presente
    {
        public int Id { get; set; }
        public string Descricao { get; set; }
        public int Tipo { get; set; }
        public int Marca { get; set; }
        public int Finalidade { get; set; }
        public string Cor { get; set; }
        public double Tamanho { get; set; }
        public double Preco { get; set; }
        public int Fornecedor { get; set; }

        public bool Save()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PresentaoDB")))
            {
                try
                {
                    connection.Execute($"INSERT INTO PRESENTE (DESCRICAO, TIPO, MARCA, FINALIDADE, COR, TAMANHO, PRECO, FORNECEDOR) " +
                                       $"VALUES ('{ this.Descricao }', { this.Tipo }, { this.Marca }, { this.Finalidade }, '{ this.Cor }', { this.Tamanho }, { this.Preco.ToString().Replace(",", ".") }, { this.Fornecedor });");
                    return true;
                }
                catch (SqlException e)
                {
                    return false;
                }
            }
        }

        public List<Presente> Find()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PresentaoDB")))
            {
                return connection.Query<Presente>($"SELECT Id, Descricao, Tipo, Marca, Finalidade, Cor, Tamanho, Preco, Fornecedor " +
                                                  $"FROM PRESENTE;").ToList();
            }
        }

        public List<Presente> Find(int Id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PresentaoDB")))
            {
                return connection.Query<Presente>($"SELECT Id, Descricao, Tipo, Marca, Finalidade, Cor, Tamanho, Preco, Fornecedor " +
                                                  $"FROM PRESENTE " +
                                                  $"WHERE Id = { Id };").ToList();
            }
        }

        public List<Presente> Find(string descricao)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PresentaoDB")))
            {
                return connection.Query<Presente>($"SELECT Id, Descricao, Tipo, Marca, Finalidade, Cor, Tamanho, Preco, Fornecedor " +
                                                  $"FROM PRESENTE " +
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
                catch (SqlException e)
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