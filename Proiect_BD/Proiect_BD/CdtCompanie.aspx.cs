﻿using System;
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
            BindData();
            //nooo
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
    }
}