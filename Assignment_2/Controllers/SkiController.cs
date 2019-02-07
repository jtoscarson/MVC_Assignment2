using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Assignment_2.Models;

namespace Assignment_2.Controllers
{
    public class SkiController : Controller
    {
        // GET: Ski
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Resorts()
        {
            var resortslist = new List<SkiResort>
            {
                new SkiResort { Name = "Sundance", Location = "Utah County", TopElevation = 8250, BaseElevation = 6100, NumberOfLifts = 4 },
                new SkiResort { Name = "Snowbird", Location = "Salt Lake County", TopElevation = 11000, BaseElevation = 7760, NumberOfLifts = 13 },
                new SkiResort { Name = "Alta", Location = "Salt Lake County", TopElevation = 10550, BaseElevation = 8530, NumberOfLifts = 7 },
                new SkiResort { Name = "Solitude", Location = "Salt Lake County", TopElevation = 10035, BaseElevation = 7988, NumberOfLifts = 8 },
                new SkiResort { Name = "Brighton", Location = "Salt Lake County", TopElevation = 10750, BaseElevation = 8755, NumberOfLifts = 6 },
                new SkiResort { Name = "Park City", Location = "Summit County", TopElevation = 10000, BaseElevation = 6900, NumberOfLifts = 19 }
            };
            return View();
        }

        public ActionResult SkiPassOptions()
        {
            return View();
        }

    }
}