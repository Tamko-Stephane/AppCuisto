using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AppCuisto_MVC.Models;
using AppCuisto_MVC.Models.DAL;

namespace GameTour.Controllers
{
    public class FavoritesController : Controller
    {
        private FavoritesRepository FavoritesRepo = new FavoritesRepository();

        // GET: Favorites
        public ActionResult Index()
        {
            return View(FavoritesRepo.FindAll());
        }

        // GET: Favorites/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Favorite favorite = FavoritesRepo.Find(id);
            if (favorite == null)
            {
                return HttpNotFound();
            }
            return View(favorite);
        }

        // GET: Favorites/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Favorites/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Created_At,Receipts_Id,Cookers_Id")] Favorite favorite)
        {
            if (ModelState.IsValid)
            {
                FavoritesRepo.Add(favorite);
                return RedirectToAction("Index");
            }

            return View(favorite);
        }

        // GET: Favorites/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Favorite favorite = FavoritesRepo.Find(id);
            if (favorite == null)
            {
                return HttpNotFound();
            }
            return View(favorite);
        }

        // POST: Favorites/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Created_At,Receipts_Id,Cookers_Id")] Favorite favorite)
        {
            if (ModelState.IsValid)
            {
                FavoritesRepo.Edit(favorite);
                return RedirectToAction("Index");
            }
            return View(favorite);
        }

        // GET: Favorites/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Favorite favorite = FavoritesRepo.Find(id);
            if (favorite == null)
            {
                return HttpNotFound();
            }
            return View(favorite);
        }

        // POST: Favorites/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Favorite favorite = FavoritesRepo.Find(id);
            FavoritesRepo.Remove(favorite);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                FavoritesRepo.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
