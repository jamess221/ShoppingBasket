using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasketLibrary
{
    public class Offer
    {
        public int OfferId { get; private set; }
        public string Description { get; private set; }
        public string ShortDescription { get; private set; }
        public int DiscountGroup { get; private set; }
        public int Discount { get; private set; }

        public Offer(int id=0, string description="", string shortDescription="", int discountGroup=0, int discount=0)
        {
            OfferId = id;
            Description = description;
            ShortDescription = shortDescription;
            DiscountGroup = discountGroup;
            Discount = discount;
        }
    }
}
