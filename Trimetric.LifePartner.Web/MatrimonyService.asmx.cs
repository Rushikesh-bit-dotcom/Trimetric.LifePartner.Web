using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Trimetric.LifePartner.Web
{
    /// <summary>
    /// Summary description for MatrimonyService
    /// </summary>
    // [WebService(Namespace = "http://tempuri.org/")]
   // [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [WebServiceBinding(ConformsTo = WsiProfiles.None)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
     [System.Web.Script.Services.ScriptService]
    public class MatrimonyService : System.Web.Services.WebService
    {

        [WebMethod]
        public string HelloWorld(string myUserName)
        {           
            return "Hello World" + myUserName;            
        } 
       
        [WebMethod]
        public int SumOfNums(int FirstNumber, int SecondNumber)
        {
            return FirstNumber + SecondNumber;
        }

        [WebMethod(MessageName = "SumOfFloats")]
        public float SumOfNums(float FirstNumber, float SecondNumber)
        {
            return FirstNumber * SecondNumber;
        }

        
    }
}
