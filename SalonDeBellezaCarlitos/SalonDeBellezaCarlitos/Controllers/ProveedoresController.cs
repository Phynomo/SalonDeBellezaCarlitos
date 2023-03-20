using AutoMapper;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using Microsoft.AspNetCore.Mvc.Rendering;
using SalonDeBellezaCarlitos.BusinessLogic.Services;
using SalonDeBellezaCarlitos.DataAccess;
using SalonDeBellezaCarlitos.DataAccess.Repository;
using SalonDeBellezaCarlitos.Entities.Entities;
using SalonDeBellezaCarlitos.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using Microsoft.AspNetCore.Http;

namespace SalonDeBellezaCarlitos.WebUI.Controllers
{
    public class ProveedoresController : Controller
    {
        private readonly GeneralesServices _generalesService;

        private readonly IMapper _mapper;

        public ProveedoresController(GeneralesServices generalesServices, IMapper mapper)
        {
            _generalesService = generalesServices;
            _mapper = mapper;
        }


        [HttpGet("/Proveedores/Listado")]
        public IActionResult Index()
        {

            ViewBag.Toast = TempData["Proveedor"] as string;
            var listado = _generalesService.ListadoProveedores(out string error);
            var listadoMapeado = _mapper.Map<IEnumerable<ProveedorViewModel>>(listado);

            if (string.IsNullOrEmpty(error))
            {
                ModelState.AddModelError("", error);
            }

            return View(listadoMapeado);
        }
        [HttpGet("/Proveedores/Crear")]
        public IActionResult Create()
        {
            ViewBag.depa_Id = new SelectList(_generalesService.ListadoDepartamentos(out string error).ToList(), "depa_Id", "depa_Descripcion");
            return View();
        }

        [HttpPost("/Proveedores/Crear")]
        public ActionResult Create(ProveedorViewModel proveedor)
        {
            var result = 0;
            proveedor.prov_UsuarioCreacion = Convert.ToInt32(HttpContext.Session.GetString("usur_Id"));
            proveedor.prov_UsuarioModificacion = Convert.ToInt32(HttpContext.Session.GetString("usur_Id"));

            var prov = _mapper.Map<tbProveedores>(proveedor);
            result = _generalesService.InsertarProveedor(prov);

            switch (result)
            {
                case 1:
                    TempData["Proveedor"] = "success";
                    return RedirectToAction("Listado");
                case 2:
                    ViewBag.Toast = "repetido";
                    ModelState.AddModelError("", "El nombre de la empresa ya esta registrado");
                    ViewBag.depa_Id = new SelectList(_generalesService.ListadoDepartamentos(out string error).ToList(), "depa_Id", "depa_Descripcion", proveedor.depa_Id);
                    ViewBag.muni_Id = new SelectList(_generalesService.ListadoMunicipiosPorDepartamento(proveedor.depa_Id), "muni_Id", "muni_Descripcion", proveedor.muni_Id);
                    return View(proveedor);
                case 44:
                    ViewBag.Toast = "fatal";
                    ModelState.AddModelError("", "Ocurrió un error al crear este registro");
                    ViewBag.depa_Id = new SelectList(_generalesService.ListadoDepartamentos(out string error7).ToList(), "depa_Id", "depa_Descripcion", proveedor.depa_Id);
                    ViewBag.muni_Id = new SelectList(_generalesService.ListadoMunicipiosPorDepartamento(proveedor.depa_Id), "muni_Id", "muni_Descripcion", proveedor.muni_Id);
                    return View(proveedor);
                default:
                    TempData["Proveedor"] = "noprevisto";
                    ModelState.AddModelError("", "Ocurrió un error al crear este registro");
                    ViewBag.depa_Id = new SelectList(_generalesService.ListadoDepartamentos(out string error77).ToList(), "depa_Id", "depa_Descripcion", proveedor.depa_Id);
                    ViewBag.muni_Id = new SelectList(_generalesService.ListadoMunicipiosPorDepartamento(proveedor.depa_Id), "muni_Id", "muni_Descripcion", proveedor.muni_Id);
                    return View(proveedor);
            }


        }


        [HttpGet("/Proveedores/Editar")]
        public IActionResult Edit(int? id)
        {
            try
            {
                var proveedor = _generalesService.findProveedor(id);
                var proveedorMapeado = _mapper.Map<ProveedorViewModel>(proveedor);

                #region Cargando datos...
                if (proveedor == null)
                {
                    Convert.ToInt32("a");
                }

                var depa_Id = _generalesService.BuscarMunicipio(proveedor.muni_Id);
                ViewBag.depa_Id = new SelectList(_generalesService.ListadoDepartamentos(out string error).ToList(), "depa_Id", "depa_Descripcion", depa_Id.depa_Id);
                ViewBag.muni_Id = new SelectList(_generalesService.ListadoMunicipiosPorDepartamento(depa_Id.depa_Id), "muni_Id", "muni_Descripcion", proveedor.muni_Id);

                proveedorMapeado.depa_Id = depa_Id.depa_Id;

                #endregion

                return View(proveedorMapeado);
            }
            catch (Exception)
            {
                TempData["Proveedor"] = "errorC";
                return RedirectToAction("Listado");
            }

        }

