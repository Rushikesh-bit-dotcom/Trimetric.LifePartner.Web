using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trimetric.LifePartner.BDO;
using System.IO;

namespace Trimetric.LifePartner.DAL
{
    public class PictureDAL : BaseDAL
    {
        string image;
        public PictureInfo GetPicture(string ID)
        {
            string query = $"Select * from Picture where UserID = {ID}";
            PictureInfo pictureInfo = GetById<PictureInfo>(query);
            return pictureInfo;
        }
        protected override T GetEntity<T>(SqlDataReader dataReader)
        {
           
            PictureInfo pictureInfo = new PictureInfo();
            pictureInfo.PictureID = -1;
            while (dataReader.Read())
            {
                pictureInfo.PictureID = Convert.ToInt32(dataReader["PictureID"]);
                pictureInfo.Image = (byte[])dataReader["Image"];
            }
            return pictureInfo as T;
        }
        public void InsertPicture(byte[] image)
        {
            
           // byte[] bytes = Convert.FromBase64String(image);
            //string commandText = "insert into Picture (UserID,Image,Date) values("+pictureInfo.UserID+",'" + pictureInfo.Image + "','"+pictureInfo.Date+"')";             
            //ExecuteCommand(commandText);
            string commandText = "insert into Picture (Image) values(@Image)";
            SqlCommand command = new SqlCommand(commandText, _sqlConnection);
            command.Parameters.AddWithValue("@Image", image);
            
            ExecuteCommand(commandText);
            command.ExecuteNonQuery();
            

        }
        public void UpdatePicture(PictureInfo pictureInfo)
        {
            string commandText = "update Picture set Image = '" + pictureInfo.Image + "', ModifiedDate='"+pictureInfo.ModifiedDate+"' where PictureID = '" + pictureInfo.PictureID + "'";
            ExecuteCommand(commandText);
        }

       
    }
}
