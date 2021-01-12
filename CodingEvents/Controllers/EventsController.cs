using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        //static private List<string> Events = new List<string>();
        private static Dictionary<string, string> listOfEvents = new Dictionary<string, string>();

        // GET : /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            if (listOfEvents.ToList().Count == 0)
            {
                listOfEvents.Add("Strange Loop", "text");
                listOfEvents.Add("Women Who Code", "text");
                listOfEvents.Add("Diversify Tech", "text");

            }
            //Events.Add("Strange Loop");
            //Events.Add("Women Who Code");
            //Events.Add("Diversify Tech");

            ViewBag.listOfEvents =  listOfEvents;

            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            
            return View();
        }

        [HttpPost]  //annotations
        [Route("/Events/Add")]
        public IActionResult NewEvent(string name, string description)
        {

            return Redirect("/Events");
        }
    }
}