        [HttpPost("/Proveedores/Editar")]
        public ActionResult Edit(ProveedorViewModel proveedor)
        {
            var result = 0;
            proveedor.prov_UsuarioCreacion = Convert.ToInt32(HttpContext.Session.GetString("usur_Id"));
            proveedor.prov_UsuarioModificacion = Convert.ToInt32(HttpContext.Session.GetString("usur_Id"));

            var prov = _mapper.Map<tbProveedores>(proveedor);
            result = _generalesService.EditarProveedor(prov);

            switch (result)
            {
                case 1:
                    TempData["Proveedor"] = "success";
                    return RedirectToAction("Listado");
                case 2:
                    ViewBag.Toast = "repetido";
                    ModelState.AddModelError("", "El nombre de la empresa ya esta registrado");
                    ViewBag.depa_Id = new SelectList(_generalesService.ListadoDepartamentos(out string error).ToList(), "depa_Id", "depa_Descripcion", proveedor.depa_Id);
                    ViewBag.muni_Id = new SelectList(_generalesService.ListadoMunicipiosPorDepartamento(proveedor.depa_Id), "muni_Id", "muni_Descripcion", proveedor.muni_Id);
                    return View(proveedor);
                case 0:
                    ViewBag.Toast = "fatal";
                    ModelState.AddModelError("", "Ocurrió un error al crear este registro");
                    ViewBag.depa_Id = new SelectList(_generalesService.ListadoDepartamentos(out string error7).ToList(), "depa_Id", "depa_Descripcion", proveedor.depa_Id);
                    ViewBag.muni_Id = new SelectList(_generalesService.ListadoMunicipiosPorDepartamento(proveedor.depa_Id), "muni_Id", "muni_Descripcion", proveedor.muni_Id);
                    return View(proveedor);
                default:
                    TempData["Proveedor"] = "noprevisto";
                    ModelState.AddModelError("", "Ocurrió un error al crear este registro");
                    ViewBag.depa_Id = new SelectList(_generalesService.ListadoDepartamentos(out string error77).ToList(), "depa_Id", "depa_Descripcion", proveedor.depa_Id);
                    ViewBag.muni_Id = new SelectList(_generalesService.ListadoMunicipiosPorDepartamento(proveedor.depa_Id), "muni_Id", "muni_Descripcion", proveedor.muni_Id);
                    return View(proveedor);
            }
        }

        [HttpGet("/Proveedores/Detalles")]
        public IActionResult Details(int? id)
        {
            try
            {
                var proveedor = _generalesService.findProveedor(id);
                var proveedorMapeado = _mapper.Map<ProveedorViewModel>(proveedor);

                #region Cargando datos ...
                if (proveedor == null)
                {
                    Convert.ToInt32("a");
                }

                var muni_Id = _generalesService.BuscarMunicipio(proveedorMapeado.muni_Id);
                var depa_Id = _generalesService.findDepartameto(muni_Id.depa_Id);

                ViewBag.depa_Id = depa_Id.depa_Descripcion;
                ViewBag.muni_Id = muni_Id.muni_Descripcion;

                var UsuarioCreacion = _generalesService.BuscarUsuario(proveedorMapeado.prov_UsuarioCreacion);
                var nombreCreacion = _generalesService.BuscarEmpleados(UsuarioCreacion.empl_Id);
                foreach (var item in nombreCreacion)
                {
                    ViewBag.UsuarioCreacion = item.empl_Nombre + " " + item.empl_Apellido;
                }


                if (!string.IsNullOrEmpty(proveedorMapeado.prov_UsuarioModificacion.ToString()))
                {
                    var UsuarioModificacion = _generalesService.BuscarUsuario(proveedorMapeado.prov_UsuarioModificacion);
                    var nombreModificacion = _generalesService.BuscarEmpleados(UsuarioModificacion.empl_Id);
                    foreach (var item in nombreModificacion)
                    {
                        ViewBag.UsuarioModificacion = item.empl_Nombre + " " + item.empl_Apellido;
                    }

                }
                #endregion

                return View(proveedorMapeado);
            }
            catch
            {

                TempData["Proveedor"] = "errorC";
                return RedirectToAction("Listado");
            }

        }

        [HttpPost("/Proveedores/Eliminar")]
        public IActionResult Delete(ProveedorViewModel Proveedor)
        {
            var result = 0;
            var pro = _mapper.Map<tbProveedores>(Proveedor);
            result = _generalesService.EliminarProveedor(pro);

            if (result == 0)
            {
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                return View();
            }
            return RedirectToAction("Listado");

        }

        //public IEnumerable<tbProveedores> BuscarProveedor(int? id)
        //{
        //    using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
        //    var parametros = new DynamicParameters();
        //    parametros.Add("@prov_Id", id, DbType.String, ParameterDirection.Input);
        //    return db.Query<tbProveedores>(ScriptsDataBase.UDP_Buscar_Proveedores, parametros, commandType: CommandType.StoredProcedure);

        //}

    }
}
