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
        public ActionResult Index(SuperHeroe superheroe)
        {
            //bring the table of hereoes here
            return View();
        }

        // GET: SuperHeroes/Details/5
        public ActionResult Details(int id)
        {
            return View();
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
                // TODO: Add insert logic here

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
            return View();
        }

        // POST: SuperHeroes/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: SuperHeroes/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: SuperHeroes/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
