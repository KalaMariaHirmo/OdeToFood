﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
    public class ThanosController : Controller
    {
		// GET: Thanos
		public ActionResult Search(string name)
		{
			return Content("Thanos did " + name);
		}
	}
}