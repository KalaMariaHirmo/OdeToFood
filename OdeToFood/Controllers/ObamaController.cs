using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class ObamaController : Controller
    {
		// GET: Obama
		public ActionResult Search(string name)
		{
			return Content("Obama " + name);
		}
	}
}