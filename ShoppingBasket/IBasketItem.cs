using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket
{
    interface IBasketItem
    {
        string ProductName { get; }
        double LatestPrice { get; }
        int Quantity { get; set; }
        double TotalItemCost { get; }
        double Discount { get; }

        // Format of method used to increase the quantity of basket item
        void AddItems(int increase);
    }
}
