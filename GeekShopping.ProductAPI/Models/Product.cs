using GeekShopping.ProductAPI.Models.Base;
using System.ComponentModel.DataAnnotations;

namespace GeekShopping.ProductAPI.Models
{
    public class Product : BaseEntity
    {
        public Product()
        {

        }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [Range(0.1,double.MaxValue)]
        public decimal Price { get; set; }

        [StringLength(300)]
        public string? Description { get; set; }

        [StringLength(50)]
        public string? CategoryName { get; set; }

        [StringLength(300)]
        public string? ImageUrl { get; set; }

        public void ChangeName(string newName) => Name = newName;
        public void ChangeDescription(string newDescription) => Description = newDescription;
        public void ChangeCategoryName(string newCategoryName) => CategoryName = newCategoryName;
        public void ChangeImageUrl(string newImageUrl) => ImageUrl = newImageUrl;
        public void ChangePrice(decimal newPrice) => Price = newPrice;
    }
}
