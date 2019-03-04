using Service.EF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Dao
{
    public class _BreakingNewsDao
    {
        DanhMuc_DbContext db = null;
        string Language = "vi-VN";
        public _BreakingNewsDao()
        {
            db = new DanhMuc_DbContext();
        }
        //List
        public List<tblNewsGroup> _NewsGetAll()
        {
            var res = db.Database.SqlQuery<tblNewsGroup>("EXEC _NewsGroupGetBreakingNews @Language", new SqlParameter("@Language", Language)).ToList();
            return res;
        }
        public List<tblNewsGroup> _BreakingNewsGroupGetById(int NewsGroupID)
        {
            var res = db.Database.SqlQuery<tblNewsGroup>("EXEC _NewsGroupGetById @NewsGroupID", new SqlParameter("@NewsGroupID", NewsGroupID)).ToList();
            return res;
        }
    }
}
