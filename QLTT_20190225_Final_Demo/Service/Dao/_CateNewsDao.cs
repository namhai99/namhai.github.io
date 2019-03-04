using Service.EF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Dao
{
    public class _CateNewsDao
    {
        DanhMuc_DbContext db = null;
        public _CateNewsDao()
        {
            db = new DanhMuc_DbContext();
        }
        //List
        public List<tblCateNews> _CateNewsDaoGetAll()
        {
            var res = db.Database.SqlQuery<tblCateNews>("_CateNewsGetChild").ToList();
            return res;
        }
    }
}
