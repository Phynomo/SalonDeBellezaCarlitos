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
            throw new NotImplementedException();
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
