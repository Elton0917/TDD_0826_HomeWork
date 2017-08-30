using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarryPotterShopLib
{
    public class HarryPotterShoppingCart
    {
        public HarryPotterShoppingCart()
        {
            _products = new List<HarryPotterProduct>();
        }

        public List<HarryPotterProduct> _products { get; set; }

        public void AddProductInCart(HarryPotterProduct product)
        {
            _products.Add(product);
        }

        public double CheckOut()
        {
            var totalPrice = _products.Sum(x => x.SellPrice);
            var ProductsGroup = _products.GroupBy(i => i.ProductID)
            .Select(g => g.Key);

            if (ProductsGroup.Count() == 2)
            {
                totalPrice *= 0.95;
            }
            else if (ProductsGroup.Count() == 3)
            {
                totalPrice *= 0.9;
            }
            else if (ProductsGroup.Count() >= 4)
            {
                totalPrice *= 0.8;
            }
            return totalPrice;
        }
    }
}