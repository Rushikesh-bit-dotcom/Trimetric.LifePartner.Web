using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trimetric.LifePartner.BLL;

namespace Trimetric.LifePartner.Web
{
    public partial class CustomerData : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            SetProfile();
          
            BindRepeater();
            DivData();
        }
        public void SetProfile()
        {
            BLL.ProfileService profileService = new BLL.ProfileService();
            GridView1.DataSource = profileService.SetProfile();
            GridView1.DataBind();
        }
      
        protected void GridView1_PageIndexChanging(object sender, GridViewPageEventArgs e)
        {
            GridView1.PageIndex = e.NewPageIndex;
            SetProfile();
        }

        protected void GridView1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        public void BindRepeater()
        {
            ForYouService forYouService = new ForYouService();
            Repeater1.DataSource= forYouService.GetProfileData();
            Repeater1.DataBind();
        }
        public void DivData()
        {
            ForYouService forYouService = new ForYouService();
            ListView1.DataSource= forYouService.GetProfileData();
            ListView1.DataBind();
        }

    }
}