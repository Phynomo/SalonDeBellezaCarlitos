﻿using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SalonDeBellezaCarlitos.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SalonDeBellezaCarlitos.DataAccess.Repository
{
    public class ServicioRepository : IRepository<tbServicios>
    {
        public int Delete(tbServicios item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@serv_Id", item.serv_Id, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Borrar_Servicios, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public tbServicios find(int? id)
        {
            using var db = new SalonCarlitosContext();
            var listado = db.tbServicios.Find(id);
            return listado;
        }

        public int Insert(tbServicios item)
        {
            //using var db = new SalonCarlitosContext();
            //db.tbServicios.Add(item);
            //return item.serv_Id;
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@serv_Nombre", item.serv_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@serv_Descripcion", item.serv_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@serv_Precio", item.serv_Precio, DbType.String, ParameterDirection.Input);
            parametros.Add("@serv_UsuarioCreacion", item.serv_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Insertar_Servicios, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public IEnumerable<tbServicios> List()
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            return db.Query<tbServicios>(ScriptsDataBase.UDP_Listado_Servicios, null, commandType: CommandType.StoredProcedure);
        }

        public int Update(tbServicios item)
        {
            //using var db = new SalonCarlitosContext();
            //db.Entry(item).State = EntityState.Modified;
            //db.SaveChanges();
            //return item.serv_Id;
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@serv_Id", item.serv_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@serv_Nombre", item.serv_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@serv_Descripcion", item.serv_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@serv_Precio", item.serv_Precio, DbType.String, ParameterDirection.Input);
            parametros.Add("@serv_UsuarioModificacion", item.serv_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Editar_Servicios, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public IEnumerable<tbServicios> BuscarServicio(int? id)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@serv_Id", id, DbType.Int32, ParameterDirection.Input);
            return db.Query<tbServicios>(ScriptsDataBase.UDP_Buscar_Servicios, parametros, commandType: CommandType.StoredProcedure);

        }
    }
}
