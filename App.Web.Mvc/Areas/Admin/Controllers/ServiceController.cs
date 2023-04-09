using App.Data;
using App.Data.Entity;
using App.Web.Mvc.Utils;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;

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
        public async Task<IActionResult> Create(Service service)
        {

            await _context.Services.AddAsync(service);            
            await _context.SaveChangesAsync();            
            return RedirectToAction(nameof(Index));



        }


        // GET: ServiceController/Edit/5
        public async Task<ActionResult> DeleteAsync(int id)
        {
            var model = await _context.FindAsync(typeof(int));
            return View(model);
        }

        // POST: ServiceController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> EditAsync(int id, Service service)
        {
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(service);
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

        // GET: ServiceController/Delete/5
        public ActionResult Delete(int id)
        {
            var model =  _context.Find(typeof(int));
            return View(model);
        }


        // POST: ServiceController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, Service service)
        {
            try
            {
              
                _context.Remove(service);
                 _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
