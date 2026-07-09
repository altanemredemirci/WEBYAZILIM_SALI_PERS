namespace _08_Code_First.Models
{
    public class Category
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public List<Product> Products { get; set; }

        public int BrandId { get; set; }
        public Brand Brand { get; set; }
    }
}
