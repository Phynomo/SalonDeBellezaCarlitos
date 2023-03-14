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
    public class FacturasController : Controller
    {
        private readonly GeneralesServices _generalesService;

        private readonly IMapper _mapper;

        public FacturasController(GeneralesServices generalesServices, IMapper mapper)
        {
            _generalesService = generalesServices;
            _mapper = mapper;
        }


        [HttpGet("/Facturas/Listado")]
        public IActionResult Index()
        {

            var listado = _generalesService.ListadoFacturas(out string error);
            var listadoMapeado = _mapper.Map<IEnumerable<FacturasViewModel>>(listado);

            if (string.IsNullOrEmpty(error))
            {
                ModelState.AddModelError("", error);
            }

            return View(listadoMapeado);
        }
        [HttpGet("/Facturas/Crear")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("/Facturas/Crear")]
        public ActionResult Create(FacturasViewModel factura)
        {
            var result = 0;
            var fac = _mapper.Map<tbFacturas>(factura);
            result = _generalesService.InsertarFacturas(fac);

            if (result == 0)
            {
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                return View();
            }
            return RedirectToAction("Listado");
        }
    }
}
