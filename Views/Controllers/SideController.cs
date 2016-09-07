using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Views.Infrastructure;

namespace Views.Controllers
{
    public class SideController : Controller
    {
        private PersonRepository repository;

        public SideController()
        {
            repository = PersonRepository.Instance;

        }
        // GET: Side
        [ChildActionOnly]
        public ActionResult Join()
        {
            return PartialView("Footer");
        }

        [HttpPost]
        public ActionResult Join(string answer)
        {
            var person = repository.GetAll()[0];
            if (answer == "yes")
            {
                if (person.Side != "Dark")
                {
                    repository.GetAll()[0].Side = "Dark";
                }
                else
                {
                    return View("Footer", "LOL. There is no way out. PS your HR manager has been contacted.");
                }
            }
            return RedirectToAction("Index", "Person");
        }
    }
}