using Livraria_TI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Livraria_TI.Helpers;
using Livraria_TI.Models.DTOs;
using Livraria_TI.Models.ViewModels.Livro;
using Livraria_TI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using System.Security.Claims;

namespace Livraria_TI.Controllers
{
    public class AdministradorController : Controller
    {
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