namespace IkinciProje.Models
{
    public class Urun
    {
        public int Id { get; set; }
        public String Ad { get; set; } = string.Empty;
        public String Aciklama { get; set; } = string.Empty;
        public double Fiyat { get; set; }
        public DateTime SonKullanmaTarihi { get; set; }
        public bool BoykotDurumu { get; set; } = false;
        public Urun()
        {
            SonKullanmaTarihi= DateTime.Now;
        }
    }
}
