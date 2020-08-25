using AdoNetExample.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace AdoNetExample.Controllers
{
    public class BooksController : Controller
    {
        // GET: Books
        LibraryContext db = new LibraryContext();
        AuthorContext dbAuth = new AuthorContext();
        public ActionResult Create()
        {
            BookModel bkmodel = new BookModel();
            bkmodel.BookName = "C# Book";
            ViewBag.bkCategory = new SelectList(db.GetBookCategory(), "CategoryBookName", "CategoryBookName");
            ViewBag.bkAuthor = new SelectList(dbAuth.GetAuthors(), "AuthorId", "AuthorName");
           
            return View(bkmodel);
        }
        [HttpPost]
        public ActionResult Create(string bkCategory, HttpPostedFileBase ImageName)
        {
            string filename = Path.GetFileName(ImageName.FileName);
            string path = Server.MapPath("~/upload");
            ImageName.SaveAs(Path.Combine(path, filename));
            string file = "~/upload" + filename;

            BookModel bkmodel = new BookModel();
            bkmodel.BookName = "C# Book";
            ViewBag.bkCategory = new SelectList(db.GetBookCategory(), "CategoryBookName", "CategoryBookName");
            ViewBag.bkAuthor = new SelectList(dbAuth.GetAuthors(), "AuthorId", "AuthorName");

            return View(bkmodel);
        }
    }
}