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

        [ChildActionOnly]
        public ActionResult Join()
        {
            return PartialView("Footer");
        }

        public ActionResult SwitchSides(string answer)
        {
            var person = repository.GetAll()[0];
            if (answer.ToLower() == "yes")
            {
                if (person.Side != "Dark")
                {
                    repository.GetAll()[0].Side = "Dark";
                }
                else
                {
                    return View("Footer", (object)"LOL. There is no way out. PS your HR manager has been contacted.");
                }
            }
            return RedirectToAction("Index", "Person");
        }
    }
}