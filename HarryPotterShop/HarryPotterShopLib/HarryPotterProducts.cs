using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterShopLib
{
    public class HarryPotterProduct
    {
        public string ProductID { get; set; }
        public string ProductName { get; set; }
        public double SellPrice { get; set; }
    }

    public class HarryPotterProductsGroup
    {
        public string ProductID { get; set; }
        public double ProductPrice { get; set; }
        public int ProductCount { get; set; }
    }
}