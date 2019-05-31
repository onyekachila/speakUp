using SpeakUp.Models;
using SpeakUp.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace SpeakUp.Controllers
{
    public class EventsController : Controller
    {
        private readonly ApplicationDbContext _context;

        public EventsController()
        {
            _context = new ApplicationDbContext();  
        }

        // GET: Events
        public ActionResult Create()
        {
            var viewModel = new EventFormViewModel
            {
                Talks = _context.Talks.ToList()
            };
                     
            return View(viewModel);
        }
    }
}