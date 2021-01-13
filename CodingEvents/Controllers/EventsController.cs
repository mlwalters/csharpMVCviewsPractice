using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using CodingEvents.Models;
using CodingEvents.Data;


namespace CodingEvents.Controllers
{
    public class EventsController : Controller
    {
        //static private List<string> Events = new List<string>();
        // private static Dictionary<string, string> listOfEvents = new Dictionary<string, string>();
        // static private List<Event> Events = new List<Event>(); // use EventData instead of this list

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

            ViewBag.events = EventData.GetAll();

            return View();
        }

        [HttpGet]
        public IActionResult Add()
        {
            return View();
        }

        [HttpPost]  //annotations, request type attribute
        [Route("/Events/Add")]
        public IActionResult NewEvent(Event newEvent)
        {
            EventData.Add(newEvent);

            return Redirect("/Events");
        }

        public IActionResult Delete()
        {
            ViewBag.events = EventData.GetAll();
            return View();
        }

        [HttpPost]
        public IActionResult Delete(int[] eventIds)
        {
            foreach(int eventId in eventIds)
            {
                EventData.Remove(eventId);
            }

            return Redirect("/Events");
        }
    }
}
