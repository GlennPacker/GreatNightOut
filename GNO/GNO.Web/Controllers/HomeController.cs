using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using GNO.Core;

namespace GNO.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly IPartyService _partyService;

        public HomeController(IPartyService partyService)
        {
            _partyService = partyService;
        }

        public ActionResult Index()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            return View();
        }

        public ActionResult Events()
        {
            ViewBag.Message = "Your app description page.";

            return View();
        }

        public ActionResult LatestMembers()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }
    }
}
