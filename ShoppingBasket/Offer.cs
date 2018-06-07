using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShoppingBasket
{
    class Offer
    {
        private int OfferId { get; set; }
        private string Description { get; set; }
        private string ShortDescription { get; set; }
        private int DiscountGroup { get; set; }
        private int Discount { get; set; }

        public Offer(int id, string description, string shortDescription, int discountGroup, int discount)
        {
            OfferId = id;
            Description = description;
            ShortDescription = shortDescription;
            DiscountGroup = discountGroup;
            Discount = discount;
        }
    }
}
