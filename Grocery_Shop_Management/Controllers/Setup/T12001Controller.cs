using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Grocery_Shop_Management_DAL.Implementation.Interface.Setup;
using Grocery_Shop_Management_DAL.Models;

namespace Grocery_Shop_Management.Controllers
{
    public class T12001Controller : Controller
    {
        public IT12001 repository;

        public T12001Controller(IT12001 _repository)
        {
            repository = _repository;
        }
        // GET: T12001
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetGridData()
        {
            try
            {
                var ItemBrand = repository.GetGridData();
                return Json(ItemBrand, JsonRequestBehavior.AllowGet);
            }
            catch (Exception exc)
            {
                return Json(exc.Message, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpPost]
        public ActionResult GetDdlData()
        {
            try
            {
                var ItemBrand = repository.GetDdlData();
                return Json(ItemBrand, JsonRequestBehavior.AllowGet);
            }
            catch (Exception exc)
            {
                return Json(exc.Message, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpPost]
        public ActionResult SaveData(T12001 T01)
        {
            try
            {
                var ItemBrand = repository.SaveData(T01);
                return Json(ItemBrand, JsonRequestBehavior.AllowGet);
            }
            catch (Exception exc)
            {
                return Json(exc.Message, JsonRequestBehavior.AllowGet);
            }
        }
    }
}