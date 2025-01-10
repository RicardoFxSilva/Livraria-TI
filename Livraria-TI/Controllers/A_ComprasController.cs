using Livraria_TI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Livraria_TI.Helpers;
using Livraria_TI.Models.DTOs;
using Livraria_TI.Models.ViewModels.Cliente;
using Livraria_TI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using System.Security.Claims;
using Livraria_TI.Models.ViewModels.Compra;

namespace Livraria_TI.Controllers
{
    [Authorize]
    public class A_ComprasController : Controller
        {
            private readonly MyOptions _myOptions;
            private readonly ComprasService _ComprasService;
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly ILogger<A_ComprasController> _logger;

            public A_ComprasController(IOptions<MyOptions> myOptions, IHttpContextAccessor httpContextAccessor)
            {
                _ComprasService = new ComprasService(myOptions);
                _httpContextAccessor = httpContextAccessor;
            }

            // Lista os clientes
            public IActionResult Index()
            {
                var model = GetIndexViewModel();
                return View("Index", model);
            }

            private CompraIndexViewModel GetIndexViewModel()
            {
                CompraIndexViewModel model = new CompraIndexViewModel
                {
                    Compras = _ComprasService.Get().Results
                };
                return model;
            }

            [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
            public IActionResult Error()
            {
                return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
            }
        }
    }


