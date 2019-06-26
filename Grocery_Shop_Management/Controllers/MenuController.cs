using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Grocery_Shop_Management_DAL.Implementation.Interface;
using Grocery_Shop_Management_DAL.Implementation.Interface.Setup;

namespace Grocery_Shop_Management.Controllers
{
    public class MenuController : Controller
    {
        public IMenu repository;

        public MenuController(IMenu _repository)
        {
            repository = _repository;
        }
        // GET: Menu
        public ActionResult Menu()
        {
            return View();
        }

        [HttpPost]
        public ActionResult getfromData()
        {
            try
            {
                var ItemBrand = repository.GetfromData();
                // Session["UserId"]= ItemBrand.T_ENTRY_USER.toList();
                return Json(ItemBrand, JsonRequestBehavior.AllowGet);
            }
            catch (Exception exc)
            {
                return Json(exc.Message, JsonRequestBehavior.AllowGet);
            }
        }
    }
}