﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Odbc;

namespace ComprasModelo
{
    public class SentenciasJ
    {
        Conexion con = new Conexion();

        //Codigo movimiento clientes
        public OdbcDataAdapter llenartablaMovCliente(string tabla, string tipodato, string dato)
        {
          /*string sql = "select cli.PkId_Clientes, cli.Nombre_Clientes, caja.abono_CajaClientes, caja.SaldoAnterior_CajaClientes, caja.SaldoActualizado_CajaClientes, cli.status_Cliente from " + tabla + " as caja inner join tblVentasEncabezado as v on caja.FKId_VentasEncabezado = v.PkId_VentasEncabezado inner join tblasociacion as aso on v.FkId_Asociacion = aso.FkId_Clientes inner join tblclientes as cli on aso.FkId_Clientes = cli.PkId_Clientes where " + tipodato + " like ('" + dato + "%');"; */
            string sql = "select c.PkId_Clientes, c.Nombre_Clientes, cj.abono_CajaClientes, cj.SaldoAnterior_CajaClientes, cj.SaldoActualizado_CajaClientes, c.status_Cliente from " + tabla + " as cj inner join  tblVentasEncabezado as ven on ven.PkId_VentasEncabezado = cj.FKId_VentasEncabezado inner join tblasociacion as assc on assc.PkId_Asociacion = ven.FkId_Asociacion inner join tblclientes as c on c.PkId_Clientes = assc.FkId_Clientes where " + tipodato + " like ('" + dato + "%');";
            /*string sql = "select * from " + tabla + " where " + tipodato + " like ('" + dato + "%');"; */
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;

        }

        public OdbcDataAdapter llenartablaListPrecio(string tabla, string tipodato, string dato)
        {
            string sql = "select * from " + tabla + " where " + tipodato + " like ('" + dato + "%');";
            /*string sql = "select * from " + tabla + " where " + tipodato + " like ('" + dato + "%');"; */
            OdbcDataAdapter datatable = new OdbcDataAdapter(sql, con.conexion());
            return datatable;

        }
    }
}
