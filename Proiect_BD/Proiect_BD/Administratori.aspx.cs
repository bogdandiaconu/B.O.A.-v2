using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using DataLayer;
using BussinessLayer;

namespace Proiect_BD
{
    public partial class Administratori : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //BindData();
            if (!IsPostBack)
            {
                GridView1.DataSource = BussinessLayer.clsBusiness_get_Administratori.get_Administratori().ToList();
                GridView1.DataBind();
            }
           // DataLayer.Models.Administratori.insert_Administratori(1203, "Ceaparu", "Marian", 2212);
        }

        protected void Button1_Click(object sender, EventArgs e)
        {

            if (BussinessLayer.clsBusiness_get_Administratori.insert_Administratori(TextBox1.Text, TextBox2.Text, Int32.Parse(TextBox3.Text)))
                BindData();
                
        }
        protected void BindData()
        {
            GridView1.DataSource = DataLayer.Models.Administratori.get_Administratori().ToList();
            GridView1.DataBind();
        }
        protected void Edit(object sender, GridViewEditEventArgs e)
        {
            GridView1.EditIndex = e.NewEditIndex;
//           GridView1.DataBind();
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

            BussinessLayer.clsBusiness_get_Administratori.update_Administratori(Int32.Parse(ID), Nume, Prenume, Int32.Parse(ID_Grad));
            GridView1.EditIndex = -1;
            BindData();
        }

        protected void Delete(object sender, GridViewDeleteEventArgs e)
        {


        }
    }
   
}