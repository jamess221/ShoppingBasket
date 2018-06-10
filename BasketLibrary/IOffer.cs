namespace BasketLibrary
{
    public interface IOffer
    {
        int OfferId { get; }
        string Description { get; }
        string ShortDescription { get; }
        int DiscountGroup { get; }
        int Discount { get; }
    }
}