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
    public class MetodopagoController : Controller
    {
        private readonly GeneralesServices _generalesService;

        private readonly IMapper _mapper;

        public MetodopagoController(GeneralesServices generalesServices, IMapper mapper)
        {
            _generalesService = generalesServices;
            _mapper = mapper;
        }


        [HttpGet("/Metodopago/Listado")]
        public IActionResult Index()
        {

            var listado = _generalesService.ListadoMetodoPago(out string error);
            var listadoMapeado = _mapper.Map<IEnumerable<MetodoPagoViewModel>>(listado);

            if (string.IsNullOrEmpty(error))
            {
                ModelState.AddModelError("", error);
            }

            return View(listadoMapeado);
        }


        [HttpGet("/Metodopago/Crear")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("/Metodopago/Crear")]
        public ActionResult Create(MetodoPagoViewModel Metodopagos)
        {
            var result = 0;
            var met = _mapper.Map<tbMetodoPago>(Metodopagos);
            result = _generalesService.InsertarMetodoPago(met);

            if (result == 0)
            {
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                return View();
            }
            return RedirectToAction("Listado");
        }


    }
}
