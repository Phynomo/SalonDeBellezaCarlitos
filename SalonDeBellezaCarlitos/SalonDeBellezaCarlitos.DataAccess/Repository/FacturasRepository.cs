using Dapper;
using Microsoft.Data.SqlClient;
using SalonDeBellezaCarlitos.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SalonDeBellezaCarlitos.DataAccess.Repository
{
    public class FacturasRepository : IRepository<tbFacturas>
    {
        public int Delete(tbFacturas item)
        {
            throw new NotImplementedException();
        }

        public tbFacturas find(int? id)
        {
            using var db = new SalonCarlitosContext();
            var listado = db.tbFacturas.Find(id);
            return listado;
        }

        public int Insert(tbFacturas item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@clie_Id", item.clie_Id, DbType.String, ParameterDirection.Input);
            parametros.Add("@empl_Id_Atendido", item.empl_Id_Atendido, DbType.String, ParameterDirection.Input);
            parametros.Add("@empl_Id_Caja", item.empl_Id_Caja, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@metp_Id", item.metp_Id, DbType.String, ParameterDirection.Input);
            parametros.Add("@fact_UsuarioCreacion", 1, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Insertar_Facturas, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public IEnumerable<tbFacturas> List()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<VW_tbFacturas_Listado> ListView()
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            return db.Query<VW_tbFacturas_Listado>(ScriptsDataBase.UDP_Listado_Facturas, null, commandType: CommandType.StoredProcedure);
        }

        public int Update(tbFacturas item)
        {
            throw new NotImplementedException();
        }
    }
}
