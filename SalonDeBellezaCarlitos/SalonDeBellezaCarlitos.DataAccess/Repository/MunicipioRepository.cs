using Dapper;
using Microsoft.Data.SqlClient;
using SalonDeBellezaCarlitos.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SalonDeBellezaCarlitos.DataAccess.Repository
{
    public class MunicipioRepository : IRepository<tbMunicipios>
    {
        public int Delete(tbMunicipios item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@muni_Id", item.muni_Id, DbType.String, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Borrar_Municipios, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public tbMunicipios find(int? id)
        {
            using var db = new SalonCarlitosContext();
            var listado = db.tbMunicipios.Find(id);
            return listado;
        }

        public int Insert(tbMunicipios item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();
            
            parametros.Add("@muni_Descripcion", item.muni_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@muni_Codigo", item.muni_Codigo, DbType.String, ParameterDirection.Input);
            parametros.Add("@depa_Id", item.depa_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@muni_UsuarioCreacion", item.muni_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Insertar_Municipios, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public IEnumerable<tbMunicipios> List()
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            return db.Query<tbMunicipios>(ScriptsDataBase.UDP_Listado_Municipios, null, commandType: CommandType.StoredProcedure);
        }
        public IEnumerable<VW_tbMunicipios_View> ListView()
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            return db.Query<VW_tbMunicipios_View>(ScriptsDataBase.UDP_Listado_Municipios, null, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<VW_tbMunicipios_View> BuscarView(int? id)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);

            var parametros = new DynamicParameters();
            parametros.Add("@muni_Id", id, DbType.Int32, ParameterDirection.Input);

            return db.Query<VW_tbMunicipios_View>(ScriptsDataBase.UDP_Buscar_Municipios, parametros, commandType: CommandType.StoredProcedure);
        }

        public int Update(tbMunicipios item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@muni_Id", item.muni_Id, DbType.String, ParameterDirection.Input);
            parametros.Add("@muni_Descripcion", item.muni_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@muni_Codigo", item.muni_Codigo, DbType.String, ParameterDirection.Input);
            parametros.Add("@depa_Id", item.depa_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@muni_UsuarioModificacion", item.muni_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Editar_Municipios, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public IEnumerable<tbMunicipios> MunicipiosxDepartamento(int? id)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@depa_Id", id, DbType.String, ParameterDirection.Input);
            return db.Query<tbMunicipios>(ScriptsDataBase.UDP_Listado_MunicipiosXDepartamento, parametros, commandType: CommandType.StoredProcedure);
        }

    }
}
