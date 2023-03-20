using AutoMapper;
using Microsoft.AspNetCore.Http;
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
            ViewBag.Toast = TempData["Clientes"] as string;
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
            try
            {

                departamento.depa_UsuarioCreacion = Convert.ToInt32(HttpContext.Session.GetInt32("usur_Id"));
                departamento.depa_UsuarioModificacion = Convert.ToInt32(HttpContext.Session.GetInt32("usur_Id"));
                var result = 0;
                var car = _mapper.Map<tbDepartamentos>(departamento);
                result = _generalesService.InsertarDepartamento(car);

                if (result == 0)
                {
                    TempData["Departamentos"] = "error";
                    ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                    return View();
                }
            }
            catch (Exception)
            {

            }
            TempData["Departamentos"] = "success";
            return RedirectToAction("Listado");
        }

        [HttpPost("/Departamentos/Editar")]
        public IActionResult Edit(DepartamentoViewModel departamento)
        {
            try
            {
                departamento.depa_UsuarioCreacion = Convert.ToInt32(HttpContext.Session.GetInt32("usur_Id"));
                departamento.depa_UsuarioModificacion = Convert.ToInt32(HttpContext.Session.GetInt32("usur_Id"));
                var result = 0;
                var dep = _mapper.Map<tbDepartamentos>(departamento);
                result = _generalesService.EditarDepartamento(dep);

                if (result == 0)
                {
                    TempData["Departamentos"] = "error";
                    ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                    return View();
                }
            }
            catch (Exception)
            {

            }
            TempData["Departamentos"] = "success";
            return RedirectToAction("Listado");

        }

        [HttpGet("/Departamentos/Eliminar/{id}")]
        public IActionResult Delete(int? id)
        {
            var listado = _generalesService.BuscarCargo(id);
            return View(listado);
        }

        [HttpPost("/Departamentos/Eliminar")]
        public IActionResult Delete(DepartamentoViewModel departamento)
        {
            try
            {
                var result = 0;
                var dep = _mapper.Map<tbDepartamentos>(departamento);
                result = _generalesService.EliminarDepartamento(dep);

                if (result == 0)
                {
                    TempData["Departamentos"] = "error";
                    ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                    return View();
                }
            }
            catch (Exception)
            {

            }
            TempData["Departamentos"] = "success";
            return RedirectToAction("Listado");

        }

        [HttpGet("/Departamentos/Detalles")]
        public IActionResult Details(int? id)
        {
            try
            {
                var servicio = _generalesService.BuscarDepartameto(id);
                var servicioMapeado = _mapper.Map<IEnumerable<DepartamentoViewModel>>(servicio);
                return View(servicioMapeado);
            }
            catch (Exception)
            {

            }
            return RedirectToAction("Listado");
        }
    }
}
