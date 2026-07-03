using System.ComponentModel.DataAnnotations;

//Simple Meaning: Namespace is a kind of folder address or house address
//Why is this necessary? In a pure project, if you Productwant to use this class in another file (such as a controller), you need to specify at the top: using WEBAPI.Models;. This lets the compiler know Productin which folder the class is stored.

namespace MyEcommerceWEB_MVC.Models
{
    public class Product
    {
        [Key]
        public int Id { get; set; }


        [Required(ErrorMessage = "Product name is required.")]
        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        [Required]
        [Range(1,500000,ErrorMessage = "Price 1 se badi honi chaiye")]
        public decimal Price { get; set; }

        [Required]

        public int StockQuantity { get; set; }




    }
}
