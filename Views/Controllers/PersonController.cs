using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Views.Infrastructure;

namespace Views.Controllers
{
    public class PersonController : Controller
    {
        private PersonRepository repository;

        public PersonController()
        {
            repository = PersonRepository.Instance;
        }

        // GET: Person
        public ActionResult Index()
        {
            return View("Person", repository.GetAll()[0]);
        }
    }
}