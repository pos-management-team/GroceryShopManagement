using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_Shop_Management_DAL.Implementation.Interface
{
    public interface ILogin
    {
        int GetData(string id, string pass);
    }
}
