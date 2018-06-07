using System;
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
        public int Discount { get; private set; }
        public int DiscountGroup { get; private set; }

        //Calculate the total item cost accounting for discount
        public double TotalItemCost { get => (Quantity * LatestPrice) * (1 - (Discount / 100)); }

        public BasketItem(string productName, double latestPrice, int quantity, int discount=0, int discountGroup=0)
        {
            ProductName = productName;
            LatestPrice = latestPrice;
            Quantity = quantity;
            Discount = discount;
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