using System.Net;
using System.Web.Mvc;
using AppCuisto_MVC.Models;
using AppCuisto_MVC.Models.DAL;

namespace AppCuisto_MVC.Controllers
{
    public class CookersController : Controller
    {
        private CookersRepository CookersRepo = new CookersRepository();//GameTourDB();

        // GET: Cookers
        public ActionResult Index()
        {
            return View(CookersRepo.FindAll());
        }

        // GET: Cookers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cooker cooker = CookersRepo.Find(id);
            if (cooker == null)
            {
                return HttpNotFound();
            }
            return View(cooker);
        }

        // GET: Cookers/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Cookers/Create
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Name,Email,Password")] Cooker cooker)
        {
            if (ModelState.IsValid)
            {
                CookersRepo.Add(cooker);
                return RedirectToAction("Index");
            }

            return View(cooker);
        }

        // GET: Cookers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cooker cooker = CookersRepo.Find(id);
            if (cooker == null)
            {
                return HttpNotFound();
            }
            return View(cooker);
        }

        // POST: Cookers/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Email,Password")] Cooker cooker)
        {
            if (ModelState.IsValid)
            {
                CookersRepo.Edit(cooker);
                return RedirectToAction("Index");
            }
            return View(cooker);
        }

        // GET: Cookers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Cooker cooker = CookersRepo.Find(id);
            if (cooker == null)
            {
                return HttpNotFound();
            }
            return View(cooker);
        }

        // POST: Cookers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Cooker cooker = CookersRepo.Find(id);
            CookersRepo.Remove(cooker);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                CookersRepo.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
