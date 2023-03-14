﻿using Dapper;
using Microsoft.Data.SqlClient;
using SalonDeBellezaCarlitos.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Globalization;

namespace SalonDeBellezaCarlitos.DataAccess.Repository
{
    public class EmpleadoRepository : IRepository<tbEmpleados>
    {
        public int Delete(tbEmpleados item)
        {
            throw new NotImplementedException();
        }

        public tbEmpleados find(int? id)
        {
            using var db = new SalonCarlitosContext();
            var listado = db.tbEmpleados.Find(id);
            return listado;
        }

        public int Insert(tbEmpleados item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);

            var parametros = new DynamicParameters();

            string fechaNacimientostring = item.empl_FechaNacimiento.ToString().Replace("/", "-").Replace("00:00:00", "");
            string fechaContratacionstring = item.empl_FechaContratacion.ToString().Replace("/", "-").Replace("00:00:00", "");
            DateTime fechaNacimineto = Convert.ToDateTime(fechaNacimientostring);
            DateTime fechaContratacion = Convert.ToDateTime(fechaContratacionstring);
            string FN = fechaNacimineto.ToString("yyyy-MM-dd");
            string FC = fechaContratacion.ToString("yyyy-MM-dd");


            parametros.Add("@empl_Nombre", item.empl_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@empl_Apellido", item.empl_Apellido, DbType.String, ParameterDirection.Input);
            parametros.Add("@empl_Sexo", item.empl_Sexo, DbType.String, ParameterDirection.Input);
            parametros.Add("@muni_Id", item.muni_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@empl_DireccionExacta", item.empl_DireccionExacta, DbType.String, ParameterDirection.Input);
            parametros.Add("@estc_Id", item.estc_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@empl_Telefono", item.empl_Telefono, DbType.String, ParameterDirection.Input);
            parametros.Add("@empl_CorreoElectronico", item.empl_CorreoElectronico, DbType.String, ParameterDirection.Input);
            parametros.Add("@empl_FechaNacimiento", FN, DbType.String, ParameterDirection.Input);
            parametros.Add("@empl_FechaContratacion", FC.ToString(), DbType.String, ParameterDirection.Input);
            parametros.Add("@carg_Id", item.carg_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@empl_UsuarioCreacion", 1, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Insertar_Empleados, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public IEnumerable<tbEmpleados> List()
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            return db.Query<tbEmpleados>(ScriptsDataBase.UDP_Listado_Empleados, null, commandType: CommandType.StoredProcedure);

        }

        public int Update(tbEmpleados item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbEmpleados> BuscarEmpleado(int? id)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@empl_Id", id, DbType.String, ParameterDirection.Input);
            return db.Query<tbEmpleados>(ScriptsDataBase.UDP_Buscar_Empleados, parametros, commandType: CommandType.StoredProcedure);

        }


    }
}
