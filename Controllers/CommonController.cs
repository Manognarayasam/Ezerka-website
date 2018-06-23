using Ezerkaproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Ezerkaproject.Controllers
{
    
    public class CommonController : Controller
    {

        // GET: Common
        public ActionResult About()
        {

            About model = new About();
            return View(model);
            
        }
    }
}