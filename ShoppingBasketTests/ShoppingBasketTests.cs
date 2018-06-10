using System;
using BasketLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingBasketTests
{
    [TestClass]
    public class ShoppingBasketTests
    {
        [TestMethod]
        public void BasketTotalTest()
        {
            // Arrange
            ShoppingBasket basket = new ShoppingBasket();

            // Act
            basket.AddProduct("Product1", 3, 3.33);
            basket.AddProduct("Product2", 1, 97.38);
            basket.AddProduct("Product3", 2, 8.00);
            basket.AddProduct("Product4", 14, 0.01);
            // Total should be 123.51

            // Assert with accuracy of 0.001 because type of total is double and not completely exact
            Assert.AreEqual(123.51, basket.BasketTotal, 0.001);
        }

        [TestMethod]
        public void NumberOfItemsTest()
        {
            ShoppingBasket basket = new ShoppingBasket();

            basket.AddProduct("Product1", 3, 3.33);
            basket.AddProduct("Product2", 1, 97.38);
            basket.AddProduct("Product3", 2, 8.00);
            basket.AddProduct("Product4", 14, 0.01);
            // Total quantity should be 20

            Assert.AreEqual(20, basket.NumberOfItems);
        }

        [TestMethod]
        public void AddProductTest()
        {
            ShoppingBasket basket = new ShoppingBasket();

            basket.AddProduct("Product1", 4, 5.44);
     
            Assert.AreEqual(4, basket.Find("Product1").Quantity);
        }

        [TestMethod]
        public void RemoveProductTest()
        {
            ShoppingBasket basket = new ShoppingBasket();

            basket.AddProduct("Product1", 4, 5.44);
            basket.RemoveProduct("Product1");           

            Assert.AreEqual(0, basket.Find("Product1").Quantity);
        }

        [TestMethod]
        public void ClearBasketTest()
        {
            ShoppingBasket basket = new ShoppingBasket();

            basket.AddProduct("Product1", 3, 3.33);
            basket.AddProduct("Product2", 1, 97.38);
            basket.AddProduct("Product3", 2, 8.00);
            basket.AddProduct("Product4", 14, 0.01);

            basket.ClearBasket();


            Assert.AreEqual(0, basket.NumberOfItems);

        }
    }
}
