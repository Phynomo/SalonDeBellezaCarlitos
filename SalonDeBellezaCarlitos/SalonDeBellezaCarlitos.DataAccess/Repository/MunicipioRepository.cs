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
            throw new NotImplementedException();
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

            parametros.Add("@muni_Id", item.muni_Id, DbType.String, ParameterDirection.Input);
            parametros.Add("@muni_Descripcion", item.muni_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@muni_Codigo", item.muni_Codigo, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@depa_Id", item.depa_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@muni_UsuarioCreacion", 1, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Insertar_Municipios, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public IEnumerable<tbMunicipios> List()
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            return db.Query<tbMunicipios>(ScriptsDataBase.UDP_Listado_Municipios, null, commandType: CommandType.StoredProcedure);
        }

        public int Update(tbMunicipios item)
        {
            throw new NotImplementedException();
        }
    }
}
