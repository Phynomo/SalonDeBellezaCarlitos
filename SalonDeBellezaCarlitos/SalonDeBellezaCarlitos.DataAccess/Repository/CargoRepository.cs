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
    public class CargoRepository : IRepository<tbCargos>
    {
        public int Delete(tbCargos item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@carg_Id", item.carg_Id, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Borrar_Cargos, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public tbCargos find(int? id)
        {
            using var db = new SalonCarlitosContext();
            var listado = db.tbCargos.Find(id);
            return listado;
        }

        public IEnumerable<tbCargos> buscar(int? id)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@carg_Id", id, DbType.Int32, ParameterDirection.Input);

            return db.Query<tbCargos>(ScriptsDataBase.UDP_Buscar_Cargos, parametros, commandType: CommandType.StoredProcedure);

        }


        public int Insert(tbCargos item)
        {

            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@carg_Descripcion", item.carg_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@carg_UsuarioCreacion", item.carg_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            
            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Insertar_Cargos, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public IEnumerable<tbCargos> List()
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            return db.Query<tbCargos>(ScriptsDataBase.UDP_Listado_Cargos, null, commandType: CommandType.StoredProcedure);

        }

        public int Update(tbCargos item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@carg_Id", item.carg_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@carg_Descripcion", item.carg_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@carg_UsuarioModificacion", item.carg_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Editar_Cargos, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }
    }
}
