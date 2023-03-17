﻿using AutoMapper;
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

            var listado = _generalesService.ListadoProductos(out string error);
            var listadoMapeado = _mapper.Map<IEnumerable<ProductoViewModel>>(listado);

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
            var prod = _mapper.Map<tbProductos>(producto);
            result = _generalesService.InsertarProducto(prod);

            if (result == 0)
            {
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                ViewBag.cate_Id = new SelectList(_generalesService.ListadoCategorias(out string error).ToList(), "cate_Id", "cate_Descripcion");
                ViewBag.prov_Id = new SelectList(_generalesService.ListadoProveedores(out string error2).ToList(), "prov_Id", "prov_NombreContacto");
                return View();
            }
            return RedirectToAction("Listado");
        }
    }
}
