using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VP_Project
{
    public partial class SingleItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           

            ListView.DataSource = DatabaseOps.ConnObject.getAdDetails(Convert.ToInt32(Request.QueryString["id"].ToString()));
            ListView.DataBind();
            numberLabel.Text = DatabaseOps.ConnObject.getMobileNumber(Session["user"].ToString());
            
        }
    }
}