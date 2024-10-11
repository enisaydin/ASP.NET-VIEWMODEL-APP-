using ViewModelApp.Models;

namespace ViewModel.Models
{
    public class Country
    {
        public int CountryID { get; set; }
        public string CountryName { get; set; }
        public ICollection<Student> Students { get; set; }
    }
}