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
    public class ProductoController : Controller
    {
        private readonly GeneralesServices _generalesService;

        private readonly IMapper _mapper;

        public ProductoController(GeneralesServices generalesServices, IMapper mapper)
        {
            _generalesService = generalesServices;
            _mapper = mapper;
        }


        [HttpGet("/Productos/Listado")]
        public IActionResult Index()
        {

            var listado = _generalesService.ListadoProductos(out string error);
            var listadoMapeado = _mapper.Map<IEnumerable<ProductoViewModel>>(listado);

            if (string.IsNullOrEmpty(error))
            {
                ModelState.AddModelError("", error);
            }

            return View(listadoMapeado);
        }
        [HttpGet("/Productos/Crear")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("/Productos/Crear")]
        public ActionResult Create(ProductoViewModel producto)
        {
            var result = 0;
            var prod = _mapper.Map<tbProductos>(producto);
            result = _generalesService.InsertarProducto(prod);

            if (result == 0)
            {
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                return View();
            }
            return RedirectToAction("Listado");
        }
    }
}
