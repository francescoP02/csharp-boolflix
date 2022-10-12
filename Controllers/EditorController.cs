using csharp_boolflix.Controllers.Context;
using Microsoft.AspNetCore.Mvc;

namespace csharp_boolflix.Controllers
{
    public class EditorController : Controller
    {
        
        BoolflixDbContext db;
        public EditorController()
        {
            db = new BoolflixDbContext();
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Films()
        {
            return View();
        }
        public IActionResult TvSeries()
        {
            return View();
        }
        public IActionResult Actors()
        {
            return View();
        }
        public IActionResult Genres()
        {
            return View();
        }
        public IActionResult Features()
        {
            return View(db.Features.ToList());
        }
    }
}

