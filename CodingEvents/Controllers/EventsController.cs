using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingEvents.Models;


namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        //static private List<string> Events = new List<string>();
        // private static Dictionary<string, string> listOfEvents = new Dictionary<string, string>();

        static private List<Event> Events = new List<Event>();

        // GET : /<controller>/
        [HttpGet]
        public IActionResult Index()
        {
            //Events.Add("Strange Loop");       //for the old list
            //Events.Add("Women Who Code");
            //Events.Add("Diversify Tech");

            //if (listOfEvents.ToList().Count == 0)         // optional auto populated events
            //{
            //    listOfEvents.Add("Strange Loop", "text");
            //    listOfEvents.Add("Women Who Code", "text");
            //    listOfEvents.Add("Diversify Tech", "text");
            //}
            //ViewBag.listOfEvents =  listOfEvents;

            ViewBag.events = Events;

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
            Events.Add(new Event(name, description));

            return Redirect("/Events");
        }
    }
}
