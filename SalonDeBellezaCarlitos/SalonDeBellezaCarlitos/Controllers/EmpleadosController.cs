using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SalonDeBellezaCarlitos.BusinessLogic.Services;
using SalonDeBellezaCarlitos.DataAccess;
using SalonDeBellezaCarlitos.Entities.Entities;
using SalonDeBellezaCarlitos.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalonDeBellezaCarlitos.WebUI.Controllers
{

    
    public class EmpleadosController : Controller
    {

        private readonly GeneralesServices _generalesService;

        private readonly IMapper _mapper;

        
        public EmpleadosController(GeneralesServices generalesServices, IMapper mapper)
        {
            _generalesService = generalesServices;
            _mapper = mapper;
        }


        [HttpGet("/Empleados/Listado")]
        public IActionResult Index()
        {
            var listado = _generalesService.ListadoEmpleados(out string error);
            
            var listadoMapeado = _mapper.Map<IEnumerable<EmpleadoViewModel>>(listado);
           
            if (string.IsNullOrEmpty(error))
            {
                ModelState.AddModelError("", error);
            }

            return View(listadoMapeado);
        }



        [HttpGet("/Empleados/Crear")]
        public IActionResult Create()
        {

            //var CargosList = ; @estc_Id
            ViewBag.depa_Id = new SelectList(_generalesService.ListadoDepartamentos(out string error).ToList(), "depa_Id", "depa_Descripcion");
            ViewBag.carg_Id = new SelectList(_generalesService.ListadoCargos(out string error2).ToList(), "carg_Id", "carg_Descripcion");
            ViewBag.estc_Id = new SelectList(_generalesService.ListadoEstadosCiviles(out string error1).ToList(), "estc_Id", "estc_Descripcion");
            return View();
        }

        [HttpPost("/Empleados/Crear")]
        public ActionResult Create(EmpleadoViewModel empleado)
        {
            var result = 0;
            var emp = _mapper.Map<tbEmpleados>(empleado);
            result = _generalesService.InsertarEmpleado(emp);

            if (result == 0)
            {
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                var CargosList = _generalesService.ListadoCargos(out string error).ToList();
                ViewBag.carg_Id = new SelectList(CargosList, "carg_Id", "carg_Descripcion");
                return View();
            }
            return RedirectToAction("Listado");
        }

        public IActionResult CargarMunicipios(int id)
        {
            var cargarmunicipios = _generalesService.BuscarCargo(id);
            return Json(cargarmunicipios);
        }

    }
}
