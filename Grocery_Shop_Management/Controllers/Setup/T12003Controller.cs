using Grocery_Shop_Management_DAL.Implementation.Interface.Setup;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Grocery_Shop_Management.Controllers.Setup
{
    public class T12003Controller : Controller
    {
        public IT12003 repository;

        public T12003Controller(IT12003 _repository)
        {
            repository = _repository;
        }
        // GET: T12003
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetCompanyData()
        {

            try
            {
                var ItemBrand = repository.GetCompanyData();
                return Json(ItemBrand, JsonRequestBehavior.AllowGet);
            }
            catch (Exception exc)
            {
                return Json(exc.Message, JsonRequestBehavior.AllowGet);
            }
        }
        //GetCompanyData
    }
}