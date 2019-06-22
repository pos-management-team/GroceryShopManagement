﻿using Grocery_Shop_Management_DAL.Models;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grocery_Shop_Management_DAL.Implementation.Interface.Setup
{
   public interface IT12001
    {
        IEnumerable GetGridData();
        IEnumerable GetDdlData();
        string SaveData(T12001 T01);
    }
}
