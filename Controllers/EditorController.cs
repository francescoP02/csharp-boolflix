using csharp_boolflix.Controllers.Context;
using csharp_boolflix.Models;
using Microsoft.AspNetCore.Mvc;

namespace csharp_boolflix.Controllers
{
    public class EditorController : Controller
    {
        
        private BoolflixDbContext _db;
        public EditorController()
        {
            _db = new BoolflixDbContext();
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
            List<Genre> genres = _db.Genres.ToList();
            return View(genres);
        }
        public IActionResult Features()
        {
            List<Feature> features = _db.Features.ToList();
            return View(features);
        }
    }
}

