using SpeakUp.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace SpeakUp.ViewModels
{
    public class EventFormViewModel
    {
        public string Venue { get; set; }
        public string Date { get; set; }
        public string Time { get; set; }
        public int Talk { get; set; }
        public IEnumerable<Talk> Talks { get; set; }
    } 
}