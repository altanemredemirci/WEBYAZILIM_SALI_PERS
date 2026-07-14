namespace _08_Code_First_2.Models
{
    public class Bolum
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public List<Sinif> Siniflar { get; set; }
    }
}
