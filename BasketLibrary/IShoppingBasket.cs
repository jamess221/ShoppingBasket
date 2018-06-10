using System.Collections.Generic;

namespace BasketLibrary
{
    public interface IShoppingBasket
    {
        List<BasketItem> BasketItems { get; set; }

        List<Offer> Offers { get; set; }
    }
}