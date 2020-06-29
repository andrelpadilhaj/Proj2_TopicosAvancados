using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proj2
{
    public partial class Home : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        protected void UpdateGrid()
        {
            Model.Fornecedor f = new Model.Fornecedor();
            gridFornecedor.DataSource = f.Find();
            gridFornecedor.DataBind();
        }

        protected void ClearFields()
        {
            nome.Text = "";
            telefone.Text = "";
            cidade.Text = "";
            estado.Text = "";
            logradouro.Text = "";
            numero.Text = "";
            cnpj.Text = "";
            email.Text = "";
            banco.Text = "";
            agencia.Text = "";
            contaCorrente.Text = "";
        }

        protected void Save(object sender, EventArgs e)
        {
            Model.Fornecedor f = new Model.Fornecedor();
            f.Nome = nome.Text;
            f.Telefone = telefone.Text;
            f.Cidade = cidade.Text;
            f.Estado = estado.Text;
            f.Logradouro = logradouro.Text;
            f.Numero = numero.Text;
            f.CNPJ = cnpj.Text;
            f.Email = email.Text;
            f.Banco = banco.Text;
            f.Agencia = agencia.Text;
            f.ContaCorrente = contaCorrente.Text;
            f.Save();
            UpdateGrid();
            ClearFields();
            nome.Focus();
        }

        protected void Delete(object sender, EventArgs e)
        {
            Model.Fornecedor f = new Model.Fornecedor();
            f.Id = Convert.ToInt32(idelete.Text);
            f.Delete();
            UpdateGrid();
            idelete.Text = "";
            idelete.Focus();
        }
    }
}