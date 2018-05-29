using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace VP_Project
{
    public partial class AllAds : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            mobileList.DataSource = DatabaseOps.ConnObject.getAllAds();
            mobileList.DataBind();
           
        }

        protected void Page_Prerender(object sender, EventArgs e)
        {
          
            locationList.DataSource = DatabaseOps.ConnObject.getLocations();
            locationList.DataBind();
        }

        protected void searchButton_Click(object sender, EventArgs e)
        {
            if (DatabaseOps.ConnObject.IsConnect())
            { }

        }

        protected void locationList_SelectedIndexChanged(object sender, EventArgs e)
        {
            mobileList.DataSource = DatabaseOps.ConnObject.searchByLocation(locationList.SelectedItem.Text.ToString().ToLower());
            mobileList.DataBind();
        }

        protected void searchByLocation_Click(object sender, EventArgs e)
        {
            mobileList.DataSource = DatabaseOps.ConnObject.searchByLocation(locationList.SelectedItem.Text.ToString().ToLower());
            mobileList.DataBind();
        }

        protected void locationList_TextChanged(object sender, EventArgs e)
        {
            mobileList.DataSource = DatabaseOps.ConnObject.searchByLocation(locationList.SelectedItem.Text.ToString().ToLower());
            mobileList.DataBind();
        }
    }
}