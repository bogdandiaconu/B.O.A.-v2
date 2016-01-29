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

            BindData();

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
            string CNP = ((TextBox)GridView2.Rows[e.RowIndex].Cells[6].Controls[0]).Text;
            string ADresa = ((TextBox)GridView2.Rows[e.RowIndex].Cells[7].Controls[0]).Text;
            string ID_Companie = ((TextBox)GridView2.Rows[e.RowIndex].Cells[8].Controls[0]).Text;
            GridView2.EditIndex = -1;
            
            GridView2.DataBind();
        }

        protected void Delete(object sender, GridViewDeleteEventArgs e)
        {
            string ID = GridView2.Rows[e.RowIndex].Cells[2].Text;


        }
    }
}