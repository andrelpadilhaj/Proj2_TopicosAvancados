using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using Dapper;

namespace Proj2.Model
{
    public class Fornecedor
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public string Telefone { get; set; }
        public string Cidade { get; set; }
        public string Estado { get; set; }
        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string CNPJ { get; set; }
        public string Email { get; set; }
        public string Banco { get; set; }
        public string Agencia { get; set; }
        public string ContaCorrente { get; set; }

        public string GetCoreData
        {
            get
            {
                return $"{Nome} - {Cidade} - {Estado}";
            }
        }

        public bool Save()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PresentaoDB")))
            {
                try
                {
                    connection.Execute($"INSERT INTO FORNECEDOR (NOME, TELEFONE, CIDADE, ESTADO, LOGRADOURO, NUMERO, CNPJ, EMAIL, BANCO, AGENCIA, CONTACORRENTE) " +
                                       $"VALUES ('{ this.Nome }'," +
                                       $"'{ this.Telefone }', " +
                                       $"'{ this.Cidade }', " +
                                       $"'{ this.Estado }', " +
                                       $"'{ this.Logradouro }', " +
                                       $"'{ this.Numero }', " +
                                       $"'{ this.CNPJ }', " +
                                       $"'{ this.Email }', " +
                                       $"'{ this.Banco }', " +
                                       $"'{ this.Agencia }', " +
                                       $"'{ this.ContaCorrente }');");
                    return true;
                }
                catch (SqlException e)
                {
                    return false;
                }
            }
        }

        public List<Fornecedor> Find()
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PresentaoDB")))
            {
                return connection.Query<Fornecedor>($"SELECT ID, NOME, TELEFONE, CIDADE, ESTADO, LOGRADOURO, NUMERO, CNPJ, EMAIL, BANCO, AGENCIA, CONTACORRENTE " +
                                                    $"FROM FORNECEDOR;").ToList();
            }
        }

        public List<Fornecedor> Find(int Id)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PresentaoDB")))
            {
                return connection.Query<Fornecedor>($"SELECT ID, NOME, TELEFONE, CIDADE, ESTADO, LOGRADOURO, NUMERO, CNPJ, EMAIL, BANCO, AGENCIA, CONTACORRENTE " +
                                                    $"FROM FORNECEDOR " +
                                                    $"WHERE Id = { Id };").ToList();
            }
        }

        public List<Fornecedor> Find(string nome)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PresentaoDB")))
            {
                return connection.Query<Fornecedor>($"SELECT ID, NOME, TELEFONE, CIDADE, ESTADO, LOGRADOURO, NUMERO, CNPJ, EMAIL, BANCO, AGENCIA, CONTACORRENTE " +
                                                    $"FROM FORNECEDOR " +
                                                    $"WHERE NOME LIKE '%{ nome }%';").ToList();
            }
        }

        public List<Fornecedor> Find(string nome, string cidade, string estado)
        {
            using (IDbConnection connection = new System.Data.SqlClient.SqlConnection(Helper.CnnVal("PresentaoDB")))
            {
                return connection.Query<Fornecedor>($"SELECT ID, NOME, TELEFONE, CIDADE, ESTADO, LOGRADOURO, NUMERO, CNPJ, EMAIL, BANCO, AGENCIA, CONTACORRENTE " +
                                                    $"FROM FORNECEDOR " +
                                                    $"WHERE NOME LIKE '%{ nome }%' " +
                                                    $"AND CIDADE LIKE '%{ cidade }%'" +
                                                    $"AND ESTADO LIKE '%{ estado }%';").ToList();
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
                                       $"WHERE Fornecedor = { this.Id }");
                    connection.Execute($"DELETE FROM FORNECEDOR " +
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