using Grocery_Shop_Management_DAL.Implementation.Interface.Setup;
using Grocery_Shop_Management_DAL.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Validation;
using System.Diagnostics;
using System.Linq;
using System.Web;

namespace Grocery_Shop_Management_DAL.Implementation.Repository.Setup
{
    public class T12002Repository: IT12002
    {
        POS_Management_DBEntities obj = new POS_Management_DBEntities();
        public  IEnumerable GetGridData()
        {
            IEnumerable query = Enumerable.Empty<object>();

            try
            {
                query = (from t02 in obj.T12002
                         select new
                         {
                            T_PRODUCT_TYPE_ID= t02.T_PRODUCT_TYPE_ID,
                             T_PRODUCT_TYPE_NAME=t02.T_PRODUCT_TYPE_NAME
                         }).ToList();
            }
            catch (DbEntityValidationException dbEx)
            {
                foreach (var validationErrors in dbEx.EntityValidationErrors)
                {
                    foreach (var validationError in validationErrors.ValidationErrors)
                    {
                        Trace.TraceInformation("Property: {0} Error: {1}", validationError.PropertyName, validationError.ErrorMessage);
                       
                    }
                }
            }
            return query;

        }
      public  string SaveData(T12002 t02)
        {
            string sms = "";
            try
            {
                if (t02.T_PRODUCT_TYPE_ID == 0)
                {
                    obj.T12002.Add(t02);
                    obj.SaveChanges();
                    sms = "Save Successfully ";
                }
                else
                {
                    var ck = obj.T12002.Where(X => X.T_PRODUCT_TYPE_ID == t02.T_PRODUCT_TYPE_ID).FirstOrDefault();
                    if (ck != null)
                    {

                        ck.T_PRODUCT_TYPE_NAME = t02.T_PRODUCT_TYPE_NAME;                       
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