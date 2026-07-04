using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace MyEcommerceWEB_MVC.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "Product name is required.")]
        [StringLength(100, ErrorMessage = "Product name 100 characters se bada nahi hona chahiye.")]
        public string Name { get; set; } = string.Empty;

        [StringLength(500, ErrorMessage = "Description 500 characters se badi nahi honi chahiye.")]
        public string Description { get; set; } = string.Empty;

        [Required]
        [Range(1.00, 500000.00, ErrorMessage = "Price 1 se 5,00,000 ke beech honi chahiye")]
        [Precision(18, 2)]
        public decimal Price { get; set; }

        [Required]
        [Range(0, int.MaxValue, ErrorMessage = "Stock quantity negative nahi ho sakti.")]
        public int StockQuantity { get; set; }
    }
}