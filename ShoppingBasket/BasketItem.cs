using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket
{
    class BasketItem : IBasketItem
    {
        public string ProductName { get; private set; }
        public double LatestPrice { get; private set; }
        public int Quantity { get; set; }
        public double TotalItemValue { get => this.Quantity*this.LatestPrice; set => TotalItemValue = value; }
        public double Discount { get; private set; }

        public BasketItem(string productName, double latestPrice, int quantity, double discount)
        {
            ProductName = productName;
            LatestPrice = latestPrice;
            Quantity = quantity;
            Discount = discount;

        }

        public void AddItems(int increase)
        {
            Quantity += increase;
        }
    }
}
