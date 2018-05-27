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
         
        }

        protected void btnSignup_Click(object sender, EventArgs e)
        {
            if (txtPassword.Text.ToString() == txtPasswordConfirm.Text.ToString())
            {
                string name = txtName.Text.ToString();
                string email = txtEmail.Text.ToString();
                string number = txtTel.Text.ToString();
                string password = txtPassword.Text.ToString();
                string userDetails = "\n\nDear " + name + "!\n\nEmail: " + email + "\nPassword: " + password + "\n\n";

                if(DatabaseOps.ConnObject.addUser(userDetails))
                {
                    Session["user"] = email ;
                    NotifyCustomer notification = new NotifyCustomer();
                    notification.sendEmailNotification(userDetails,email);
                    Response.Redirect("home.aspx");
                }
            }
            else
                Response.Write("Password Donot Match");
        }
    }
}
