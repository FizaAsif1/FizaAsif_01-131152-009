using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VP_Project
{
    public partial class WebMasterpage : System.Web.UI.MasterPage
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if(Session["user"]==null)
            {
                signoutButton.Visible = false;
                signinButton.Visible = true;
                nameLabel.Text = "";
            }
            else
            {
                signoutButton.Visible = true;
                signinButton.Visible = false;
                nameLabel.Text = DatabaseOps.ConnObject.getUsername(Session["user"].ToString());
            }
        }

        protected void signoutButton_Click(object sender, EventArgs e)
        {
            Session["user"] = null;
            Response.Redirect("~/home.aspx");
        }

        protected void signinButton_Click(object sender, EventArgs e)
        {
            Response.Redirect("~/signin.aspx");
        }
    }
}