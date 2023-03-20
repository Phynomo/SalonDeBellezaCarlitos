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
    public class EstadosCivilesController : Controller
    {
        private readonly GeneralesServices _generalesService;

        private readonly IMapper _mapper;

        public EstadosCivilesController(GeneralesServices generalesServices, IMapper mapper)
        {
            _generalesService = generalesServices;
            _mapper = mapper;
        }


        [HttpGet("/EstadosCiviles/Listado")]
        public IActionResult Index()
        {
            ViewBag.Toast = TempData["EstadosCiviles"] as string;
            var listado = _generalesService.ListadoEstadosCiviles(out string error);
            var listadoMapeado = _mapper.Map<IEnumerable<EstadoCivilViewModel>>(listado);

            if (string.IsNullOrEmpty(error))
            {
                ModelState.AddModelError("", error);
            }

            return View(listadoMapeado);
        }
        [HttpGet("/EstadosCiviles/Crear")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("/EstadosCiviles/Crear")]
        public ActionResult Create(EstadoCivilViewModel estadociv)
        {
            try
            {
                estadociv.estc_UsuarioCreacion = Convert.ToInt32(HttpContext.Session.GetString("usur_Id"));
                estadociv.estc_UsuarioModificacion = Convert.ToInt32(HttpContext.Session.GetString("usur_Id"));

                var result = 0;
                var civ = _mapper.Map<tbEstadosCiviles>(estadociv);
                result = _generalesService.InsertarEstadoCivil(civ);

                if (result == 0)
                {
                    TempData["EstadosCiviles"] = "error";
                    ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                    return RedirectToAction("Listado");
                }
            }
            catch (Exception)
            {

            }
            TempData["EstadosCiviles"] = "success";
            return RedirectToAction("Listado");
        }

        [HttpPost("/EstadosCiviles/Eliminar")]
        public IActionResult Delete(EstadoCivilViewModel estado)
        {
            try
            {
                var result = 0;
                var est = _mapper.Map<tbEstadosCiviles>(estado);
                result = _generalesService.EliminarEstadoCivil(est);

                if (result == 0)
                {
                    TempData["EstadosCiviles"] = "error";
                    ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                    return View();
                }
            }
            catch (Exception)
            {

            }
            TempData["EstadosCiviles"] = "success";
            return RedirectToAction("Listado");

        }


        [HttpGet("/EstadosCiviles/Editar/{id}")]
        public IActionResult Edit(int? id)
        {
            var listado = _generalesService.BuscarCargo(id);
            return View(listado);
        }
        [HttpPost("/EstadosCiviles/Editar")]
        public IActionResult Edit(EstadoCivilViewModel estado)//mua
        {
            try
            {
                estado.estc_UsuarioCreacion = Convert.ToInt32(HttpContext.Session.GetString("usur_Id"));
                estado.estc_UsuarioModificacion = Convert.ToInt32(HttpContext.Session.GetString("usur_Id"));

                var result = 0;
                var est = _mapper.Map<tbEstadosCiviles>(estado);
                result = _generalesService.EditarEstadoCivil(est);

                if (result == 0)
                {
                    TempData["EstadosCiviles"] = "error";
                    ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                    return View();
                }
            }
            catch (Exception)
            {

            }
            TempData["EstadosCiviles"] = "success";
            return RedirectToAction("Listado");

        }

        [HttpGet("/EstadoCivil/Detalles")]
        public IActionResult Details(int? id)
        {
            try
            {
                var servicio = _generalesService.BuscarEstadoCivil_IEnumerable(id);
                var servicioMapeado = _mapper.Map<IEnumerable<EstadoCivilViewModel>>(servicio);
                return View(servicioMapeado);
            }
            catch (Exception)
            {

            }
            return RedirectToAction("Listado");
        }

    }
}
