using Service.EF;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Service.Dao
{
    public class _ModulesFrontPanelDao
    {
        DanhMuc_DbContext db = new DanhMuc_DbContext();
        string Language = "vi-VN";
        public _ModulesFrontPanelDao()
        {
            db = new DanhMuc_DbContext();
        }

        public List<tblCateNews> _CateNewsGetAll()
        {
            var res = db.Database.SqlQuery<tblCateNews>("_CateNewsGetAll").ToList();
            return res;
        }
        public List<tblBrand> _BrandGetAll()
        {
            var res = db.Database.SqlQuery<tblBrand>("EXEC _BrandGetAll  {0}", "vi-VN").ToList();
            return res;
        }
        
        public List<tblModulesFrontPanel> _ModulesFrontPanelGetAll()
        {
            var res = db.Database.SqlQuery<tblModulesFrontPanel>("_ModulesFrontPanelGetAll").ToList();
            return res;
        }
        public List<FrontPanel_News> ListModulesFrontPanel_NewMain()
        {
            var res = db.Database.SqlQuery<FrontPanel_News>("ListModulesFrontPanel_NewMain").ToList();
            return res;
        }
        

        public List<tblVideo> _VideoGetAll()
        {
            var res = db.Database.SqlQuery<tblVideo>("_VideoGetAll  {0}", "vi-VN").ToList();
            return res;
        }
        public List<tblOfficial> _OfficialGetAll()
        {
            var res = db.Database.SqlQuery<tblOfficial>("_OfficialGetAll").ToList();
            return res;
        }
        
        public List<tblMenuLinks> _MenuLinksGetAll()
        {
            var res = db.Database.SqlQuery<tblMenuLinks>("_MenuLinksGetAll").ToList();
            return res;
        }
        

        public List<FrontPanel_News> _CateNewsGroupGetByIdSize()
        {
            var res = db.Database.SqlQuery<FrontPanel_News>("_CateNewsGroupGetByIdSize").ToList();
            return res;
        }
        
        public List<tblCateNews> _ModulesFrontPanelGetAll_Category(int GroupCate)
        {
            var res = db.Database.SqlQuery<tblCateNews>("EXEC _CateNewsGetByGroup {0}", GroupCate).ToList();
            return res;
        }
        public List<tblNewsGroup> _ModulesFrontPanelGetAll_News(int GroupCate)
        {
            var res = db.Database.SqlQuery<tblNewsGroup>("EXEC _NewsGroupGetAllGroup @Language, @GroupCate", new SqlParameter("@Language", Language), new SqlParameter("@GroupCate", GroupCate)).ToList();
            return res;
        }
        public List<tblNewsGroup> _ModulesFrontPanelGetAll_Slider(int GroupCate)
        {
            var res = db.Database.SqlQuery<tblNewsGroup>("EXEC _NewsGroupGetNewsGroupSlider @Language, @GroupCate", new SqlParameter("@Language", Language), new SqlParameter("@GroupCate", GroupCate)).ToList();
            return res;
        }
        public List<tblNewsGroup> _ModulesFrontPanelGetAll_NewsHot(int GroupCate)
        {
            var res = db.Database.SqlQuery<tblNewsGroup>("EXEC _NewsGroupHotGroup @Language, @GroupCate", new SqlParameter("@Language", Language), new SqlParameter("@GroupCate", GroupCate)).ToList();
            return res;
        }
        public List<tblBrand> _ModulesFrontPanelGetAll_Brand()
        {
            var res = db.Database.SqlQuery<tblBrand>("_BrandGetAll").ToList();
            return res;
        }
    }
}
