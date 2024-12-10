using Microsoft.AspNetCore.Mvc;

namespace Livraria_TI.Controllers
{
    public class CheckoutController : Controller
    {

        public IActionResult Checkout()
        {
            return View();
        }
    }
}
