using Livraria_TI.Models;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;
using Livraria_TI.Helpers;
using Livraria_TI.Models.DTOs;
using Livraria_TI.Models.ViewModels.Cliente;
using Livraria_TI.Models.ViewModels.Livro;
using Livraria_TI.Services;
using Microsoft.AspNetCore.Authorization;
using Microsoft.Extensions.Options;
using System.Security.Claims;

namespace Livraria_TI.Controllers
{
    public class HomeController : Controller
    {

        private readonly MyOptions _myOptions;
        private readonly UtilizadorService _UtilizadorService;
        private readonly LivroService _LivroService;
        private readonly IHttpContextAccessor _httpContextAccessor;

        private readonly ILogger<HomeController> _logger;

        public HomeController(IOptions<MyOptions> myOptions, IHttpContextAccessor httpContextAccessor)
        {
            _LivroService = new LivroService(myOptions);
            _UtilizadorService = new UtilizadorService(myOptions);
            _httpContextAccessor = httpContextAccessor;
        }

        public IActionResult Index()
        {
            return View(GetIndexViewModel());
        }

        private LivroIndexViewModel GetIndexViewModel()
        {
            LivroIndexViewModel model = new LivroIndexViewModel();
            model.livros = _LivroService.Get().Results;

            return model;
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
