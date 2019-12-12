using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using OdeToFood.Models;

namespace OdeToFood.Controllers
{
	public class ReviewsController : Controller
	{
		/*
		public ActionResult BestReview()
		{					
			var best = from r in 
		}
		*/
		// GET: Review
		public ActionResult Index()
		{
			var model = from r in _review
						orderby r.Country
						select r;
			return View(model);
		}

		// GET: Review/Details/5
		public ActionResult Details(int id)
		{
			return View();
		}

		// GET: Review/Create
		public ActionResult Create()
		{
			return View();
		}

		// POST: Review/Create
		[HttpPost]
		public ActionResult Create(FormCollection collection)
		{
			try
			{
				// TODO: Add insert logic here

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}

		// GET: Review/Edit/5
		public ActionResult Edit(int id)
		{
			return View();
		}

		// POST: Review/Edit/5
		[HttpPost]
		public ActionResult Edit(int id, FormCollection collection)
		{
			try
			{
				// TODO: Add update logic here

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}

		// GET: Review/Delete/5
		public ActionResult Delete(int id)
		{
			return View();
		}

		// POST: Review/Delete/5
		[HttpPost]
		public ActionResult Delete(int id, FormCollection collection)
		{
			try
			{
				// TODO: Add delete logic here

				return RedirectToAction("Index");
			}
			catch
			{
				return View();
			}
		}
		static List<RestaurantReview> _review = new List<RestaurantReview>
		{
			new RestaurantReview
			{
				Id = 1,
				Name = "Cinamon Club",
				City = "London",
				Country = "UK",
				Rating = 10,
			},
			new RestaurantReview
			{
				Id = 1,
				Name = "Obamos",
				City = "Mmmmmmmm",
				Country = "USA",
				Rating = 6,
			},
			new RestaurantReview
			{
				Id = 1,
				Name = "YES",
				City = "Maybe",
				Country = "Definetly",
				Rating = 9,
			}
		};
		public ActionResult Index([Bind(Prefix = "id")]
    }
}
