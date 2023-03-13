using Dapper;
using Microsoft.Data.SqlClient;
using SalonDeBellezaCarlitos.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SalonDeBellezaCarlitos.DataAccess.Repository
{
    public class SucursalesRepository : IRepository<tbSucursales>
    {
        public int Delete(tbSucursales item)
        {
            throw new NotImplementedException();
        }

        public tbSucursales find(int? id)
        {
            using var db = new SalonCarlitosContext();
            var listado = db.tbSucursales.Find(id);
            return listado;
        }

        public int Insert(tbSucursales item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbSucursales> List()
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            return db.Query<tbSucursales>(ScriptsDataBase.UDP_Listado_Sucursales, null, commandType: CommandType.StoredProcedure);
        }

        public int Update(tbSucursales item)
        {
            throw new NotImplementedException();
        }
    } 
}
