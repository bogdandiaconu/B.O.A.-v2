using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proiect_BD
{
    public partial class Preturi : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                BindData();
            }
        }
        protected void BindData()
        {
            GridView1.DataSource = BussinessLayer.clsBusiness_get_Preturi.get_Preturi().ToList();
            GridView1.DataBind();
        }
        protected void Edit(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindData();
            GridView1.Rows[e.NewEditIndex].Cells[2].Controls[0].Visible = false;
        }
        protected void CancelEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindData();
        }
        protected void Update(object sender, GridViewUpdateEventArgs e)
        {
            GridView1.Rows[e.RowIndex].RowState = DataControlRowState.Edit;

            string ID = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            string Nume = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
            string Pret = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text;
            string Data = ((TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0]).Text;


            BussinessLayer.clsBusiness_get_Preturi.update_Pret(Int32.Parse(ID), Nume, Double.Parse(Pret), DateTime.Parse(Data));

        
            GridView1.EditIndex = -1;
            BindData();
        }

        protected void Delete(object sender, GridViewDeleteEventArgs e)
        {
          

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            double d;
            DateTime dd;
            Double.TryParse(TextBox2.Text, out d);
            DateTime.TryParse(TextBox3.Text, out dd);
            if (!Double.TryParse(TextBox2.Text, out d))
                MessageBox.Show(Page, "Pretul introdus nu este corect!");
            else if (!DateTime.TryParse(TextBox3.Text, out dd))
                MessageBox.Show(Page, "Data introdusa nu este corecta!");
            else
            {
                BussinessLayer.clsBusiness_get_Preturi.insert_Preturi(TextBox1.Text, Double.Parse(TextBox2.Text), DateTime.Parse(TextBox3.Text));
                TextBox1.Text = string.Empty;
                TextBox2.Text = string.Empty;
                TextBox3.Text = string.Empty;
                BindData();
            }

        }
    }
}