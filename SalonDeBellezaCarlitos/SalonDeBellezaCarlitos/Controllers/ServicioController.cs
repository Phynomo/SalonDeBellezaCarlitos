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
    public class ServicioController : Controller
    {
        private readonly GeneralesServices _generalesService;

        private readonly IMapper _mapper;


        public ServicioController(GeneralesServices generalesServices, IMapper mapper)
        {
            _generalesService = generalesServices;
            _mapper = mapper;
        }


        [HttpGet("/Servicios/Listado")]
        public IActionResult Index()
        {
            var listado = _generalesService.ListadoServicios(out string error);

            var listadoMapeado = _mapper.Map<IEnumerable<ServicioViewModel>>(listado);

            if (string.IsNullOrEmpty(error))
            {
                ModelState.AddModelError("", error);
            }

            return View(listadoMapeado);
        }

        [HttpPost("/Servicios/Crear")]
        public ActionResult Create(ServicioViewModel servicio)
        {
            var result = 0;
            var car = _mapper.Map<tbServicios>(servicio);
            result = _generalesService.InsertarServicio(car);

            if (result == 0)
            {
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                return View();
            }
            return RedirectToAction("Listado");
        }
        [HttpGet("/Servicios/Eliminar/{id}")]
        public IActionResult Delete(int? id)
        {
            var listado = _generalesService.BuscarCargo(id);
            return View(listado);
        }

        [HttpPost("/Servicios/Eliminar")]
        public IActionResult Delete(ServicioViewModel servicio)
        {
            var result = 0;
            var ser = _mapper.Map<tbServicios>(servicio);
            result = _generalesService.EliminarServicio(ser);

            if (result == 0)
            {
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                return View();
            }
            return RedirectToAction("Listado");

        }
    }
}
