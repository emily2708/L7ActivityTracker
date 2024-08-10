using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using L7ActivityTracker.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace L7ActivityTracker.Controllers
{
    public class ActivityController : Controller
    {
        private readonly ApplicationDbContext _db;

        public ActivityController(ApplicationDbContext db)
        {
            _db = db;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            return View(_db.ActivityList.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        public IActionResult Create([Bind("Id,Name,Date")] Activity nextActivity)
        {
            if (ModelState.IsValid)
            {
                _db.ActivityList.Add(nextActivity);
                _db.SaveChanges();
                return RedirectToAction("Index");
            }
            return RedirectToAction("Index");
        }

    }
}

