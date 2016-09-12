using Day2.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using System.Web.Mvc;

namespace Day2.Controllers
{
    public class RemoteDataController : Controller
    {
        // GET: RemoteData
        public async Task<ActionResult> Data()
        {
            var service = new RemoteService();
            string data = await Task.Run(() => service.GetRemoteData());
            return View((object)data);
        }
    }
}