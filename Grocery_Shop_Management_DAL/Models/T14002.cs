//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Grocery_Shop_Management_DAL.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class T14002
    {
        public int T_STOCK_DETAILS_ID { get; set; }
        public Nullable<int> T_STOCK_ID { get; set; }
        public Nullable<int> T_PRODUCT_ID { get; set; }
        public Nullable<int> T_PRODUCT_TYPE_ID { get; set; }
        public Nullable<decimal> T_PRICE { get; set; }
        public Nullable<decimal> T_STOCK_QUANTITY { get; set; }
        public Nullable<decimal> T_PURCHASE_QUENTITY { get; set; }
        public Nullable<decimal> T_SALE_QUANTIY { get; set; }
        public Nullable<decimal> T_PURCHASE_RETURN_QUANTITY { get; set; }
        public Nullable<System.DateTime> T_RETURN_DATE { get; set; }
        public string T_ENTRY_USER { get; set; }
        public Nullable<System.DateTime> T_ENTRY_DATE { get; set; }
        public string T_UPDATE_USER { get; set; }
        public Nullable<System.DateTime> T_UPDATE_DATE { get; set; }
    }
}
