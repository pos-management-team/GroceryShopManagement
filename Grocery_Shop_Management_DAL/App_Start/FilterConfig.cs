using System.Web;
using System.Web.Mvc;

namespace Grocery_Shop_Management_DAL
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
