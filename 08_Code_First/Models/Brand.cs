namespace _08_Code_First.Models
{
    public class Brand
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public Category Category { get; set; }
    }
}
