using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace TraversalCoreProject.Controllers
{
    public class LoginController : Controller
    {
        [AllowAnonymous]
        [HttpGet]
        public IActionResult SingUp()
        {
            return View();
        }
        //[HttpPost]
        //public IActionResult SingUp()
        //{
        //    return View();
        //}
        [HttpGet]
        public IActionResult SingIn()
        {
            return View();
        }

    }
}
