using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class DefaultController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();

        public ActionResult Index()
        {
            return View();
        }

        public PartialViewResult PartialHead()
        {
            return PartialView();
        }

        public PartialViewResult PartialNavbar()
        {
            return PartialView();
        }

        public PartialViewResult PartialQuickContact()
        {
            var values = db.Social.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialFeature()
        {
            ViewBag.Behance = db.Social.Select(x => x.Behance).FirstOrDefault();
            ViewBag.Linkedin = db.Social.Select(x => x.Linkedin).FirstOrDefault();
            ViewBag.Facebook = db.Social.Select(x => x.Facebook).FirstOrDefault();
            ViewBag.Twitter = db.Social.Select(x => x.Twitter).FirstOrDefault();
            var values = db.About.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialService()
        {
            var values = db.Service.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialSkill()
        {
            var values = db.Skill.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialAward()
        {
            var value = db.Award.ToList();
            return PartialView(value);
        }

        public PartialViewResult PartialTestimonial()
        {
            var values = db.Testimonial.ToList();
            return PartialView(values);
        }

        public PartialViewResult PartialClient()
        {
            var value = db.Client.ToList();
            return PartialView(value);
        }

        public PartialViewResult PartialContact()
        {
            var values = db.About.ToList();
            return PartialView(values);
        }
    }
}

