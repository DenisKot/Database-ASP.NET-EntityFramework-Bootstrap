using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseLab.Controllers
{
    using DatabaseConnector;

    public class HomeController : Controller
    {
        private readonly MyDbContext dbContext;

        public HomeController()
        {
            this.dbContext = new MyDbContext();
        }

        // GET: Home
        public ActionResult Index()
        {
            var list = this.dbContext.Users.ToList();
            this.ViewBag.users = list;

            return View();
        }
    }
}