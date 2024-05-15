using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trimetric.LifePartner.BDO;
using Trimetric.LifePartner.BLL;


namespace Trimetric.LifePartner.Web
{
    public partial class User : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            
        }
        protected void Button_Click(object sender, EventArgs e)
        {
            UserInfo userInfo = new UserInfo();
            userInfo.Mobile = Convert.ToInt64(txtMobile.Text);
            userInfo.UserID = CheckUser(userInfo).UserID;
            if(userInfo.UserID > -1)
            {
                lblError.Text = "already have account";
            }
            else
            {
                InsertUser(ReadSignUp());
               // Thread.Sleep(2000);
                Response.Redirect("~/Login.aspx");
            }
        }
        //protected  void Button_Click(object sender, EventArgs e)
        //{
        //    UserInfo userInfo = ReadSignUp();
        //    InsertUser(userInfo);             
        //    Thread.Sleep(2000);          
        //    Response.Redirect("~/Login.aspx");
        //}
        public UserInfo CheckUser(UserInfo userInfo)
        {
            UserService userService = new UserService();
            return userService.CheckUser(userInfo);
        }
        public UserInfo ReadSignUp()
        {
            UserInfo userInfo = new UserInfo();
            userInfo.Mobile = Convert.ToInt64(txtMobile.Text);
            userInfo.Password = txtPassword.Text;
            userInfo.Date= DateTime.Now;
            return userInfo;
        }

        public void InsertUser(UserInfo userInfo)
        {
            UserService signUpService = new UserService();
            signUpService.InsertUser(userInfo);
            
        }     
        
    }
}