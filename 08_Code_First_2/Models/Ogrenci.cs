namespace _08_Code_First_2.Models
{
    public class Ogrenci
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int SinifId { get; set; }
        public Sinif Sinif { get; set; }
    }
}
