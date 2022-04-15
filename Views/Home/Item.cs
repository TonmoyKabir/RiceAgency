using Rice_Agency.DAL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Rice_Agency.Views.Home
{
    public class Item
    {
        public Tbl_Product Product { get; set; }
        public int Quantity { get; set; }
    }
}