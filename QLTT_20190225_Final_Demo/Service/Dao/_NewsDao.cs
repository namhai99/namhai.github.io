using Service.EF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Dao
{
    public class _NewsDao
    {
        string Language = "vi-VN";
        DanhMuc_DbContext db = null;
        public _NewsDao()
        {
            db = new DanhMuc_DbContext();
        }
        //List
        public List<tblNewsGroup> _NewsGroupGetAllGroup(int GroupCate)
        {
            var res = db.Database.SqlQuery<tblNewsGroup>("EXEC _NewsGroupGetAllGroup @Language, @GroupCate", new SqlParameter("@Language", Language), new SqlParameter("@GroupCate", GroupCate)).ToList();
            return res;
        }
        public List<tblNewsGroup> _NewsGroupGetAllNewsCategory(int CateNewsID)
        {
            var res = db.Database.SqlQuery<tblNewsGroup>("EXEC _NewsGroupGetAllNewsCategory @Language, @CateNewsID", new SqlParameter("@Language", Language), new SqlParameter("@CateNewsID", CateNewsID)).ToList();
            return res;
        }
        public List<tblNewsGroup> _NewsGroupGetById(int NewsGroupID)
        {
            var res = db.Database.SqlQuery<tblNewsGroup>("EXEC _NewsGroupGetById @NewsGroupID", new SqlParameter("@NewsGroupID", NewsGroupID)).ToList();
            return res;
        }
    }
}
