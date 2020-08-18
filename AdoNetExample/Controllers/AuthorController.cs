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
    }
}