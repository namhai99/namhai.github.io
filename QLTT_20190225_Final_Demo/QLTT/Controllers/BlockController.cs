using Service.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Mvc;

namespace QLTT.Controllers
{
    public class BlockController : Controller
    {
        // GET: Block
        public ActionResult Index()
        {
            return View();
        }

        //Block in Left Right

        public ActionResult BlockCategory()
        {
            int GroupCate;
            _ModulesFrontPanelDao dbModulesFrontPanel = new _ModulesFrontPanelDao();
            //Lấy danh sách các khối block ở menu bên trái và bên phải
            var modelModulesFrontPanel = dbModulesFrontPanel._ModulesFrontPanelGetAll();
            ViewBag.ListModulesFrontPanel = modelModulesFrontPanel;
            for (int i = 0; i <= ViewBag.ListModulesFrontPanel.Count; i++)
            {
                GroupCate = Convert.ToInt32(ViewBag.ListModulesFrontPanel[i].ModulesFrontPanel_Value);
                _ModulesFrontPanelDao dbModulesFrontPanel_Category = new _ModulesFrontPanelDao();
                var modelModulesFrontPanel_Category = dbModulesFrontPanel_Category._ModulesFrontPanelGetAll_Category(Convert.ToInt32(GroupCate));
                ViewBag.ListModulesFrontPanel_Category = modelModulesFrontPanel_Category;
                //return PartialView();
            }

            return PartialView();
        }
        public ActionResult BlockNews()
        {
            int GroupCate;
            _ModulesFrontPanelDao dbModulesFrontPanel = new _ModulesFrontPanelDao();
            var modelModulesFrontPanel = dbModulesFrontPanel._ModulesFrontPanelGetAll();
            ViewBag.ListModulesFrontPanel = modelModulesFrontPanel;
            for (int i = 0; i <= ViewBag.ListModulesFrontPanel.Count; i++)
            {
                GroupCate = Convert.ToInt32(ViewBag.ListModulesFrontPanel[i].ModulesFrontPanel_Value);
                _ModulesFrontPanelDao dbModulesFrontPanel_News = new _ModulesFrontPanelDao();
                var modelModulesFrontPanel_News = dbModulesFrontPanel_News._ModulesFrontPanelGetAll_News(GroupCate);
                ViewBag.ListModulesFrontPanel_News = modelModulesFrontPanel_News;

                return PartialView();
            }

            return PartialView();
        }
        public ActionResult BlockNewsScroll()
        {
            int GroupCate;
            _ModulesFrontPanelDao dbModulesFrontPanel = new _ModulesFrontPanelDao();
            var modelModulesFrontPanel = dbModulesFrontPanel._ModulesFrontPanelGetAll();
            ViewBag.ListModulesFrontPanel = modelModulesFrontPanel;
            for (int i = 0; i <= ViewBag.ListModulesFrontPanel.Count; i++)
            {
                GroupCate = Convert.ToInt32(ViewBag.ListModulesFrontPanel[i].ModulesFrontPanel_Value);
                _ModulesFrontPanelDao dbModulesFrontPanel_News = new _ModulesFrontPanelDao();
                var modelModulesFrontPanel_News = dbModulesFrontPanel_News._ModulesFrontPanelGetAll_News(GroupCate);
                ViewBag.ListModulesFrontPanel_News = modelModulesFrontPanel_News;

                return PartialView();
            }

            return PartialView();
        }
        public ActionResult BlockWebLink()
        {
            _ModulesFrontPanelDao dbModulesFrontPanel = new _ModulesFrontPanelDao();
            var modelModulesFrontPanel = dbModulesFrontPanel._ModulesFrontPanelGetAll();
            ViewBag.ListModulesFrontPanel = modelModulesFrontPanel;

            _ModulesFrontPanelDao dbModulesFrontPanel_Brand = new _ModulesFrontPanelDao();
            var modelModulesFrontPanel_Brand = dbModulesFrontPanel_Brand._ModulesFrontPanelGetAll_Brand();
            ViewBag.ListModulesFrontPanel_Brand = modelModulesFrontPanel_Brand;

            return PartialView();
        }
        public ActionResult BlockMaps()
        {
            return PartialView();
        }
        public ActionResult BlockVideo()
        {
            return PartialView();
        }

        //Block in MainHome
        public ActionResult MainHomeNews()
        {
            int GroupCate;
            _ModulesFrontPanelDao dbModulesFrontPanel = new _ModulesFrontPanelDao();
            var modelModulesFrontPanel = dbModulesFrontPanel._ModulesFrontPanelGetAll();
            ViewBag.ListModulesFrontPanel = modelModulesFrontPanel;

            //Lay thong tin NewMain
            var lstNews = dbModulesFrontPanel.ListModulesFrontPanel_NewMain();
            if(lstNews != null)
            {
                foreach(var itemNew in lstNews)
                {
                    itemNew.ImageThumb = WebConfigurationManager.AppSettings["ThumbUploadUrl"].ToString() + itemNew.ImageThumb;
                }
            }
            ViewBag.lstNews = lstNews;

            //for (int i = 0; i <= ViewBag.ListModulesFrontPanel.Count; i++)
            //{
            //    GroupCate = Convert.ToInt32(ViewBag.ListModulesFrontPanel[i].ModulesFrontPanel_Value);

            //    _ModulesFrontPanelDao dbModulesFrontPanel_News = new _ModulesFrontPanelDao();
            //    var modelModulesFrontPanel_News = dbModulesFrontPanel_News._ModulesFrontPanelGetAll_News(GroupCate);
            //    ViewBag.ListModulesFrontPanel_News = modelModulesFrontPanel_News;


            //    _ModulesFrontPanelDao dbModulesFrontPanel_NewsHot = new _ModulesFrontPanelDao();
            //    var modelModulesFrontPanel_NewsHot = dbModulesFrontPanel_NewsHot._ModulesFrontPanelGetAll_NewsHot(GroupCate);
            //    ViewBag.ListModulesFrontPanel_NewsHot = modelModulesFrontPanel_NewsHot;

            //    return PartialView();
            //}

            return PartialView();
        }
        public ActionResult MainHomeSlider()
        {
            int GroupCate;
            _ModulesFrontPanelDao dbModulesFrontPanel = new _ModulesFrontPanelDao();
            var modelModulesFrontPanel = dbModulesFrontPanel._ModulesFrontPanelGetAll();
            ViewBag.ListModulesFrontPanel = modelModulesFrontPanel;
            
            for (int i = 0; i <= ViewBag.ListModulesFrontPanel.Count; i++)
            {
                GroupCate = Convert.ToInt32(ViewBag.ListModulesFrontPanel[i].ModulesFrontPanel_Value);
                _ModulesFrontPanelDao dbModulesFrontPanel_Slider = new _ModulesFrontPanelDao();
                var modelModulesFrontPanel_Slider = dbModulesFrontPanel_Slider._ModulesFrontPanelGetAll_Slider(GroupCate);
                foreach(var itemThumb in modelModulesFrontPanel_Slider)
                {
                    itemThumb.ImageThumb = WebConfigurationManager.AppSettings["ThumbUploadUrl"] + itemThumb.ImageThumb;
                }
                ViewBag.ListModulesFrontPanel_Slider = modelModulesFrontPanel_Slider;

                return PartialView();
            }
            return PartialView();
        }
    }
}