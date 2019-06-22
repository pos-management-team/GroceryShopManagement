using Grocery_Shop_Management_DAL.Implementation.Interface.Setup;
using Grocery_Shop_Management_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Grocery_Shop_Management.Controllers.Setup
{
    public class T12002Controller : Controller
    {
        public IT12002 repository;

        public T12002Controller(IT12002 _repository)
        {
            repository = _repository;
        }
        // GET: T12002
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetGridData()
        {
            try
            {
                var Data = repository.GetGridData();
                return Json(Data, JsonRequestBehavior.AllowGet);
            }
            catch (Exception exc)
            {
                return Json(exc.Message, JsonRequestBehavior.AllowGet);
            }
        }
        [HttpPost]
        public ActionResult SaveData(T12002 T02)
        {
            try
            {
                var ItemBrand = repository.SaveData(T02);
                return Json(ItemBrand, JsonRequestBehavior.AllowGet);
            }
            catch (Exception exc)
            {
                return Json(exc.Message, JsonRequestBehavior.AllowGet);
            }
        }
    }
}