﻿using Microsoft.Extensions.DependencyInjection;
using SalonDeBellezaCarlitos.BusinessLogic.Services;
using SalonDeBellezaCarlitos.DataAccess.Repository;
using SalonDeBellezaCarlitos.DataAccess;

using System;
using System.Collections.Generic;
using System.Text;

namespace SalonDeBellezaCarlitos.BusinessLogic
{
    public static class ServiceConfiguration
    {

        public static void DataAccess(this IServiceCollection service, string connectionString) 
        {
            service.AddScoped<CargoRepository>();
            service.AddScoped<EmpleadoRepository>();
            service.AddScoped<UsuarioRepository>();
            service.AddScoped<ServicioRepository>();
            service.AddScoped<CategoriaRepository>();
            service.AddScoped<DepartametoRepository>();
            service.AddScoped<MunicipioRepository>();
            service.AddScoped<ClienteRepository>();
            service.AddScoped<EstadoCivilRepository>();
            service.AddScoped<SucursalesRepository>();
            service.AddScoped<ProductoRepository>();
            service.AddScoped<ReservacionRepository>();
            service.AddScoped<FacturasRepository>();
            service.AddScoped<MetodopagoRepositpory>();
            service.AddScoped<ProveedorRepository>();


            SalonCarlitosContext.BuildConnectionString(connectionString);

        }

        public static void BusinessLogic(this IServiceCollection service) 
        {
            service.AddScoped<GeneralesServices>();
        }

    }

}
