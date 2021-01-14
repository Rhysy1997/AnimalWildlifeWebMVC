using AnimalWildlife.Data.Animals;
using AnimalWildlife.Data.Services;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using Microsoft.AspNetCore.Authorization;


namespace AnimalWildlife.WebMVC.Controllers
{
    public class AnimalController : Controller
    {
        private IAnimalDataService service;

        public AnimalController()
        {
            service = new AnimalDataService();
        }

        [HttpGet]
        public IActionResult Index()
        {
            List<Animal> animals = (List<Animal>)service.SelectAll();
            return View(animals);
        }

        [Authorize][HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [Authorize][HttpPost] 
        public IActionResult Create(Animal obj)
        {
            if (ModelState.IsValid)
            { // check valid state
                service.Insert(obj);
                return RedirectToAction("Index");
            }
            else // not valid so redisplay
            {
                return View(obj);
            }
        }


        [Authorize]
        [HttpGet, ActionName("Delete")]
        public IActionResult Delete(int id)
        {
            Animal existing = service.SelectByID(id);
            return View(existing);
        }

        [Authorize]
        [HttpPost, ActionName("Delete")]
        public IActionResult ConfirmDelete(int id)
        {
            service.Delete(id);
            return RedirectToAction("Index");
        }

        [Authorize]
        [HttpGet]
        public ActionResult Edit(int id)
        {
            Animal existing = service.SelectByID(id);
            return View(existing);
        }

        [Authorize]
        [HttpPost, ActionName("Edit")]
        public ActionResult ConfirmEdit(Animal obj)
        {
            if (ModelState.IsValid)
            { // check valid state
                service.Update(obj);
                return RedirectToAction("Index");
            }
            else // not valid so redisplay
            {
                return View(obj);
            }
        }

        [HttpGet]
        public ActionResult Details(int id)
        {
            Animal existing = service.SelectByID(id);
            return View(existing);
        }

    }
}
