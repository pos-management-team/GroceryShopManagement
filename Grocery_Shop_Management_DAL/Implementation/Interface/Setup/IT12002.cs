using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Grocery_Shop_Management_DAL.Models;

namespace Grocery_Shop_Management_DAL.Implementation.Interface.Setup
{
    public interface IT12002
    {
        IEnumerable GetGridData();
        string SaveData(T12002 t02);
    }
}
