using AutoMapper;
using SalonDeBellezaCarlitos.Entities.Entities;
using SalonDeBellezaCarlitos.WebUI.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SalonDeBellezaCarlitos.WebUI.Extensions
{
    public class MappingProfileExtensions: Profile
    {
        public MappingProfileExtensions()
        {
            CreateMap<CargoViewModel, tbCargos>().ReverseMap();
            CreateMap<EmpleadoViewModel, tbEmpleados>().ReverseMap();
            CreateMap<UsuariosViewModel, tbUsuarios>().ReverseMap();
            CreateMap<ServicioViewModel, tbServicios>().ReverseMap();
            CreateMap<CategoriaViewModel, tbCategorias>().ReverseMap();
            CreateMap<DepartamentoViewModel, tbDepartamentos>().ReverseMap();
            CreateMap<MunicipioViewModel, tbMunicipios>().ReverseMap();
            CreateMap<ClienteViewModel, tbClientes>().ReverseMap();
            CreateMap<EstadoCivilViewModel, tbEstadosCiviles>().ReverseMap();
            CreateMap<SucursalViewModel, tbSucursales>().ReverseMap();
            CreateMap<ProductoViewModel, tbProductos>().ReverseMap();
            CreateMap<ReservacionesViewModel, tbReservaciones>().ReverseMap();
            CreateMap<FacturasViewModel, tbFacturas>().ReverseMap();
            CreateMap<MetodoPagoViewModel, tbMetodoPago>().ReverseMap();
            CreateMap<ProveedorViewModel, tbProveedores>().ReverseMap();


            CreateMap<VWMunicipiosViewModel, VW_tbMunicipios_View>().ReverseMap();
        }
    }
}