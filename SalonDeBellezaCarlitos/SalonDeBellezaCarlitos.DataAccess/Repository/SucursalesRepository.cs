using Dapper;
using Microsoft.Data.SqlClient;
using SalonDeBellezaCarlitos.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SalonDeBellezaCarlitos.DataAccess.Repository
{
    public class SucursalesRepository : IRepository<tbSucursales>
    {
        public int Delete(tbSucursales item)
        {
            throw new NotImplementedException();
        }

        public tbSucursales find(int? id)
        {
            using var db = new SalonCarlitosContext();
            var listado = db.tbSucursales.Find(id);
            return listado;
        }

        public int Insert(tbSucursales item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@sucu_Decripcion", item.sucu_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@muni_Id", item.muni_Id, DbType.String, ParameterDirection.Input);
            parametros.Add("@sucu_DireccionExacta", item.sucu_DireccionExacta, DbType.String, ParameterDirection.Input);
            parametros.Add("@sucu_UsuarioCreacion", 1, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Insertar_Sucursales, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public IEnumerable<tbSucursales> List()
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            return db.Query<tbSucursales>(ScriptsDataBase.UDP_Listado_Sucursales, null, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<VW_tbSucursales_View> ListView()
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            return db.Query<VW_tbSucursales_View>(ScriptsDataBase.UDP_Listado_Sucursales, null, commandType: CommandType.StoredProcedure);
        }

        public int Update(tbSucursales item)
        {
            throw new NotImplementedException();
        }
    } 
}
