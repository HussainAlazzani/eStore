namespace Core.Entities.OrderAggregate
{
    /// <summary>
    /// This is a value entity because it will be owned by the OrderItem.
    /// It represents a snapshot of the item ordered.
    /// </summary>
    public class ProductItemOrdered
    {
        // An empty constructor is required by EF.
        public ProductItemOrdered()
        {
        }

        public ProductItemOrdered(int productItemId, string productName, string pictureUrl)
        {
            ProductItemId = productItemId;
            ProductName = productName;
            PictureUrl = pictureUrl;
        }

        public int ProductItemId { get; set; }
        public string ProductName { get; set; }
        public string PictureUrl { get; set; }
    }
}