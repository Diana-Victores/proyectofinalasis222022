using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusquedaInteligente
{

    class CRUDC
    {
        OdbcConnection con = new OdbcConnection("FIL=MS Acces;DSN=Colchoneria");
        public bool InsertBusquedaCompleja(string _ope, string _camp, string _valo)
        {
            using (con)
            {
                OdbcCommand cmda = new OdbcCommand();
                con.Open();
                cmda.Connection = con;

                #region Query
                String query = @"INSERT INTO busqueda (operador,campos,valor) VALUE(?,?,?);" ;
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
   
  
    
}
