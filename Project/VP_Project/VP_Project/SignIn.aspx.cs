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
          
        }

        protected void btnSignin_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text.ToString();
            string password = txtPassword.Text.ToString();
           
            if (DatabaseOps.ConnObject.authenticateUser(email, password))
            {
                Session["user"] = email;
                Response.Redirect("home.aspx");
            }
        }
    }
}