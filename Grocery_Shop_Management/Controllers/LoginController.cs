using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Grocery_Shop_Management_DAL.Implementation.Interface;

namespace Grocery_Shop_Management.Controllers
{
    public class LoginController : Controller
    {
        // GET: Loging
        public ILogin repository;

        public LoginController(ILogin _repository)
        {
            repository = _repository;
        }
        public ActionResult Login()
        {
            return View();
        }
        [HttpPost]
        public ActionResult GetData(string id, string pass)
        {
            try
            {
                var ItemBrand = repository.GetData( id, pass);
                return Json(ItemBrand, JsonRequestBehavior.AllowGet);
            }
            catch (Exception exc)
            {
                return Json(exc.Message, JsonRequestBehavior.AllowGet);
            }
        }
    }
}