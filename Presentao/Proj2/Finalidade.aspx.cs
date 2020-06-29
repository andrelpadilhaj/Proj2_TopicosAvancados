using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proj2
{
    public partial class Finalidade : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        protected void UpdateGrid()
        {
            Model.Finalidade f = new Model.Finalidade();
            gridFinalidade.DataSource = f.Find();
            gridFinalidade.DataBind();
        }

        protected void Save(object sender, EventArgs e)
        {
            Model.Finalidade f = new Model.Finalidade();
            f.Descricao = descricao.Text;
            f.Origem = origem.Text;
            f.Save();
            UpdateGrid();
            descricao.Text = "";
            origem.Text = "";
            descricao.Focus();
        }

        protected void Delete(object sender, EventArgs e)
        {
            Model.Finalidade f = new Model.Finalidade();
            f.Id = Convert.ToInt32(idelete.Text);
            f.Delete();
            UpdateGrid();
            idelete.Text = "";
            idelete.Focus();
        }
    }
}