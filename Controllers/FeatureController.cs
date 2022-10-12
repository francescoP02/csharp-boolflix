using csharp_boolflix.Controllers.Context;
using csharp_boolflix.Models;
using Microsoft.AspNetCore.Mvc;

namespace csharp_boolflix.Controllers
{
    public class FeatureController : Controller
    {
        private BoolflixDbContext _db;
        public FeatureController()
        {
            _db = new BoolflixDbContext();
        }

        [HttpGet]
        public IActionResult Create()
        {
            Feature feature = new Feature();

            return View(feature);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create(Feature featureData)
        {
            if (!ModelState.IsValid)
            {
                return View("Create", featureData);
            }

            Feature newFeature = new Feature();

            newFeature.Name = featureData.Name;
            _db.Add(newFeature);
            _db.SaveChanges();

            return RedirectToAction("Features", "Editor");

        }
        [HttpGet]
        public IActionResult Edit(int id)
        {
            Feature updateFeature = _db.Features.Where(feature => feature.Id == id).FirstOrDefault();
            return View("Edit", updateFeature);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Update(int id, Feature featureData)
        {
            Feature updateFeature = _db.Features.Where(feature => feature.Id == id).FirstOrDefault();

            if (!ModelState.IsValid)
            {
                return View("Edit", updateFeature);
            }

            updateFeature.Name = featureData.Name;
            updateFeature.Id = featureData.Id;

            _db.Update(updateFeature);
            _db.SaveChanges();

            return RedirectToAction("Features", "Editor");
        }


        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Delete(int id)
        {
            Feature deleteFeature = _db.Features.Where(feature => feature.Id == id).FirstOrDefault();

            _db.Remove(deleteFeature);
            _db.SaveChanges();

            return RedirectToAction("Features", "Editor");
        }

    }
}



