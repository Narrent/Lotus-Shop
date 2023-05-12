using System.ComponentModel.DataAnnotations;

namespace LotusShop.Domain.Entities
{
    public class ShippingDetails
    {
        [Required(ErrorMessage = "Вкажіть як вас звуть")]
        public string Name { get; set; }

        [Required(ErrorMessage = "Вставте першу адресу доставки")]
        [Display(Name = "Першу адресу")]
        public string Line1 { get; set; }
        [Display(Name = "Другу адресу")]
        public string Line2 { get; set; }
        [Display(Name = "Третью адресу")]
        public string Line3 { get; set; }

        [Required(ErrorMessage = "Вкажіть місто")]
        [Display(Name = "Місто")]
        public string City { get; set; }

        [Required(ErrorMessage = "Вкажіть країну")]
        [Display(Name = "Країна")]
        public string Country { get; set; }

        public bool GiftWrap { get; set; }
    }
}