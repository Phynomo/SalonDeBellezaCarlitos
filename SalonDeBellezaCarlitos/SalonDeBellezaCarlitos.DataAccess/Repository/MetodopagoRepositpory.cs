using Dapper;
using Microsoft.Data.SqlClient;
using SalonDeBellezaCarlitos.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SalonDeBellezaCarlitos.DataAccess.Repository
{
    public class MetodopagoRepositpory : IRepository<tbMetodoPago>
    {
        public int Delete(tbMetodoPago item)
        {
            throw new NotImplementedException();
        }

        public tbMetodoPago find(int? id)
        {
            using var db = new SalonCarlitosContext();
            var listado = db.tbMetodoPago.Find(id);
            return listado;
        }

        public int Insert(tbMetodoPago item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@metp_Descripcion", item.metp_Descripcion, DbType.String, ParameterDirection.Input);
            parametros.Add("@metp_UsuarioCreacion", 1, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Insertar_MetodoPago, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public IEnumerable<tbMetodoPago> List()
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            return db.Query<tbMetodoPago>(ScriptsDataBase.UDP_Listado_MetodoPago, null, commandType: CommandType.StoredProcedure);
        }

        public int Update(tbMetodoPago item)
        {
            throw new NotImplementedException();
        }
    }
}
