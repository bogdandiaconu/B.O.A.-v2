using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proiect_BD
{
    public partial class Studenti : System.Web.UI.Page
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
            GridView2.DataSource = BussinessLayer.clsBusiness_get_Student.get_Student().ToList();
            GridView2.DataBind();
        }

        protected void Edit(object sender, GridViewEditEventArgs e)
        {
            GridView2.EditIndex = e.NewEditIndex;
            BindData();
            GridView2.Rows[e.NewEditIndex].Cells[2].Controls[0].Visible = false;
            GridView2.Rows[e.NewEditIndex].Cells[6].Controls[0].Visible = false;
            
        }
        protected void CancelEdit(object sender, GridViewCancelEditEventArgs e)
        {
            GridView2.EditIndex = -1;
            BindData();
        }
        protected void Update(object sender, GridViewUpdateEventArgs e)
        {
            GridView2.Rows[e.RowIndex].RowState = DataControlRowState.Edit;

            string ID = ((TextBox)GridView2.Rows[e.RowIndex].Cells[2].Controls[0]).Text;
            string Nume = ((TextBox)GridView2.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
            string Prenume = ((TextBox)GridView2.Rows[e.RowIndex].Cells[4].Controls[0]).Text;
            string ID_Grad = ((TextBox)GridView2.Rows[e.RowIndex].Cells[5].Controls[0]).Text;
            string CNP = ((TextBox)GridView2.Rows[e.RowIndex].Cells[7].Controls[0]).Text;
            string Adresa = ((TextBox)GridView2.Rows[e.RowIndex].Cells[8].Controls[0]).Text;
            string ID_Companie = ((TextBox)GridView2.Rows[e.RowIndex].Cells[9].Controls[0]).Text;

            if (BussinessLayer.clsBusiness_get_Student.update_Student(Int32.Parse(ID), Nume, Prenume, Int32.Parse(ID_Grad), CNP, Adresa, Int32.Parse(ID_Companie)))
            {
                GridView2.EditIndex = -1;
                BindData();
            }
            else
                MessageBox.Show(Page, "Datele introduse nu sunt valide!");
        }

        protected void Delete(object sender, GridViewDeleteEventArgs e)
        {
           // BussinessLayer.clsBusiness_get_Student.
            //string ID = GridView2.Rows[e.RowIndex].Cells[2].Text;

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            if (BussinessLayer.clsBusiness_get_Student.insert_Student(TextBox1.Text, TextBox2.Text, Int32.Parse(TextBox3.Text), TextBox4.Text, TextBox5.Text, Int32.Parse(TextBox6.Text)))
            {
                BindData();

            }
            else
                MessageBox.Show(Page, "Datele introduse nu sunt valide!");

            TextBox1.Text = String.Empty;
            TextBox2.Text = String.Empty;
            TextBox3.Text = String.Empty;
            TextBox4.Text = String.Empty;
            TextBox5.Text = String.Empty;
            TextBox6.Text = String.Empty;

        }

        protected void DropDownList2_SelectedIndexChanged(object sender, EventArgs e)
        {            
            GridView3.Visible = false;
        }

        protected void DropDownList1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(DropDownList1.SelectedValue == "")
            {
                DropDownList2.Visible = false;
                Button2.Visible = false;
                GridView3.Visible = false;
            }
            if(DropDownList1.SelectedValue=="StudentByCompanie")
            {
                DropDownList2.DataSource = DataLayer.Models.Companie.get_nume_Companie().ToList();
                DropDownList2.DataBind();
                DropDownList2.Visible = true;
                Button2.Visible = true;
            }
            
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            if (DropDownList1.SelectedValue == "StudentByCompanie")
            {
                GridView3.DataSource = DataLayer.Models.Student.Get_Student_by_comp(DropDownList2.SelectedValue.ToString()).ToList();
                GridView3.DataBind();
            }
            GridView3.Visible = true;
           // Response.Redirect("Query.aspx");

        }
    }
}