using Service.EF;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Dao
{
    public class _OfficialDao
    {
        DanhMuc_DbContext db = null;
        public _OfficialDao()
        {
            db = new DanhMuc_DbContext();
        }
        public List<tblOfficial> _OfficialGetAll()
        {
            var res = db.Database.SqlQuery<tblOfficial>("_OfficialGetAll").ToList();
            return res;
        }
    }
}
