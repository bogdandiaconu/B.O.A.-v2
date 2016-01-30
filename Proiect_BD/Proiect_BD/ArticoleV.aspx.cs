using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proiect_BD
{
    public partial class AlocareV : System.Web.UI.Page
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
            GridView1.DataSource = BussinessLayer.clsBusiness_get_ArticoleVest.get_ArticoleVest().ToList();
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

            string ID = ((TextBox)GridView1.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            string Nume = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
            string Prenume = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text;
            string ID_Grad = ((TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0]).Text;

          
            GridView1.EditIndex = -1;

            GridView1.DataBind();
        }

        protected void Delete(object sender, GridViewDeleteEventArgs e)
        {
            
          
        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if(BussinessLayer.clsBusiness_get_ArticoleVest.insert_ArticoleVest(Int32.Parse(TextBox10.Text), Int32.Parse(TextBox11.Text), DateTime.Parse(TextBox12.Text), Int32.Parse(TextBox1.Text), Int32.Parse(TextBox2.Text), Int32.Parse(TextBox3.Text), Int32.Parse(TextBox4.Text), Int32.Parse(TextBox5.Text), Int32.Parse(TextBox6.Text), Int32.Parse(TextBox7.Text), Int32.Parse(TextBox8.Text), Int32.Parse(TextBox9.Text), Int32.Parse(TextBox13.Text), Int32.Parse(TextBox14.Text), Int32.Parse(TextBox15.Text), Int32.Parse(TextBox16.Text), Int32.Parse(TextBox17.Text), Int32.Parse(TextBox18.Text), Int32.Parse(TextBox19.Text), Int32.Parse(TextBox20.Text), Int32.Parse(TextBox21.Text), Int32.Parse(TextBox22.Text)))
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
                TextBox15.Text = String.Empty;
                TextBox16.Text = String.Empty;
                TextBox17.Text = String.Empty;
                TextBox18.Text = String.Empty;
                TextBox19.Text = String.Empty;
                TextBox20.Text = String.Empty;
                TextBox21.Text = String.Empty;
                TextBox22.Text = String.Empty;
            }
            else
            {
                MessageBox.Show(Page, "Datele introduse nu sunt valide!");
            }
        }
    }
}