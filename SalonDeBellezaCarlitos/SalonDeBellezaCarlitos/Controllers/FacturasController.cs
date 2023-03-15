using AutoMapper;
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
    public class FacturasController : Controller
    {
        private readonly GeneralesServices _generalesService;

        private readonly IMapper _mapper;

        public FacturasController(GeneralesServices generalesServices, IMapper mapper)
        {
            _generalesService = generalesServices;
            _mapper = mapper;
        }


        [HttpGet("/Facturas/Listado")]
        public IActionResult Index()
        {

            var listado = _generalesService.ListadoFacturas(out string error);
            var listadoMapeado = _mapper.Map<IEnumerable<VWFacturasViewModel>>(listado);

            if (!string.IsNullOrEmpty(error))
            {
                ModelState.AddModelError("", error);
            }

            return View(listadoMapeado);
        }
        [HttpGet("/Facturas/Crear")]
        public IActionResult Create()
        {
            ViewBag.empl_Id_Atendido = new SelectList(_generalesService.ListadoEmpleados(out string error).ToList(), "empl_Id", "empl_Nombre");
            ViewBag.empl_Id_Caja = new SelectList(_generalesService.ListadoEmpleados(out string error3).ToList(), "empl_Id", "empl_Nombre");
            ViewBag.clie_Id = new SelectList(_generalesService.ListadoClientes(out string error2).ToList(), "clie_Id", "clie_Nombre");
            ViewBag.metp_Id = new SelectList(_generalesService.ListadoMetodoPago(out string error1).ToList(), "metp_Id", "metp_Descripcion");
            return View();
        }

        [HttpPost("/Facturas/Crear")]
        public ActionResult Create(FacturasViewModel factura)
        {
            var result = 0;
            var fac = _mapper.Map<tbFacturas>(factura);
            result = _generalesService.InsertarFacturas(fac);

            if (result == 0)
            {
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro"); 
                ViewBag.empl_Id_Atendido = new SelectList(_generalesService.ListadoEmpleados(out string error).ToList(), "empl_Id", "empl_Nombre",factura.empl_Id_Atendido);
                ViewBag.empl_Id_Caja = new SelectList(_generalesService.ListadoEmpleados(out string error3).ToList(), "empl_Id", "empl_Nombre",factura.empl_Id_Caja);
                ViewBag.clie_Id = new SelectList(_generalesService.ListadoClientes(out string error2).ToList(), "clie_Id", "clie_Nombre", factura.clie_Id);
                ViewBag.metp_Id = new SelectList(_generalesService.ListadoMetodoPago(out string error1).ToList(), "metp_Id", "metp_Descripcion", factura.metp_Id);
                return View(factura);
            }
            return RedirectToAction("Listado");
        }
    }
}
