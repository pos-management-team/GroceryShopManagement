using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Grocery_Shop_Management_DAL.Implementation.Interface.Setup;
using Grocery_Shop_Management_DAL.Models;

namespace Grocery_Shop_Management_DAL.Implementation.Repository.Setup
{
    public class T12001Repository:IT12001
    {
        POS_Management_DBEntities obj = new POS_Management_DBEntities();
        public IEnumerable GetGridData()
        {
            var result = (from a in obj.T12001
                select new
                {
                    T_LANG2_NAME = a.T_COMPANY_NAME,
                }).ToList();
            return result;
        }
    }
}