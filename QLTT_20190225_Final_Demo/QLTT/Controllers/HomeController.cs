using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Service.Dao;
using System.Web.Configuration;

namespace QLTT.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            //Lay thong tin cac khoi block trang chu
            _ModulesFrontPanelDao dbModulesFrontPanel = new _ModulesFrontPanelDao();
            var modelModulesFrontPanel = dbModulesFrontPanel._ModulesFrontPanelGetAll();
            ViewBag.ListModulesFrontPanel = modelModulesFrontPanel;
            return View();
        }
        public ActionResult TrangCon()
        {
            return View();
        }
        public ActionResult TopMenu()
        {
            //Viet bang ViewBag
            //CateNewsGroup
            _CateNewsGroupDao dbCateNewsGroup = new _CateNewsGroupDao();
            var modelCateNewsGroup = dbCateNewsGroup._CateNewsGroupDaoGetAll();
            ViewBag.ListCateNewsGroup = modelCateNewsGroup;

            //CateNews
            _CateNewsDao dbCateNews = new _CateNewsDao();
            var modelCateNews = dbCateNews._CateNewsDaoGetAll();
            ViewBag.ListCateNews = modelCateNews;

            return PartialView();

            //Viet bang model
            //var model = new _CateNewsGroupDao().List_CateNewsGroupDao();
            //return PartialView(model);
        }

        public ActionResult FootMenu()
        {
            _CateNewsGroupDao dbCateNewsGroup = new _CateNewsGroupDao();
            var modelCateNewsGroup = dbCateNewsGroup._CateNewsGroupDaoGetAll();
            ViewBag.ListCateNewsGroup = modelCateNewsGroup;
            return PartialView();
        }

        public ActionResult LeftPanel()
        {            
            //Lấy thông tin các khối block trong
            _ModulesFrontPanelDao dbModulesFrontPanel = new _ModulesFrontPanelDao();
            var modelModulesFrontPanel = dbModulesFrontPanel._ModulesFrontPanelGetAll();
            var lstBlockLeft = modelModulesFrontPanel.ToList().Where(x=>x.ModulesFrontPanel_Panel=="Left").ToList();
            ViewBag.BlockLeft = lstBlockLeft;
            //Lấy thông tin chi tiết các khối là BlockNews
            var lstNew = dbModulesFrontPanel._CateNewsGroupGetByIdSize();
            foreach(var itemNew in lstNew)
            {
                itemNew.ImageThumb = WebConfigurationManager.AppSettings["ImageUploadUrl"] + itemNew.ImageThumb;
            }
            ViewBag.BlockNews = lstNew;

            //Lấy thông tin danh sách liên kết ảnh (BlockImageLink)
            var lstBrand = dbModulesFrontPanel._BrandGetAll();
            foreach(var itemBrand in lstBrand)
            {
                itemBrand.Image = WebConfigurationManager.AppSettings["BrandUploadUrl"] + itemBrand.Image;
            }
            ViewBag.lstBrand = lstBrand;

            //Lấy thông tin link website liên kết
            var lstLink = dbModulesFrontPanel._MenuLinksGetAll();
            ViewBag.lstLink = lstLink;         
            return PartialView();
        }

        public ActionResult RightPanel()
        {
            _ModulesFrontPanelDao dbModulesFrontPanel = new _ModulesFrontPanelDao();
            var modelModulesFrontPanel = dbModulesFrontPanel._ModulesFrontPanelGetAll();
            var lstBlockRight = modelModulesFrontPanel.ToList().Where(x => x.ModulesFrontPanel_Panel == "Right").ToList();
            ViewBag.BlockRight = lstBlockRight;

            //Lấy thông tin chi tiết các khối là BlockNews
            var lstNew = dbModulesFrontPanel._CateNewsGroupGetByIdSize();
            foreach (var itemNew in lstNew)
            {
                itemNew.ImageThumb = WebConfigurationManager.AppSettings["ImageUploadUrl"] + itemNew.ImageThumb;
            }
            ViewBag.BlockNews = lstNew;

            //Lấy thông tin danh sách liên kết ảnh (BlockImageLink)
            var lstBrand = dbModulesFrontPanel._BrandGetAll();
            foreach (var itemBrand in lstBrand)
            {
                itemBrand.Image = WebConfigurationManager.AppSettings["BrandUploadUrl"] + itemBrand.Image;
            }
            ViewBag.lstBrand = lstBrand;

            //Lấy thông tin danh sách video (BlockImageLink)
            var lstVideo = dbModulesFrontPanel._VideoGetAll();
            foreach (var itemVideo in lstVideo)
            {
                itemVideo.VideoUrl = WebConfigurationManager.AppSettings["VideoUploadUrl"] + itemVideo.VideoUrl;
            }
            ViewBag.lstVideo = lstVideo;

            //Lấy thông tin link website liên kết
            var lstLink = dbModulesFrontPanel._MenuLinksGetAll();
            ViewBag.lstLink = lstLink;
            return PartialView();
        }

        public ActionResult BreakingNews()
        {
            _BreakingNewsDao dbBreakingNews = new _BreakingNewsDao();
            var modelBreakingNews = dbBreakingNews._NewsGetAll();
            ViewBag.ListBreakingNews = modelBreakingNews;
            return PartialView();
        }

        public ActionResult BreakingNewsDetail(string NewsGroupID)
        {
            _BreakingNewsDao dbBreakingNews = new _BreakingNewsDao();
            var modelBreakingNews = dbBreakingNews._BreakingNewsGroupGetById(Convert.ToInt32(NewsGroupID));
            ViewBag.ListBreakingNews = modelBreakingNews;
            return View();
        }

        //public ActionResult TopSlider()
        //{
        //    return PartialView();
        //}

        //public ActionResult MainMenu()
        //{
        //    _ModulesFrontPanelDao dbModulesFrontPanel = new _ModulesFrontPanelDao();
        //    var modelModulesFrontPanel = dbModulesFrontPanel._ModulesFrontPanelGetAll();
        //    ViewBag.ListModulesFrontPanel = modelModulesFrontPanel;
        //    return PartialView();
        //}

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}