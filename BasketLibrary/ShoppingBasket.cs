using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLibrary
{
    public class ShoppingBasket
    {
        public List<BasketItem> Items { get; set; }

        public double BasketTotal
        {
            // Return the sum of the TotalItemCost property across all BasketItem in the items list
            get { return Items.Sum(item => item.TotalItemCost); }
        }

        public ShoppingBasket()
        {
            // Instantiate new list of BasketItem
            Items = new List<BasketItem>();
        }

        public void AddProduct(string name, double price, int quantity, int discount=0, int discountGroup = 0)
        {
            // Check if existing basket item using the product name as reference
            try
            {
                // If exists, increase the quantity by passed amount
                Items.Find(item => item.ProductName == name).AddItems(quantity);
            }
            catch(Exception e)
            {
                // if does not exist, instantiate new BasketItem with passed parameters
                BasketItem newProduct = new BasketItem(name, price, quantity, discount, discountGroup);
                Items.Add(newProduct);
            }
        }

        public void RemoveProduct(string name)
        {
            Items.Find(item => item.ProductName == name).Quantity = 0;
        }

        public void ClearBasket()
        {
            // Set quantity of each product in the basket to 0
            foreach(BasketItem item in Items)
            {
                item.Quantity = 0;
            }
        }
    }
}
