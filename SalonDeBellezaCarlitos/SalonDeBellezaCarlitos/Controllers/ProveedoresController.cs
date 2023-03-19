using AutoMapper;
using Dapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;
using SalonDeBellezaCarlitos.BusinessLogic.Services;
using SalonDeBellezaCarlitos.DataAccess;
using SalonDeBellezaCarlitos.DataAccess.Repository;
using SalonDeBellezaCarlitos.Entities.Entities;
using SalonDeBellezaCarlitos.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;

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
            return View();
        }

        [HttpPost("/Proveedores/Crear")]
        public ActionResult Create(ProveedorViewModel proveedor)
        {
            var result = 0;
            var prov = _mapper.Map<tbProveedores>(proveedor);
            result = _generalesService.InsertarProveedor(prov);

            if (result == 0)
            {
                ModelState.AddModelError("", "Ocurrió un error al Crear este registro");
                return View();
            }
            return RedirectToAction("Listado");
        }

        public IEnumerable<tbProveedores> BuscarProveedor(int? id)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@prov_Id", id, DbType.String, ParameterDirection.Input);
            return db.Query<tbProveedores>(ScriptsDataBase.UDP_Buscar_Proveedores, parametros, commandType: CommandType.StoredProcedure);

        }

    }
}
