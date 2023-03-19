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
    public class UsuarioController : Controller
    {
        private readonly GeneralesServices _generalesService;

        private readonly IMapper _mapper;


        public UsuarioController(GeneralesServices generalesServices, IMapper mapper)
        {
            _generalesService = generalesServices;
            _mapper = mapper;
        }


        [HttpGet("/Usuario/Listado")]
        public IActionResult Index()
        {

            ViewBag.empl_Id = new SelectList(_generalesService.ListadoEmpleados(out string error1).ToList(), "empl_Id", "empl_Nombre");


            var listado = _generalesService.ListadoUsuariosView(out string error);

            var listadoMapeado = _mapper.Map<IEnumerable<VWUsuariosViewModel>>(listado);

            if (!string.IsNullOrEmpty(error))
            {
                ModelState.AddModelError("", error);
            }

            return View(listadoMapeado);
        }

        [HttpPost("/Usuario/Crear")]
        public ActionResult Create(UsuariosViewModel Usuario)
        {
            var result = 0;
            var usu = _mapper.Map<tbUsuarios>(Usuario);
            result = _generalesService.InsertarUsuario(usu);

            if (result == 0)
            {
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                return RedirectToAction("Listado");
            }
            return RedirectToAction("Listado");
        }

        [HttpPost("/Usuario/Editar")]
        public ActionResult Edit(UsuariosViewModel Usuario)
        {
            var result = 0;
            var usu = _mapper.Map<tbUsuarios>(Usuario);
            result = _generalesService.EditarUsuario(usu);

            if (result == 0)
            {
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                return RedirectToAction("Listado");
            }
            return RedirectToAction("Listado");
        }


        [HttpPost("/Usuario/Eliminar")]
        public IActionResult Delete(UsuariosViewModel Usuario)
        {
            var result = 0;
            var usu = _mapper.Map<tbUsuarios>(Usuario);
            result = _generalesService.EliminarUsuario(usu);

            if (result == 0)
            {
                ModelState.AddModelError("", "Ocurrió un error al eliminar este registro");
                return RedirectToAction("Listado");
            }
            return RedirectToAction("Listado");

        }

        [HttpGet("/Usuario/Detalles")]
        public IActionResult Details(int? id)
        {
            try
            {
                var Usuario = _generalesService.BuscarUsuarioView(id);
                var UsuarioMapeado = _mapper.Map<IEnumerable<VWUsuariosViewModel>>(Usuario);

                #region Cargando datos...
                if (UsuarioMapeado == null)
                {
                    Convert.ToInt32("a");
                }

                foreach (var item in UsuarioMapeado)
                {

                    var UsuarioCreacion = _generalesService.BuscarUsuario(item.usur_UsuarioCreacion);
                    var nombreCreacion = _generalesService.BuscarEmpleados(UsuarioCreacion.empl_Id);
                    foreach (var item2 in nombreCreacion)
                    {
                        ViewBag.UsuarioCreacion = item2.empl_Nombre + " " + item2.empl_Apellido;
                    }


                    if (!string.IsNullOrEmpty(item.usur_UsuarioModificacion.ToString()))
                    {
                        var UsuarioModificacion = _generalesService.BuscarUsuario(item.usur_UsuarioModificacion);
                        var nombreModificacion = _generalesService.BuscarEmpleados(UsuarioModificacion.empl_Id);
                        foreach (var item2 in nombreModificacion)
                        {
                            ViewBag.UsuarioModificacion = item2.empl_Nombre + " " + item2.empl_Apellido;
                        }

                    }
                }


                #endregion

                return View(UsuarioMapeado);
            }
            catch
            {

                TempData["Usuario"] = "errorC";
                return RedirectToAction("Listado");
            }

        }


    }
}
