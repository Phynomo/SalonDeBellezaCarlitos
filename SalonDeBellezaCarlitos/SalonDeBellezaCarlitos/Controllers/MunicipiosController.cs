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
    public class MunicipiosController : Controller
    {
        private readonly GeneralesServices _generalesService;

        private readonly IMapper _mapper;

        public MunicipiosController(GeneralesServices generalesServices, IMapper mapper)
        {
            _generalesService = generalesServices;
            _mapper = mapper;
        }


        [HttpGet("/Municipios/Listado")]
        public IActionResult Index()
        {

            ViewBag.Toast = TempData["Municipios"] as string;

            ViewBag.depa_Id = new SelectList(_generalesService.ListadoDepartamentos(out string error).ToList(), "depa_Id", "depa_Descripcion");
            var listado = _generalesService.ListadoMunicipios(out string error1);
            var listadoMapeado = _mapper.Map<IEnumerable<VWMunicipiosViewModel>>(listado);

            if (!string.IsNullOrEmpty(error))
            {
                ModelState.AddModelError("", error);
            }

            return View(listadoMapeado);
        }
        [HttpGet("/Municipios/Crear")]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost("/Municipios/Crear")]
        public ActionResult Create(MunicipioViewModel municipio)
        {
            var result = 0;
            municipio.muni_UsuarioCreacion = Convert.ToInt32(HttpContext.Session.GetString("usur_Id"));
            municipio.muni_UsuarioModificacion = Convert.ToInt32(HttpContext.Session.GetString("usur_Id"));

            var muni = _mapper.Map<tbMunicipios>(municipio);
            result = _generalesService.InsertarMunicipio(muni);

            if (result == 0)
            {
                TempData["Municipios"] = "error";
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                return RedirectToAction("Listado");
            }
            TempData["Municipios"] = "success";
            return RedirectToAction("Listado");
        }

        [HttpPost("/Municipios/Editar")]
        public ActionResult Edit(MunicipioViewModel municipio)
        {
            var result = 0;
            municipio.muni_UsuarioCreacion = Convert.ToInt32(HttpContext.Session.GetString("usur_Id"));
            municipio.muni_UsuarioModificacion = Convert.ToInt32(HttpContext.Session.GetString("usur_Id"));

            var muni = _mapper.Map<tbMunicipios>(municipio);
            result = _generalesService.EditarMunicipio(muni);

            if (result == 0)
            {
                TempData["Municipios"] = "error";
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                return RedirectToAction("Listado");
            }
            TempData["Municipios"] = "sucess";
            return RedirectToAction("Listado");
        }

        [HttpPost("/Municipios/Eliminar")]
        public ActionResult Delete(MunicipioViewModel municipio)
        {
            var result = 0;
            var muni = _mapper.Map<tbMunicipios>(municipio);
            result = _generalesService.EliminarMunicipio(muni);

            if (result == 0)
            {
                TempData["Municipios"] = "error";
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                return RedirectToAction("Listado");
            }
            TempData["Municipios"] = "success";
            return RedirectToAction("Listado");
        }

        [HttpGet("/Municipios/Detalles")]
        public IActionResult Details(int? id)
        {

            ViewBag.depa_Id = new SelectList(_generalesService.ListadoDepartamentos(out string error).ToList(), "depa_Id", "depa_Descripcion");

            var listado = _generalesService.BuscarMunicipioView(id);
            var listadoMapeado = _mapper.Map<IEnumerable<VWMunicipiosViewModel>>(listado);
            foreach (var item in listadoMapeado)
            {
                var UsuarioCreacion = _generalesService.BuscarUsuario(item.muni_UsuarioCreacion);
                var nombreCreacion = _generalesService.findEmpleado(UsuarioCreacion.empl_Id);
                ViewBag.UsuarioCreacion = nombreCreacion.empl_Nombre + " " + nombreCreacion.empl_Apellido;

                if (!string.IsNullOrEmpty(item.muni_UsuarioModificacion.ToString()))
                {
                    var UsuarioModificacion = _generalesService.BuscarUsuario(item.muni_UsuarioModificacion);
                    var nombreModificacion = _generalesService.findEmpleado(UsuarioModificacion.empl_Id);
                    ViewBag.UsuarioModificacion = nombreModificacion.empl_Nombre + " " + nombreModificacion.empl_Apellido;
                }
            }


            return View(listadoMapeado);
        }

    }
}
