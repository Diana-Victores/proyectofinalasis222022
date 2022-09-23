using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace BusquedaInteligente
{

    class CRUD
    {
        OdbcConnection con = new OdbcConnection("FIL=MS Acces;DSN=Colchoneria");
        public bool InsertBusqueda(string _nomb, string _cons, string _area,string _camp)
        {
            using (con)
            {
                OdbcCommand cmd = new OdbcCommand();
                con.Open();
                cmd.Connection = con;

                #region Query
                String query = @"INSERT INTO busqueda (nombre,consulta,area,campos) VALUE(?,?,?,?);" ;
                #endregion
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.Add("@nombre", OdbcType.Int).Value = _nomb;
                cmd.Parameters.Add("@nombre", OdbcType.VarChar).Value = _cons;
                cmd.Parameters.Add("@nombre", OdbcType.VarChar).Value = _area;
                cmd.Parameters.Add("@nombre", OdbcType.VarChar).Value = _camp;

                cmd.ExecuteNonQuery();
                con.Close();
            }
            return true;
        }
        public bool InsertBusquedaCompleja(string _ope, string _camp, string _valo)
        {
            using (con)
            {
                OdbcCommand cmda = new OdbcCommand();
                con.Open();
                cmda.Connection = con;

                #region Query
                String query = @"INSERT INTO busqueda (operador,campos,valor) VALUE(?,?,?);";
                #endregion
                cmda.CommandType = CommandType.Text;
                cmda.CommandText = query;
                cmda.Parameters.Add("@nombre", OdbcType.Int).Value = _ope;
                cmda.Parameters.Add("@nombre", OdbcType.VarChar).Value = _camp;
                cmda.Parameters.Add("@nombre", OdbcType.VarChar).Value = _valo;


                //cmda.ExecuteNonQuery();
                con.Close();
            }
            return true;
        }
    }

    //******************************eliminar*
    public bool DeleteConsulta(string _ope)
    {
        try
        {
            using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=Colchoneria"))
            {
                OdbcCommand cmd = new OdbcCommand();
                con.Open();
                cmd.Connection = con;
                #region Query
               
                string query = @"DELETE FROM busqueda WHERE busqueda.Upc = ?;";
                #endregion
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = query;
                cmd.Parameters.Add("@nombre", OdbcType.VarChar).Value = _ope;
                cmd.ExecuteNonQuery();

                cmd.Parameters.Clear();
                con.Close();
            }
            return true;
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message);
            return false;
        }
    }
}






