using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class AwardController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();
        [Authorize]
        public ActionResult Index()
        {
            var value = db.Award.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult AddAward()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddAward(Award award)
        {
            var value = db.Award.Add(award);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteAward(int id)
        {
            var value = db.Award.Find(id);
            db.Award.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateAward(int id)
        {
            var value = db.Award.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateAward(Award award)
        {
            var value = db.Award.Find(award.AwardID);
            value.AwardName = award.AwardName;
            value.AwardDescription = award.AwardDescription;
            db.SaveChanges();
            return RedirectToAction("Index");
        }




    }
}