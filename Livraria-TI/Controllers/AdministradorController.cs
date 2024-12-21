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
        private readonly MyOptions _myOptions;
        private readonly LivroService _LivroService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private const string ViewPath = "~/Views/Administrador/Produto/";
        private readonly ILogger<AdministradorController> _logger;

        public AdministradorController(IOptions<MyOptions> myOptions, IHttpContextAccessor httpContextAccessor)
        {
            _LivroService = new LivroService(myOptions);
            _httpContextAccessor = httpContextAccessor;
        }

        // Lista os produtos
        public IActionResult Index()
        {
            var model = GetIndexViewModel();
            return View($"{ViewPath}Index.cshtml", model);
        }

        private LivroIndexViewModel GetIndexViewModel()
        {
            LivroIndexViewModel model = new LivroIndexViewModel
            {
                livros = _LivroService.Get().Results
            };
            return model;
        }

        public IActionResult Create()
        {
            LivroCreateViewModel model = new LivroCreateViewModel();

            return View($"{ViewPath}Create.cshtml", model);
        }

        [HttpPost]
        public IActionResult Create(LivroCreateViewModel model)
        {
            LivroDTO dto = new LivroDTO();
            dto.Titulo = model.Titulo;
            dto.Editora = model.Editora;
            dto.Descricao = model.descricao;
            dto.Preco = model.Preco;

            ExecutionResult<LivroDTO> result = _LivroService.Insert(dto, GetUsername());

            return View($"{ViewPath}Index.cshtml", GetIndexViewModel());
        }

        [HttpPost]
        public IActionResult Edit(LivroEditViewModel model)
        {
            LivroDTO dto = new LivroDTO();
            dto.Titulo = model.Titulo;
            dto.Editora = model.Editora;
            dto.Descricao = model.descricao;
            dto.Preco = model.Preco;

            ExecutionResult<LivroDTO> result = _LivroService.Update(dto, GetUsername());

            return View(model);
        }

        private string GetUsername()
        {
            return _httpContextAccessor.HttpContext.User.FindFirstValue(ClaimTypes.Name);
        }
        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}