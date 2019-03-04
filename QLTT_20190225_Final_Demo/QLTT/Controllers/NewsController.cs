using Service.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace QLTT.Controllers
{
    public class NewsController : Controller
    {
        // GET: News
        public ActionResult Index()
        {
            return View();
        }
        public ActionResult NewsIndex(string GroupCate)
        {
            _NewsDao dbNews = new _NewsDao();
            var modelNews = dbNews._NewsGroupGetAllGroup(Convert.ToInt32(GroupCate));
            ViewBag.ListNews = modelNews;
            return View();
        }
        public ActionResult NewsCategory(string CateNewsID)
        {
            _NewsDao dbNews = new _NewsDao();
            var modelNews = dbNews._NewsGroupGetAllNewsCategory(Convert.ToInt32(CateNewsID));
            ViewBag.ListNews = modelNews;
            return View();
        }
        public ActionResult NewsDetail(string NewsGroupID)
        {
            _NewsDao dbNews = new _NewsDao();
            var modelNews = dbNews._NewsGroupGetById(Convert.ToInt32(NewsGroupID));
            ViewBag.ListNews = modelNews;
            return View();
        }
    }
}