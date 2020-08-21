using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AdoNetExample.Models;
namespace AdoNetExample.Controllers
{
    public class AuthorController : Controller
    {
        // GET: Author
        AuthorContext db = new AuthorContext();
        public ActionResult Index()
        {
            return View(db.GetAuthors());
        }
        [HttpGet]
        public ActionResult Create() {

            return View();
        }
        [HttpPost]
        public ActionResult Create(AuthorModel Authobj)
        {
            int i = db.SaveAuthors(Authobj);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
            
        }
        [HttpGet]
        public ActionResult Edit(int? id)
        {
            AuthorModel auth = db.getAuthodById(id);
            return View(auth);
        }
        [HttpPost]
        public ActionResult Edit(FormCollection frm)
        {
            AuthorModel obj = new Models.AuthorModel();
            obj.AuthorId = Convert.ToInt32(frm[0]);
            obj.AuthorName = Convert.ToString(frm[1]);
            obj.Description = Convert.ToString(frm[2]);

            int i = db.EditAuthors(obj);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }


        [HttpGet]
        public ActionResult Delete(int? id)
        {
            AuthorModel auth = db.getAuthodById(id);
            return View(auth);
        }
        [HttpPost]
        [ActionName("Delete")]
        public ActionResult DeleteConfirmed(int?id)
        {
            
            int i = db.DeleteAuthors(id);
            if (i > 0)
            {
                return RedirectToAction("Index");
            }
            else
            {
                return View();
            }
        }
    }
}