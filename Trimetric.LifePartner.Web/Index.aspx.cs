using System;

using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trimetric.LifePartner.BLL;


namespace Trimetric.LifePartner.Web
{
    public partial class Imdex : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            //Session["login"] = "jaydeep";

            if (Session["UserID"] != null)
            {
                submitbutton.Visible = true;                               
            }
            else
            {
                submitbutton.Visible = false;
            }
        }
    }
}