using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proiect_BD
{
    public partial class _Default : Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach (var c in DataLayer.Class1.get_Administratori())
                s = c.Nume + " " + s;
                Label1.Text = s;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            string s = "";
            foreach (var c in DataLayer.Class1.get_CDT_comp())
                s = c.Nume + " " + s;
            Label2.Text = s;
        }
    }
}