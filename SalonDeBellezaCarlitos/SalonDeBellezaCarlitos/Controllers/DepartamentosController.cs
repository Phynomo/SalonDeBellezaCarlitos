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
    public class DepartamentosController : Controller
    {
        private readonly GeneralesServices _generalesService;

        private readonly IMapper _mapper;

        public DepartamentosController(GeneralesServices generalesServices, IMapper mapper)
        {
            _generalesService = generalesServices;
            _mapper = mapper;
        }


        [HttpGet("/Departamentos/Listado")]
        public IActionResult Index()
        {

            var listado = _generalesService.ListadoDepartamentos(out string error);
            var listadoMapeado = _mapper.Map<IEnumerable<DepartamentoViewModel>>(listado);

            if (string.IsNullOrEmpty(error))
            {
                ModelState.AddModelError("", error);
            }

            return View(listadoMapeado);
        }

        [HttpGet("/Departamentos/Crear")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("/Departamentos/Crear")]
        public ActionResult Create(DepartamentoViewModel departamento)
        {
            var result = 0;
            var car = _mapper.Map<tbDepartamentos>(departamento);
            result = _generalesService.InsertarDepartamento(car);

            if (result == 0)
            {
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                return View();
            }
            return RedirectToAction("Listado");
        }



    }
}
