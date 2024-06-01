using Microsoft.AspNetCore.Http.Extensions;
using Microsoft.AspNetCore.Mvc;
using Microsoft.IdentityModel.Tokens;
using System.Diagnostics;
using University.Models;

namespace University.Controllers
{
    public class HomeController : BaseController
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            url = Request.GetEncodedUrl();
            if (HttpContext.Session.GetString(UserName).IsNullOrEmpty() || HttpContext.Session.GetString(UserId).IsNullOrEmpty())
            {
                return View();
            }
            else
            {
                return RedirectToAction("IndexLogged");
            }
        }

        public IActionResult IndexLogged()
        {
            url = Request.GetEncodedUrl();
            return View();
        }

        public IActionResult Privacy()
        {
            //returnUrl = HttpContext.Request.Host.ToString();
            url = Request.GetEncodedUrl();
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}