using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proiect_BD
{
    public partial class AlocareD : System.Web.UI.Page
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
            GridView1.DataSource = BussinessLayer.clsBusiness_get_Articole_Drepturi.get_Articole_Drepturi().ToList();
            GridView1.DataBind();
        }
        protected void Edit(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindData();
            GridView1.Rows[e.NewEditIndex].Cells[3].Controls[0].Visible = false;
            GridView1.Rows[e.NewEditIndex].Cells[5].Controls[0].Visible = false;

        }
        protected void CancelEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView1.EditIndex = -1;
            BindData();
        }
        protected void Update(object sender, GridViewUpdateEventArgs e)
        {
            GridView1.Rows[e.RowIndex].RowState = DataControlRowState.Edit;

            string ID_Stud = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            string ID_Adm = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
            string Data = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text;
            string Savoniera = ((TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0]).Text;
            string Sapun = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            string Spumaras = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
            string Aparatras = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text;
            string Caiete = ((TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0]).Text;
            string Rigla = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            string Guma = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
            string Crema = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text;
            string Maieu = ((TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0]).Text;
            string Agrafe = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text;
            string Capsa = ((TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0]).Text;

           //if(BussinessLayer.clsBusiness_get_Articole_Drepturi.)
            GridView1.EditIndex = -1;

            GridView1.DataBind();
        }

        protected void Delete(object sender, GridViewDeleteEventArgs e)
        {
         
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (BussinessLayer.clsBusiness_get_Articole_Drepturi.insert_ArticoleDrepturi(Int32.Parse(TextBox1.Text), Int32.Parse(TextBox2.Text), DateTime.Parse(TextBox3.Text), Int32.Parse(TextBox4.Text), Int32.Parse(TextBox5.Text), Int32.Parse(TextBox6.Text), Int32.Parse(TextBox7.Text), Int32.Parse(TextBox8.Text), Int32.Parse(TextBox9.Text), Int32.Parse(TextBox10.Text), Int32.Parse(TextBox11.Text), Int32.Parse(TextBox12.Text), Int32.Parse(TextBox13.Text), Int32.Parse(TextBox14.Text)))
            {
                BindData();
                TextBox1.Text = String.Empty;
                TextBox2.Text = String.Empty;
                TextBox3.Text = String.Empty;
                TextBox4.Text = String.Empty;
                TextBox5.Text = String.Empty;
                TextBox6.Text = String.Empty;
                TextBox7.Text = String.Empty;
                TextBox8.Text = String.Empty;
                TextBox9.Text = String.Empty;
                TextBox10.Text = String.Empty;
                TextBox11.Text = String.Empty;
                TextBox12.Text = String.Empty;
                TextBox13.Text = String.Empty;
                TextBox14.Text = String.Empty;
            }
            else
                MessageBox.Show(Page, "Datele introduse nu sunt valide!");
               
        }
    }
}