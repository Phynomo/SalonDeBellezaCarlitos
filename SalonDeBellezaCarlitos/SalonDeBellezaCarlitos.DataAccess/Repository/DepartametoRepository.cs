using Dapper;
using Microsoft.Data.SqlClient;
using SalonDeBellezaCarlitos.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SalonDeBellezaCarlitos.DataAccess.Repository
{
    public class DepartametoRepository : IRepository<tbDepartamentos>
    {
        public int Delete(tbDepartamentos item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@depa_Id", item.depa_Id, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Borrar_Departamentos, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public tbDepartamentos find(int? id)
        {
            using var db = new SalonCarlitosContext();
            var listado = db.tbDepartamentos.Find(id);
            return listado;
        }

        public int Insert(tbDepartamentos item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@depa_Codigo", item.depa_Codigo, DbType.String, ParameterDirection.Input);
            parametros.Add("@depa_Descripcion", item.depa_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@depa_UsuarioCreacion", item.depa_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Insertar_Departamentos, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public IEnumerable<tbDepartamentos> List()
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            return db.Query<tbDepartamentos>(ScriptsDataBase.UDP_Listado_Departamentos, null, commandType: CommandType.StoredProcedure);
        }

        public int Update(tbDepartamentos item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@depa_Id", item.depa_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@depa_Descripcion", item.depa_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@depa_Codigo", item.depa_Codigo, DbType.String, ParameterDirection.Input);
            parametros.Add("@depa_UsuarioModificacion", item.depa_UsuarioModificacion, DbType.String, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Editar_Departamentos, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }
        public IEnumerable<tbDepartamentos> BuscarDepartamento(int? id)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@depa_Id", id, DbType.Int32, ParameterDirection.Input);
            return db.Query<tbDepartamentos>(ScriptsDataBase.UDP_Buscar_Departamentos, parametros, commandType: CommandType.StoredProcedure);

        }
    }
}
