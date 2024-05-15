using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Trimetric.LifePartner.BDO;
using Trimetric.LifePartner.DAL;

namespace Trimetric.LifePartner.BLL
{
    public class HoroScopeService
    {
        public HoroScopeInfo GetHoroScope(string ID)
        {
            HoroScopeDAL horoScopeDAL = new HoroScopeDAL();
            return horoScopeDAL.GetHoroScope(ID);
        }
        public void InsertHoroScope(HoroScopeInfo horoScopeInfo)
        {
            HoroScopeDAL horoScopeDAL = new HoroScopeDAL();
            horoScopeDAL.InsertHoroScope(horoScopeInfo);
        }
        public void UpdateHoroScope(HoroScopeInfo horoScopeInfo)
        {
            HoroScopeDAL horoScopeDAL = new HoroScopeDAL();
            horoScopeDAL.UpdateHoroScope(horoScopeInfo);
        }
    }
}
