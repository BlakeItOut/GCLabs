using CandyShop.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CandyShop.Controllers
{
    public class HomeController : Controller
    {
        private CandyShopContext db = new CandyShopContext();
        // GET: Home
        public ActionResult Index(string searchString)
        {
            var items = from i in db.Items
                        select i;

            if (!String.IsNullOrEmpty(searchString))
            {
                items = items.Where(s => s.Name.Contains(searchString) || s.Description.Contains(searchString));
            }

            return View(items);
        }
    }
}