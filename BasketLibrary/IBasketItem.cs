using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLibrary
{
    interface IBasketItem
    {
        string ProductName { get; }
        double LatestPrice { get; }
        int Quantity { get; set; }
        double TotalItemValue { get; }
        double DiscountedPrice { get; }
        Offer Offer { get; }

        int CompareTo(BasketItem that);

        // Format of method used to increase the quantity of basket item
        void AddItems(int increase);
    }
}
