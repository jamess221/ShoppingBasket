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
        public Offer Offer { get; private set; }
        public string AppliedOffer { get; set;}
        // Calculate price of product with percentage discount applied
        public double DiscountedPrice { get => LatestPrice * (((double)100 - Offer.Discount)/100); }
        //Calculate the total price for the quantity with BOGOF applied
        public double TotalItemValue
        {
            get
            {
                // There is a space in BOGOF from DB for some reason
                if (Offer.ShortDescription.Trim() == "BOGOF" && Quantity > 1)
                {
                    // IF quantity is 3: (3 - 1) + 1.5
                    Console.WriteLine("{0} {1}", Quantity % 2, Quantity / 2);
                    return ((Quantity / 2) + (Quantity % 2)) * LatestPrice;
                }
                else
                {
                    return Quantity * DiscountedPrice;
                }
            }
        }

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