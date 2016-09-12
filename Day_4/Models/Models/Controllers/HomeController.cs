using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Models.Data;
using Models.Models;

namespace Models.Controllers
{
    public class HomeController : Controller
    {
	    private readonly IPersonRepo _repo;

	    public HomeController(IPersonRepo personRepo)
	    {
		    _repo = personRepo;
	    }

        public ActionResult Index(int id)
        {
	        var person = _repo.GetAll().First(p => p.PersonId == id);
			return View(person);
        }

        [HttpGet]
        public ActionResult CreatePerson()
        {
            return View(new Person());
        }

        [HttpPost]
        public ActionResult CreatePerson(Person model)
        {
            return View("Idnex", model);
        }

        [HttpGet]
        public ActionResult DisplaySummary()
        {
            return View();
        }

        [HttpPost]
        public ActionResult DisplaySummary(Address summary)
        {
            return View(summary);
        }

        public ActionResult Names(string[] names)
        {
            names = names ?? new string[0];
            return View(names);
        }

        public ActionResult Address(IList<Address> addresses)
        {
            //var addresses = new List<Address>();
            //UpdateModel(addresses);
            addresses = addresses ?? new List<Address>();
            return View(addresses);
        }
    }
}