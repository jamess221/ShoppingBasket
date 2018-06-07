﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLibrary
{
    public class BasketItem : IBasketItem, IComparable<BasketItem>
    {
        public string ProductName { get; private set; }
        public double LatestPrice { get; private set; }
        public int Quantity { get; set; }
        public Offer Offer { get; private set; }
        // Calculate cost of product with percentage discount applied
        public double DiscountedPrice { get => LatestPrice * (1 - (Offer.Discount / 100)); }
        //Calculate the total cost for the quantity
        public double TotalItemValue { get => Quantity * DiscountedPrice; }

        public BasketItem(string productName, double latestPrice, int quantity, Offer offer)
        {
            // Set class properties to those passed to the constructor
            ProductName = productName;
            LatestPrice = latestPrice;
            Quantity = quantity;
            Offer = offer;
        }

        public int CompareTo(BasketItem that)
        {
            // Define the property of the class that separate instances of the class will be compared by
            return this.Quantity.CompareTo(that.Quantity);
        }

        public void AddItems(int increase)
        {
            Quantity += increase;
        }
    }
}