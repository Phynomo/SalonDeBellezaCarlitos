﻿using Dapper;
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


        public int DeleteDetalle(tbFacturas item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@fade_Id", item.fact_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Borrar_FacturasDetalle, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
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
            parametros.Add("@fact_UsuarioCreacion", item.fact_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Insertar_Facturas, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public int InsertFacturaDetalles(tbFacturas item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@fact_Id", item.fact_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@prod_Id", item.empl_Id_Atendido, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@serv_Id", item.empl_Id_Caja, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@fade_Cantidad", item.fact_UsuarioCreacion, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@fade_UsuarioCreacion", item.fact_UsuarioModificacion, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_Insertar_FacturasDetalle, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }


        public IEnumerable<VW_tbFacturaDetalle_View> BuscarFacturaDetalles(int? item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@fact_Id", item, DbType.Int32, ParameterDirection.Input);

            var resultado = db.Query<VW_tbFacturaDetalle_View>(ScriptsDataBase.UDP_Buscar_FacturasDetalle, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public IEnumerable<VW_tbFacturas_Listado> BuscarFactura(int? item)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@fact_Id", item, DbType.Int32, ParameterDirection.Input);

            var resultado = db.Query<VW_tbFacturas_Listado>(ScriptsDataBase.UDP_Buscar_Facturas, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

        public IEnumerable<tbFacturas> List()
        {
            throw new NotImplementedException();
        }
        public IEnumerable<VW_tbFacturas_Listado> ListView(int sucu_id)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();

            parametros.Add("@sucu_Id", sucu_id, DbType.Int32, ParameterDirection.Input);

            return db.Query<VW_tbFacturas_Listado>(ScriptsDataBase.UDP_Listado_Facturas, parametros, commandType: CommandType.StoredProcedure);
        }

        public int Update(tbFacturas item)
        {
            throw new NotImplementedException();
        }

        public int stockmax(int prod_Id, int serv_Id)
        {
            using var db = new SqlConnection(SalonCarlitosContext.ConnectionString);
            var parametros = new DynamicParameters();
            parametros.Add("@prod_Id", prod_Id, DbType.Int32, ParameterDirection.Input);
            parametros.Add("@serv_Id", serv_Id, DbType.Int32, ParameterDirection.Input);

            var resultado = db.QueryFirst<int>(ScriptsDataBase.UDP_StockMax_FacturasDetalle, parametros, commandType: CommandType.StoredProcedure);

            return resultado;
        }

    }
}
