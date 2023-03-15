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
    public class SucursalController : Controller
    {
        private readonly GeneralesServices _generalesService;

        private readonly IMapper _mapper;

        public SucursalController(GeneralesServices generalesServices, IMapper mapper)
        {
            _generalesService = generalesServices;
            _mapper = mapper;
        }


        [HttpGet("/Sucursales/Listado")]
        public IActionResult Index()
        {

            var listado = _generalesService.ListadoSucursales(out string error);
            var listadoMapeado = _mapper.Map<IEnumerable<SucursalViewModel>>(listado);

            if (string.IsNullOrEmpty(error))
            {
                ModelState.AddModelError("", error);
            }

            return View(listadoMapeado);
        }
        [HttpPost("/Sucursal/Crear")]
        public ActionResult Create(SucursalViewModel cargo)
        {
            var result = 0;
            var car = _mapper.Map<tbSucursales>(cargo);
            result = _generalesService.InsertarSucursal(car);

            if (result == 0)
            {
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                return View();
            }
            return RedirectToAction("Listado");
        }
    }
}
