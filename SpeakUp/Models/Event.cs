using System;
using System.ComponentModel.DataAnnotations;

namespace SpeakUp.Models
{
    public class Event
    {
        public int Id { get; set; }

        [Required]
        public ApplicationUser  Speaker { get; set; }
        public DateTime DateTime { get; set; }
        public string String { get; set; }

        [Required]
        [StringLength(255)]
        public string Venue { get; set; }

        [Required]
        public Talk Talk { get; set; }
    }    
}