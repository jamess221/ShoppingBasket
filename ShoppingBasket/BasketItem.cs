using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket
{
    class BasketItem : IBasketItem, IComparable<BasketItem>
    {
        public string ProductName { get; private set; }
        public double LatestPrice { get; private set; }
        public int Quantity { get; set; }

        //Calculate the total item value inside the getter- accounting for any discount percentage
        public double TotalItemValue { get => (Quantity*LatestPrice/100)*(1-(Discount/100)) ;}
        public double Discount { get; private set; }

        public BasketItem(string productName, double latestPrice, double discount)
        {
            ProductName = productName;
            LatestPrice = latestPrice;
            Quantity = 0;
            Discount = discount;
        }

		public int CompareTo(BasketItem that)
		{
			return this.Quantity.CompareTo(that.Quantity);
		}

        public void AddItems(int increase)
        {
            Quantity += increase;
        }
    }
}