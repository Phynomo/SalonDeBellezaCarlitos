﻿using AutoMapper;
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
    public class CategoriasController : Controller
    {
        private readonly GeneralesServices _generalesService;

        private readonly IMapper _mapper;

        public CategoriasController(GeneralesServices generalesServices, IMapper mapper)
        {
            _generalesService = generalesServices;
            _mapper = mapper;
        }


        [HttpGet("/Categorias/Listado")]
        public IActionResult Index()
        {

            var listado = _generalesService.ListadoCategorias(out string error);
            var listadoMapeado = _mapper.Map<IEnumerable<CategoriaViewModel>>(listado);

            if (string.IsNullOrEmpty(error))
            {
                ModelState.AddModelError("", error);
            }

            return View(listadoMapeado);
        }


        [HttpGet("/Categorias/Crear")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("/Categorias/Crear")]
        public ActionResult Create(CategoriaViewModel categoria)
        {
            try
            {
                var result = 0;
                var cate = _mapper.Map<tbCategorias>(categoria);
                result = _generalesService.InsertarCategoria(cate);

                if (result == 0)
                {
                    ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                    return View();
                }
            }
            catch (Exception)
            {

            }
            
            return RedirectToAction("Listado");
        }

        [HttpGet("/Categorias/Eliminar/{id}")]
        public IActionResult Delete(int? id)
        {
            var listado = _generalesService.BuscarCargo(id);
            return View(listado);
        }

        [HttpGet("/Categorias/Editar/{id}")]
        public IActionResult Edit(int? id)
        {
            var listado = _generalesService.BuscarCargo(id);
            return View(listado);
        }

        [HttpPost("/Categorias/Editar")]
        public IActionResult Edit(CategoriaViewModel cargo)
        {
            try
            {
                var result = 0;
                var car = _mapper.Map<tbCategorias>(cargo);
                result = _generalesService.EditarCategoria(car);

                if (result == 0)
                {
                    ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                    return View();
                }
            }
            catch (Exception)
            {

            }
            
            return RedirectToAction("Listado");

        }


        [HttpPost("/Categorias/Eliminar")]
        public IActionResult Delete(CategoriaViewModel cargo)
        {
            try
            {
                var result = 0;
                var car = _mapper.Map<tbCategorias>(cargo);
                result = _generalesService.EliminarCategoria(car);

                if (result == 0)
                {
                    ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                    return View();
                }
            }
            catch (Exception)
            {

            }
            
            return RedirectToAction("Listado");

        }

        [HttpGet("/Categorias/Detalles")]
        public IActionResult Details(int? id)
        {
            try
            {
                var servicio = _generalesService.BuscarCategoria(id);
                var servicioMapeado = _mapper.Map<IEnumerable<CategoriaViewModel>>(servicio);
                return View(servicioMapeado);
            }
            catch (Exception)
            {

            }
            return RedirectToAction("Listado");
        }
    }
}
