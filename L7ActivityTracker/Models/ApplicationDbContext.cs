using System;
using Microsoft.EntityFrameworkCore;

namespace L7ActivityTracker.Models
{
	public class ApplicationDbContext : DbContext
	{
		public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
		{
			Database.EnsureCreated();
		}

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
			optionsBuilder.UseSqlite("Filename=./ActivityList.sqlite");
        }

		public DbSet<Activity> ActivityList { get; set; }
    }
}

