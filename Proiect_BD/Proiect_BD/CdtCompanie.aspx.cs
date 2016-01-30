using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proiect_BD
{
    public partial class Batalion : System.Web.UI.Page
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
            GridView1.DataSource = BussinessLayer.clsBusiness_get_CDT_Comp.get_CDT_Comp().ToList();
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
            string Prenume = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text;
            string ID_Grad = ((TextBox)GridView1.Rows[e.RowIndex].Cells[5].Controls[0]).Text;

            bool val = BussinessLayer.clsBusiness_get_CDT_Comp.update_CDT_Comp(Int32.Parse(ID), Nume, Prenume, Int32.Parse(ID_Grad));
            if (val == false)
                MessageBox.Show(Page, "Datele introduse nu sunt valide!");
            else
            {
                GridView1.EditIndex = -1;
                BindData();
            }

        }

        protected void Delete(object sender, GridViewDeleteEventArgs e)
        {
            BussinessLayer.clsBusiness_get_CDT_Comp.delete_CDT_Comp(Int32.Parse(GridView1.Rows[e.RowIndex].Cells[2].Text));
            BindData();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (BussinessLayer.clsBusiness_get_CDT_Comp.insert_CDT_Comp(TextBox1.Text, TextBox2.Text, Int32.Parse(TextBox3.Text)))
            {
                BindData();
                TextBox1.Text = String.Empty;
                TextBox2.Text = String.Empty;
                TextBox3.Text = String.Empty;
            }
            else
                MessageBox.Show(Page, "Datele introduse nu sunt valide!");

           
        }
    }

}