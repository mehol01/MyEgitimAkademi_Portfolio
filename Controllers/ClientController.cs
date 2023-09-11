using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using MyEgitimAkademi_Portfolio.Models;

namespace MyEgitimAkademi_Portfolio.Controllers
{
    public class ClientController : Controller
    {
        MyPortfolioDbEntities db = new MyPortfolioDbEntities();

        [Authorize]
        public ActionResult Index()
        {
            var value = db.Client.ToList();
            return View(value);
        }

        [HttpGet]
        public ActionResult AddClient()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddClient(Client client)
        {
            db.Client.Add(client);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        public ActionResult DeleteClient(int id)
        {
            var value = db.Client.Find(id);
            db.Client.Remove(value);
            db.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpGet]
        public ActionResult UpdateClient(int id)
        {
            var value = db.Client.Find(id);
            return View(value);
        }

        [HttpPost]
        public ActionResult UpdateClient(Client client)
        {
            var value = db.Client.Find(client.ClientID);
            value.ClientNameSurname = client.ClientNameSurname;
            value.ClientDescription = client.ClientDescription;
            value.ClientImage = client.ClientImage;
            db.SaveChanges();
            return RedirectToAction("Index");
        }




    }
}