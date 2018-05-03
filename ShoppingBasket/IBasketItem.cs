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
        double TotalItemValue { get; set; }
        double Discount { get; }

        void AddItems(int increase);

    }
}
