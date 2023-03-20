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
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);

            var parametros = new DynamicParameters();
            parametros.Add("@rese_Id", item.rese_Id, DbType.Int32, ParameterDirection.Input);

            return db.QueryFirst<int>(ScriptsDataBase.UDP_Borrar_Reservaciones, parametros, commandType: CommandType.StoredProcedure);

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

            DateTime dia = Convert.ToDateTime(item.rese_DiaReservado);
            string rese_DiaReservado = dia.ToString("yyyy-MM-dd");

            parametros.Add("@clie_Id", item.clie_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@sucu_Id", item.sucu_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@rese_DiaReservado", rese_DiaReservado, DbType.Date, ParameterDirection.Input);
            parametros.Add("@rese_HoraInicio", item.rese_HoraInicio, DbType.Time, ParameterDirection.Input);
            parametros.Add("@rese_HoraFin", item.rese_HoraFin, DbType.Time, ParameterDirection.Input);
            parametros.Add("@rese_UsuarioCreacion", item.rese_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Insertar_Reservaciones, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public IEnumerable<tbReservaciones> List()
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            return db.Query<tbReservaciones>(ScriptsDataBase.UDP_Listado_Reservaciones, null, commandType: CommandType.StoredProcedure);
        }
        
        public IEnumerable<VW_tbReservaciones_View> ListView()
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            return db.Query<VW_tbReservaciones_View>(ScriptsDataBase.UDP_Listado_Reservaciones, null, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<VW_tbReservaciones_View> BuscarView(int? id)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);

            var parametros = new DynamicParameters();
            parametros.Add("@rese_Id", id, DbType.Int32, ParameterDirection.Input);

            return db.Query<VW_tbReservaciones_View>(ScriptsDataBase.UDP_Buscar_Reservaciones, parametros, commandType: CommandType.StoredProcedure);
        }

        public int Update(tbReservaciones item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();

            DateTime dia = Convert.ToDateTime(item.rese_DiaReservado);
            string rese_DiaReservado = dia.ToString("yyyy-MM-dd");

            parametros.Add("@rese_Id", item.rese_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@clie_Id", item.clie_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@sucu_Id", item.sucu_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@rese_DiaReservado", rese_DiaReservado, DbType.Date, ParameterDirection.Input);
            parametros.Add("@rese_HoraInicio", item.rese_HoraInicio, DbType.Time, ParameterDirection.Input);
            parametros.Add("@rese_HoraFin", item.rese_HoraFin, DbType.Time, ParameterDirection.Input);
            parametros.Add("@rese_UsuarioModificacion", item.rese_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Editar_Reservaciones, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }
    }
}
