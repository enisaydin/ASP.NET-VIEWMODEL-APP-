namespace ViewModelApp.Models
{
    public class Futbolcu
    {
        public int FutbolcuID { get; set; }
        public string AdSoyad { get; set; }
        public int Yas {  get; set; }
        public int MevkiID { get; set; }
        public int TakimID { get; set; }
        public Mevki mevki { get; set; }
        public Takim takim { get; set; }
    }
}
