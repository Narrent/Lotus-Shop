using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace LotusShop.Domain.Entities
{
    public class Product
    {
        [HiddenInput(DisplayValue = false)]
   
        public int ProductId { get; set; }

        [Display(Name = "Назва")]
        [Required(ErrorMessage = "Будь ласка, введіть назву товару")]
        public string Name { get; set; }

        [Display(Name = "Опис")]
        [Required(ErrorMessage = "Будь ласка, введіть опис для товару")]
        public string Description { get; set; }

        [Display(Name = "Категорія")]
        [Required(ErrorMessage = "Будь ласка, вкажіть категорію для товару")]
        public string Category { get; set; }

        [Display(Name = "Ціна в грн")]
        [Required]
        [Range(0.01, double.MaxValue, ErrorMessage = "Будь ласка, введіть позитивне значення для ціни")]
        public decimal Price { get; set; }
        public byte[] ImageData { get; set; }
        public string ImageMimeType { get; set; }
    }
}
