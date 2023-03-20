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
    public class ProductoController : Controller
    {
        private readonly GeneralesServices _generalesService;

        private readonly IMapper _mapper;

        public ProductoController(GeneralesServices generalesServices, IMapper mapper)
        {
            _generalesService = generalesServices;
            _mapper = mapper;
        }


        [HttpGet("/Producto/Listado")]
        public IActionResult Index()
        {
            ViewBag.Toast = TempData["Producto"] as string;
            var listado = _generalesService.ListadoProductosView(out string error);
            var listadoMapeado = _mapper.Map<IEnumerable<VWProductosViewModel>>(listado);

            if (string.IsNullOrEmpty(error))
            {
                ModelState.AddModelError("", error);
            }

            return View(listadoMapeado);
        }
        [HttpGet("/Producto/Crear")]
        public IActionResult Create()
        {
            ViewBag.cate_Id = new SelectList(_generalesService.ListadoCategorias(out string error).ToList(), "cate_Id", "cate_Descripcion");
            ViewBag.prov_Id = new SelectList(_generalesService.ListadoProveedores(out string error2).ToList(), "prov_Id", "prov_NombreContacto");
            return View();
        }

        [HttpPost("/Producto/Crear")]
        public ActionResult Create(ProductoViewModel producto)
        {
            var result = 0;
            producto.prod_UsuarioCreacion = Convert.ToInt32(HttpContext.Session.GetString("usur_Id"));
            producto.prod_UsuarioModificacion = Convert.ToInt32(HttpContext.Session.GetString("usur_Id"));

            var prod = _mapper.Map<tbProductos>(producto);
            result = _generalesService.InsertarProducto(prod);

            if (result == 0)
            {
                TempData["Producto"] = "error";
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                ViewBag.cate_Id = new SelectList(_generalesService.ListadoCategorias(out string error).ToList(), "cate_Id", "cate_Descripcion");
                ViewBag.prov_Id = new SelectList(_generalesService.ListadoProveedores(out string error2).ToList(), "prov_Id", "prov_NombreContacto");
                return View();
            }
            TempData["Producto"] = "success";
            return RedirectToAction("Listado");
        }

        [HttpPost("/Producto/Eliminar")]
        public IActionResult Delete(ProductoViewModel producto)
        {
            var result = 0;
            var prod = _mapper.Map<tbProductos>(producto);
            result = _generalesService.EliminarProducto(prod);

            if (result == 0)
            {
                TempData["Producto"] = "error";
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                return View();
            }
            TempData["Producto"] = "success";
            return RedirectToAction("Listado");

        }
        [HttpGet("/Producto/Editar")]
        public IActionResult Edit(int? id)
        {
            var productos = _generalesService.BuscarProducto(id);
            ViewBag.cate_Id = new SelectList(_generalesService.ListadoCategorias(out string error).ToList(), "cate_Id", "cate_Descripcion");
            ViewBag.prov_Id = new SelectList(_generalesService.ListadoProveedores(out string error2).ToList(), "prov_Id", "prov_NombreContacto");
            foreach (var item in productos)
            {
                ViewBag.prod_Id = item.prod_Id;
                ViewBag.prod_Nombre = item.prod_Nombre;
                ViewBag.prod_Precio = item.prod_Precio;
                ViewBag.prod_Stock = item.prod_Stock;
            }
            
            return View();
        }

        [HttpPost("/Producto/Editar")]
        public IActionResult Edit(ProductoViewModel producto)
        {
            var result = 0;
            producto.prod_UsuarioCreacion = Convert.ToInt32(HttpContext.Session.GetString("usur_Id"));
            producto.prod_UsuarioModificacion = Convert.ToInt32(HttpContext.Session.GetString("usur_Id"));

            var prod = _mapper.Map<tbProductos>(producto);
            result = _generalesService.EditarProducto(prod);

            if (result == 0)
            {
                TempData["Producto"] = "error";
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                ViewBag.cate_Id = new SelectList(_generalesService.ListadoCategorias(out string error).ToList(), "cate_Id", "cate_Descripcion");
                ViewBag.prov_Id = new SelectList(_generalesService.ListadoProveedores(out string error2).ToList(), "prov_Id", "prov_NombreContacto");
            }
            TempData["Producto"] = "success";
            return RedirectToAction("Listado");
        }

        [HttpGet("/Producto/Detalles")]
        public IActionResult Details(int? id)
        {
            var producto = _generalesService.BuscarProducto(id);
            foreach (var item in producto)
            {   
                var cate_Id = _generalesService.BuscarCategoria(item.cate_Id);
                var prov_Id = _generalesService.findProveedor(item.prov_id);

                ViewBag.cate_Id = cate_Id.cate_Descripcion;
                ViewBag.prov_Id = prov_Id.prov_NombreContacto;

                ViewBag.prod_Id = item.prod_Id;
                ViewBag.prod_Nombre = item.prod_Nombre;
                ViewBag.prod_Precio = item.prod_Precio;
                ViewBag.prod_Stock = item.prod_Stock;

                var UsuarioCreacion = _generalesService.BuscarUsuario(item.prod_UsuarioCreacion);
                var nombreCreacion = _generalesService.findEmpleado(UsuarioCreacion.empl_Id);
                ViewBag.UsuarioCreacion = nombreCreacion.empl_Nombre + " " + nombreCreacion.empl_Apellido;
                ViewBag.FechaCreacion = item.prod_FechaCreacion;

                if (!string.IsNullOrEmpty(item.prod_UsuarioModificacion.ToString()))
                {
                    var UsuarioModificacion = _generalesService.BuscarUsuario(item.prod_UsuarioModificacion);
                    var nombreModificacion = _generalesService.findEmpleado(UsuarioModificacion.empl_Id);
                    ViewBag.UsuarioModificacion = nombreModificacion.empl_Nombre + " " + nombreModificacion.empl_Apellido;
                    ViewBag.FechaModificacion = item.prod_FechaModificacion;
                }
            }   
            return View();
        }
    }
}
