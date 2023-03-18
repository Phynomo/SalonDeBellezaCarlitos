using Dapper;
using Microsoft.Data.SqlClient;
using SalonDeBellezaCarlitos.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace SalonDeBellezaCarlitos.DataAccess.Repository
{
    public class ClienteRepository : IRepository<tbClientes>
    {
        public int Delete(tbClientes item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@clie_Id", item.clie_Id, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Borrar_Clientes, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public tbClientes find(int? id)
        {
            using var db = new SalonCarlitosContext();
            var listado = db.tbClientes.Find(id);
            return listado;
        }

        public int Insert(tbClientes item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@clie_Nombre", item.clie_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@clie_Apellido", item.clie_Apellido, DbType.String, ParameterDirection.Input);
            parametros.Add("@clie_Telefono", item.clie_Telefono, DbType.String, ParameterDirection.Input);
            parametros.Add("@clie_CorreoElectronico", item.clie_CorreoElectronico, DbType.String, ParameterDirection.Input);
            parametros.Add("@clie_UsuarioCreacion", 1, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Insertar_Clientes, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public IEnumerable<tbClientes> List()
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            return db.Query<tbClientes>(ScriptsDataBase.UDP_Listado_Clientes, null, commandType: CommandType.StoredProcedure);
        }

        public int Update(tbClientes item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@clie_Id", item.clie_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@clie_Nombre", item.clie_Nombre, DbType.String, ParameterDirection.Input);
            parametros.Add("@clie_Apellido", item.clie_Apellido, DbType.String, ParameterDirection.Input);
            parametros.Add("@clie_Telefono", item.clie_Telefono, DbType.String, ParameterDirection.Input);
            parametros.Add("@clie_CorreoElectronico", item.clie_CorreoElectronico, DbType.String, ParameterDirection.Input);
            parametros.Add("@clie_UsuarioModificacion", 1, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Editar_Clientes, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }
    }
}
