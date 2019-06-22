using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Grocery_Shop_Management_DAL.Implementation.Interface.Setup;
using Grocery_Shop_Management_DAL.Models;
using System.Data.Entity.Validation;
using System.Diagnostics;

namespace Grocery_Shop_Management_DAL.Implementation.Repository.Setup
{
    public class T12001Repository:IT12001
    {
        POS_Management_DBEntities obj = new POS_Management_DBEntities();
        public IEnumerable GetGridData()
        {
            var result = (from a in obj.T12001
                          join t02 in obj.T12002 on a.T_COMPANY_TYPE equals t02.T_PRODUCT_TYPE_ID.ToString()
                          orderby a.T_COMPANY_ID descending
                          select new
                {
                    T_COMPANY_ID= a.T_COMPANY_ID,
                    T_LANG2_NAME = a.T_COMPANY_NAME,
                    T_PRODUCT_TYPE_NAME= t02.T_PRODUCT_TYPE_NAME,
                    T_COMPANY_TYPE= a.T_COMPANY_TYPE
                }).ToList();
            return result;
        }
         public  IEnumerable GetDdlData()
        {
            IEnumerable query = Enumerable.Empty<object>();
            query = (from t02 in obj.T12002
                     select new
                     {
                         T_COMPANY_TYPE =  t02.T_PRODUCT_TYPE_ID,
                         T_PRODUCT_TYPE_NAME=  t02.T_PRODUCT_TYPE_NAME
                     }).ToList();
            return query;
        }
       public string SaveData(T12001 T01)
        {
           var sms = "";
            try
            {
                if (T01.T_COMPANY_ID==0)
                {
                    obj.T12001.Add(T01);
                    obj.SaveChanges();
                    sms = "Save Successfully ";
                }
                else
                {
                    var ck = obj.T12001.Where(X => X.T_COMPANY_ID == T01.T_COMPANY_ID).FirstOrDefault();
                    if (ck!= null)
                    {

                        ck.T_COMPANY_NAME = T01.T_COMPANY_NAME;
                        ck.T_COMPANY_TYPE = T01.T_COMPANY_TYPE;
                        obj.SaveChanges();
                        sms = "Update Successfully ";
                    }
                   
                }
               
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                        sms = "Data is not Saved ";
                    }
                }
            }
           
            return sms;
        }
    }
}