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
            ViewBag.Toast = TempData["Factura"] as string;
            int sucu_id = Convert.ToInt32(HttpContext.Session.GetInt32("Sucursal"));
            var listado = _generalesService.ListadoFacturas(out string error, sucu_id);
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
            try
            {
                //Feliz dia papasito
                ViewBag.FecturaPreInsertadahidden = "hidden";
                ViewBag.prod_Id = new SelectList(_generalesService.ListadoProductos(out string error2).Where(x => x.prod_Stock > 0).ToList(), "prod_Id", "prod_Nombre");
                ViewBag.serv_Id = new SelectList(_generalesService.ListadoServicios(out string error1).ToList(), "serv_Id", "serv_Nombre");
                ViewBag.empl_Id_Atendido = new SelectList(_generalesService.ListadoEmpleados(out string error).ToList(), "empl_Id", "empl_Nombre");
                ViewBag.empl_Id_Caja = new SelectList(_generalesService.ListadoEmpleados(out string error3).ToList(), "empl_Id", "empl_Nombre");
                ViewBag.clie_Id = new SelectList(_generalesService.ListadoClientes(out string error221).ToList(), "clie_Id", "clie_Nombre");
                ViewBag.metp_Id = new SelectList(_generalesService.ListadoMetodoPago(out string error69).ToList(), "metp_Id", "metp_Descripcion");

                var lista = _generalesService.BuscarFacturasDetalles(0).ToList();
                ViewBag.Clientes = lista;

                return View();
            }
            catch (Exception)
            {

                TempData["Factura"] = "errorD";
                return RedirectToAction("Listado");
            }

        }

        [HttpPost("/Facturas/Crear")]
        public ActionResult Create(FacturasViewModel factura)
        {
            try
            {
                var result = 0;
                factura.fact_UsuarioModificacion = Convert.ToInt32(HttpContext.Session.GetInt32("usur_Id"));
                //Eliminar registro
                if (Convert.ToInt32(factura.fade_UsuarioModificacion) == 1)
                {
                    factura.fact_UsuarioCreacion = factura.fade_Id;
                    var car = _mapper.Map<tbFacturas>(factura);
                    result = _generalesService.EliminarDetalle(car);

                    if (result == 0)
                    {
                        #region Error
                        ModelState.AddModelError("", "Ocurrió un error al eliminar este registro");
                        ViewBag.clie_Id = new SelectList(_generalesService.ListadoClientes(out string error241).ToList(), "clie_Id", "clie_Nombre", factura.clie_Id);
                        ViewBag.metp_Id = new SelectList(_generalesService.ListadoMetodoPago(out string error141).ToList(), "metp_Id", "metp_Descripcion", factura.metp_Id);

                        ViewBag.clie_IdD = factura.clie_Id;
                        ViewBag.metp_IdD = factura.metp_Id;

                        ViewBag.prod_Id = new SelectList(_generalesService.ListadoProductos(out string error24021).Where(x => x.prod_Stock > 0).ToList(), "prod_Id", "prod_Nombre");
                        ViewBag.serv_Id = new SelectList(_generalesService.ListadoServicios(out string error14).ToList(), "serv_Id", "serv_Nombre");

                        ViewBag.Toast = "errorD";

                        return View(factura);

                        #endregion
                    }

                    #region success

                    ViewBag.empl_Id_Atendido = new SelectList(_generalesService.ListadoEmpleados(out string error12).ToList(), "empl_Id", "empl_Nombre", factura.empl_Id_Atendido);
                    ViewBag.empl_Id_Caja = new SelectList(_generalesService.ListadoEmpleados(out string error31).ToList(), "empl_Id", "empl_Nombre", factura.empl_Id_Caja);
                    ViewBag.clie_Id = new SelectList(_generalesService.ListadoClientes(out string error21).ToList(), "clie_Id", "clie_Nombre", factura.clie_Id);
                    ViewBag.metp_Id = new SelectList(_generalesService.ListadoMetodoPago(out string error11).ToList(), "metp_Id", "metp_Descripcion", factura.metp_Id);

                    ViewBag.clie_IdD = factura.clie_Id;
                    ViewBag.metp_IdD = factura.metp_Id;

                    ViewBag.prod_Id = new SelectList(_generalesService.ListadoProductos(out string error2).Where(x => x.prod_Stock > 0).ToList(), "prod_Id", "prod_Nombre");
                    ViewBag.serv_Id = new SelectList(_generalesService.ListadoServicios(out string error1).ToList(), "serv_Id", "serv_Nombre", 0);

                    ViewBag.fact_Id = factura.fact_Id;
                    ViewBag.logrado = "true";

                    var lista = _generalesService.BuscarFacturasDetalles(factura.fact_Id).ToList();
                    ViewBag.Clientes = lista;

                    ViewBag.Toast = "successD";

                    return View();
                    #endregion

                }

                //crear encabezado de la factura
                if ((factura.prod_Id == 0 && factura.serv_Id == 0) || (factura.prod_Id == null && factura.serv_Id == null))
                {

                    var fac = _mapper.Map<tbFacturas>(factura);
                    result = _generalesService.InsertarFacturas(fac);

                    if (result == 0)
                    {

                        #region error

                        ViewBag.FecturaPreInsertadahidden = "hidden";
                        ModelState.AddModelError("", "Ocurrió un error al crear el encabezado");
                        ViewBag.empl_Id_Atendido = new SelectList(_generalesService.ListadoEmpleados(out string error).ToList(), "empl_Id", "empl_Nombre", factura.empl_Id_Atendido);
                        ViewBag.empl_Id_Caja = new SelectList(_generalesService.ListadoEmpleados(out string error3).ToList(), "empl_Id", "empl_Nombre", factura.empl_Id_Caja);
                        ViewBag.clie_Id = new SelectList(_generalesService.ListadoClientes(out string error22).ToList(), "clie_Id", "clie_Nombre", factura.clie_Id);
                        ViewBag.metp_Id = new SelectList(_generalesService.ListadoMetodoPago(out string error1255).ToList(), "metp_Id", "metp_Descripcion", factura.metp_Id);
                        ViewBag.prod_Id = new SelectList(_generalesService.ListadoProductos(out string error2).Where(x => x.prod_Stock > 0).ToList(), "prod_Id", "prod_Nombre");
                        ViewBag.serv_Id = new SelectList(_generalesService.ListadoServicios(out string ersror1).ToList(), "serv_Id", "serv_Nombre");

                        var lista2 = _generalesService.BuscarFacturasDetalles(factura.fact_Id).ToList();
                        ViewBag.Clientes = lista2;

                        ViewBag.Toast = "errorH";

                        return View(factura);
                        #endregion

                    }

                    #region success

                    ViewBag.empl_Id_Atendido = new SelectList(_generalesService.ListadoEmpleados(out string error12).ToList(), "empl_Id", "empl_Nombre", factura.empl_Id_Atendido);
                    ViewBag.empl_Id_Caja = new SelectList(_generalesService.ListadoEmpleados(out string error31).ToList(), "empl_Id", "empl_Nombre", factura.empl_Id_Caja);
                    ViewBag.clie_Id = new SelectList(_generalesService.ListadoClientes(out string error21).ToList(), "clie_Id", "clie_Nombre", factura.clie_Id);
                    ViewBag.metp_Id = new SelectList(_generalesService.ListadoMetodoPago(out string error11).ToList(), "metp_Id", "metp_Descripcion", factura.metp_Id);

                    ViewBag.clie_IdD = factura.clie_Id;
                    ViewBag.metp_IdD = factura.metp_Id;
                    ViewBag.fact_Id = result;
                    ViewBag.prod_Id = new SelectList(_generalesService.ListadoProductos(out string error122).Where(x => x.prod_Stock > 0).ToList(), "prod_Id", "prod_Nombre");
                    ViewBag.serv_Id = new SelectList(_generalesService.ListadoServicios(out string error1).ToList(), "serv_Id", "serv_Nombre");

                    var lista = _generalesService.BuscarFacturasDetalles(factura.fact_Id).ToList();
                    ViewBag.Clientes = lista;


                    ViewBag.Toast = "successH";

                    ViewBag.logrado = "true";
                    return View(factura);

                    #endregion

                }
                else//Insertar detalles
                {

                    factura.fact_UsuarioCreacion = factura.fade_Cantidad;
                    factura.empl_Id_Caja = Convert.ToInt32(factura.serv_Id);
                    factura.empl_Id_Atendido = Convert.ToInt32(factura.prod_Id);

                    var fac = _mapper.Map<tbFacturas>(factura);
                    result = _generalesService.InsertarFacturasDetalles(fac);

                    if (result == 0)
                    {
                        #region error

                        ModelState.AddModelError("", "Ocurrió un error al crear este registro");
                        ViewBag.clie_Id = new SelectList(_generalesService.ListadoClientes(out string error241).ToList(), "clie_Id", "clie_Nombre", factura.clie_Id);
                        ViewBag.metp_Id = new SelectList(_generalesService.ListadoMetodoPago(out string error141).ToList(), "metp_Id", "metp_Descripcion", factura.metp_Id);

                        ViewBag.clie_IdD = factura.clie_Id;
                        ViewBag.metp_IdD = factura.metp_Id;

                        ViewBag.prod_Id = new SelectList(_generalesService.ListadoProductos(out string error1242).Where(x => x.prod_Stock > 0).ToList(), "prod_Id", "prod_Nombre");
                        ViewBag.serv_Id = new SelectList(_generalesService.ListadoServicios(out string error14).ToList(), "serv_Id", "serv_Nombre");


                        var lista3 = _generalesService.BuscarFacturasDetalles(factura.fact_Id).ToList();
                        ViewBag.Clientes = lista3;

                        ViewBag.Toast = "errorB";

                        return View(factura);

                        #endregion

                    }

                    #region success

                    ViewBag.empl_Id_Atendido = new SelectList(_generalesService.ListadoEmpleados(out string error12).ToList(), "empl_Id", "empl_Nombre", factura.empl_Id_Atendido);
                    ViewBag.empl_Id_Caja = new SelectList(_generalesService.ListadoEmpleados(out string error31).ToList(), "empl_Id", "empl_Nombre", factura.empl_Id_Caja);
                    ViewBag.clie_Id = new SelectList(_generalesService.ListadoClientes(out string error21).ToList(), "clie_Id", "clie_Nombre", factura.clie_Id);
                    ViewBag.metp_Id = new SelectList(_generalesService.ListadoMetodoPago(out string error11).ToList(), "metp_Id", "metp_Descripcion", factura.metp_Id);

                    ViewBag.clie_IdD = factura.clie_Id;
                    ViewBag.metp_IdD = factura.metp_Id;

                    ViewBag.prod_Id = new SelectList(_generalesService.ListadoProductos(out string error2).Where(x => x.prod_Stock > 0).ToList(), "prod_Id", "prod_Nombre");
                    ViewBag.serv_Id = new SelectList(_generalesService.ListadoServicios(out string error1).ToList(), "serv_Id", "serv_Nombre", 0);

                    ViewBag.fact_Id = factura.fact_Id;
                    ViewBag.logrado = "true";

                    var lista = _generalesService.BuscarFacturasDetalles(factura.fact_Id).ToList();
                    ViewBag.Clientes = lista;

                    ViewBag.Toast = "successB";

                    return View();

                    #endregion

                }
            }
            catch (Exception)
            {

                TempData["Factura"] = "errorD";
                return RedirectToAction("Listado");
            }


        }

        [HttpGet("/Facturas/Editar")]
        public IActionResult Edit(int? id)
        {
            try
            {
                var factura = _generalesService.BuscarFactura(id);
                var facturaMapeado = _mapper.Map<IEnumerable<VWFacturasViewModel>>(factura);

                
                #region Cargar datos...
                if (factura.Count() == 0)
                {
                    Convert.ToInt32("a");
                }
                foreach (var item in factura)
                {
                    var empl = _generalesService.findEmpleado(item.empl_Id_Caja);

                    var sucursalid = Convert.ToInt32(HttpContext.Session.GetInt32("Sucursal"));

                    if (empl.sucu_Id != sucursalid)
                    {
                        TempData["Factura"] = "sucursal";
                        return RedirectToAction("Listado");
                    }


                    ViewBag.empl_Id_Atendido = new SelectList(_generalesService.ListadoEmpleados(out string error12).ToList(), "empl_Id", "empl_Nombre", item.empl_Id_Atendido);
                    ViewBag.empl_Id_Caja = new SelectList(_generalesService.ListadoEmpleados(out string error31).ToList(), "empl_Id", "empl_Nombre", item.empl_Id_Caja);
                    ViewBag.clie_Id = new SelectList(_generalesService.ListadoClientes(out string error21).ToList(), "clie_Id", "clie_Nombre", item.clie_Id);
                    ViewBag.metp_Id = new SelectList(_generalesService.ListadoMetodoPago(out string error11).ToList(), "metp_Id", "metp_Descripcion", item.metp_Id);

                    ViewBag.clie_IdD = item.clie_Id;
                    ViewBag.metp_IdD = item.metp_Id;
                    ViewBag.fact_Id = id;
                    ViewBag.prod_Id = new SelectList(_generalesService.ListadoProductos(out string error2).Where(x => x.prod_Stock > 0).ToList(), "prod_Id", "prod_Nombre");
                    ViewBag.serv_Id = new SelectList(_generalesService.ListadoServicios(out string error1).ToList(), "serv_Id", "serv_Nombre");

                    var lista = _generalesService.BuscarFacturasDetalles(item.fact_Id).ToList();

                    

                    ViewBag.Clientes = lista;

                    ViewBag.logrado = "edit";
                    return View();
                }

                #endregion

                return View();
            }
            catch (Exception)
            {
                ViewBag.Clientes = null;
                TempData["Factura"] = "errorC";
                return RedirectToAction("Listado");
            }

        }

        [HttpPost("/Facturas/Editar")]
        public ActionResult Edit(FacturasViewModel factura)
        {
            try
            {
                var result = 0;

                factura.fact_UsuarioModificacion = Convert.ToInt32(HttpContext.Session.GetInt32("usur_Id"));
                //Eliminar registro
                if (Convert.ToInt32(factura.fade_UsuarioModificacion) == 1)
                {
                    factura.fact_UsuarioCreacion = factura.fade_Id;
                    var car = _mapper.Map<tbFacturas>(factura);
                    result = _generalesService.EliminarDetalle(car);

                    if (result == 0)
                    {

                        #region error

                        ModelState.AddModelError("", "Ocurrió un error al eliminar este registro");
                        ViewBag.clie_Id = new SelectList(_generalesService.ListadoClientes(out string error241).ToList(), "clie_Id", "clie_Nombre", factura.clie_Id);
                        ViewBag.metp_Id = new SelectList(_generalesService.ListadoMetodoPago(out string error141).ToList(), "metp_Id", "metp_Descripcion", factura.metp_Id);

                        ViewBag.clie_IdD = factura.clie_Id;
                        ViewBag.metp_IdD = factura.metp_Id;

                        ViewBag.prod_Id = new SelectList(_generalesService.ListadoProductos(out string errsor2).Where(x => x.prod_Stock > 0).ToList(), "prod_Id", "prod_Nombre");
                        ViewBag.serv_Id = new SelectList(_generalesService.ListadoServicios(out string error14).ToList(), "serv_Id", "serv_Nombre");


                        ViewBag.Toast = "errorD";

                        return View(factura);

                        #endregion

                    }

                    #region success

                    ViewBag.empl_Id_Atendido = new SelectList(_generalesService.ListadoEmpleados(out string error12).ToList(), "empl_Id", "empl_Nombre", factura.empl_Id_Atendido);
                    ViewBag.empl_Id_Caja = new SelectList(_generalesService.ListadoEmpleados(out string error31).ToList(), "empl_Id", "empl_Nombre", factura.empl_Id_Caja);
                    ViewBag.clie_Id = new SelectList(_generalesService.ListadoClientes(out string error21).ToList(), "clie_Id", "clie_Nombre", factura.clie_Id);
                    ViewBag.metp_Id = new SelectList(_generalesService.ListadoMetodoPago(out string error11).ToList(), "metp_Id", "metp_Descripcion", factura.metp_Id);

                    ViewBag.clie_IdD = factura.clie_Id;
                    ViewBag.metp_IdD = factura.metp_Id;

                    ViewBag.prod_Id = new SelectList(_generalesService.ListadoProductos(out string error2).Where(x => x.prod_Stock > 0).ToList(), "prod_Id", "prod_Nombre");
                    ViewBag.serv_Id = new SelectList(_generalesService.ListadoServicios(out string error1).ToList(), "serv_Id", "serv_Nombre", 0);

                    ViewBag.fact_Id = factura.fact_Id;
                    ViewBag.logrado = "edit";

                    var lista = _generalesService.BuscarFacturasDetalles(factura.fact_Id).ToList();
                    ViewBag.Clientes = lista;

                    ViewBag.Toast = "successD";

                    return View();

                    #endregion

                }

                if ((factura.prod_Id == 0 && factura.serv_Id == 0) || (factura.prod_Id == null && factura.serv_Id == null))
                {
                    var fac = _mapper.Map<tbFacturas>(factura);
                    result = _generalesService.InsertarFacturas(fac);

                    if (result == 0)
                    {

                        #region error

                        ViewBag.FecturaPreInsertadahidden = "hidden";
                        ModelState.AddModelError("", "Ocurrió un error al crear este registro");
                        ViewBag.empl_Id_Atendido = new SelectList(_generalesService.ListadoEmpleados(out string error).ToList(), "empl_Id", "empl_Nombre", factura.empl_Id_Atendido);
                        ViewBag.empl_Id_Caja = new SelectList(_generalesService.ListadoEmpleados(out string error3).ToList(), "empl_Id", "empl_Nombre", factura.empl_Id_Caja);
                        ViewBag.clie_Id = new SelectList(_generalesService.ListadoClientes(out string error22).ToList(), "clie_Id", "clie_Nombre", factura.clie_Id);
                        ViewBag.metp_Id = new SelectList(_generalesService.ListadoMetodoPago(out string error1255).ToList(), "metp_Id", "metp_Descripcion", factura.metp_Id);
                        ViewBag.prod_Id = new SelectList(_generalesService.ListadoProductos(out string serror2).Where(x => x.prod_Stock > 0).ToList(), "prod_Id", "prod_Nombre");
                        ViewBag.serv_Id = new SelectList(_generalesService.ListadoServicios(out string errsor1).ToList(), "serv_Id", "serv_Nombre");

                        var lista2 = _generalesService.BuscarFacturasDetalles(factura.fact_Id).ToList();
                        ViewBag.Clientes = lista2;

                        ViewBag.Toast = "errorH";
                        return View(factura);

                        #endregion

                    }

                    #region success

                    ViewBag.empl_Id_Atendido = new SelectList(_generalesService.ListadoEmpleados(out string error12).ToList(), "empl_Id", "empl_Nombre", factura.empl_Id_Atendido);
                    ViewBag.empl_Id_Caja = new SelectList(_generalesService.ListadoEmpleados(out string error31).ToList(), "empl_Id", "empl_Nombre", factura.empl_Id_Caja);
                    ViewBag.clie_Id = new SelectList(_generalesService.ListadoClientes(out string error21).ToList(), "clie_Id", "clie_Nombre", factura.clie_Id);
                    ViewBag.metp_Id = new SelectList(_generalesService.ListadoMetodoPago(out string error11).ToList(), "metp_Id", "metp_Descripcion", factura.metp_Id);

                    ViewBag.clie_IdD = factura.clie_Id;
                    ViewBag.metp_IdD = factura.metp_Id;
                    ViewBag.fact_Id = result;
                    ViewBag.prod_Id = new SelectList(_generalesService.ListadoProductos(out string error2).Where(x => x.prod_Stock > 0).ToList(), "prod_Id", "prod_Nombre");
                    ViewBag.serv_Id = new SelectList(_generalesService.ListadoServicios(out string error1).ToList(), "serv_Id", "serv_Nombre");

                    var lista = _generalesService.BuscarFacturasDetalles(factura.fact_Id).ToList();
                    ViewBag.Clientes = lista;

                    ViewBag.Toast = "successH";
                    ViewBag.logrado = "edit";
                    return View(factura);

                    #endregion

                }
                else
                {

                    factura.fact_UsuarioCreacion = factura.fade_Cantidad;
                    factura.empl_Id_Caja = Convert.ToInt32(factura.serv_Id);
                    factura.empl_Id_Atendido = Convert.ToInt32(factura.prod_Id);

                    var fac = _mapper.Map<tbFacturas>(factura);
                    result = _generalesService.InsertarFacturasDetalles(fac);

                    if (result == 0)
                    {

                        #region error

                        ModelState.AddModelError("", "Ocurrió un error al crear este registro");
                        ViewBag.clie_Id = new SelectList(_generalesService.ListadoClientes(out string error241).ToList(), "clie_Id", "clie_Nombre", factura.clie_Id);
                        ViewBag.metp_Id = new SelectList(_generalesService.ListadoMetodoPago(out string error141).ToList(), "metp_Id", "metp_Descripcion", factura.metp_Id);

                        ViewBag.clie_IdD = factura.clie_Id;
                        ViewBag.metp_IdD = factura.metp_Id;

                        ViewBag.prod_Id = new SelectList(_generalesService.ListadoProductos(out string ersror2).Where(x => x.prod_Stock > 0).ToList(), "prod_Id", "prod_Nombre");
                        ViewBag.serv_Id = new SelectList(_generalesService.ListadoServicios(out string error14).ToList(), "serv_Id", "serv_Nombre");


                        var lista3 = _generalesService.BuscarFacturasDetalles(factura.fact_Id).ToList();
                        ViewBag.Clientes = lista3;

                        ViewBag.Toast = "errorB";

                        return View(factura);

                        #endregion

                    }

                    #region success

                    ViewBag.empl_Id_Atendido = new SelectList(_generalesService.ListadoEmpleados(out string error12).ToList(), "empl_Id", "empl_Nombre", factura.empl_Id_Atendido);
                    ViewBag.empl_Id_Caja = new SelectList(_generalesService.ListadoEmpleados(out string error31).ToList(), "empl_Id", "empl_Nombre", factura.empl_Id_Caja);
                    ViewBag.clie_Id = new SelectList(_generalesService.ListadoClientes(out string error21).ToList(), "clie_Id", "clie_Nombre", factura.clie_Id);
                    ViewBag.metp_Id = new SelectList(_generalesService.ListadoMetodoPago(out string error11).ToList(), "metp_Id", "metp_Descripcion", factura.metp_Id);

                    ViewBag.clie_IdD = factura.clie_Id;
                    ViewBag.metp_IdD = factura.metp_Id;

                    ViewBag.prod_Id = new SelectList(_generalesService.ListadoProductos(out string error2).Where(x => x.prod_Stock > 0).ToList(), "prod_Id", "prod_Nombre");
                    ViewBag.serv_Id = new SelectList(_generalesService.ListadoServicios(out string error1).ToList(), "serv_Id", "serv_Nombre", 0);

                    ViewBag.fact_Id = factura.fact_Id;
                    ViewBag.logrado = "edit";

                    var lista = _generalesService.BuscarFacturasDetalles(factura.fact_Id).ToList();
                    ViewBag.Clientes = lista;

                    ViewBag.Toast = "successB";

                    return View();

                    #endregion

                }

            }
            catch (Exception)
            {

                TempData["Factura"] = "errorD";
                return RedirectToAction("Listado");
            }

        }

        [HttpGet("/Facturas/Detalles")]
        public IActionResult Details(int? id)
        {
            try
            {
                var Factura = _generalesService.BuscarFactura(id);
                var listadoMapeado = _mapper.Map<IEnumerable<VWFacturasViewModel>>(Factura);
                if (Factura.Count() == 0)
                {
                    Convert.ToInt32("hola");
                }
                var lista = _generalesService.BuscarFacturasDetalles(id).ToList();


                ViewBag.Clientes = lista;

                decimal subtotal = 0;

                foreach (var item in lista)
                {
                    subtotal += item.fade_Cantidad * item.fade_Precio;
                }

                decimal iva = (subtotal * Convert.ToDecimal(0.12));
                decimal Total = iva + subtotal;



                ViewBag.Total = Total;
                ViewBag.Subtotal = subtotal;
                ViewBag.IVA = iva;

                return View(listadoMapeado);

            }
            catch (Exception)
            {
                ViewBag.Clientes = null;
                TempData["Factura"] = "errorC";
                return RedirectToAction("Listado");
            }

        }

        public IActionResult RevisarStock(int prod_Id, int serv_Id)
        {
            var stock = _generalesService.stockMaximo(prod_Id, serv_Id);
            //ViewBag.muni_Id = new SelectList(cargarmunicipios.ToList(), "muni_Id", "muni_Descripcion");
            return Json(stock);
        }


    }
}
