using System;
using System.ComponentModel.DataAnnotations;

namespace ExOfModelValidation.Models
{
    public class Person
    {
        [Required]
        public string? PersonName { get; set; }

        public string? Email { get; set; }
        

        public override string ToString()
        {
            return $"Person object - Person name: {PersonName}, Email: {Email}";
        }
    }
}

