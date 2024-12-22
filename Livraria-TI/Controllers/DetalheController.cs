using Microsoft.AspNetCore.Mvc;

namespace Livraria_TI.Controllers
{
    public class DetalheController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Detalhe(int? id)
        {
            return View(id);
        }
    }
}
