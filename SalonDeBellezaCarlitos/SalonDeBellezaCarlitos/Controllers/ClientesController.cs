using AutoMapper;
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
    public class ClientesController : Controller
    {
        private readonly GeneralesServices _generalesService;

        private readonly IMapper _mapper;

        public ClientesController(GeneralesServices generalesServices, IMapper mapper)
        {
            _generalesService = generalesServices;
            _mapper = mapper;
        }
        [HttpGet("/Clientes/Listado")]
        public IActionResult Index()
        {

            var listado = _generalesService.ListadoClientes(out string error);
            var listadoMapeado = _mapper.Map<IEnumerable<ClienteViewModel>>(listado);

            if (string.IsNullOrEmpty(error))
            {
                ModelState.AddModelError("", error);
            }

            return View(listadoMapeado);
        }
        [HttpPost("/Clientes/Crear")]
        public ActionResult Create(ClienteViewModel cliente)
        {
            try
            {
                var result = 0;
                var cli = _mapper.Map<tbClientes>(cliente);
                result = _generalesService.InsertarCLientes(cli);

                if (result == 0)
                {
                    ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                    return RedirectToAction("Listado");
                }
            }
            catch (Exception)
            {

            }
            
            return RedirectToAction("Listado");
        }
        [HttpGet("/Clientes/Editar/{id}")]
        public IActionResult Edit(int? id)
        {
            var listado = _generalesService.BuscarCargo(id);
            return View(listado);
        }

        [HttpPost("/Clientes/Editar")]
        public IActionResult Edit(ClienteViewModel cliente)
        {
            try
            {
                var result = 0;
                var cli = _mapper.Map<tbClientes>(cliente);
                result = _generalesService.EditarCliente(cli);

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

        [HttpPost("/Clientes/Eliminar")]
        public IActionResult Delete(ClienteViewModel cliente)
        {
            try
            {
                var result = 0;
                var cli = _mapper.Map<tbClientes>(cliente);
                result = _generalesService.EliminarCliente(cli);

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

        [HttpGet("/Clientes/Detalles")]
        public IActionResult Details(int? id)
        {
            try
            {
                var cliente = _generalesService.BuscarCliente(id);
                var clienteMapeado = _mapper.Map<IEnumerable<ClienteViewModel>>(cliente);
                return View(clienteMapeado);
            }
            catch (Exception)
            {

            }
            return RedirectToAction("Listado");
        }

    }
}
