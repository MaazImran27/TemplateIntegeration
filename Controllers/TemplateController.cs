﻿using Microsoft.AspNetCore.Mvc;

namespace Template_Integration.Controllers
{
    public class TemplateController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


		public IActionResult Shop()
		{
			return View();
		}

		public IActionResult AboutUs()
		{
			return View();
		}

		public IActionResult Services()
		{
			return View();
		}

		public IActionResult Blog()
		{
			return View();
		}

		public IActionResult ContactUs()
		{
			return View();
		}
	}

}
