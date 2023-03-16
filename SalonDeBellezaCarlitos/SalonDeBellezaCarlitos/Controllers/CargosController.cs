using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using SalonDeBellezaCarlitos.BusinessLogic.Services;
using SalonDeBellezaCarlitos.Entities.Entities;
using SalonDeBellezaCarlitos.WebUI.Models;
using System.Collections.Generic;

namespace SalonDeBellezaCarlitos.WebUI.Controllers
{
    public class CargosController : Controller
    {
        
        private readonly GeneralesServices _generalesService;

        private readonly IMapper _mapper;

        public CargosController(GeneralesServices generalesServices, IMapper mapper)
        {
            _generalesService = generalesServices;
            _mapper = mapper;
        }


        [HttpGet("/Cargos/Listado")]
        public IActionResult Index()
        {

            var listado = _generalesService.ListadoCargos(out string error);
            var listadoMapeado = _mapper.Map<IEnumerable<CargoViewModel>>(listado);

            if (string.IsNullOrEmpty(error))
            {
                ModelState.AddModelError("", error);
            }

            return View(listadoMapeado);
        }


        [HttpGet("/Cargos/Crear")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("/Cargos/Crear")]
        public ActionResult Create(CargoViewModel cargo)
        {
            var result = 0;
            var car = _mapper.Map<tbCargos>(cargo);
            result = _generalesService.InsertarCargo(car);

            if (result == 0)
            {
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                return RedirectToAction("Listado");
            }
            return RedirectToAction("Listado");
        }

        [HttpGet("/Cargos/Editar/{id}")]
        public IActionResult Edit(int? id)
        {
            var listado = _generalesService.BuscarCargo(id);
            return View(listado);
        }

        [HttpPost("/Cargos/Editar")]
        public IActionResult Edit(CargoViewModel cargo)
        {
            var result = 0;
            var car = _mapper.Map<tbCargos>(cargo);
            result = _generalesService.EditarCargo(car);

            if (result == 0)
            {
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                return View();
            }
            return RedirectToAction("Listado");
           
        }

        [HttpGet("/Cargos/Eliminar/{id}")]
        public IActionResult Delete(int? id)
        {
            var listado = _generalesService.BuscarCargo(id);
            return View(listado);
        }

        [HttpPost("/Cargos/Eliminar")]
        public IActionResult Delete(CargoViewModel cargo)
        {
            var result = 0;
            var car = _mapper.Map<tbCargos>(cargo);
            result = _generalesService.EliminarCargo(car);

            if (result == 0)
            {
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                return View();
            }
            return RedirectToAction("Listado");

        }

        [HttpGet("/Cargos/Detalles")]
        public IActionResult Details(int? id)
        {

            var listado = _generalesService.BuscarCargo(id);
            var listadoMapeado = _mapper.Map<IEnumerable<CargoViewModel>>(listado);
            foreach (var item in listadoMapeado)
            {
            var UsuarioCreacion = _generalesService.BuscarUsuario(item.carg_UsuarioCreacion);
            var nombreCreacion = _generalesService.findEmpleado(UsuarioCreacion.empl_Id);
            ViewBag.UsuarioCreacion = nombreCreacion.empl_Nombre + " " + nombreCreacion.empl_Apellido;

            if (!string.IsNullOrEmpty(item.carg_UsuarioModificacion.ToString()))
            {
                var UsuarioModificacion = _generalesService.BuscarUsuario(item.carg_UsuarioModificacion);
                var nombreModificacion = _generalesService.findEmpleado(UsuarioModificacion.empl_Id);
                ViewBag.UsuarioModificacion = nombreModificacion.empl_Nombre + " " + nombreModificacion.empl_Apellido;
            }
            }
            

            return View(listadoMapeado);
        }

    }
}
