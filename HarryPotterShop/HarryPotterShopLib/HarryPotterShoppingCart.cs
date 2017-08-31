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
            double totalPrice = 0;
            var ProductsGroup =
                from product in _products
                group product by new
                {
                    product.ProductID,
                    product.SellPrice
                } into productGroup
                select new HarryPotterProductsGroup
                {
                    ProductID = productGroup.Key.ProductID,
                    ProductPrice = productGroup.Key.SellPrice,
                    ProductCount = productGroup.Count()
                };

            for (int i = 1; i <= ProductsGroup.Count(); i++)
            {
                var levelProducts = ProductsGroup.Where(x => x.ProductCount >= i);
                totalPrice += HarryPotterEpisodeDiscount(levelProducts.Sum(x => x.ProductPrice), levelProducts.Count());
            }

            return totalPrice;
        }

        private double HarryPotterEpisodeDiscount(double totalPrice, int productsCount)
        {
            if (productsCount == 2)
            {
                totalPrice *= 0.95;
            }
            else if (productsCount == 3)
            {
                totalPrice *= 0.9;
            }
            else if (productsCount == 4)
            {
                totalPrice *= 0.8;
            }
            else if (productsCount == 5)
            {
                totalPrice *= 0.75;
            }
            return totalPrice;
        }
    }
}