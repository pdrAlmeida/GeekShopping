namespace GeekShopping.ProductAPI.Data.ValueObjects
{
    public class ProductVO : BaseVO
    {
        public ProductVO(string name, decimal price, string? description = null, string? categoryName = null, string? imageUrl = null)
        {
            Name = name;
            Price = price;
            Description = description;
            CategoryName = categoryName;
            ImageUrl = imageUrl;
        }

        public string Name { get; private set; }

        public decimal Price { get; private set; }

        public string? Description { get; private set; }

        public string? CategoryName { get; private set; }

        public string? ImageUrl { get; private set; }
    }
}
