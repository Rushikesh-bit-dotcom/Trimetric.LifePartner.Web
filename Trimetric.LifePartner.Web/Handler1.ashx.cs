using System;
using System.Collections.Generic;
using System.Linq;
using Trimetric.LifePartner.BDO;
using System.Web;

namespace Trimetric.LifePartner.Web
{
    /// <summary>
    /// Summary description for Handler1
    /// </summary>
    public class Handler1 : IHttpHandler
    {

        public void ProcessRequest(HttpContext context)
        {
            if (context.Request.Files.Count > 0)
            {
                HttpFileCollection files = context.Request.Files;
                for(int i = 0; i < files.Count; i++)
                {
                    HttpPostedFile file = files[i];
                    string fname = context.Server.MapPath(file.FileName);
                    file.SaveAs(fname);
                    
                }
                context.Response.ContentType = "text/plain";
                context.Response.Write("File Uploaded Sucessfull");
            }
           
        }

        public bool IsReusable
        {
            get
            {
                return false;
            }
        }
    }
}