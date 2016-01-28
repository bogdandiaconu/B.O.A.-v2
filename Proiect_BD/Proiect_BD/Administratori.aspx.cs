using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataLayer;
namespace Proiect_BD
{
    public partial class Administratori : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            GridView1.DataSource = DataLayer.Models.Administratori.get_Administratori().ToList();
            GridView1.DataBind();
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
          // DataLayer.Models.Administratori.
        }
    }
}