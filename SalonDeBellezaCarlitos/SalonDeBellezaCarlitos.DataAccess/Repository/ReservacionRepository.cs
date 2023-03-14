using Dapper;
using Microsoft.Data.SqlClient;
using SalonDeBellezaCarlitos.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SalonDeBellezaCarlitos.DataAccess.Repository
{
    public class ReservacionRepository : IRepository<tbReservaciones>
    {
        public int Delete(tbReservaciones item)
        {
            throw new NotImplementedException();
        }

        public tbReservaciones find(int? id)
        {
            using var db = new SalonCarlitosContext();
            var listado = db.tbReservaciones.Find(id);
            return listado;
        }

        public int Insert(tbReservaciones item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@clie_Id", item.clie_Id, DbType.String, ParameterDirection.Input);
            parametros.Add("@sucu_Id", item.sucu_Id, DbType.String, ParameterDirection.Input);
            parametros.Add("@rese_DiaReservado", item.rese_DiaReservado, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@rese_HoraInicio", item.rese_HoraInicio, DbType.String, ParameterDirection.Input);
            parametros.Add("@rese_HoraFin", item.rese_HoraFin, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@rese_UsuarioCreacion", 1, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Insertar_Reservaciones, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public IEnumerable<tbReservaciones> List()
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            return db.Query<tbReservaciones>(ScriptsDataBase.UDP_Listado_Reservaciones, null, commandType: CommandType.StoredProcedure);
        }

        public int Update(tbReservaciones item)
        {
            throw new NotImplementedException();
        }
    }
}
