using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proiect_BD
{
    public partial class Companie : System.Web.UI.Page
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
            GridView1.DataSource = BussinessLayer.clsBusiness_get_Companie.get_Companie().ToList();
            GridView1.DataBind();

        }
        protected void Edit(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
            BindData();
            GridView1.Rows[e.NewEditIndex].Cells[2].Controls[0].Visible = false;
            GridView1.Rows[e.NewEditIndex].Cells[5].Controls[0].Visible = false;
            GridView1.Rows[e.NewEditIndex].Cells[7].Controls[0].Visible = false;
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
            string ID_Comp = ((TextBox)GridView1.Rows[e.RowIndex].Cells[4].Controls[0]).Text;
            string ID_Admin = ((TextBox)GridView1.Rows[e.RowIndex].Cells[6].Controls[0]).Text;

            if (BussinessLayer.clsBusiness_get_Companie.update_Companie(Int32.Parse(ID), Nume, Int32.Parse(ID_Comp), Int32.Parse(ID_Admin)))
            {
                GridView1.EditIndex = -1;
                BindData();
            }

            else
                MessageBox.Show(Page, "Datele introduse nu sunt valide!");
        }

        protected void Delete(object sender, GridViewDeleteEventArgs e)
        {
            BussinessLayer.clsBusiness_get_Companie.delete_Companie(Int32.Parse(GridView1.Rows[e.RowIndex].Cells[2].Text));
            BindData();

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (BussinessLayer.clsBusiness_get_Companie.insert_Companie(TextBox2.Text, Int32.Parse(TextBox3.Text), Int32.Parse(TextBox4.Text)))
            {
                BindData();
                TextBox4.Text = String.Empty;
                TextBox2.Text = String.Empty;
                TextBox3.Text = String.Empty;
            }
            else
                MessageBox.Show(Page, "Datele introduse nu sunt valide!");
           
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "")
            {
                DropDownList2.Visible = false;
                Button2.Visible = false;
                GridView2.Visible = false;
            }
            if (DropDownList1.SelectedValue == "Sumar")
            {
                DropDownList2.DataSource = DataLayer.Models.Companie.get_nume_Companie().ToList();
                DropDownList2.DataBind();
                DropDownList2.Visible = true;
            }
            Button2.Visible = true;
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "Sumar")
            {
                GridView2.DataSource = DataLayer.Models.Student.Get_Student_by_comp(DropDownList2.SelectedValue.ToString()).ToList();
                GridView2.DataBind();
            }
            GridView2.Visible = true;
        }
    }
}