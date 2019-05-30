using System.ComponentModel.DataAnnotations;

namespace SpeakUp.Models
{
    public class Talk
    {      
         public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }
        
    }
}