using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace FullStackAuth_WebAPI.Models
{
	public class History
	{
		[Key]

		public int Id { get; set; }
		public string Description { get; set; }

		[ForeignKey("PaymentStatus")]
		public string PaymentStatus { get; set; }
		
	}
}

