using csharp_boolflix.Controllers.Context;
using csharp_boolflix.Models;
using Microsoft.AspNetCore.Mvc;

namespace csharp_boolflix.Controllers
{
    public class GenreController : Controller
    {
        private BoolflixDbContext _db;
        public GenreController()
        {
            _db = new BoolflixDbContext();
        }
        [HttpGet]
        public IActionResult Create()
        {
            Genre genre = new Genre();

            return View(genre);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Genre genreData)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", genreData);
            }
            Genre newGenre = new Genre();

            newGenre.Name = genreData.Name;
            try
            {
                _db.Add(newGenre);
                _db.SaveChanges();
            }
            catch (Exception ex)
            {
                return NotFound(ex.InnerException.Message);
            }

            return RedirectToAction("Genres", "Editor");

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Genre updateGenre = _db.Genres.Where(genre => genre.Id == id).FirstOrDefault();
            return View("Edit", updateGenre);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id, Genre genreData)
        {
            Genre updateGenre = _db.Genres.Where(genre => genre.Id == id).FirstOrDefault();

            if (!ModelState.IsValid)
            {
                return View("Edit", updateGenre);
            }

            updateGenre.Name = updateGenre.Name;
            updateGenre.Id = updateGenre.Id;

            _db.Update(updateGenre);
            _db.SaveChanges();

            return RedirectToAction("Genres", "Editor");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            Genre deleteGenre = _db.Genres.Where(genre => genre.Id == id).FirstOrDefault();

            _db.Remove(deleteGenre);
            _db.SaveChanges();

            return RedirectToAction("Features", "Editor");
        }
    }
}
