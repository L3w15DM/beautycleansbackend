using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FullStackAuth_WebAPI.Models
{
	public class Appointment
	{
		[Key]

		public int Id { get; set; }
        public DateOnly Date { get; set; }
        public DateTime Time { get; set; }
        public string SpecialInstructions { get; set; }

        [ForeignKey("User")]
        public string UserId { get; set; }
        public User User { get; set; }

        [ForeignKey("Package")]
        public string Package { get; set; }
       
        
    }
}

