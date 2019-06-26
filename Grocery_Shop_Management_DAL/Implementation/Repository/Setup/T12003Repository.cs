using Grocery_Shop_Management_DAL.Implementation.Interface.Setup;
using Grocery_Shop_Management_DAL.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Grocery_Shop_Management_DAL.Implementation.Repository.Setup
{
    public class T12003Repository: IT12003
    {
        POS_Management_DBEntities obj = new POS_Management_DBEntities();
        public  IEnumerable GetCompanyData()
        {
            IEnumerable query = Enumerable.Empty<object>();
            query = (from t01 in obj.T12001
                     select new
                     {
                         T_COMPANY_ID = t01.T_COMPANY_ID,
                         T_COMPANY_NAME = t01.T_COMPANY_NAME
                     }).ToList();
            return query;

        }
    }
}