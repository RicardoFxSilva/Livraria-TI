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

namespace Livraria_TI.Controllers
{
    public class A_ClienteController : Controller
        {
            private readonly MyOptions _myOptions;
            private readonly ClienteService _ClienteService;
            private readonly IHttpContextAccessor _httpContextAccessor;
            private readonly ILogger<A_ClienteController> _logger;

            public A_ClienteController(IOptions<MyOptions> myOptions, IHttpContextAccessor httpContextAccessor)
            {
                _ClienteService = new ClienteService(myOptions);
                _httpContextAccessor = httpContextAccessor;
            }

            // Lista os clientes
            public IActionResult Index()
            {
                var model = GetIndexViewModel();
                return View("Index", model);
            }

            private ClienteIndexViewModel GetIndexViewModel()
            {
                ClienteIndexViewModel model = new ClienteIndexViewModel
                {
                    Clientes = _ClienteService.Get().Results
                };
                return model;
            }

            public IActionResult Create()
            {
                ClienteCreateViewModel model = new ClienteCreateViewModel();

                return View("Create", model);
            }

            [HttpPost]
            public IActionResult Create(ClienteCreateViewModel model)
            {
                UtilizadorDTO dto = new UtilizadorDTO();
                dto.NomeUtilizador= model.NomeUtilizador;
                dto.Email= model.Email;
                dto.Password= model.Password;
                dto.Morada = model.Morada;

                ExecutionResult<UtilizadorDTO> result = _ClienteService.Insert(dto, GetUsername());

                return View("Index", GetIndexViewModel());
            }
            public IActionResult Edit(int id)
            {
                ClienteEditViewModel model = new ClienteEditViewModel();

                UtilizadorDTO produto = _ClienteService.Get(id).Results.FirstOrDefault();
                model.Id_Utilizador = produto.Id_Utilizador;
                model.NomeUtilizador = produto.NomeUtilizador;
                model.Email = produto.Email;
                
                return View("Edit", model);
            }

            [HttpPost]
            public IActionResult Edit(ClienteEditViewModel model)
            {
                UtilizadorDTO dto = new UtilizadorDTO();
                dto.Id_Utilizador = model.Id_Utilizador;
                dto.NomeUtilizador = model.NomeUtilizador;
                dto.Email = model.Email;

                ExecutionResult<UtilizadorDTO> result = _ClienteService.Update(dto, GetUsername());

                return RedirectToAction("Index");
            }

            public IActionResult Delete(int id)
            {
                ClienteEditViewModel model = new ClienteEditViewModel();

                ExecutionResult<UtilizadorDTO> result = _ClienteService.Delete(id);

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


