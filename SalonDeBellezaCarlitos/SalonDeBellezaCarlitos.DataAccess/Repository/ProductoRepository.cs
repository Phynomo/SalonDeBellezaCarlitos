﻿    using Dapper;
using Microsoft.Data.SqlClient;
using SalonDeBellezaCarlitos.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SalonDeBellezaCarlitos.DataAccess.Repository
{
    public class ProductoRepository : IRepository<tbProductos>
    {
        public int Delete(tbProductos item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@prod_Id", item.prod_Id, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Borrar_Productos, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public tbProductos find(int? id)
        {
            using var db = new SalonCarlitosContext();
            var listado = db.tbProductos.Find(id);
            return listado;
        }

        public int Insert(tbProductos item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@prod_Nombre", item.prod_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@prod_Precio", item.prod_Precio, DbType.String, ParameterDirection.Input);
            parametros.Add("@cate_Id", item.cate_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@prod_Stock", item.prod_Stock, DbType.String, ParameterDirection.Input);
            parametros.Add("@prov_Id", item.prov_id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@prod_UsuarioCreacion", item.prod_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Insertar_Productos, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public IEnumerable<tbProductos> List()
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            return db.Query<tbProductos>(ScriptsDataBase.UDP_Listado_Productos, null, commandType: CommandType.StoredProcedure);
        }
        public IEnumerable<VW_tbProductos_View> ListView()
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            return db.Query<VW_tbProductos_View>(ScriptsDataBase.UDP_Listado_Productos, null, commandType: CommandType.StoredProcedure);
        }

        public int Update(tbProductos item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);

            var parametros = new DynamicParameters();

            parametros.Add("@prod_Id", item.prod_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@prod_Nombre", item.prod_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@prod_Precio", item.prod_Precio, DbType.String, ParameterDirection.Input);
            parametros.Add("@cate_Id", item.cate_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@prod_Stock", item.prod_Stock, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@prov_Id", item.prov_id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@prod_UsuarioModificacion", item.prod_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Editar_Productos, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public IEnumerable<tbProductos> BuscarProducto(int? id)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@prod_Id", id, DbType.String, ParameterDirection.Input);
            return db.Query<tbProductos>(ScriptsDataBase.UDP_Buscar_Productos, parametros, commandType: CommandType.StoredProcedure);

        }
    }
}
