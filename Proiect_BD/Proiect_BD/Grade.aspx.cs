using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace Proiect_BD
{
    public partial class Grade : System.Web.UI.Page
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
            GridView1.DataSource = BussinessLayer.clsBusiness_get_Grade.get_Grade().ToList();
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
            string Grad = ((TextBox)GridView1.Rows[e.RowIndex].Cells[3].Controls[0]).Text;
          
           

            GridView1.EditIndex = -1;

            GridView1.DataBind();
        }

        protected void Delete(object sender, GridViewDeleteEventArgs e)
        {


        }

        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
           
            GridView1.PageIndex = e.NewPageIndex;
            //  GridView1.DataBind();
            BindData();
        }
    }
}