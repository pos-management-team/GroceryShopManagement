using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Web;
using Grocery_Shop_Management_DAL.Implementation.Interface;
using Grocery_Shop_Management_DAL.Models;

namespace Grocery_Shop_Management_DAL.Implementation.Repository
{
    public class MenuRepository :IMenu
    {
        POS_Management_DBEntities obj = new POS_Management_DBEntities();
        public  IEnumerable GetfromData()
        {
            IEnumerable query = Enumerable.Empty<object>();
            try
            {
                //join com in obj.tblCompanies on comType.Comp_Type_ID equals com.Comp_Type_ID
                query = (from i in obj.T00001
                    //join t02 in obj.T12002 on i.T_COMPANY_TYPE equals t02.T_PRODUCT_TYPE_ID
                    select new
                    {
                        T_FORM_TYPE = i.T_FORM_TYPE,
                        T_FORM_NAME = i.T_FORM_NAME,
                        T_NAME = i.T_NAME,
                        T_ENTRY_USER=i.T_ENTRY_USER
                    }).ToList();

            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName,
                            validationError.ErrorMessage);
                    }
                }
            }
            return query;
        }
    }
}