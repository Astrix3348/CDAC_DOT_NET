using System;
namespace ExOfActionResult.Models
{
	public class Person
	{
		public Guid id { get; set; } //Guid is the globally unique id
		public string? firstName { get; set; }
		public string? lastName { get; set; }
		public int age { get; set; }
	}
}

