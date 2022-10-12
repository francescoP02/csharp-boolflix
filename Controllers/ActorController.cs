using csharp_boolflix.Controllers.Context;
using csharp_boolflix.Models;
using Microsoft.AspNetCore.Mvc;

namespace csharp_boolflix.Controllers
{
    public class ActorController : Controller
    {
        private BoolflixDbContext _db;
        public ActorController()
        {
            _db = new BoolflixDbContext();
        }

        [HttpGet]
        public IActionResult Create()
        {
            Actor actor = new Actor();

            return View(actor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Actor actorData)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", actorData);
            }

            Actor newActor = new Actor();

            newActor.Name = actorData.Name;
            newActor.Surname = actorData.Surname;
            _db.Add(newActor);
            _db.SaveChanges();

            return RedirectToAction("Actors", "Editor");

        }

        [HttpGet]
        public IActionResult Edit(int id)
        {
            Actor updateActor = _db.Actors.Where(actor => actor.Id == id).FirstOrDefault();
            return View("Edit", updateActor);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id, Actor actorData)
        {
            Actor updateActor = _db.Actors.Where(actor => actor.Id == id).FirstOrDefault();

            if (!ModelState.IsValid)
            {
                return View("Edit", updateActor);
            }

            updateActor.Name = actorData.Name;
            updateActor.Surname = actorData.Surname;
            updateActor.Id = actorData.Id;

            _db.Update(updateActor);
            _db.SaveChanges();

            return RedirectToAction("Actors", "Editor");
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            Actor deleteActor = _db.Actors.Where(actor => actor.Id == id).FirstOrDefault();

            _db.Remove(deleteActor);
            _db.SaveChanges();

            return RedirectToAction("Actors", "Editor");
        }

    }
}
