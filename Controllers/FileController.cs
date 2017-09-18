using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using AllergicBeauty.Models;

namespace AllergicBeauty.Controllers
{
    public class FileController : Controller
    {
        private StoreContext1 db = new StoreContext1();
        //
        // GET: /File/
        public ActionResult Index(int id)
        {
            var fileToRetrieve = db.Files.Find(id);
            return File(fileToRetrieve.Content, fileToRetrieve.ContentType);
        }
    }
}