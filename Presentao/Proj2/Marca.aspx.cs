using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proj2
{
    public partial class Marca : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            UpdateGrid();
        }

        protected void UpdateGrid()
        {
            Model.Marca m = new Model.Marca();
            gridMarca.DataSource = m.Find();
            gridMarca.DataBind();
        }

        protected void Save(object sender, EventArgs e)
        {
            Model.Marca m = new Model.Marca();
            m.Descricao = descricao.Text;
            m.Save();
            UpdateGrid();
            descricao.Text = "";
            descricao.Focus();
        }

        protected void Delete(object sender, EventArgs e)
        {
            Model.Marca m = new Model.Marca();
            m.Id = Convert.ToInt32(idelete.Text);
            m.Delete();
            UpdateGrid();
            idelete.Text = "";
            idelete.Focus();
        }
    }
}