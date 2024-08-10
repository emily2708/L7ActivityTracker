using System;
using System.ComponentModel.DataAnnotations;

namespace L7ActivityTracker.Models
{
	public class Activity
	{

        [Key]
        public int Id { get; set; }

        [Required]
        public string Name { get; set; }

        public DateTime Date { get; set; }
        
	}
}

