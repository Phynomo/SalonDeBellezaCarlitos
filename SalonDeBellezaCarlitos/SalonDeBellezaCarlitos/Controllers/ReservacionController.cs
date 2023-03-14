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
    public class ReservacionController : Controller
    {
        private readonly GeneralesServices _generalesService;

        private readonly IMapper _mapper;

        public ReservacionController(GeneralesServices generalesServices, IMapper mapper)
        {
            _generalesService = generalesServices;
            _mapper = mapper;
        }


        [HttpGet("/Reservaciones/Listado")]
        public IActionResult Index()
        {

            var listado = _generalesService.ListadoReservaciones(out string error);
            var listadoMapeado = _mapper.Map<IEnumerable<ReservacionesViewModel>>(listado);

            if (string.IsNullOrEmpty(error))
            {
                ModelState.AddModelError("", error);
            }

            return View(listadoMapeado);
        }
        [HttpGet("/Reservacion/Crear")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("/Reservacion/Crear")]
        public ActionResult Create(ReservacionesViewModel producto)
        {
            var result = 0;
            var prod = _mapper.Map<tbReservaciones>(producto);
            result = _generalesService.InsertarReservaciones(prod);

            if (result == 0)
            {
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                return View();
            }
            return RedirectToAction("Listado");
        }
    }
}
