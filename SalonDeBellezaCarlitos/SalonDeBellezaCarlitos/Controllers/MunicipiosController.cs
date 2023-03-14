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
    public class MunicipiosController : Controller
    {
        private readonly GeneralesServices _generalesService;

        private readonly IMapper _mapper;

        public MunicipiosController(GeneralesServices generalesServices, IMapper mapper)
        {
            _generalesService = generalesServices;
            _mapper = mapper;
        }


        [HttpGet("/Municipios/Listado")]
        public IActionResult Index()
        {

            var listado = _generalesService.ListadoMunicipios(out string error);
            var listadoMapeado = _mapper.Map<IEnumerable<MunicipioViewModel>>(listado);

            if (string.IsNullOrEmpty(error))
            {
                ModelState.AddModelError("", error);
            }

            return View(listadoMapeado);
        }
        [HttpGet("/Municipios/Crear")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("/Municipios/Crear")]
        public ActionResult Create(MunicipioViewModel municipio)
        {
            var result = 0;
            var muni = _mapper.Map<tbMunicipios>(municipio);
            result = _generalesService.InsertarMunicipio(muni);

            if (result == 0)
            {
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                return View();
            }
            return RedirectToAction("Listado");
        }

    }
}
