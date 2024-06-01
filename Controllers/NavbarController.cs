using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using University.Data;

namespace University.Controllers
{
    public class NavbarController : BaseController
    {
        private readonly ApplicationDbContext db;
        public NavbarController(ApplicationDbContext db)
        {
            this.db = db;
        }

        [Authorize(Roles = "Admin")]
        public IActionResult ForStudents()
        {
            return View();
        }

        [Authorize(Roles = "Admin")]
        public IActionResult ForLecturers()
        {
            return View();
        }
        public IActionResult Catalog()
        {
            return View();
        }
        public IActionResult CatalogLogged()
        {
            return View();
        }
        public IActionResult LogOut()
        {
            HttpContext.Session.Clear();
            TempData["success"] = "Logged out correctly.";
            return RedirectToAction("Index", "Home");
        }
    }
}
