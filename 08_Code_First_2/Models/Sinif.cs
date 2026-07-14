namespace _08_Code_First_2.Models
{
    public class Sinif
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public List<Ogrenci> Ogrenciler { get; set; }

        public int BolumId { get; set; }
        public Bolum Bolum { get; set; }
    }
}
