namespace Kutuphane.Models
{
    public class Kitap
    {
        public String ISSN { get; set; }
        public String Ad { get; set; } = String.Empty;
        public String Yazar{ get; set; } = String.Empty;
        public String ResimYolu { get; set; } = String.Empty;
        public double Fiyat { get; set; }
        public DateTime BasimTarihi { get; set; }
        public int SayfaSayisi { get; set; }

        public Kitap()
        {
            BasimTarihi=DateTime.Now;
        }
    }
}
