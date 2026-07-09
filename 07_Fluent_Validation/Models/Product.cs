using System.ComponentModel.DataAnnotations;

namespace _07_Fluent_Validation.Models
{
    public class Product
    {
        public int Id { get; set; }

        [Required(ErrorMessage ="Ürün adı boş geçilemez.")]
        [MinLength(5,ErrorMessage ="Minumum 5 karakter olmalıdır.")]
        public string Name { get; set; }

        [Range(1000,9000,ErrorMessage ="1000 ile 9000 arasında olmalıdır.")]
        public decimal Price { get; set; }

        public int Stock { get; set; }
    }
}
