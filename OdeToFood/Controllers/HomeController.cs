using OdeToFood.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace OdeToFood.Controllers
{
	public class HomeController : Controller
	{
		OdeToFoodDb _db = new OdeToFoodDb();
		public ActionResult Index()
		{
			/*
			var model =
				from r in _db.Restaurants
				orderby r.Reviews.Average(ReviewController => review.Rating)
				select new RestaurantListViewModel
				{
					Id = r.Id,
					Name = r.Name,
					City = r.City,
					Country = r.Country,
					CountOfReviews = r.Reviews.Count()
				};
			*/

			//var controller = RouteData.Values["controlle"];
			//var action = RouteData.Values["action"];
			//var id = RouteData.Values["id"];
			//ViewBag.message = $"{controller} :: {action} - {id}";

			var model = _db.Restaurants.ToList();
			
			return View(model);
		}

		public ActionResult About()
		{
			ViewBag.Message = "Your application description page.";

			return View();
		}

		public ActionResult Contact()
		{
			ViewBag.Message = "Your contact page.";

			return View();
		}

		protected override void Dispose(bool disposing)
		{
			if (_db != null)
			{
				_db.Dispose();
			}
			base.Dispose(disposing);
		}
	}
}