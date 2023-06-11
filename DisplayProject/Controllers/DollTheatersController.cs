using DisplayProject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace DisplayProject.Controllers
{
    public class DollTheatersController : Controller
    {
        private static List<DollTheaters> dollTheaters = new List<DollTheaters>()
    {
        new DollTheaters { Id = 1, Name = "Самарский театр кукол", City = "Самара", OpenDate = new DateTime(1932, 10, 20), NumberOfPerfomances = 102, AveragePerfomancePrice = 1350, AnnualRevenue = 2100000000 },
        new DollTheaters { Id = 2, Name = "Санкт-Петербургский кукольный театр сказки", City = "Санкт-Петербург", OpenDate = new DateTime(1944, 2, 10), NumberOfPerfomances = 75, AveragePerfomancePrice = 1590, AnnualRevenue = 1700000000 },
        new DollTheaters { Id = 3, Name = "Сахалинский театр кукол", City = "Сахалин", OpenDate = new DateTime(1985, 11, 24), NumberOfPerfomances = 11, AveragePerfomancePrice = 4400, AnnualRevenue = 600000000 }
    };

        private void AddDollTheaterToList(DollTheaters dollTheater)
        {
            dollTheater.Id = dollTheaters.Count + 1;
            dollTheaters.Add(dollTheater);
        }

        public ActionResult Index()
        {
            return View(dollTheaters.ToList());
        }

        [HttpGet]
        public ActionResult AddTheater()
        {
            return View();
        }

        [HttpPost]
        public ActionResult AddTheater(DollTheaters dollTheater)
        {
            if (ModelState.IsValid)
            {
                AddDollTheaterToList(dollTheater);
                return RedirectToAction("Index");
            }
            return View(dollTheater);
        }
    }
}