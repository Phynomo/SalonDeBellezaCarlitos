﻿using AutoMapper;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using SalonDeBellezaCarlitos.BusinessLogic.Services;
using SalonDeBellezaCarlitos.DataAccess;
using SalonDeBellezaCarlitos.Entities.Entities;
using SalonDeBellezaCarlitos.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalonDeBellezaCarlitos.WebUI.Controllers
{

    
    public class EmpleadosController : Controller
    {

        private readonly GeneralesServices _generalesService;

        private readonly IMapper _mapper;

        
        public EmpleadosController(GeneralesServices generalesServices, IMapper mapper)
        {
            _generalesService = generalesServices;
            _mapper = mapper;
        }


        [HttpGet("/Empleados/Listado")]
        public IActionResult Index()
        {
            ViewBag.Toast = TempData["Empleados"] as string;
            string miValor = HttpContext.Session.GetString("MiClave");

            ViewBag.hola = miValor;

            var listado = _generalesService.ListadoEmpleados(out string error);
            
            var listadoMapeado = _mapper.Map<IEnumerable<EmpleadoViewModel>>(listado);
           
            if (string.IsNullOrEmpty(error))
            {
                ModelState.AddModelError("", error);
            }

            return View(listadoMapeado);
        }   



        [HttpGet("/Empleados/Crear")]
        public IActionResult Create()
        {
            ViewBag.depa_Id = new SelectList(_generalesService.ListadoDepartamentos(out string error).ToList(), "depa_Id", "depa_Descripcion");
            ViewBag.carg_Id = new SelectList(_generalesService.ListadoCargos(out string error2).ToList(), "carg_Id", "carg_Descripcion");
            ViewBag.estc_Id = new SelectList(_generalesService.ListadoEstadosCiviles(out string error1).ToList(), "estc_Id", "estc_Descripcion");
            ViewBag.sucu_Id = new SelectList(_generalesService.ListadoSucursales(out string error11).ToList(), "sucu_Id", "sucu_Descripcion");
            return View();
        }

        [HttpPost("/Empleados/Crear")]
        public ActionResult Create(EmpleadoViewModel empleado)
        {
            try
            {
            empleado.empl_UsuarioCreacion = Convert.ToInt32(HttpContext.Session.GetInt32("usur_Id"));
            empleado.empl_UsuarioModificacion = Convert.ToInt32(HttpContext.Session.GetInt32("usur_Id"));

            var result = 0;
            var emp = _mapper.Map<tbEmpleados>(empleado);
            result = _generalesService.InsertarEmpleado(emp);

            if (result == 0)
            {
                TempData["Empleados"] = "error";
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro"); 
                ViewBag.depa_Id = new SelectList(_generalesService.ListadoDepartamentos(out string error).ToList(), "depa_Id", "depa_Descripcion",empleado.depa_Id);
                ViewBag.muni_Id = new SelectList(_generalesService.ListadoMunicipiosPorDepartamento(empleado.depa_Id), "muni_Id", "muni_Descripcion",empleado.muni_Id);
                ViewBag.carg_Id = new SelectList(_generalesService.ListadoCargos(out string error2).ToList(), "carg_Id", "carg_Descripcion",empleado.carg_Id);
                ViewBag.estc_Id = new SelectList(_generalesService.ListadoEstadosCiviles(out string error1).ToList(), "estc_Id", "estc_Descripcion",empleado.estc_Id);
                ViewBag.sucu_Id = new SelectList(_generalesService.ListadoSucursales(out string error11).ToList(), "sucu_Id", "sucu_Descripcion",empleado.sucu_Id);
                return View(empleado);
            }
            TempData["Empleados"] = "success";
            return RedirectToAction("Listado");
            }
            catch (Exception)
            {

                TempData["Empleados"] = "error";
                return RedirectToAction("Listado");
            }
           
        }

        public IActionResult CargarMunicipios(int id)
        {
            var cargarmunicipios = _generalesService.ListadoMunicipiosPorDepartamento(id);
            //ViewBag.muni_Id = new SelectList(cargarmunicipios.ToList(), "muni_Id", "muni_Descripcion");
            return Json(cargarmunicipios);
        }

        [HttpGet("/Empleados/Editar")]
        public IActionResult Edit(int? id)
        {
            try
            {
            var empleado = _generalesService.BuscarEmpleados(id);
            var empleado2 = _generalesService.findEmpleado(id);
            var emp = _mapper.Map<EmpleadoViewModel>(empleado2);
            foreach (var item in empleado)
            {
               
                var depa_Id = _generalesService.BuscarMunicipio(item.muni_Id);
                ViewBag.depa_Id = new SelectList(_generalesService.ListadoDepartamentos(out string error).ToList(), "depa_Id", "depa_Descripcion", depa_Id.depa_Id);
                ViewBag.muni_Id = new SelectList(_generalesService.ListadoMunicipiosPorDepartamento(depa_Id.depa_Id), "muni_Id", "muni_Descripcion", item.muni_Id);
                ViewBag.carg_Id = new SelectList(_generalesService.ListadoCargos(out string error2).ToList(), "carg_Id", "carg_Descripcion", item.carg_Id);
                ViewBag.estc_Id = new SelectList(_generalesService.ListadoEstadosCiviles(out string error1).ToList(), "estc_Id", "estc_Descripcion", item.estc_Id);
                ViewBag.sucu_Id = new SelectList(_generalesService.ListadoSucursales(out string error11).ToList(), "sucu_Id", "sucu_Descripcion", item.sucu_Id);

                ViewBag.empl_Id = item.empl_Id;
                ViewBag.empl_Nombre = item.empl_Nombre;
                ViewBag.empl_Apellido = item.empl_Apellido;
                
                ViewBag.empl_DireccionExacta = item.empl_DireccionExacta;
                ViewBag.empl_Telefono = item.empl_Telefono;
                ViewBag.empl_CorreoElectronico = item.empl_CorreoElectronico;
                emp.depa_Id = depa_Id.depa_Id;
                if (item.empl_Sexo == "M")
                {
                    ViewBag.empl_SexoM = "checked";
                }
                else
                {
                    ViewBag.empl_SexoF = "checked";
                }


                DateTime fechaNacimineto = Convert.ToDateTime(item.empl_FechaNacimiento);
                DateTime fechaContratacion = Convert.ToDateTime(item.empl_FechaContratacion);
                string FN = fechaNacimineto.ToString("yyyy-MM-dd");
                string FC = fechaContratacion.ToString("yyyy-MM-dd");

                ViewBag.empl_FechaNacimiento = FN;
                ViewBag.empl_FechaContratacion = FC;

            }

            return View(emp);
            }
            catch (Exception)
            {

                TempData["Empleados"] = "error";
                return RedirectToAction("Listado");
            }
           
        }

        [HttpPost("/Empleados/Editar")]
        public IActionResult Edit(EmpleadoViewModel empleado)
        {
            try
            {
            empleado.empl_UsuarioCreacion = Convert.ToInt32(HttpContext.Session.GetInt32("usur_Id"));
            empleado.empl_UsuarioModificacion = Convert.ToInt32(HttpContext.Session.GetInt32("usur_Id"));

            var result = 0;
            var emp = _mapper.Map<tbEmpleados>(empleado);
            result = _generalesService.EditarEmpleado(emp);

            if (result == 0)
            {
                TempData["Empleados"] = "error";
                var errores = _generalesService.BuscarEmpleados(emp.empl_Id);
                ModelState.AddModelError("", "Ocurrió un error al editar este registro");
                ViewBag.depa_Id = new SelectList(_generalesService.ListadoDepartamentos(out string error).ToList(), "depa_Id", "depa_Descripcion", empleado.depa_Id);
                ViewBag.muni_Id = new SelectList(_generalesService.ListadoMunicipiosPorDepartamento(empleado.depa_Id), "muni_Id", "muni_Descripcion", empleado.muni_Id);
                ViewBag.carg_Id = new SelectList(_generalesService.ListadoCargos(out string error2).ToList(), "carg_Id", "carg_Descripcion", empleado.carg_Id);
                ViewBag.estc_Id = new SelectList(_generalesService.ListadoEstadosCiviles(out string error1).ToList(), "estc_Id", "estc_Descripcion", empleado.estc_Id);
                ViewBag.sucu_Id = new SelectList(_generalesService.ListadoSucursales(out string error11).ToList(), "sucu_Id", "sucu_Descripcion", empleado.sucu_Id);

                ViewBag.empl_Id = emp.empl_Id;
                    ViewBag.empl_Nombre = emp.empl_Nombre;
                    ViewBag.empl_Apellido = emp.empl_Apellido;
                    ViewBag.empl_Sexo = emp.empl_Sexo;
                    ViewBag.empl_DireccionExacta = emp.empl_DireccionExacta;
                    ViewBag.empl_Telefono = emp.empl_Telefono;
                    ViewBag.empl_CorreoElectronico = emp.empl_CorreoElectronico;

                    DateTime fechaNacimineto = Convert.ToDateTime(emp.empl_FechaNacimiento);
                    DateTime fechaContratacion = Convert.ToDateTime(emp.empl_FechaContratacion);
                    string FN = fechaNacimineto.ToString("yyyy-MM-dd");
                    string FC = fechaContratacion.ToString("yyyy-MM-dd");


                if (emp.empl_Sexo == "M")
                {
                    ViewBag.empl_SexoM = "checked";
                }
                else
                {
                    ViewBag.empl_SexoF = "checked";
                }


                ViewBag.empl_FechaNacimiento = FN;
                    ViewBag.empl_FechaContratacion = FC;
                

                return View(empleado);
            }

            TempData["Empleados"] = "success";
            return RedirectToAction("Listado");
            }
            catch (Exception)
            {

                TempData["Empleados"] = "error";
                return RedirectToAction("Listado");
            }
            
        }


        [HttpGet("/Empleados/Detalles")]
        public IActionResult Details(int? id)
        {
            try
            {
            var empleado = _generalesService.BuscarEmpleados(id);
            foreach (var item in empleado)
            {
                    
                var muni_Id = _generalesService.BuscarMunicipio(item.muni_Id);
                var carg_Id = _generalesService.FindCargo(item.carg_Id);
                var depa_Id = _generalesService.findDepartameto(item.depa_Id);
                var estc_Id = _generalesService.BuscarEstadoCivil(item.estc_Id);
                var sucu_Id = _generalesService.BuscarSucursal(item.sucu_Id);

                ViewBag.depa_Id = depa_Id.depa_Descripcion;
                ViewBag.muni_Id = muni_Id.muni_Descripcion;
                ViewBag.carg_Id = carg_Id.carg_Descripcion;
                ViewBag.estc_Id = estc_Id.estc_Descripcion;
                ViewBag.sucu_Id = sucu_Id.sucu_Descripcion;

                ViewBag.empl_Id = item.empl_Id;
                ViewBag.empl_Nombre = item.empl_Nombre;
                ViewBag.empl_Apellido = item.empl_Apellido;
                ViewBag.empl_Sexo = item.empl_Sexo;
                ViewBag.empl_DireccionExacta = item.empl_DireccionExacta;
                ViewBag.empl_Telefono = item.empl_Telefono;
                ViewBag.empl_CorreoElectronico = item.empl_CorreoElectronico;

                DateTime fechaNacimineto = Convert.ToDateTime(item.empl_FechaNacimiento);
                DateTime fechaContratacion = Convert.ToDateTime(item.empl_FechaContratacion);
                string FN = fechaNacimineto.ToString("yyyy-MM-dd");
                string FC = fechaContratacion.ToString("yyyy-MM-dd");

                ViewBag.empl_FechaNacimiento = FN;
                ViewBag.empl_FechaContratacion = FC;

                var UsuarioCreacion = _generalesService.BuscarUsuario(item.empl_UsuarioCreacion);
                var nombreCreacion = _generalesService.BuscarEmpleados(UsuarioCreacion.empl_Id);
                foreach (var item2 in nombreCreacion)
                {
                ViewBag.UsuarioCreacion = item2.empl_Nombre + " " + item2.empl_Apellido;
                ViewBag.FechaCreacion = item.empl_FechaCreacion;
                }
                

                if (!string.IsNullOrEmpty(item.empl_UsuarioModificacion.ToString()))
                {
                    var UsuarioModificacion = _generalesService.BuscarUsuario(item.empl_UsuarioModificacion);
                    var nombreModificacion = _generalesService.BuscarEmpleados(UsuarioModificacion.empl_Id);
                    foreach (var item3 in nombreModificacion)
                    {
                    ViewBag.UsuarioModificacion = item3.empl_Nombre + " " + item3.empl_Apellido;
                    ViewBag.FechaModificacion = item.empl_FechaModificacion;
                    }
                    
                }
            }
            return View();
            }
            catch (Exception)
            {

                TempData["Empleados"] = "error";
                return RedirectToAction("Listado");
            }
            
        }
        [HttpPost("/Empleados/Eliminar")]
        public IActionResult Delete(EmpleadoViewModel empleado)
        {
            try
            {
            var result = 0;
            var emp = _mapper.Map<tbEmpleados>(empleado);
            result = _generalesService.EliminarEmpleado(emp);

            if (result == 0)
            {
                TempData["Empleados"] = "error";
                return View();
            }
            TempData["Empleados"] = "success";
            return RedirectToAction("Listado");
            }
            catch (Exception)
            {
                TempData["Empleados"] = "error";
                return View();
            }
            

        }

    }
}
