﻿using Microsoft.AspNetCore.Mvc;

namespace App.Web.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class PageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
