using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket
{
    class ShoppingBasket
    {
        public List<BasketItem> Items { get; set; }

        public double BasketTotal 
        {
            get{ return Items.Sum(item => item.TotalItemValue); }
        }

        public ShoppingBasket()
        {
            // Substitute for data from SQL server

        }

        public void AddProduct(string name, double price, int quantity)
        {
            
            Items.Find(item => item.ProductName == name).;
        }

        public void RemoveProduct(string name)
        {
            Items.Remove(Items.Find(item => item.ProductName == name));
        }

        public void ClearBasket()
        {
            Items = new List<BasketItem>();
        }
    }
}
