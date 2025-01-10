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
    [Authorize]
    public class A_ProdutoController : Controller
    {
        private readonly MyOptions _myOptions;
        private readonly LivroService _LivroService;
        private readonly IHttpContextAccessor _httpContextAccessor;
        private readonly ILogger<A_ProdutoController> _logger;

        public A_ProdutoController(IOptions<MyOptions> myOptions, IHttpContextAccessor httpContextAccessor)
        {
            _LivroService = new LivroService(myOptions);
            _httpContextAccessor = httpContextAccessor;
        }

        // Lista os produtos
        public IActionResult Index()
        {
            var model = GetIndexViewModel();
            return View("Index", model);
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

            return View(model);
        }


        [HttpPost]
        public IActionResult Create(LivroCreateViewModel model)
        {
            LivroDTO dto = new LivroDTO();
            dto.Titulo = model.Titulo;
            dto.Descricao = model.descricao;
            dto.Editora = model.Editora;
            dto.Preco = model.Preco;
            dto.Capa = model.Capa?.FileName ?? string.Empty;

            if (model.Capa != null)
            {
                try
                {
                    var folderPath = Path.Combine(Directory.GetCurrentDirectory(), "wwwroot/Images/ImgLivros");

                    if (!Directory.Exists(folderPath))
                    {
                        Directory.CreateDirectory(folderPath);
                    }

                    var filePath = Path.Combine(folderPath, model.Capa.FileName);

                    using (var stream = new FileStream(filePath, FileMode.Create))
                    {
                        model.Capa.CopyTo(stream);
                    }
                }
                catch (Exception ex)
                {
                    ViewBag.ErrorMessage = "Erro: " + ex.Message;
                    return View(model);
                }
            }
            ExecutionResult<LivroDTO> result = _LivroService.Insert(dto, GetUsername());

            return View("Index", GetIndexViewModel());
        }





        public IActionResult Edit(int id)
        {
            LivroEditViewModel model = new LivroEditViewModel();

            LivroDTO produto = _LivroService.Get(id).Results.FirstOrDefault();
            model.Id_livro = produto.Id_Livro;
            model.titulo = produto.Titulo;
            model.Preco = produto.Preco;
            model.Editora = produto.Editora;
            model.descricao = produto.Descricao;

            return View("Edit", model);
        }

        [HttpPost]
        public IActionResult Edit(LivroEditViewModel model)
        {
            LivroDTO dto = new LivroDTO();
            dto.Id_Livro = model.Id_livro;
            dto.Titulo = model.Titulo;
            dto.Editora = model.Editora;
            dto.Descricao = model.descricao;
            dto.Preco = model.Preco;

            ExecutionResult<LivroDTO> result = _LivroService.Update(dto, GetUsername());

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
            LivroEditViewModel model = new LivroEditViewModel();

            ExecutionResult<LivroDTO> result = _LivroService.Delete(id);

            return View("Index", GetIndexViewModel());
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