using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VP_Project
{
    public partial class SignIn : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            btnSignin_Click(sender, e);
        }

        protected void btnSignin_Click(object sender, EventArgs e)
        {
            string email = "Fiza@gmail.com";
            string password = "test";
            //string email = txtEmail.Text.ToString();
            //string password = txtPassword.Text.ToString();
            string formattedString = "email='" + email + "' and password='"+ password + "'";

            if (DatabaseOps.ConnObject.authenticateUser("[dbo].[RegisteredUsers]", formattedString))
            {
                Session["username"] = "Fiza";
                Response.Redirect("home.aspx");
            }
        }
    }
}