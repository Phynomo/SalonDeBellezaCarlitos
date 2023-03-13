using Dapper;
using Microsoft.Data.SqlClient;
using SalonDeBellezaCarlitos.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SalonDeBellezaCarlitos.DataAccess.Repository
{
    public class ProductoRepository : IRepository<tbProductos>
    {
        public int Delete(tbProductos item)
        {
            throw new NotImplementedException();
        }

        public tbProductos find(int? id)
        {
            using var db = new SalonCarlitosContext();
            var listado = db.tbProductos.Find(id);
            return listado;
        }

        public int Insert(tbProductos item)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<tbProductos> List()
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            return db.Query<tbProductos>(ScriptsDataBase.UDP_Listado_Productos, null, commandType: CommandType.StoredProcedure);
        }

        public int Update(tbProductos item)
        {
            throw new NotImplementedException();
        }
    }
}
