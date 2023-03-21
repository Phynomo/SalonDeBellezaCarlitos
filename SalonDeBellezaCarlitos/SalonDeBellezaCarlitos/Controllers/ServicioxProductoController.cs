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
                return RedirectToAction("Listado");
            }
            TempData["ServicioxProducto"] = "success";
            return RedirectToAction("Listado");
        }
        [HttpGet("/ServicioxProducto/Editar/{id}")]
        public IActionResult Edit(int? id)
        {
            //    var listado = _generalesService.BuscarCargo(id);
            var productos = _generalesService.BuscarServicioXProducto(id);
            //ViewBag.serv_Id = new SelectList(_generalesService.ListadoServicios(out string error1).ToList(), "serv_Id", "serv_Nombre");
            //ViewBag.prod_Id = new SelectList(_generalesService.ListadoProductos(out string error2).ToList(), "prod_Id", "prod_Nombre");
            foreach (var item in productos)
            {
                ViewBag.serv_Id = item.serv_Id;
                ViewBag.prod_Id = item.prod_Id;
            }
            return RedirectToAction("Listado");

        }

        [HttpPost("/ServicioxProducto/Editar")]
        public IActionResult Edit(ServicioxProductoViewModel producto)
        {
            var result = 0;
            producto.spro_UsuarioCreacion = Convert.ToInt32(HttpContext.Session.GetInt32("usur_Id"));
            producto.spro_UsuarioModificacion = Convert.ToInt32(HttpContext.Session.GetInt32("usur_Id"));

            var prod = _mapper.Map<tbProductosXServicio>(producto);
            result = _generalesService.EditarServicioxProducto(prod);

            if (result == 0)
            {
                TempData["ServicioxProducto"] = "error";
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                //ViewBag.serv_Id = new SelectList(_generalesService.ListadoServicios(out string error1).ToList(), "serv_Id", "serv_Nombre");
                //ViewBag.prod_Id = new SelectList(_generalesService.ListadoProductos(out string error2).ToList(), "prod_Id", "prod_Nombre");
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
                    TempData["ServicioxProducto"] = "error";
                    ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                    return RedirectToAction("Listado");
                }
            }
            catch (Exception)
            {

            }
            TempData["ServicioxProducto"] = "success";
            return RedirectToAction("Listado");
        }
        [HttpGet("/ServicioxProducto/Detalles")]
        public IActionResult Details(int? id)
        {
            //ViewBag.serv_Id = new SelectList(_generalesService.ListadoServicios(out string error).ToList(), "serv_Id", "serv_Nombre");
            //ViewBag.prod_Id = new SelectList(_generalesService.ListadoProductos(out string ersdfror).ToList(), "prod_Id", "prod_Nombre");
            //var listado = _generalesService.ListadoServicioxproducto(out string esdfarror);
            //var listadoMapeado = _mapper.Map <IEnumerable<VWServicioxproductoViewModel>>(listado);

            //if (!string.IsNullOrEmpty(error))
            //{
            //    ModelState.AddModelError("", error);
            //}

            //return View(listadoMapeado);

            var producto = _generalesService.BuscarServicioXProducto(id);

            foreach (var item in producto)
            {
                var serv_Id = _generalesService.findServicio(item.serv_Id);
                var prod_Id = _generalesService.findProducto(item.prod_Id);

                ViewBag.serv_Id = item.serv_Id;
                ViewBag.prod_Id = item.prod_Id;
                ViewBag.serv_Nombre = serv_Id.serv_Nombre;
                ViewBag.prod_Nombre = prod_Id.prod_Nombre;
                ViewBag.spro_Id = id;


                var UsuarioCreacion = _generalesService.BuscarUsuario(item.spro_UsuarioCreacion);
                var nombreCreacion = _generalesService.findEmpleado(UsuarioCreacion.empl_Id);
                ViewBag.UsuarioCreacion = nombreCreacion.empl_Nombre + " " + nombreCreacion.empl_Apellido;
                ViewBag.FechaCreacion = item.spro_FechaCreacion;

                if (!string.IsNullOrEmpty(item.spro_UsuarioModificacion.ToString()))
                {
                    var UsuarioModificacion = _generalesService.BuscarUsuario(item.spro_UsuarioModificacion);
                    var nombreModificacion = _generalesService.findEmpleado(UsuarioModificacion.empl_Id);
                    ViewBag.UsuarioModificacion = nombreModificacion.empl_Nombre + " " + nombreModificacion.empl_Apellido;
                    ViewBag.FechaModificacion = item.spro_FechaModificacion;
                }
            }
            return View();
        }
    }
}
