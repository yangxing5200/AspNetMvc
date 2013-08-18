using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MvcApplication1.Models;

namespace MvcApplication1.Controllers
{
    public class YxUserController : Controller
    {
        private YxUsersContext db = new YxUsersContext();

        //
        // GET: /YxUser/

        public ActionResult Index()
        {
            return View(db.YxUserProfile.ToList());
        }

        //
        // GET: /YxUser/Details/5

        public ActionResult Details(int id = 0)
        {
            YxUserProfile yxuserprofile = db.YxUserProfile.Find(id);
            if (yxuserprofile == null)
            {
                return HttpNotFound();
            }
            return View(yxuserprofile);
        }

        //
        // GET: /YxUser/Create

        public ActionResult Create()
        {
            return View();
        }

        //
        // POST: /YxUser/Create

        [HttpPost]
        public ActionResult Create(YxUserProfile yxuserprofile)
        {
            if (ModelState.IsValid)
            {
                db.YxUserProfile.Add(yxuserprofile);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(yxuserprofile);
        }

        //
        // GET: /YxUser/Edit/5

        public ActionResult Edit(int id = 0)
        {
            YxUserProfile yxuserprofile = db.YxUserProfile.Find(id);
            if (yxuserprofile == null)
            {
                return HttpNotFound();
            }
            return View(yxuserprofile);
        }

        //
        // POST: /YxUser/Edit/5

        [HttpPost]
        public ActionResult Edit(YxUserProfile yxuserprofile)
        {
            if (ModelState.IsValid)
            {
                db.Entry(yxuserprofile).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(yxuserprofile);
        }

        //
        // GET: /YxUser/Delete/5

        public ActionResult Delete(int id = 0)
        {
            YxUserProfile yxuserprofile = db.YxUserProfile.Find(id);
            if (yxuserprofile == null)
            {
                return HttpNotFound();
            }
            return View(yxuserprofile);
        }

        //
        // POST: /YxUser/Delete/5

        [HttpPost, ActionName("Delete")]
        public ActionResult DeleteConfirmed(int id)
        {
            YxUserProfile yxuserprofile = db.YxUserProfile.Find(id);
            db.YxUserProfile.Remove(yxuserprofile);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        protected override void Dispose(bool disposing)
        {
            db.Dispose();
            base.Dispose(disposing);
        }
    }
}