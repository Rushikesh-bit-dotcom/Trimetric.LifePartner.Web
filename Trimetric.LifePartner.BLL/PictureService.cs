using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trimetric.LifePartner.BDO;
using Trimetric.LifePartner.BLL;
using Trimetric.LifePartner.DAL;

namespace Trimetric.LifePartner.BLL
{
    public class PictureService
    {
        public PictureInfo GetPicture(string ID)
        {
            PictureDAL pictureDAL = new PictureDAL();
            return pictureDAL.GetPicture(ID);
        }
        public void InsertPicture(byte[] image)
        {
            PictureDAL pictureDAL = new PictureDAL();
            pictureDAL.InsertPicture(image);
        }
        public void UpdatePicture(PictureInfo pictureInfo)
        {
            PictureDAL pictureDAL = new PictureDAL();
            pictureDAL.UpdatePicture(pictureInfo);
        }
    }
}
