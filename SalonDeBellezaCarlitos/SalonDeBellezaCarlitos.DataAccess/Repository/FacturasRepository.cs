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
            throw new NotImplementedException();
        }

        public IEnumerable<tbFacturas> List()
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            return db.Query<tbFacturas>(ScriptsDataBase.UDP_Listado_Facturas, null, commandType: CommandType.StoredProcedure);
        }

        public int Update(tbFacturas item)
        {
            throw new NotImplementedException();
        }
    }
}
