using Day2.Infrastructure;
using Day2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.SessionState;

namespace Day2.Controllers
{
    [SessionState(SessionStateBehavior.Disabled)]
    public class CustomerController : Controller
    {
        public ActionResult Index()
        {
            return View("Result", new Result
            {
                ControllerName = "CustomerController",
                ActionName = "Index"
            });
        }

        [ActionName("Index")]
        [Local]
        public ActionResult LocalIndex()
        {
            return View("Result", new Result
            {
                ControllerName = "CustomerController",
                ActionName = "LocalIndex"
            });
        }

        public ActionResult List()
        {
            return View("Result", new Result
            {
                ControllerName = "CustomerController",
                ActionName = "List"
            });
        }
    }
}