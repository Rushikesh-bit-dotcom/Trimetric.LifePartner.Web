using System;
using System.Collections.Generic;
using System.Configuration;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Threading;
using System.Web;
using Microsoft.VisualBasic;
using System.Web.UI;
using System.Web.UI.WebControls;
using Trimetric.LifePartner.BDO;
using Trimetric.LifePartner.BLL;
using static System.Net.Mime.MediaTypeNames;
using System.Web.Services;

namespace Trimetric.LifePartner.Web
{
    public partial class Picture : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            

            //if (!Page.IsPostBack)
            //{
            //    PictureService pictureService = new PictureService();
            //    PictureInfo pictureInfo = pictureService.GetPicture(Session["UserID"].ToString());
            //    if (pictureInfo.PictureID > -1)
            //    {
            //        btnSave.Attributes["Action"] = "update";
            //        BindPicture(pictureInfo);
            //    }
            //    else
            //    {
            //        btnSave.Attributes["Action"] = "insert";

            //    }
            //}

            //if (Request.Files.Count > 0)
            //{

            //    HttpPostedFile file = Request.Files[0];
            //    byte[] imageBytes = null;

            //    using (MemoryStream ms = new MemoryStream())
            //    {
            //        file.InputStream.CopyTo(ms);
            //        imageBytes = ms.ToArray();
            //    }

            //    // Save imageBytes to SQL Server database

            //    InsertPicture(imageBytes);
            //}

        }

        public PictureInfo ReadPicture()
        {
    
           
            PictureInfo pictureInfo = new PictureInfo();   
           // pictureInfo.PictureID = Convert.ToInt32(btnSave.Attributes["PictureId"]);
            pictureInfo.UserID = Convert.ToInt32(Session["UserID"]);
           
            //pictureInfo.Date = DateTime.Now;
            //pictureInfo.ModifiedDate = DateTime.Now;           
            return pictureInfo;
        }       
        public void BindPicture(PictureInfo pictureInfo)
        {
           // btnSave.Attributes["PictureId"] = pictureInfo.PictureID.ToString();

        }


       // [WebMethod]
        public void InsertPicture(byte[] image)
        {
            PictureService pictureService = new PictureService();
            pictureService.InsertPicture(image);
        }
        public void UpdatePicture(PictureInfo pictureInfo)
        {
            PictureService pictureService = new PictureService();
            pictureService.UpdatePicture(pictureInfo);
        }
       

        //protected void btnSave_Click1(object sender, EventArgs e)
        //{
        //    //if (btnSave.Attributes["Action"] == "update")
        //    //{
        //    //    UpdatePicture(ReadPicture());
        //    //}
        //    //else
        //    //{
        //    //    InsertPicture(ReadPicture());
        //    //}
        //}
    }
}