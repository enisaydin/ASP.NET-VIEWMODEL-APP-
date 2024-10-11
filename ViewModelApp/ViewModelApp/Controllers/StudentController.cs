using Microsoft.AspNetCore.Mvc;
using ViewModel.Models;
using ViewModelApp.Models;

namespace ViewModelApp.Controllers
{
    public class StudentController : Controller
    {
        List<Gender> genders = new List<Gender>()
        {
            new Gender
            {
                GenderID = 1,
                GenderName = "Erkek"
            },
            new Gender
            {
                GenderID=2,
                GenderName="Kadın"
            }

        };
        List<Country> countries = new List<Country>()
        {
            new Country
            {
                CountryID = 1,
                CountryName = "Türkiye"
            },
            new Country
            {
                CountryID = 2,
                CountryName = "NL"
            },
            new Country
            {
                CountryID = 3,
                CountryName = "UK"
            }
        };
        public IActionResult Index()
        {
            ViewData["Gender"] = genders;
            ViewData["Country"] = countries;
            Student student = new Student();
            return View(student);
        }
    }
}
