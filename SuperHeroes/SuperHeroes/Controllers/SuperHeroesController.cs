using SuperHeroes.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SuperHeroes.Controllers
{
    public class SuperHeroesController : Controller
    {
        //Variables
        ApplicationDbContext context;

        //Ctor//////////////////////////////////////////////////////////////////////////////////////////////////////////
        public SuperHeroesController()
        {
            context = new ApplicationDbContext();
        }

        //Methods///////////////////////////////////////////////////////////////////////////////////////////////////////

        // GET: SuperHeroes
        public ActionResult Index()
        {
            var listedHeroes = context.SuperHeroes.ToList();
            return View(listedHeroes);
        }

        // GET: SuperHeroes/Details/5
        public ActionResult Details(int id)
        {
            IEnumerable<SuperHeroe> detailedHero = context.SuperHeroes;
            detailedHero = context.SuperHeroes.Where(h => h.Id == id);
            return View(detailedHero);
        }

        // GET: SuperHeroes/Create
        public ActionResult Create()
        {
            SuperHeroe superheroe = new SuperHeroe();
            return View(superheroe);
        }

        // POST: SuperHeroes/Create
        [HttpPost]
        public ActionResult Create(SuperHeroe superheroe)
        {
            try
            {
                context.SuperHeroes.Add(superheroe);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeroes/Edit/5
        public ActionResult Edit(int id)
        {
            SuperHeroe superheroe = context.SuperHeroes.Where(s => s.Id == id).First();
            return View(superheroe);
        }

        // POST: SuperHeroes/Edit/5
        [HttpPost]
        public ActionResult Edit(SuperHeroe superheroe)
        {
            try
            {
                SuperHeroe heroFromDb = context.SuperHeroes.Where(s => s.Id == superheroe.Id).First();
                UpdateModel(heroFromDb);
                context.SaveChanges();
                return RedirectToAction("Details", new { id=heroFromDb.Id });//goes back to the hero table (making a new object using the hero
                
            }
            catch
            {
                return View();
            }
        }

        //GET: SuperHeroes/Delete/5
        public ActionResult Delete(int id)
        {
            var superHero = context.SuperHeroes.Find(id);
            return View(superHero);
        }

        //POST: SuperHeroes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, SuperHeroe superheroe)
        {
            try
            {
                var heroToRemove = context.SuperHeroes.Where(h => h.Id == superheroe.Id).Single();
                context.SuperHeroes.Remove(heroToRemove);
                context.SaveChanges();
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
