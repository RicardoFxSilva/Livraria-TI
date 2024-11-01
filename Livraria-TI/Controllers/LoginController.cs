using Microsoft.AspNetCore.Mvc;

namespace Livraria_TI.Controllers
{
    public class LoginController : Controller
    {
        public IActionResult Registrar()
        {
            return View();
        }
        public IActionResult Login()
        {
            return View();
        }
    }
}
