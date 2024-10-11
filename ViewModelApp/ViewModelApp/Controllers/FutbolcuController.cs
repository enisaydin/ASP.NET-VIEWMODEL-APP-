using Microsoft.AspNetCore.Mvc;
using ViewModelApp.Models;
using ViewModelApp.Models.ViewModel;

namespace ViewModelApp.Controllers
{
    public class FutbolcuController : Controller
    {
        List<Takim> teams = new List<Takim>()
        {
            new Takim{TakimID =1,TakimAdi="Fenerbahçe"},
            new Takim{TakimID =1,TakimAdi="Galatasaray"},
            new Takim{TakimID =1,TakimAdi="Beşiktaş"},
            new Takim{TakimID =1,TakimAdi="Trabzonspor"},
            new Takim{TakimID =1,TakimAdi="Bursaspor"},
        };
        List<Mevki> positions = new List<Mevki>()
        {
            new Mevki{MevkiID=1,MevkiAdi="Kaleci"},
            new Mevki{MevkiID=1,MevkiAdi="orta saha"},
            new Mevki{MevkiID=1,MevkiAdi="Forvet"},
            new Mevki{MevkiID=1,MevkiAdi="Stoper"},
            new Mevki{MevkiID=1,MevkiAdi="Sol kanat"},
        };
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Create()
        {
            FutbolcuAddVM futbolcuAddVM = new FutbolcuAddVM();
            futbolcuAddVM.Futbolcu = new Futbolcu();
            futbolcuAddVM.Takimlar = teams;
            futbolcuAddVM.Mevkiler = positions;

            return View(futbolcuAddVM);
        }
    }
}
