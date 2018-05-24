using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VP_Project
{
    public partial class Signup : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
          //  btnSignup_Click(sender, e);
        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.ToString() == txtPasswordConfirm.Text.ToString())
            {
                string name = txtName.Text.ToString();
                string email = txtEmail.Text.ToString();
                string number = txtTel.Text.ToString();
                string password = txtPassword.Text.ToString();
                string formattedValueString = "'" + name + "','" + email + "','" + number + "','" + password + "'";

                if(DatabaseOps.ConnObject.addUser(formattedValueString))
                {
                    Session["username"] = name ;
                    Response.Redirect("home.aspx");
                }
            }
            else
                Response.Write("Password Donot Match");
        }
    }
}
