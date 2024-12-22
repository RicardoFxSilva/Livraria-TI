using Microsoft.AspNetCore.Mvc;

namespace Livraria_TI.Controllers
{
    public class AdministradorController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
