using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        static private List<string> Events = new List<string>();
        // GET : /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            Events.Add("Strange Loop");
            Events.Add("Women Who Code");
            Events.Add("Diversify Tech");
            ViewBag.events = Events;

            return View();
        }
    }
}
