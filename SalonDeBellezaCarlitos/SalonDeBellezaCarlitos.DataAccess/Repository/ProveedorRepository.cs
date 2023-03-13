using Dapper;
using Microsoft.Data.SqlClient;
using SalonDeBellezaCarlitos.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SalonDeBellezaCarlitos.DataAccess.Repository
{
    public class ProveedorRepository : IRepository<tbProveedores>
    {
        public int Delete(tbProveedores item)
        {
            throw new NotImplementedException();
        }

        public tbProveedores find(int? id)
        {
            using var db = new SalonCarlitosContext();
            var listado = db.tbProveedores.Find(id);
            return listado;
        }

        public int Insert(tbProveedores item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbProveedores> List()
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            return db.Query<tbProveedores>(ScriptsDataBase.UDP_Listado_Proveedores, null, commandType: CommandType.StoredProcedure);
        }

        public int Update(tbProveedores item)
        {
            throw new NotImplementedException();
        }
    }
}
