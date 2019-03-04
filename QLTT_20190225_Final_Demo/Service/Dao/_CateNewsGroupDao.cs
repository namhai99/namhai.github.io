using Service.EF;
using System.Collections.Generic;
using System.Linq;

namespace Service.Dao
{
    public class _CateNewsGroupDao
    {
        DanhMuc_DbContext db = null;
        public _CateNewsGroupDao()
        {
            db = new DanhMuc_DbContext();
        }
        //List
        public List<tblCateNewsGroup> _CateNewsGroupDaoGetAll()
        {
            var res = db.Database.SqlQuery<tblCateNewsGroup>("_CateNewsGroupGetAll").Where(x=>x.IsView==true).ToList();
            return res;
        }
    }
}
