using Livraria_TI.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace Livraria_TI.Controllers
{
    [Authorize]
    public class AdministradorController : Controller
    {
        [Authorize (Roles = "Admin")]
        public IActionResult Index()
        {
           
            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}