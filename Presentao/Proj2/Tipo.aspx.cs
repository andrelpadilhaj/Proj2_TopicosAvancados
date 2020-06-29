using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proj2
{
    public partial class Tipo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        protected void UpdateGrid()
        {
            Model.Tipo t = new Model.Tipo();
            gridTipo.DataSource = t.Find();
            gridTipo.DataBind();
        }

        protected void Save(object sender, EventArgs e)
        {
            Model.Tipo t = new Model.Tipo();
            t.Descricao = descricao.Text;
            t.Save();
            descricao.Text = "";
            UpdateGrid();
        }

        protected void Delete(object sender, EventArgs e)
        {
            Model.Tipo p = new Model.Tipo();
            p.Id = Convert.ToInt32(idelete.Text);
            p.Delete();
            UpdateGrid();
            idelete.Text = "";
            idelete.Focus();
        }
    }
}