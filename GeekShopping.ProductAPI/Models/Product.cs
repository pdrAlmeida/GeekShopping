using GeekShopping.ProductAPI.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace GeekShopping.ProductAPI.Models
{
    public class Product : BaseEntity
    {
        public Product(string name, decimal price, string? description = null, string? categoryName = null, string? imageUrl = null)
        {
            Name = name;
            Price = price;
            Description = description;
            CategoryName = categoryName;
            ImageUrl = imageUrl;
        }

        [Required]
        [StringLength(50)]
        public string Name { get; private set; }

        [Required]
        [Range(0.1,double.MaxValue)]
        public decimal Price { get; private set; }

        [StringLength(300)]
        public string? Description { get; private set; }

        [StringLength(50)]
        public string? CategoryName { get; private set; }

        [StringLength(300)]
        public string? ImageUrl { get; private set; }

        public void ChangeName(string newName) => Name = newName;
        public void ChangeDescription(string newDescription) => Description = newDescription;
        public void ChangeCategoryName(string newCategoryName) => CategoryName = newCategoryName;
        public void ChangeImageUrl(string newImageUrl) => ImageUrl = newImageUrl;
        public void ChangePrice(decimal newPrice) => Price = newPrice;
    }
}
