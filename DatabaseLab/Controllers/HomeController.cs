using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DatabaseLab.Controllers
{
    using System.Data.Entity;
    using System.Net;
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

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Create(User user)
        {
            try
            {
                if (this.ModelState.IsValid)
                {
                    this.dbContext.Users.Add(user);
                    this.dbContext.SaveChanges();
                    return RedirectToAction("Index");
                }

                return this.View(user);
            }
            catch (Exception)
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Details(int? id)
        {
            if (id==null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var user = this.dbContext.Users.First(x => x.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }

            return View(user);
        }

        [HttpGet]
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var user = this.dbContext.Users.First(x => x.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }

            return View(user);
        }

        [HttpPost]
        public ActionResult Edit(User user)
        {
            try
            {
                if (this.ModelState.IsValid)
                {
                    this.dbContext.Entry(user).State = EntityState.Modified;
                    this.dbContext.SaveChanges();
                    return RedirectToAction("Index");
                }

                return this.View(user);
            }
            catch
            {
                return View();
            }
        }

        [HttpGet]
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }

            var user = this.dbContext.Users.First(x => x.Id == id);
            if (user == null)
            {
                return HttpNotFound();
            }

            return View(user);
        }

        [HttpPost]
        public ActionResult Delete(User user)
        {
            try
            {
                if (this.ModelState.IsValid)
                {
                    this.dbContext.Entry(user).State = EntityState.Deleted;
                    this.dbContext.SaveChanges();
                    return RedirectToAction("Index");
                }

                return this.View(user);
            }
            catch
            {
                return View();
            }
        }
    }
}