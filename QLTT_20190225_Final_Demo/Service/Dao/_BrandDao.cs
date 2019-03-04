using Service.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Dao
{
    public class _BrandDao
    {
        DanhMuc_DbContext db = null;
        public _BrandDao()
        {
            db = new DanhMuc_DbContext();
        }
        //List
        public List<tblBrand> _BrandGetAll()
        {
            var res = db.Database.SqlQuery<tblBrand>("_BrandGetAll").ToList();
            return res;
        }
    }
}
