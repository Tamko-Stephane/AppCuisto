using System.Net;
using System.Web.Mvc;
using AppCuisto_MVC.Models;
using AppCuisto_MVC.Models.DAL;

namespace AppCuisto_MVC.Controllers
{
    public class ReceiptsController : Controller
    {
        private ReceiptsRepository ReceiptsRepo = new ReceiptsRepository();//GameTourDB();

        // GET: Cookers
        public ActionResult Index()
        {
            return View(ReceiptsRepo.FindAll());
        }

        // GET: Cookers/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Receipt receipt = ReceiptsRepo.Find(id);
            if (receipt == null)
            {
                return HttpNotFound();
            }
            return View(receipt);
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
        public ActionResult Create([Bind(Include = "Id,Name,Duration,Description,Guest,Cookers_Id")] Receipt receipt)
        {
            if (ModelState.IsValid)
            {
                ReceiptsRepo.Add(receipt);
                return RedirectToAction("Index");
            }

            return View(receipt);
        }

        // GET: Cookers/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Receipt receipt = ReceiptsRepo.Find(id);
            if (receipt == null)
            {
                return HttpNotFound();
            }
            return View(receipt);
        }

        // POST: Cookers/Edit/5
        // Afin de déjouer les attaques par sur-validation, activez les propriétés spécifiques que vous voulez lier. Pour 
        // plus de détails, voir  http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Name,Duration,Description,Guest,Cookers_Id")] Receipt receipt)            //The Binding model
        {
            if (ModelState.IsValid)
            {
                ReceiptsRepo.Edit(receipt);
                return RedirectToAction("Index");
            }
            return View(receipt);
        }

        // GET: Cookers/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Receipt receipt = ReceiptsRepo.Find(id);
            if (receipt == null)
            {
                return HttpNotFound();
            }
            return View(receipt);
        }

        // POST: Cookers/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Receipt receipt = ReceiptsRepo.Find(id);
            ReceiptsRepo.Remove(receipt);
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                ReceiptsRepo.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
