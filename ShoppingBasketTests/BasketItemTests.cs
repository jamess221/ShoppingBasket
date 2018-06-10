using System;
using BasketLibrary;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace ShoppingBasketTests
{
    [TestClass]
    public class BasketItemTests
    {
        [TestMethod]
        public void DiscountedPriceTest()
        {
            Offer offer = new Offer(0, "", "", 0, 20);
            BasketItem item = new BasketItem("Product1", 9.99, 1, offer);
            // Discounted price should be 9.99 with 20% off, so 7.99 rounded to the nearest penny

            // Allow error of 0.005 to account for rounding to nearest penny
            Assert.AreEqual(7.99, item.DiscountedPrice, 0.005);
        }

        [TestMethod]
        public void TotalItemValueTest()
        {
            Offer offer = new Offer(0, "", "BOGOF", 0, 0);
            BasketItem item = new BasketItem("Product1", 9.99, 1, offer);
            // Discounted price should be 9.99 with 20% off, so 7.99 rounded to the nearest penny

            // Allow error of 0.005 to account for rounding to nearest penny
            Assert.AreEqual(7.99, item.DiscountedPrice, 0.005);
        }
    }
}
