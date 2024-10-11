namespace ViewModelApp.Models
{
    public class Takim
    {
        public int TakimID { get; set; }
        public string TeknikDirektor    { get; set; }
        public string TakimAdi { get; set; }
        public ICollection<Futbolcu> futbolcular {  get; set; }
    }
}
