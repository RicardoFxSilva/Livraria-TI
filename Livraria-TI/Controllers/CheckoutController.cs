using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace Livraria_TI.Controllers
{
    [Authorize]
    public class CheckoutController : Controller
    {

        public IActionResult Checkout()
        {
            return View();
        }

        [AllowAnonymous]
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Carinho()
        {
            return View();
        }
    }
}
