using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SalonDeBellezaCarlitos.BusinessLogic.Services;
using SalonDeBellezaCarlitos.Entities.Entities;
using SalonDeBellezaCarlitos.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalonDeBellezaCarlitos.WebUI.Controllers
{
    public class ClientesController : Controller
    {
        private readonly GeneralesServices _generalesService;

        private readonly IMapper _mapper;

        public ClientesController(GeneralesServices generalesServices, IMapper mapper)
        {
            _generalesService = generalesServices;
            _mapper = mapper;
        }
        [HttpGet("/Clientes/Listado")]
        public IActionResult Index()
        {

            var listado = _generalesService.ListadoClientes(out string error);
            var listadoMapeado = _mapper.Map<IEnumerable<ClienteViewModel>>(listado);

            if (string.IsNullOrEmpty(error))
            {
                ModelState.AddModelError("", error);
            }

            return View(listadoMapeado);
        }
        [HttpPost("/Clientes/Crear")]
        public ActionResult Create(ClienteViewModel cliente)
        {
            var result = 0;
            var cli = _mapper.Map<tbClientes>(cliente);
            result = _generalesService.InsertarCLientes(cli);

            if (result == 0)
            {
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                return RedirectToAction("Listado");
            }
            return RedirectToAction("Listado");
        }

    }
}
