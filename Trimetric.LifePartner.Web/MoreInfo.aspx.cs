using System;
using System.Collections.Generic;
using System.Drawing.Printing;
using System.Linq;
using System.Web;
using System.Web.DynamicData;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trimetric.LifePartner.BDO;
using Trimetric.LifePartner.BLL;

namespace Trimetric.LifePartner.Web
{
    public partial class MoreInfo : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
            {
                // LikeProfile();
            }
            //LikeProfile(sender, e);


        }
        public void GetData()
        {
            //ForYouService forYouService = new ForYouService();
            //ListView1.DataSource = forYouService.GetProfileData();
            //ListView1.DataBind();
        }

        public void LikeProfile(object sender, EventArgs e)
        {
            //ListView listView = (sender as ListView);
            // (listView.FindControl("lblFullName")as Label).Text = Session["Name"].ToString();
            // (listView.FindControl("LblEducation") as Label).Text = Session["Education"].ToString();
            //lblFullName.Text = Session["Name"].ToString();
            //LblEducation.Text = Session["Education"].ToString();

            //ListView listView = (sender as ListView);
            //string name = (listView.FindControl("lblFullName") as Label).Text;
            //name = Session["Name"].ToString();
            //(listView.FindControl("lblEducation")as Label).Text = Session["Education"].ToString();  

        }

    }
}