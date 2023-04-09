﻿using App.Data;
using App.Data.Entity;
using App.Web.Mvc.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Drawing.Drawing2D;

namespace App.Web.Mvc.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class ServiceController : Controller
    {
        private readonly AppDbContext? _context;
       

        public ServiceController(AppDbContext context)
        {
            _context = context;
        }

        // GET: ServiceController
        public async Task<ActionResult> Index()
        {
            var model =await _context.Services.ToListAsync();
            return View(model);
        }

        // GET: ServiceController/Details/5
        public ActionResult Details(int id)
        {

            return View();
        }

        // GET: ServiceController/Create
        public async Task<IActionResult> Create()
        {
            return View();
        }

        // POST: ServiceController/Create
        // POST: CategoriesController/Create
        [HttpPost]        
        public async Task<IActionResult> Create(Service service, IFormFile? Logo)
        {

            if (ModelState.IsValid) // Model class ımız olan brand nesnesinin validasyon için koyduğumuz kurallarınıa (örneğin marka adı required-boş geçilemez gibi) uyulmuşsa
            {
                try
                {
                    service.Image = await FileHelpers.FileLoaderAsync(Logo);
                    await _context.AddAsync(service);
                    await _context.SaveChangesAsync();
                    return RedirectToAction(nameof(Index));
                }
                catch
                {
                    ModelState.AddModelError("", "Hata Oluştu!");
                }
            }

            return View(service);



        }


        // GET: ServiceController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ServiceController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ServiceController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ServiceController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}