using System.ComponentModel.DataAnnotations;

namespace _08_Code_First.Models
{
    public class Product
    {
        public int Id { get; set; }

        [StringLength(30)]
        public string Name { get; set; }
        public decimal Price { get; set; }
        public int Stock { get; set; }

        //Mapping 1-N
        public int CategoryId { get; set; }
        public Category Category { get; set; }
    }
}
