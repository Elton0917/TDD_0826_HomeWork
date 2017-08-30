using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using HarryPotterShopLib;
using System.Collections.Generic;
using System.Linq;

namespace HarryPotterShop_Test
{
    [TestClass]
    public class HarryPotterShop_Test
    {
        [TestMethod]
        public void Test_CartCheckout_Only_Buy_1_booK_with_FirstEpisode_Should_100()
        {
            //arrange
            var cart = new HarryPotterShopLib.HarryPotterShoppingCart();

            //act
            var product = GetAllProduct().Where(x => x.ProductID == "P01").FirstOrDefault();
            cart.AddProductInCart(product);
            var actual = cart.CheckOut();

            //accert
            double expected = 100;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Test_CartCheckout_Buy_1_FirstEpisode_1_SecondEpisode_Should_190()
        {
            //arrange
            var cart = new HarryPotterShopLib.HarryPotterShoppingCart();

            //act
            var FirstEpisode = GetAllProduct().Where(x => x.ProductID == "P01").FirstOrDefault();
            var SecondEpisode = GetAllProduct().Where(x => x.ProductID == "P02").FirstOrDefault();
            cart.AddProductInCart(FirstEpisode);
            cart.AddProductInCart(SecondEpisode);
            var actual = cart.CheckOut();

            //accert
            double expected = 190;

            Assert.AreEqual(actual, expected);
        }

        [TestMethod]
        public void Test_CartCheckout_Buy_1FirstEpisode_1SecondEpisode_1ThirdEpisode_Should_270()
        {
            //arrange
            var cart = new HarryPotterShopLib.HarryPotterShoppingCart();

            //act
            var FirstEpisode = GetAllProduct().Where(x => x.ProductID == "P01").FirstOrDefault();
            var SecondEpisode = GetAllProduct().Where(x => x.ProductID == "P02").FirstOrDefault();
            var ThirdEpisode = GetAllProduct().Where(x => x.ProductID == "P03").FirstOrDefault();
            cart.AddProductInCart(FirstEpisode);
            cart.AddProductInCart(SecondEpisode);
            cart.AddProductInCart(ThirdEpisode);
            var actual = cart.CheckOut();

            //accert
            double expected = 270;

            Assert.AreEqual(actual, expected);
        }

        private IEnumerable<HarryPotterProduct> GetAllProduct()
        {
            var allProduct = new List<HarryPotterProduct>() {
            new HarryPotterProduct { ProductID = "P01", ProductName = "哈利波特第一集", SellPrice = 100 },
            new HarryPotterProduct { ProductID = "P02", ProductName = "哈利波特第二集", SellPrice = 100 },
            new HarryPotterProduct { ProductID = "P03", ProductName = "哈利波特第三集", SellPrice = 100 },
            new HarryPotterProduct { ProductID = "P04", ProductName = "哈利波特第四集", SellPrice = 100 },
            new HarryPotterProduct { ProductID = "P05", ProductName = "哈利波特第五集", SellPrice = 100 }
            };
            return allProduct;
        }
    }
}