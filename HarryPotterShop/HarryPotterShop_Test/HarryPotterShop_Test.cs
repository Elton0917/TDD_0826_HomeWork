﻿using System;
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
        public void Test1_CartCheckout_Only_Buy_1_booK_with_FirstEpisode_Should_100()
        {
            //arrange
            var cart = new HarryPotterShopLib.HarryPotterShoppingCart();

            //act
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P01").FirstOrDefault());
            var actual = cart.CheckOut();

            //accert
            double expected = 100;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test2_CartCheckout_Buy_1_FirstEpisode_1_SecondEpisode_Should_190()
        {
            //arrange
            var cart = new HarryPotterShopLib.HarryPotterShoppingCart();

            //act
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P01").FirstOrDefault());
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P02").FirstOrDefault());
            var actual = cart.CheckOut();

            //accert
            double expected = 190;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test3_CartCheckout_Buy_1FirstEpisode_1SecondEpisode_1ThirdEpisode_Should_270()
        {
            //arrange
            var cart = new HarryPotterShopLib.HarryPotterShoppingCart();

            //act
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P01").FirstOrDefault());
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P02").FirstOrDefault());
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P03").FirstOrDefault());
            var actual = cart.CheckOut();

            //accert
            double expected = 270;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test4_CartCheckout_Buy_1FirstEpisode_1SecondEpisode_1ThirdEpisode_1FourthEpisode_Should_320()
        {
            //arrange
            var cart = new HarryPotterShopLib.HarryPotterShoppingCart();

            //act
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P01").FirstOrDefault());
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P02").FirstOrDefault());
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P03").FirstOrDefault());
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P04").FirstOrDefault());
            var actual = cart.CheckOut();

            //accert
            double expected = 320;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test5_CartCheckout_Buy_AllEpisode_Should_375()
        {
            //arrange
            var cart = new HarryPotterShopLib.HarryPotterShoppingCart();

            //act
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P01").FirstOrDefault());
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P02").FirstOrDefault());
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P03").FirstOrDefault());
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P04").FirstOrDefault());
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P05").FirstOrDefault());
            var actual = cart.CheckOut();

            //accert
            double expected = 375;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test6_CartCheckout_Buy_1FirstEpisode_1SecondEpisode_2ThirdEpisode_Should_370()
        {
            //arrange
            var cart = new HarryPotterShopLib.HarryPotterShoppingCart();

            //act
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P01").FirstOrDefault());
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P02").FirstOrDefault());
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P03").FirstOrDefault());
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P03").FirstOrDefault());
            var actual = cart.CheckOut();

            //accert
            double expected = 370;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test7_CartCheckout_Buy_1FirstEpisode_2SecondEpisode_2ThirdEpisode_Should_460()
        {
            //arrange
            var cart = new HarryPotterShopLib.HarryPotterShoppingCart();

            //act
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P01").FirstOrDefault());
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P02").FirstOrDefault());
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P02").FirstOrDefault());
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P03").FirstOrDefault());
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P03").FirstOrDefault());
            var actual = cart.CheckOut();

            //accert
            double expected = 460;

            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test8_CartCheckout_Buy_2FirstEpisode_2SecondEpisode_2ThirdEpisode_1FourthEpisode_1FifthEpisode_Should_640()
        {
            //arrange
            var cart = new HarryPotterShopLib.HarryPotterShoppingCart();

            //act
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P01").FirstOrDefault());
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P01").FirstOrDefault());
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P02").FirstOrDefault());
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P02").FirstOrDefault());
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P03").FirstOrDefault());
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P03").FirstOrDefault());
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P04").FirstOrDefault());
            cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P05").FirstOrDefault());
            var actual = cart.CheckOut();

            //accert
            double expected = 640;

            Assert.AreEqual(expected, actual);
        }

        //[TestMethod]
        //public void Test9_CartCheckout_Buy_2FirstEpisode_2SecondEpisode_2ThirdEpisode_2FourthEpisode_1FifthEpisode_Should_695()
        //{
        //    //arrange
        //    var cart = new HarryPotterShopLib.HarryPotterShoppingCart();

        //    //act
        //    cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P01").FirstOrDefault());
        //    cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P01").FirstOrDefault());
        //    cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P02").FirstOrDefault());
        //    cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P02").FirstOrDefault());
        //    cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P03").FirstOrDefault());
        //    cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P03").FirstOrDefault());
        //    cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P04").FirstOrDefault());
        //    cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P04").FirstOrDefault());
        //    cart.AddProductInCart(GetAllProduct().Where(x => x.ProductID == "P05").FirstOrDefault());
        //    var actual = cart.CheckOut();

        //    //accert
        //    double expected = 695;

        //    Assert.AreEqual(expected, actual);
        //}

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