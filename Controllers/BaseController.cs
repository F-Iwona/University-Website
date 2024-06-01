using Microsoft.AspNetCore.Mvc;

namespace University.Controllers
{
    public class BaseController : Controller
    {
        public static bool isLogged = false;
        protected static string url = "maslo";
        protected const string UserName = "_Name";
        protected const string UserId = "_Id";
    }
}
