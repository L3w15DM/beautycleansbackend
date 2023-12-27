using System;
using System.ComponentModel.DataAnnotations;

namespace FullStackAuth_WebAPI.Models
{
	public class Package
	{
		[Key]
		public int Id { get; set; }
		public string Name { get; set; }
		public double Price { get; set; }
		public string Description { get; set; }
	}
}

