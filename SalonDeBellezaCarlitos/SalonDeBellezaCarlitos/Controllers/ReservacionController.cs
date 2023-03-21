using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SalonDeBellezaCarlitos.BusinessLogic.Services;
using SalonDeBellezaCarlitos.Entities.Entities;
using SalonDeBellezaCarlitos.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;

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


        [HttpGet("/Reservacion/Listado")]
        public IActionResult Index()
        {

            ViewBag.Toast = TempData["Reservacion"] as string;
            var listado = _generalesService.ListadoReservacionesView(out string error);
            var listadoMapeado = _mapper.Map<IEnumerable<VWReservacionesViewModel>>(listado);

            if (!string.IsNullOrEmpty(error))
            {
                ModelState.AddModelError("", error);
            }

            return View(listadoMapeado);
        }
        [HttpGet("/Reservacion/Crear")]
        public IActionResult Create()
        {
            ViewBag.clie_Id = new SelectList(_generalesService.ListadoClientes(out string error).ToList(), "clie_Id", "clie_Nombre");
            ViewBag.sucu_Id = new SelectList(_generalesService.ListadoSucursales(out string error2).ToList(), "sucu_Id", "sucu_Descripcion");
            return View();
        }

        [HttpPost("/Reservacion/Crear")]
        public ActionResult Create(ReservacionesViewModel reservacion)
        {
            try
            {
            var result = 0;
            reservacion.rese_UsuarioCreacion = Convert.ToInt32(HttpContext.Session.GetInt32("usur_Id"));
            reservacion.rese_UsuarioModificacion = Convert.ToInt32(HttpContext.Session.GetInt32("usur_Id"));

            var rese = _mapper.Map<tbReservaciones>(reservacion);
            result = _generalesService.InsertarReservaciones(rese);

            if (result == 0)
            {
                ViewBag.clie_Id = new SelectList(_generalesService.ListadoClientes(out string error).ToList(), "clie_Id", "clie_Nombre", rese.clie_Id);
                ViewBag.sucu_Id = new SelectList(_generalesService.ListadoSucursales(out string error2).ToList(), "sucu_Id", "sucu_Descripcion", rese.sucu_Id);
                    ViewBag.Toast = "error";
                    return View(reservacion);
                }
                ViewBag.Toast = "success";
                return RedirectToAction("Listado");
            }
            catch (Exception)
            {
                TempData["Reservacion"] = "error";
                return RedirectToAction("Listado");
            }
           
        }

        [HttpGet("/Reservacion/Editar")]
        public IActionResult Edit(int? id)
        {
            try
            {
                var Reservacion = _generalesService.findReservaciones(id);
                var ReservacionMapeado = _mapper.Map<ReservacionesViewModel>(Reservacion);

                #region Cargando datos...
                if (Reservacion == null)
                {
                    Convert.ToInt32("a");
                }

                ViewBag.clie_Id = new SelectList(_generalesService.ListadoClientes(out string error).ToList(), "clie_Id", "clie_Nombre", Reservacion.clie_Id);
                ViewBag.sucu_Id = new SelectList(_generalesService.ListadoSucursales(out string error2).ToList(), "sucu_Id", "sucu_Descripcion", Reservacion.sucu_Id);


                #endregion

                return View(ReservacionMapeado);
            }
            catch (Exception)
            {
                TempData["Reservacion"] = "errorC";
                return RedirectToAction("Listado");
            }

        }

        [HttpPost("/Reservacion/Editar")]
        public ActionResult Edit(ReservacionesViewModel reservaciones)
        {
            try
            {
            var result = 0;
            reservaciones.rese_UsuarioCreacion = Convert.ToInt32(HttpContext.Session.GetInt32("usur_Id"));
            reservaciones.rese_UsuarioModificacion = Convert.ToInt32(HttpContext.Session.GetInt32("usur_Id"));

            var rese = _mapper.Map<tbReservaciones>(reservaciones);
            result = _generalesService.EditarReservacion(rese);

            switch (result)
            {
                case 1:
                    TempData["Reservacion"] = "success";
                    return RedirectToAction("Listado");
                case 0:
                    ViewBag.Toast = "fatal";
                    ModelState.AddModelError("", "Ocurrió un error inesperado, intentelo de nuevo");
                    ViewBag.clie_Id = new SelectList(_generalesService.ListadoClientes(out string error).ToList(), "clie_Id", "clie_Nombre", reservaciones.clie_Id);
                    ViewBag.sucu_Id = new SelectList(_generalesService.ListadoSucursales(out string error2).ToList(), "sucu_Id", "sucu_Descripcion", reservaciones.sucu_Id);
                    return View(reservaciones);
                default:
                    TempData["Proveedor"] = "noprevisto";
                    ModelState.AddModelError("", "Ocurrió un error inesperado, intentelo de nuevo");
                    ViewBag.clie_Id = new SelectList(_generalesService.ListadoClientes(out string error1).ToList(), "clie_Id", "clie_Nombre", reservaciones.clie_Id);
                    ViewBag.sucu_Id = new SelectList(_generalesService.ListadoSucursales(out string error12).ToList(), "sucu_Id", "sucu_Descripcion", reservaciones.sucu_Id);
                    return View(reservaciones);
            }
            }
            catch (Exception)
            {
                TempData["Reservacion"] = "error";
                return RedirectToAction("Listado");
            }
            
        }

        [HttpGet("/Reservacion/Detalles")]
        public IActionResult Details(int? id)
        {
            try
            {
                var Reservacion = _generalesService.BuscarReservaciones(id);
                var ReservacionMapeado = _mapper.Map<IEnumerable<VWReservacionesViewModel>>(Reservacion);

                #region Cargando datos...
                if (Reservacion == null)
                {
                    Convert.ToInt32("a");
                }

                foreach (var item in ReservacionMapeado)
                {
                    ViewBag.clie_Id = new SelectList(_generalesService.ListadoClientes(out string error).ToList(), "clie_Id", "clie_Nombre", item.clie_Id);
                    ViewBag.sucu_Id = new SelectList(_generalesService.ListadoSucursales(out string error2).ToList(), "sucu_Id", "sucu_Descripcion", item.sucu_Id);


                    var UsuarioCreacion = _generalesService.BuscarUsuario(item.rese_UsuarioCreacion);
                    var nombreCreacion = _generalesService.BuscarEmpleados(UsuarioCreacion.empl_Id);
                    foreach (var item2 in nombreCreacion)
                    {
                        ViewBag.UsuarioCreacion = item2.empl_Nombre + " " + item2.empl_Apellido;
                    }


                    if (!string.IsNullOrEmpty(item.rese_UsuarioModificacion.ToString()))
                    {
                        var UsuarioModificacion = _generalesService.BuscarUsuario(item.rese_UsuarioModificacion);
                        var nombreModificacion = _generalesService.BuscarEmpleados(UsuarioModificacion.empl_Id);
                        foreach (var item2 in nombreModificacion)
                        {
                            ViewBag.UsuarioModificacion = item2.empl_Nombre + " " + item2.empl_Apellido;
                        }

                    }
                }


                #endregion

                return View(ReservacionMapeado);
            }
            catch
            {

                TempData["Proveedor"] = "errorC";
                return RedirectToAction("Listado");
            }

        }

        [HttpPost("/Reservacion/Eliminar")]
        public IActionResult Delete(ReservacionesViewModel reservaciones)
        {
            try
            {
            var result = 0;
            var rese = _mapper.Map<tbReservaciones>(reservaciones);
            result = _generalesService.EliminarReservacion(rese);

            if (result == 0)
                {
                    TempData["Reservacion"] = "error";
                    return RedirectToAction("Listado");
                }

                TempData["Reservacion"] = "success";
                return RedirectToAction("Listado");
            }
            catch (Exception)
            {
                TempData["Reservacion"] = "error";
                return RedirectToAction("Listado");
            }
            

        }

    }
}
