using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VP_Project
{
    public partial class PostAd : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (Session["user"] == null)
                Response.Redirect("~/SignIn.aspx");
            else
            {
                locationList.DataSource = DatabaseOps.ConnObject.getLocations();
                locationList.DataBind();
            }
        }

        protected void postAdButton_Click(object sender, EventArgs e)
        {
            string name = mobileName.Text.ToString();
            string brand = mobileBrand.SelectedItem.Text.ToString();
            string imageName = Path.GetFileName(imageUpload.PostedFile.FileName);
            imageUpload.SaveAs("F:/Bs. Software Engineering/BSE-Semester-6/FizaAsif_01-131152-009/Project/VP_Project/VP_Project/uploads/" + imageName);
            int price = Int32.Parse(productPrice.Text.ToString());
            string date = DateTime.Today.ToString();
            string location = locationList.SelectedItem.Text.ToString();
            string title = adTitle.Text.ToString();
            string description = adDescription.InnerText.ToString();
            string condition = productCondition.Text.ToString();
            string userID = Session["user"].ToString();

            if (DatabaseOps.ConnObject.postAd(name, brand, "uploads/" + imageName, price, date, location, title, description, condition, userID))
                Response.Redirect("~/AllAds.aspx");
        }
    }
}