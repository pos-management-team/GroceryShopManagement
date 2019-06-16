using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Grocery_Shop_Management_DAL.Implementation.Interface;
using Grocery_Shop_Management_DAL.Models;

namespace Grocery_Shop_Management_DAL.Implementation.Repository
{
    public class LoginRepository: ILogin
    {
        POS_Management_DBEntities obj = new POS_Management_DBEntities();
        public int GetData(string id, string pass)
        {
            var result =  obj.T00000.Where(X => X.T_USER_ID == id && X.T_PASSWORD == pass).FirstOrDefault();
            return 1;
        }
    }
}