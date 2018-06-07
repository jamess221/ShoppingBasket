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

        public List<Offer> Offers { get; set; }

        public double BasketTotal
        {
            // Return the sum of the TotalItemCost property across all BasketItem in the items list
            get { return Items.Sum(item => item.TotalItemValue); }
        }

        public ShoppingBasket()
        {
            // Instantiate new list of BasketItem and Offer
            Items = new List<BasketItem>();
            Offers = new List<Offer>();
        }

        public void AddProduct(string name, int quantity=0, double price=0, int offerId=0)
        {
            // Check if existing basket item using the product name as reference
            try
            {
                // If exists, increase the quantity by passed amount
                Items.Find(item => item.ProductName == name).AddItems(quantity);
            }
            catch (Exception e)
            {
                // Create new instance of Offer class with default parameters
                Offer linkedOffer = new Offer();

                // If offerId is not set, ignore discount and discount group 
                if (offerId != 0)
                {
                    linkedOffer = Offers.Find(offer => offer.OfferId == offerId);
                }

                // if does not exist, instantiate new BasketItem with passed parameters
                BasketItem newProduct = new BasketItem(name, price, quantity, linkedOffer);
                Items.Add(newProduct);
            }
        }

        public void RemoveProduct(string name)
        {
            Find(name).Quantity = 0;
        }

        public void ClearBasket()
        {
            // Set quantity of each product in the basket to 0
            foreach (BasketItem item in Items)
            {
                item.Quantity = 0;
            }
        }

        public BasketItem Find(string name)
        {
            return Items.Find(item => item.ProductName == name);
        }
    }
}
