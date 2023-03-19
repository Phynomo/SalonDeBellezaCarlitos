using Dapper;
using Microsoft.Data.SqlClient;
using SalonDeBellezaCarlitos.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SalonDeBellezaCarlitos.DataAccess.Repository
{
    public class ProveedorRepository : IRepository<tbProveedores>
    {
        public int Delete(tbProveedores item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@prov_Id", item.prov_Id, DbType.Int32, ParameterDirection.Input);
            return db.QueryFirst<int>(ScriptsDataBase.UDP_Borrar_Proveedores, parametros, commandType: CommandType.StoredProcedure);
        }

        public tbProveedores find(int? id)
        {
            using var db = new SalonCarlitosContext();
            var listado = db.tbProveedores.Find(id);
            return listado;
        }

        public IEnumerable<tbProveedores> BuscarProveedor(int? id)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@prov_Id", id, DbType.Int32, ParameterDirection.Input);
            return db.Query<tbProveedores>(ScriptsDataBase.UDP_Buscar_Proveedores, parametros, commandType: CommandType.StoredProcedure);
        }


        public int Insert(tbProveedores item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@prov_NombreEmpresa", item.prov_NombreEmpresa, DbType.String, ParameterDirection.Input);
            parametros.Add("@prov_NombreContacto", item.prov_NombreContacto, DbType.String, ParameterDirection.Input);
            parametros.Add("@muni_Id", item.muni_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@prov_DireccionExacta", item.prov_DireccionExacta, DbType.String, ParameterDirection.Input);
            parametros.Add("@prov_Telefono", item.prov_Telefono, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@prov_UsuarioCreacion", 1, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Insertar_Proveedores, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public IEnumerable<tbProveedores> List()
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            return db.Query<tbProveedores>(ScriptsDataBase.UDP_Listado_Proveedores, null, commandType: CommandType.StoredProcedure);
        }

        public int Update(tbProveedores item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@prov_Id", item.prov_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@prov_NombreEmpresa", item.prov_NombreEmpresa, DbType.String, ParameterDirection.Input);
            parametros.Add("@prov_NombreContacto", item.prov_NombreContacto, DbType.String, ParameterDirection.Input);
            parametros.Add("@muni_Id", item.muni_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@prov_DireccionExacta", item.prov_DireccionExacta, DbType.String, ParameterDirection.Input);
            parametros.Add("@prov_Telefono", item.prov_Telefono, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@prov_UsuarioModificacion", 1, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Editar_Proveedores, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
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
