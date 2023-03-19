using Dapper;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using SalonDeBellezaCarlitos.Entities.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;

namespace SalonDeBellezaCarlitos.DataAccess.Repository
{
    public class UsuarioRepository : IRepository<tbUsuarios>
    {
        public int Delete(tbUsuarios item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);

            var parametros = new DynamicParameters();
            parametros.Add("@usur_Id", item.usur_Id, DbType.String, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Borrar_Usuarios, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public tbUsuarios find(int? id)
        {
            using var db = new SalonCarlitosContext();
            var listado = db.tbUsuarios.Find(id);
            return listado;
        }

        public int Insert(tbUsuarios item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@usur_Usuario", item.usur_Usuario, DbType.String, ParameterDirection.Input);
            parametros.Add("@usur_Contrasenia", item.usur_Contrasenia, DbType.String, ParameterDirection.Input);
            parametros.Add("@empl_Id", item.empl_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usur_UsuarioCreacion", 1, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Insertar_Usuarios, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public IEnumerable<tbUsuarios> List()
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            return db.Query<tbUsuarios>(ScriptsDataBase.UDP_Listado_Usuarios, null, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<VW_tbUsuarios_View> ListView()
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            return db.Query<VW_tbUsuarios_View>(ScriptsDataBase.UDP_Listado_Usuarios, null, commandType: CommandType.StoredProcedure);
        }

        public IEnumerable<VW_tbUsuarios_View> BuscarView(int? id)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@usur_Id", id, DbType.String, ParameterDirection.Input);
            return db.Query<VW_tbUsuarios_View>(ScriptsDataBase.UDP_Buscar_Usuarios, parametros, commandType: CommandType.StoredProcedure);
        }

        public int Update(tbUsuarios item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@usur_Id", item.usur_Id, DbType.String, ParameterDirection.Input);
            parametros.Add("@empl_Id", item.empl_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@usuarioModificacion", 1, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Editar_Usuarios, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }
    }
}
