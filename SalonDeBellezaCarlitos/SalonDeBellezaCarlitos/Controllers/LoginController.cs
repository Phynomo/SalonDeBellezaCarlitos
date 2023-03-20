using AutoMapper;
using Microsoft.AspNetCore.Http;
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
    public class LoginController : Controller
    {

        private readonly GeneralesServices _generalesService;

        private readonly IMapper _mapper;

        public LoginController(GeneralesServices generalesServices, IMapper mapper)
        {
            _generalesService = generalesServices;
            _mapper = mapper;
        }


        [HttpGet("Login/Index")]
        public IActionResult Index()
        {

            HttpContext.Session.SetString("Nombre", "");
            HttpContext.Session.SetString("Cargo", "");
            HttpContext.Session.SetString("Sucursal", "");
            HttpContext.Session.SetInt32("usur_Id", 0);

            ViewBag.Toast = TempData["login"] as string;
            return View();
        }

        [HttpPost("Login/Index")]
        public IActionResult Index(UsuariosViewModel Usuario)
        {
            var usu = _mapper.Map<tbUsuarios>(Usuario);
            var result = _generalesService.Login(usu);

            if (result.Count() == 0)
            {
                TempData["login"] = "error";
                return RedirectToAction("Index");
            }

            foreach (var item in result)
            {
            HttpContext.Session.SetString("Nombre", item.empl_NombreCompleto);
            HttpContext.Session.SetString("Cargo", item.carg_Descripcion);
            HttpContext.Session.SetString("Sucursal", item.sucu_Id.ToString());
            HttpContext.Session.SetInt32("usur_Id", item.usur_Id);
            }

            return RedirectToAction("Index", "Home");
        }

        [HttpPost("Login/Recuperar")]
        public IActionResult Recuperar(UsuariosViewModel Usuario)
        {
            var usu = _mapper.Map<tbUsuarios>(Usuario);
            var result = _generalesService.RecuperarUsuario(usu);

            if (result == 0)
            {
                TempData["login"] = "recuperacionfallida";
                return RedirectToAction("Index");
            }
            TempData["login"] = "recuperacionExitosa";
            return RedirectToAction("Index");
        }


    }
}
