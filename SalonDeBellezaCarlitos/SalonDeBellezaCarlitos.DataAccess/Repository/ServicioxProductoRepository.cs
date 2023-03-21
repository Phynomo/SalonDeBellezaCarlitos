    using Dapper;
using Microsoft.Data.SqlClient;
using SalonDeBellezaCarlitos.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SalonDeBellezaCarlitos.DataAccess.Repository
{
    public class ServicioxProductoRepository : IRepository<tbProductosXServicio>
    {
        public int Delete(tbProductosXServicio item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@spro_Id", item.spro_Id, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Borrar_ServiciosXProducto, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public tbProductosXServicio find(int? id)
        {
            throw new NotImplementedException();
        }

        public int Insert(tbProductosXServicio item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@serv_Id", item.serv_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@prod_Id", item.prod_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@spro_UsuarioCreacion", 1, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Insertar_ServiciosXProducto, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public IEnumerable<tbProductosXServicio> List()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<VW_tbProductosxServicio_View> ListView()
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            return db.Query<VW_tbProductosxServicio_View>(ScriptsDataBase.UDP_Listado_ServiciosXProducto, null, commandType: CommandType.StoredProcedure);
        }

        public int Update(tbProductosXServicio item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@spro_Id", item.spro_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@serv_Id", item.serv_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@prod_Id", item.prod_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@spro_UsuarioModificacion", item.spro_UsuarioModificacion, DbType.Int32, ParameterDirection.Input); 
            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Editar_ServiciosXProducto, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }
        public IEnumerable<tbProductosXServicio> BuscarServicioXProducto(int? id)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@spro_Id", id, DbType.Int32, ParameterDirection.Input);
            return db.Query<tbProductosXServicio>(ScriptsDataBase.UDP_Borrar_ServiciosXProducto, parametros, commandType: CommandType.StoredProcedure);
        }
    }
}
