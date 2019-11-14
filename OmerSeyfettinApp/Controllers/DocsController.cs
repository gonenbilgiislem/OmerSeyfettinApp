using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OmerSeyfettinApp.Models;

namespace OmerSeyfettinApp.Controllers
{
    public class DocsController : Controller
    {
        private OmerSeyfettinAppDb db = new OmerSeyfettinAppDb();

        // GET: Docs
        public ActionResult Index()
        {
            return View(db.Docs.ToList());
        }

        // GET: Docs/Details/5
        public ActionResult Details(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doc doc = db.Docs.Find(id);
            if (doc == null)
            {
                return HttpNotFound();
            }
            return View(doc);
        }

        // GET: Docs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Docs/Create
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,DocBytes,Comment")] Doc doc)
        {
            if (ModelState.IsValid)
            {
                doc.Id = Guid.NewGuid();
                db.Docs.Add(doc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(doc);
        }

        // GET: Docs/Edit/5
        public ActionResult Edit(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doc doc = db.Docs.Find(id);
            if (doc == null)
            {
                return HttpNotFound();
            }
            return View(doc);
        }

        // POST: Docs/Edit/5
        // Aşırı gönderim saldırılarından korunmak için, lütfen bağlamak istediğiniz belirli özellikleri etkinleştirin, 
        // daha fazla bilgi için https://go.microsoft.com/fwlink/?LinkId=317598 sayfasına bakın.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,DocBytes,Comment")] Doc doc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(doc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(doc);
        }

        // GET: Docs/Delete/5
        public ActionResult Delete(Guid? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Doc doc = db.Docs.Find(id);
            if (doc == null)
            {
                return HttpNotFound();
            }
            return View(doc);
        }

        // POST: Docs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(Guid id)
        {
            Doc doc = db.Docs.Find(id);
            db.Docs.Remove(doc);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
