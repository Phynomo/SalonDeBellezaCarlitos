using Dapper;
using Microsoft.Data.SqlClient;
using SalonDeBellezaCarlitos.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SalonDeBellezaCarlitos.DataAccess.Repository
{
    public class EstadoCivilRepository : IRepository<tbEstadosCiviles>
    {
        public int Delete(tbEstadosCiviles item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@estc_Id", item.estc_Id, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Borrar_EstadosCiviles, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public tbEstadosCiviles find(int? id)
        {
            using var db = new SalonCarlitosContext();
            var listado = db.tbEstadosCiviles.Find(id);
            return listado;
        }

        public int Insert(tbEstadosCiviles item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@estc_Descripcion", item.estc_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@estc_UsuarioCreacion", 1, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Insertar_EstadosCiviles, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public IEnumerable<tbEstadosCiviles> List()
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            return db.Query<tbEstadosCiviles>(ScriptsDataBase.UDP_Listado_EstadosCiviles, null, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<tbEstadosCiviles> Buscar(int? id)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@estc_Id", id, DbType.Int32, ParameterDirection.Input);
            return db.Query<tbEstadosCiviles>(ScriptsDataBase.UDP_Buscar_EstadosCiviles, parametros, commandType: CommandType.StoredProcedure);
        }

        public int Update(tbEstadosCiviles item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@estc_Id", item.estc_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@estc_Descripcion", item.estc_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@estc_UsuarioModificacion", item.estc_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Editar_EstadosCiviles, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }
    }
}
