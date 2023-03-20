    using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
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
            ViewBag.Toast = TempData["Metodopago"] as string;
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
            try
            {
                Metodopagos.metp_UsuarioCreacion = Convert.ToInt32(HttpContext.Session.GetString("usur_Id"));
                Metodopagos.metp_UsuarioModificacion = Convert.ToInt32(HttpContext.Session.GetString("usur_Id"));

                var result = 0;
                var met = _mapper.Map<tbMetodoPago>(Metodopagos);
                result = _generalesService.InsertarMetodoPago(met);

                if (result == 0)
                {
                    TempData["Metodopago"] = "error";
                    ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                    return RedirectToAction("Listado");
                }
            }
            catch (Exception)
            {
                
            }
            TempData["Metodopago"] = "success";
            return RedirectToAction("Listado");
        }


        //[HttpGet("/Metodopago/Eliminar/{id}")]
        //public IActionResult Delete(int? id)
        //{
        //    var listado = _generalesService.BuscarCargo(id);
        //    return View(listado);
        //}

        [HttpPost("/Metodopago/Eliminar")]
        public IActionResult Delete(MetodoPagoViewModel Metodopago)
        {

            try
            {
                var result = 0;
                var met = _mapper.Map<tbMetodoPago>(Metodopago);
                result = _generalesService.EliminarMetodoPago(met);

                if (result == 0)
                {
                    TempData["Metodopago"] = "error";
                    ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                    return RedirectToAction("Listado");
                }
            }
            catch (Exception)
            {

            }
            TempData["Metodopago"] = "success";
            return RedirectToAction("Listado");

        }
        [HttpPost("/Metodopago/Editar")]
        public IActionResult Edit(MetodoPagoViewModel metodo)
        {
            try
            {
                metodo.metp_UsuarioCreacion = Convert.ToInt32(HttpContext.Session.GetString("usur_Id"));
                metodo.metp_UsuarioModificacion = Convert.ToInt32(HttpContext.Session.GetString("usur_Id"));

                var result = 0;
                var met = _mapper.Map<tbMetodoPago>(metodo);
                result = _generalesService.EditarMetodoPago(met);

                if (result == 0)
                {
                    TempData["Metodopago"] = "error";
                    ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                    return RedirectToAction("Listado");
                }
            }
            catch (Exception)
            {

            }
            TempData["Metodopago"] = "success";
            return RedirectToAction("Listado");

        }

        [HttpGet("/Metodopago/Detalles")]
        public IActionResult Details(int? id)
        {
            try
            {
                var servicio = _generalesService.BuscarMetodoPago(id);
                var servicioMapeado = _mapper.Map<IEnumerable<MetodoPagoViewModel>>(servicio);
                return View(servicioMapeado);
            }
            catch (Exception)
            {

            }

            return RedirectToAction("Listado");
        }


    }
}
