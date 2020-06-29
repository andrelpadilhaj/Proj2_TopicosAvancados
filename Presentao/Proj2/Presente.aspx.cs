using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proj2
{
    public partial class Presente : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                RefreshFields();
            }
        }

        private void RefreshFields()
        {
            LoadTipo();
            LoadMarca();
            LoadFinalidade();
            LoadFornecedor();
            UpdateGrid();
        }

        private void LoadTipo()
        {
            Model.Tipo t = new Model.Tipo();

            tipo.DataSource = t.Find();
            tipo.DataTextField = "Descricao";
            tipo.DataValueField = "Id";
            tipo.DataBind();
        }

        private void LoadMarca()
        {
            Model.Marca m = new Model.Marca();
            marca.DataTextField = "Descricao";
            marca.DataValueField = "Id";
            marca.DataSource = m.Find();
            marca.DataBind();
        }

        private void LoadFinalidade()
        {
            Model.Finalidade f = new Model.Finalidade();

            finalidade.DataSource = f.Find();
            finalidade.DataTextField = "GetCoreData";
            finalidade.DataValueField = "Id";
            finalidade.DataBind();
        }

        private void LoadFornecedor()
        {
            Model.Fornecedor f = new Model.Fornecedor();
            fornecedor.DataSource = f.Find();
            fornecedor.DataTextField = "GetCoreData";
            fornecedor.DataValueField = "Id";
            fornecedor.DataBind();
        }

        private void LimparCampos()
        {
            descricao.Text = "";
            cor.Text = "";
            tamanho.Text = "";
            preco.Text = "";
            idelete.Text = "";
        }

        protected void UpdateGrid()
        {
            Model.Presente p = new Model.Presente();
            gridPessoas.DataSource = p.Find();
            gridPessoas.DataBind();
        }

        protected void Save(object sender, EventArgs e)
        {
            Model.Presente p = new Model.Presente();
            p.Descricao = descricao.Text;
            p.Tipo = Convert.ToInt32(tipo.SelectedValue);
            p.Marca = Convert.ToInt32(marca.SelectedValue);
            p.Finalidade = Convert.ToInt32(finalidade.SelectedValue);
            p.Cor = cor.Text;
            p.Tamanho = Convert.ToDouble(tamanho.Text);
            p.Preco = Convert.ToDouble(preco.Text);
            p.Fornecedor = Convert.ToInt32(fornecedor.SelectedValue);
            p.Save();
            RefreshFields();
            LimparCampos();
            descricao.Focus();
        }

        protected void Delete(object sender, EventArgs e)
        {
            Model.Presente p = new Model.Presente();
            p.Id = Convert.ToInt32(idelete.Text);
            p.Delete();
            RefreshFields();
            LimparCampos();
            idelete.Focus();
        }
    }
}