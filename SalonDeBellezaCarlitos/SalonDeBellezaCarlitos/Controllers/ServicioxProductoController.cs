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
    public class ServicioxProductoController : Controller
    {
        private readonly GeneralesServices _generalesService;

        private readonly IMapper _mapper;

        public ServicioxProductoController(GeneralesServices generalesServices, IMapper mapper)
        {
            _generalesService = generalesServices;
            _mapper = mapper;
        }


        [HttpGet("/ServicioxProducto/Listado")]
        public IActionResult Index()
        {
            ViewBag.Toast = TempData["ServicioxProducto"] as string;
            ViewBag.serv_Id = new SelectList(_generalesService.ListadoServicios(out string error).ToList(), "serv_Id", "serv_Nombre");
            ViewBag.prod_Id = new SelectList(_generalesService.ListadoProductos(out string ersdfror).ToList(), "prod_Id", "prod_Nombre");
            var listado = _generalesService.ListadoServicioxproducto(out string esdfarror);
            var listadoMapeado = _mapper.Map<IEnumerable<VWServicioxproductoViewModel>>(listado);

            if (!string.IsNullOrEmpty(error))
            {
                ModelState.AddModelError("", error);
            }

            return View(listadoMapeado);
        }

        [HttpGet("/ServicioxProducto/Crear")]
        public IActionResult Create()
        {
            ViewBag.serv_Id = new SelectList(_generalesService.ListadoServicios(out string error1).ToList(), "serv_Id", "serv_Nombre");
            ViewBag.prod_Id = new SelectList(_generalesService.ListadoProductos(out string error2).ToList(), "prod_Id", "prod_Nombre");
            return View();
        }
        [HttpPost("/ServicioxProducto/Crear")]
        public ActionResult Create(ServicioxProductoViewModel producto)
        {
            var result = 0;
            var prod = _mapper.Map<tbProductosXServicio>(producto);
            result = _generalesService.InsertarServicioxProducto(prod);
            
            if (result == 0)
            {
                TempData["ServicioxProducto"] = "error";
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                ViewBag.serv_Id = new SelectList(_generalesService.ListadoServicios(out string error1).ToList(), "serv_Id", "serv_Nombre");
                ViewBag.prod_Id = new SelectList(_generalesService.ListadoProductos(out string error2).ToList(), "prod_Id", "prod_Nombre");
                return View();
            }
            TempData["ServicioxProducto"] = "success";
            return RedirectToAction("Listado");
        }

        [HttpPost("/ServicioxProducto/Editar")]
        public IActionResult Edit(ServicioxProductoViewModel producto)
        {
            var result = 0;
            producto.spro_UsuarioCreacion = Convert.ToInt32(HttpContext.Session.GetInt32("usur_Id"));
            producto.spro_UsuarioModificacion = Convert.ToInt32(HttpContext.Session.GetInt32("usur_Id"));

            var prod = _mapper.Map<tbProductos>(producto);
            result = _generalesService.EditarProducto(prod);

            if (result == 0)
            {
                TempData["ServicioxProducto"] = "error";
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                ViewBag.cate_Id = new SelectList(_generalesService.ListadoCategorias(out string error).ToList(), "cate_Id", "cate_Descripcion");
                ViewBag.prov_Id = new SelectList(_generalesService.ListadoProveedores(out string error2).ToList(), "prov_Id", "prov_NombreContacto");
            }
            TempData["ServicioxProducto"] = "success";
            return RedirectToAction("Listado");
        }

        [HttpGet("/ServicioxProducto/Eliminar/{id}")]
        public IActionResult Delete(int? id)
        {
            var listado = _generalesService.BuscarCargo(id);
            return View(listado);
        }

        [HttpPost("/ServicioxProducto/Eliminar")]
        public IActionResult Delete(ServicioxProductoViewModel servicio)
        {
            try
            {
                var result = 0;
                var ser = _mapper.Map<tbProductosXServicio>(servicio);
                result = _generalesService.EliminarServicioxProducto(ser);

                if (result == 0)
                {
                    TempData["Servicio"] = "error";
                    ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                    return View();
                }
            }
            catch (Exception)
            {

            }
            TempData["Servicio"] = "success";
            return RedirectToAction("Listado");
        }
    }
}
