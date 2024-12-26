using Livraria_TI.Helpers;
using Livraria_TI.Models.ViewModels.Livro;
using Livraria_TI.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace Livraria_TI.Controllers
{
    public class DetalheController : Controller
    {
        private readonly MyOptions _myOptions;
        private readonly LivroService _LivroService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ILogger<A_ProdutoController> _logger;

        public DetalheController(IOptions<MyOptions> myOptions, IHttpContextAccessor httpContextAccessor)
        {
            _LivroService = new LivroService(myOptions);
            _httpContextAccessor = httpContextAccessor;
        }
        public IActionResult Index()
        {
            return View();
        }

        private LivroIndexViewModel GetIndexViewModel(int? id)
        {
            LivroIndexViewModel model = new LivroIndexViewModel
            {
                livros = _LivroService.Get(id).Results
            };
            return model;
        }
        public IActionResult Detalhe(int? id)
        {
            var model = GetIndexViewModel(id);
            return View("Detalhe", model);
        }
    }
}
