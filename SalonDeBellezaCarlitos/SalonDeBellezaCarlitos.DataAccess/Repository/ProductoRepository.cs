using Dapper;
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
            throw new NotImplementedException();
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
            parametros.Add("@prod_UsuarioCreacion", 1, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Insertar_Categorias, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public IEnumerable<tbProductos> List()
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            return db.Query<tbProductos>(ScriptsDataBase.UDP_Listado_Productos, null, commandType: CommandType.StoredProcedure);
        }

        public int Update(tbProductos item)
        {
            throw new NotImplementedException();
        }
    }
}
