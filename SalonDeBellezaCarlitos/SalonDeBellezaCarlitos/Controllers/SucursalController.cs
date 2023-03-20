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


        [HttpGet("/Sucursal/Listado")]
        public IActionResult Index()
        {
            ViewBag.Toast = TempData["Sucursal"] as string;
            ViewBag.depa_Id = new SelectList(_generalesService.ListadoDepartamentos(out string error).ToList(), "depa_Id", "depa_Descripcion");

            var listado = _generalesService.ListadoSucursalesView(out string error2);
            var listadoMapeado = _mapper.Map<IEnumerable<VWSucursalesViewModel>>(listado);

            if (string.IsNullOrEmpty(error))
            {
                ModelState.AddModelError("", error);
            }

            return View(listadoMapeado);
        }
        [HttpPost("/Sucursal/Crear")]
        public ActionResult Create(SucursalViewModel sucursal)
        {
            var result = 0;
            sucursal.sucu_UsuarioCreacion = Convert.ToInt32(HttpContext.Session.GetInt32("usur_Id"));
            sucursal.sucu_UsuarioModificacion = Convert.ToInt32(HttpContext.Session.GetInt32("usur_Id"));

            var suc = _mapper.Map<tbSucursales>(sucursal);
            result = _generalesService.InsertarSucursal(suc);

            if (result == 0)
            {
                TempData["Sucursal"] = "error";
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                return RedirectToAction("Listado");
            }
            TempData["Sucursal"] = "success";
            return RedirectToAction("Listado");
        }

        [HttpPost("/Sucursal/Editar")]
        public ActionResult Edit(SucursalViewModel sucursal)
        {
            var result = 0;
            sucursal.sucu_UsuarioCreacion = Convert.ToInt32(HttpContext.Session.GetInt32("usur_Id"));
            sucursal.sucu_UsuarioModificacion = Convert.ToInt32(HttpContext.Session.GetInt32("usur_Id"));

            var suc = _mapper.Map<tbSucursales>(sucursal);
            result = _generalesService.EditarSucursal(suc);

            if (result == 0)
            {
                TempData["Sucursal"] = "error";
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                return RedirectToAction("Listado");
            }
            TempData["Sucursal"] = "success";
            return RedirectToAction("Listado");
        }

        [HttpPost("/Sucursal/Eliminar")]
        public IActionResult Delete(SucursalViewModel sucursal)
        {
            var result = 0;
            var suc = _mapper.Map<tbSucursales>(sucursal);
            result = _generalesService.EliminarSucursal(suc);

            if (result == 0)
            {
                TempData["Success"] = "error";
                ModelState.AddModelError("", "Ocurrió un error al eliminar este registro");
                return RedirectToAction("Listado");
            }
            TempData["Sucursal"] = "success";
            return RedirectToAction("Listado");

        }

        [HttpGet("/Sucursal/Detalles")]
        public IActionResult Details(int? id)
        {

            ViewBag.depa_Id = new SelectList(_generalesService.ListadoDepartamentos(out string error).ToList(), "depa_Id", "depa_Descripcion");
            var listado = _generalesService.BuscarSucursalesView(id);
            var listadoMapeado = _mapper.Map<IEnumerable<VWSucursalesViewModel>>(listado);

            foreach (var item in listadoMapeado)
            {
                 var UsuarioCreacion = _generalesService.BuscarUsuario(item.sucu_UsuarioCreacion);
                var nombreCreacion = _generalesService.BuscarEmpleados(UsuarioCreacion.empl_Id);
                foreach (var item2 in nombreCreacion)
                {
                    ViewBag.UsuarioCreacion = item2.empl_Nombre + " " + item2.empl_Apellido;
                }

                if (!string.IsNullOrEmpty(item.sucu_UsuarioModificacion.ToString()))
                {
                    var UsuarioModificacion = _generalesService.BuscarUsuario(item.sucu_UsuarioModificacion);
                    var nombreModificacion = _generalesService.BuscarEmpleados(UsuarioModificacion.empl_Id);
                    foreach (var item2 in nombreModificacion)
                    {
                        ViewBag.UsuarioModificacion = item2.empl_Nombre + " " + item2.empl_Apellido;
                    }
                }
            }
            
            return View(listadoMapeado);
        }

    }
}
