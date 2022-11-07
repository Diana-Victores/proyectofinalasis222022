using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Odbc;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Forms;
using Capa_ModeloContabilidad;

namespace Capa_ControladorContabilidad
{
   public class controlador
    {
            Sentencias sn = new Sentencias();

            public void llenarcombo(string tabla, ComboBox combo, int posicion)
            {

                try
                {

                    OdbcDataAdapter dt = sn.llenarcomboproducto(tabla);
                    DataTable table = new DataTable();
                    dt.Fill(table);

                    int contador = 0;
                    combo.Items.Clear();

                    foreach (DataRow row in table.Rows)
                    {

                        combo.Items.Add(table.Rows[contador][posicion].ToString());
                        contador++;
                    }

                }
                catch (Exception e)
                {
                MessageBox.Show(" " + e);
            }
            }

        public bool InsertProducto(string _Pk, string _Edi, string _Mue, string _Equi, string _Maqui, string _Herra, string _Eqco)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"INSERT INTO tbl_activosfijos (pk_ActivosFijos,Edificaiones,Muebles,Equipos,Maquinaria,Herramientas,EquipoComputo)VALUE(?,?,?,?,?,?,?);";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@pk_ActivosFijos", OdbcType.Int).Value = _Pk;
                    cmd.Parameters.Add("@Edificaiones", OdbcType.VarChar).Value = _Edi;
                    cmd.Parameters.Add("@Muebles", OdbcType.VarChar).Value = _Mue;
                    cmd.Parameters.Add("@Equipos", OdbcType.VarChar).Value = _Equi;
                    cmd.Parameters.Add("@Maquinaria", OdbcType.VarChar).Value = _Maqui;
                    cmd.Parameters.Add("@Herramientas", OdbcType.VarChar).Value = _Herra;
                    cmd.Parameters.Add("@EquipoComputo", OdbcType.VarChar).Value = _Eqco;
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


        public bool UpdateProducto(string _Pk, string _Edi, string _Mue, string _Equi, string _Maqui, string _Herra, string _Eqco)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"UPDATE tbl_activosfijos SET tbl_activosfijos.Edificaiones = ?, tbl_activosfijos.Muebles = ?, tbl_activosfijos.Equipos = ?, tbl_activosfijos.Maquinaria = ? , tbl_activosfijos.Herramientas = ? , tbl_activosfijos.EquipoComputo = ? WHERE tbl_activosfijos.pk_ActivosFijos = ?;";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.Add("@Edificaiones", OdbcType.VarChar).Value = _Edi;
                    cmd.Parameters.Add("@Muebles", OdbcType.VarChar).Value = _Mue;
                    cmd.Parameters.Add("@Equipos", OdbcType.VarChar).Value = _Equi;
                    cmd.Parameters.Add("@Maquinaria", OdbcType.VarChar).Value = _Maqui;
                    cmd.Parameters.Add("@Herramientas", OdbcType.VarChar).Value = _Herra;
                    cmd.Parameters.Add("@EquipoComputo", OdbcType.VarChar).Value = _Eqco;
                    cmd.Parameters.Add("@pk_ActivosFijos", OdbcType.Int).Value = _Pk;

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

        public bool DeleteProducto(string _Pk)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;
                    #region Query
                    string query = @"DELETE FROM tbl_activosfijos WHERE tbl_activosfijos.pk_ActivosFijos = ?;";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@pk_ActivosFijos", OdbcType.VarChar).Value = _Pk;
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

        public DataTable SelectProducto()
        {
            DataTable dt = new DataTable();
            using (OdbcDataAdapter adapter = new OdbcDataAdapter("SELECT * FROM tbl_activosfijos;", "FIL=MS Access;DSN=colchoneria"))
            {
                adapter.SelectCommand.CommandType = CommandType.Text;
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable BuscarDato(string data, string col, DataTable dt)
        {
            OdbcConnection con = new OdbcConnection("Dsn=Colchoneria");
            try
            {
                //DataTable dt = new DataTable();
                String cadenaB = "";
                con.Open();
                cadenaB = " SELECT * FROM tbl_activosfijos WHERE " + col + " LIKE ('%" + data.Trim() + "%')";
                OdbcDataAdapter datos = new OdbcDataAdapter(cadenaB, con);
                datos.Fill(dt);
                OdbcCommand comando = new OdbcCommand(cadenaB, con);
                OdbcDataReader leer;
                leer = comando.ExecuteReader();
            }
            catch
            {
                String textalert = " El dato : " + data + " No se encontro ";
                MessageBox.Show(textalert);
            }
            con.Close();
            return dt;
        }

        public DataTable ActualizarT(string table, DataTable dt)
        {
            try
            {
                OdbcConnection con = new OdbcConnection("Dsn=Colchoneria");
                String cadena = "";
                con.Open();
                cadena = "SELECT * FROM " + table;
                OdbcDataAdapter datos = new OdbcDataAdapter(cadena, con);
                datos.Fill(dt);
                OdbcCommand comando = new OdbcCommand(cadena, con);
                OdbcDataReader leer;
                leer = comando.ExecuteReader();
                con.Close();
            }
            catch
            {
                String textalert = " Error al actualizar datos, puede que no haya datos que mostrar ";
                MessageBox.Show(textalert);
            }
            return dt;
        }

        //Jonathan Xuyá

        public bool InsertEF(float _Pk, float _Edi, float _Mue, float _Equi, float _Maqui, float _Herra, float _Eqco)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"INSERT INTO tbl_EstadosFinancieros (Pk_EstadosFinancieros,ActivoCirculante,ActivoNoCirculante,PasivoACortoPlazo,PasivoALargoPlazo,CapitalContable,ResultadoAPeriodo)VALUE(?,?,?,?,?,?,?);";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@Pk_EstadosFinancieros", OdbcType.Double).Value = _Pk;
                    cmd.Parameters.Add("@ActivoCirculante", OdbcType.Double).Value = _Edi;
                    cmd.Parameters.Add("@ActivoNoCirculante", OdbcType.Double).Value = _Mue;
                    cmd.Parameters.Add("@PasivoACortoPlazo", OdbcType.Double).Value = _Equi;
                    cmd.Parameters.Add("@PasivoALargoPlazo", OdbcType.Double).Value = _Maqui;
                    cmd.Parameters.Add("@CapitalContable", OdbcType.Double).Value = _Herra;
                    cmd.Parameters.Add("@ResultadoAPeriodo", OdbcType.Double).Value = _Eqco;
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

        public DataTable data(DataTable dt, string v)
        {
            OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria");
            con.Open();
            string cadena;
            cadena = "Select" + v + " from tbl_cierregeneral";
            OdbcDataAdapter datos = new OdbcDataAdapter(cadena, con);
            datos.Fill(dt);
            con.Close();
            return (dt);

        }

        public bool UpdateEF(float _Pk, float _Edi, float _Mue, float _Equi, float _Maqui, float _Herra, float _Eqco)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"UPDATE tbl_EstadosFinancieros SET tbl_EstadosFinancieros.ActivoCirculante = ?, tbl_EstadosFinancieros.ActivoNoCirculante = ?, tbl_EstadosFinancieros.PasivoACortoPlazo = ?, tbl_EstadosFinancieros.PasivoALargoPlazo = ? , tbl_EstadosFinancieros.CapitalContable = ? , tbl_EstadosFinancieros.ResultadoAPeriodo = ? WHERE tbl_EstadosFinancieros.Pk_EstadosFinancieros = ?;";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;


                    cmd.Parameters.Add("@ActivoCirculante", OdbcType.Double).Value = _Edi;
                    cmd.Parameters.Add("@ActivoNoCirculante", OdbcType.Double).Value = _Mue;
                    cmd.Parameters.Add("@PasivoACortoPlazo", OdbcType.Double).Value = _Equi;
                    cmd.Parameters.Add("@PasivoALargoPlazo", OdbcType.Double).Value = _Maqui;
                    cmd.Parameters.Add("@CapitalContable", OdbcType.Double).Value = _Herra;
                    cmd.Parameters.Add("@ResultadoAPeriodo", OdbcType.Double).Value = _Eqco;
                    cmd.Parameters.Add("@Pk_EstadosFinancieros", OdbcType.Double).Value = _Pk;

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

        public bool DeleteEF(float _Pk)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;
                    #region Query
                    string query = @"DELETE FROM tbl_activosfijos WHERE tbl_activosfijos.pk_ActivosFijos = ?;";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@tbl_EstadosFinancieros", OdbcType.VarChar).Value = _Pk;
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

        public DataTable SelectEF()
        {
            DataTable dt = new DataTable();
            using (OdbcDataAdapter adapter = new OdbcDataAdapter("SELECT * FROM tbl_EstadosFinancieros;", "FIL=MS Access;DSN=colchoneria"))
            {
                adapter.SelectCommand.CommandType = CommandType.Text;
                adapter.Fill(dt);
            }
            return dt;
        }

        public DataTable BuscarEF(string data, string col, DataTable dt)
        {
            OdbcConnection con = new OdbcConnection("Dsn=colchoneria");
            try
            {
                //DataTable dt = new DataTable();
                String cadenaB = "";
                con.Open();
                cadenaB = " SELECT * FROM tbl_EstadosFinancieros WHERE " + col + " LIKE ('%" + data.Trim() + "%')";
                OdbcDataAdapter datos = new OdbcDataAdapter(cadenaB, con);
                datos.Fill(dt);
                OdbcCommand comando = new OdbcCommand(cadenaB, con);
                OdbcDataReader leer;
                leer = comando.ExecuteReader();
            }
            catch
            {
                String textalert = " El dato : " + data + " No se encontro ";
                MessageBox.Show(textalert);
            }
            con.Close();
            return dt;
        }

        public DataTable ActualizarEF(string table, DataTable dt)
        {
            try
            {
                OdbcConnection con = new OdbcConnection("Dsn=colchoneria");
                String cadena = "";
                con.Open();
                cadena = "SELECT * FROM " + table;
                OdbcDataAdapter datos = new OdbcDataAdapter(cadena, con);
                datos.Fill(dt);
                OdbcCommand comando = new OdbcCommand(cadena, con);
                OdbcDataReader leer;
                leer = comando.ExecuteReader();
                con.Close();
            }
            catch
            {
                String textalert = " Error al actualizar datos, puede que no haya datos que mostrar ";
                MessageBox.Show(textalert);
            }
            return dt;
        }

        //Josue Amaya 0901-19-12421
        public void ConsultaConta(TextBox txt_boxcodcont, TextBox txt_boxnamecont, string fecha, string cuenta)
        {
            try
            {
                OdbcConnection con = new OdbcConnection("Dsn=colchoneria");
                con.Open();
                OdbcCommand comando = new OdbcCommand("SELECT codigo_contador, nombre_contador FROM tbl_confctascierrre WHERE cuenta_nombre LIKE ('%" + cuenta.Trim() + "%') AND fecha_cierre LIKE ('%" + fecha + "%')", con);
                OdbcDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    txt_boxcodcont.Text = leer["codigo_contador"].ToString();
                    txt_boxnamecont.Text = leer["nombre_contador"].ToString();
                }
                con.Close();
            }
            catch
            {
                String mensaje = "Error al Consultar Contador Encargado";
                MessageBox.Show(mensaje);
            }

        }

        //Josue Amaya 0901-19-12421
        public DataTable ConsultarCtas(string cuenta, String fecha, DataTable dt1, DataTable dt2, DateTimePicker dtime_consulta)
        {
            OdbcConnection con = new OdbcConnection("Dsn=colchoneria");
            String cadena1 = "";
            String cadena2 = "";
            con.Open();
            try
            {
                cadena1 = "SELECT fecha,razon,monto FROM  tbl_cierrectasact WHERE nombre_cuenta LIKE ('%" + cuenta.Trim() + "%') AND fecha LIKE ('%" + fecha + "%') ";
                cadena2 = "SELECT fecha,razon,monto FROM  tbl_cierrectaspas WHERE nombre_cuenta LIKE ('%" + cuenta.Trim() + "%') AND fecha LIKE ('%" + fecha + "%') ";
                OdbcDataAdapter datos1 = new OdbcDataAdapter(cadena1, con);
                OdbcDataAdapter datos2 = new OdbcDataAdapter(cadena2, con);
                datos1.Fill(dt1);
                datos2.Fill(dt2);
                OdbcCommand comando1 = new OdbcCommand(cadena1, con);
                OdbcCommand comando2 = new OdbcCommand(cadena2, con);
                OdbcDataReader leer;
                leer = comando1.ExecuteReader();
                leer = comando2.ExecuteReader();
                con.Close();

            }
            catch
            {
                String mensaje = "Error al realizar la consulta.";
                MessageBox.Show(mensaje);
            }
            return dt1;
            return dt2;
        }

        //Josue Amaya 0901-19-12421
        public void ConsultaCont2(string finicio, string ffin, TextBox txt_boxcodcont, TextBox txt_boxnamecont)
        {
            try
            {
                OdbcConnection con = new OdbcConnection("Dsn=colchoneria");
                con.Open();
                OdbcCommand comando = new OdbcCommand("SELECT codigo_contador, nombre_contador FROM tbl_cierregeneral WHERE fecha_cierre BETWEEN ('" + finicio + "') AND ('" + ffin + "')", con);
                OdbcDataReader leer = comando.ExecuteReader();
                while (leer.Read())
                {
                    txt_boxcodcont.Text = leer["codigo_contador"].ToString();
                    txt_boxnamecont.Text = leer["nombre_contador"].ToString();
                }
                con.Close();
            }
            catch
            {
                String mensaje = "Error al Consultar Contador Encargado";
                MessageBox.Show(mensaje);
            }
        }

        //Josue Amaya 0901-19-12421
        public DataTable ConsultaCG(string finicio, string ffin, DataTable dt1, DataTable dt2)
        {
            OdbcConnection con = new OdbcConnection("Dsn=colchoneria");
            String cadena1 = "";
            String cadena2 = "";
            con.Open();
            try
            {
                cadena1 = "SELECT fecha_cierre, cuenta_nombre, monto_total FROM  tbl_cierreact WHERE fecha_cierre BETWEEN ('" + finicio + "') AND ('" + ffin + "')";
                cadena2 = "SELECT fecha_cierre, cuenta_nombre, monto_total FROM  tbl_cierrepas WHERE fecha_cierre BETWEEN('" + finicio + "') AND ('" + ffin + "')";
                OdbcDataAdapter datos1 = new OdbcDataAdapter(cadena1, con);
                OdbcDataAdapter datos2 = new OdbcDataAdapter(cadena2, con);
                datos1.Fill(dt1);
                datos2.Fill(dt2);
                OdbcCommand comando1 = new OdbcCommand(cadena1, con);
                OdbcCommand comando2 = new OdbcCommand(cadena2, con);
                OdbcDataReader leer;
                leer = comando1.ExecuteReader();
                leer = comando2.ExecuteReader();
                con.Close();

            }
            catch
            {
                String mensaje = "Error al realizar la consulta. Cierre Contable No Encontrado";
                MessageBox.Show(mensaje);
            }
            return dt1;
            return dt2;
        }

        //Josue Amaya 0901-19-12421
        public void CargarComboCtas(ComboBox cbo_boxctas)
        {
            OdbcConnection con = new OdbcConnection("Dsn=colchoneria");
            con.Open();
            OdbcCommand comando = new OdbcCommand("SELECT nombre_cuenta FROM tbl_cuentas", con);
            OdbcDataReader leer = comando.ExecuteReader();
            while (leer.Read())
            {
                cbo_boxctas.Items.Add(leer["nombre_cuenta"].ToString());
            }
        }

        //Josue Amaya 0901-19-12421
        public bool cierreGAct(string p, string cuenta, float monto, string fecha)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"INSERT INTO tbl_cierreAct (pkid_cierreA,cuenta_nombre,monto_total,fecha_cierre)VALUE(?,?,?,?);";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@pkid_cierreA", OdbcType.Int).Value = p;
                    cmd.Parameters.Add("@cuenta_nombre", OdbcType.VarChar).Value = cuenta;
                    cmd.Parameters.Add("@monto_total", OdbcType.Double).Value = monto;
                    cmd.Parameters.Add("@fecha_cierre", OdbcType.Date).Value = fecha;
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

        //Josue Amaya 0901-19-12421
        public bool CierreGeneral(string p, float totA, float totP, string cod, string name, string fecha)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"INSERT INTO tbl_cierregeneral (pkid_cierreG,total_activo,total_pasivo,codigo_contador,nombre_contador,fecha_cierre)VALUE(?,?,?,?,?,?);";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@pkid_cierreG", OdbcType.Int).Value = p;
                    cmd.Parameters.Add("@total_activo", OdbcType.Double).Value = totA;
                    cmd.Parameters.Add("@total_pasivo", OdbcType.Double).Value = totP;
                    cmd.Parameters.Add("@codigo_contador", OdbcType.VarChar).Value = cod;
                    cmd.Parameters.Add("@nombre_contador", OdbcType.VarChar).Value = name;
                    cmd.Parameters.Add("@fecha_cierre", OdbcType.Date).Value = fecha;
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

        //Josue Amaya 0901-19-12421
        public bool cierreGPas(string p, string cuenta, float monto, string fecha)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"INSERT INTO tbl_cierrePas (pkid_cierreP,cuenta_nombre,monto_total,fecha_cierre)VALUE(?,?,?,?);";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@pkid_cierreP", OdbcType.Int).Value = p;
                    cmd.Parameters.Add("@cuenta_nombre", OdbcType.VarChar).Value = cuenta;
                    cmd.Parameters.Add("@monto_total", OdbcType.Double).Value = monto;
                    cmd.Parameters.Add("@fecha_cierre", OdbcType.Date).Value = fecha;
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

        //Josue Amaya 0901-19-12421
        public DataTable ctas(DataTable dt)
        {
            OdbcConnection con = new OdbcConnection("Dsn=colchoneria");
            String cadena = "";
            try
            {
                con.Open();
                cadena = "SELECT nombre_cuenta FROM  tbl_cuentas";
                OdbcDataAdapter datos = new OdbcDataAdapter(cadena, con);
                datos.Fill(dt);
                OdbcCommand comando = new OdbcCommand(cadena, con);
                OdbcDataReader leer;
                leer = comando.ExecuteReader();
                con.Close();
            }
            catch
            {

            }
            return dt;
        }

        //Josue Amaya 0901-19-12421
        public bool confcierre(string p, string cuenta, float totp, float totac, string cod, string name, string fec)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"INSERT INTO tbl_confctascierrre (pkid_confcierre,cuenta_nombre,total_activo,total_pasivo,codigo_contador,nombre_contador,fecha_cierre)VALUE(?,?,?,?,?,?,?);";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@pkid_confcierre", OdbcType.Int).Value = p;
                    cmd.Parameters.Add("@cuenta_nombre", OdbcType.VarChar).Value = cuenta;
                    cmd.Parameters.Add("@total_activo", OdbcType.Double).Value = totac;
                    cmd.Parameters.Add("@total_pasivo", OdbcType.Double).Value = totp;
                    cmd.Parameters.Add("@codigo_contador", OdbcType.VarChar).Value = cod;
                    cmd.Parameters.Add("@nombre_contador", OdbcType.VarChar).Value = name;
                    cmd.Parameters.Add("@fecha_cierre", OdbcType.Date).Value = fec;
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

        //Josue Amaya 0901-19-12421
        public bool guardarcta(string razon, float monto, string fecha, string cuenta, string p)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"INSERT INTO tbl_cierrectasact (pkid_ctaAct,nombre_cuenta,razon,monto,fecha)VALUE(?,?,?,?,?);";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@pkid_ctaAct", OdbcType.Int).Value = p;
                    cmd.Parameters.Add("@nombre_cuenta", OdbcType.VarChar).Value = cuenta;
                    cmd.Parameters.Add("@razon", OdbcType.VarChar).Value = razon;
                    cmd.Parameters.Add("@monto", OdbcType.Double).Value = monto;
                    cmd.Parameters.Add("@fecha", OdbcType.Date).Value = fecha;
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

        //Josue Amaya 0901-19-12421
        public bool guardarctaP(string p, string razon, float monto, string cuenta, string fecha)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"INSERT INTO tbl_cierrectaspas (pkid_ctaPas,nombre_cuenta,razon,monto,fecha)VALUE(?,?,?,?,?);";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@pkid_ctaPas", OdbcType.Int).Value = p;
                    cmd.Parameters.Add("@nombre_cuenta", OdbcType.VarChar).Value = cuenta;
                    cmd.Parameters.Add("@razon", OdbcType.VarChar).Value = razon;
                    cmd.Parameters.Add("@monto", OdbcType.Double).Value = monto;
                    cmd.Parameters.Add("@fecha", OdbcType.Date).Value = fecha;
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
        public bool InsertPres(string PKidpresupuesto, string Mes, float gastosCorrientes, float gastosPersol, float gastosFinancieros, float TransferenciaCorriente, float TransferenciaCapital, float ActivosFijos, float ActivosFinancieros, float PasivosFinancieros, float Total_Presupuesto)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"INSERT INTO tbl_presupuesto (PKidpresupuesto,Mes,gastosCorrientes,gastosPersol,gastosFinancieros,TransferenciaCorriente,TransferenciaCapital,ActivosFijos,ActivosFinancieros,PasivosFinancieros,Total_Presupuesto)VALUE(?,?,?,?,?,?,?,?,?,?,?);";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@PKidpresupuesto", OdbcType.Int).Value = PKidpresupuesto;
                    cmd.Parameters.Add("@Mes", OdbcType.Date).Value = Mes;
                    cmd.Parameters.Add("@gastosCorrientes", OdbcType.Double).Value = gastosCorrientes;
                    cmd.Parameters.Add("@gastosPersol", OdbcType.Double).Value = gastosPersol;
                    cmd.Parameters.Add("@gastosFinancieros", OdbcType.Double).Value = gastosFinancieros;
                    cmd.Parameters.Add("@TransferenciaCorriente", OdbcType.Double).Value = TransferenciaCorriente;
                    cmd.Parameters.Add("@TransferenciaCapital", OdbcType.Double).Value = TransferenciaCapital;
                    cmd.Parameters.Add("@ActivosFijos", OdbcType.Double).Value = ActivosFijos;
                    cmd.Parameters.Add("@ActivosFinancieros", OdbcType.Double).Value = ActivosFinancieros;
                    cmd.Parameters.Add("@PasivosFinancieros", OdbcType.Double).Value = PasivosFinancieros;
                    cmd.Parameters.Add("@Total_Presupuesto", OdbcType.Double).Value = Total_Presupuesto;
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


        public bool UpdatePres(string PKidpresupuesto, string Mes, float gastosCorrientes, float gastosPersol, float gastosFinancieros, float TransferenciaCorriente, float TransferenciaCapital, float ActivosFijos, float ActivosFinancieros, float PasivosFinancieros, float Total_Presupuesto)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"UPDATE tbl_presupuesto SET tbl_presupuesto.PKidpresupuesto = ?, tbl_presupuesto.gastosCorrientes = ?, tbl_presupuesto.gastosPersol = ?, tbl_presupuesto.gastosFinancieros = ? , tbl_presupuesto.TransferenciaCorriente = ? , tbl_presupuesto.TransferenciaCapital = ? , tbl_presupuesto.ActivosFijos = ? , tbl_presupuesto.ActivosFinancieros = ? , tbl_presupuesto.PasivosFinancieros = ?, tbl_presupuesto.Total_Presupuesto = ? WHERE tbl_presupuesto.Mes = ?;";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;


                    cmd.Parameters.Add("@PKidpresupuesto", OdbcType.Int).Value = PKidpresupuesto;
                    cmd.Parameters.Add("@gastosCorrientes", OdbcType.Double).Value = gastosCorrientes;
                    cmd.Parameters.Add("@gastosPersol", OdbcType.Double).Value = gastosPersol;
                    cmd.Parameters.Add("@gastosFinancieros", OdbcType.Double).Value = gastosFinancieros;
                    cmd.Parameters.Add("@TransferenciaCorriente", OdbcType.Double).Value = TransferenciaCorriente;
                    cmd.Parameters.Add("@TransferenciaCapital", OdbcType.Double).Value = TransferenciaCapital;
                    cmd.Parameters.Add("@ActivosFijos", OdbcType.Double).Value = ActivosFijos;
                    cmd.Parameters.Add("@ActivosFinancieros", OdbcType.Double).Value = ActivosFinancieros;
                    cmd.Parameters.Add("@PasivosFinancieros", OdbcType.Double).Value = PasivosFinancieros;
                    cmd.Parameters.Add("@Total_Presupuesto", OdbcType.Double).Value = Total_Presupuesto;
                    cmd.Parameters.Add("@Mes", OdbcType.Date).Value = Mes;

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

        public bool DeletePres(string Mes)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;
                    #region Query
                    string query = @"DELETE FROM tbl_presupuesto WHERE tbl_presupuesto.Mes = ?;";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;
                    cmd.Parameters.Add("@Mes", OdbcType.Date).Value = Mes;
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
        public DataTable ActualizarPres(string table, DataTable dt)
        {
            try
            {
                OdbcConnection con = new OdbcConnection("Dsn=Colchoneria");
                String cadena = "";
                con.Open();
                cadena = "SELECT * FROM " + table;
                OdbcDataAdapter datos = new OdbcDataAdapter(cadena, con);
                datos.Fill(dt);
                OdbcCommand comando = new OdbcCommand(cadena, con);
                OdbcDataReader leer;
                leer = comando.ExecuteReader();
                con.Close();
            }
            catch
            {
                String textalert = " Error al actualizar datos, puede que no haya datos que mostrar ";
                MessageBox.Show(textalert);
            }
            return dt;
        }
        public bool InsertMoneda(float MpnedaDolar, float MonedaEuro, float MonedaQuetzal)
        {
            try
            {
                using (OdbcConnection con = new OdbcConnection("FIL=MS Access;DSN=Colchoneria"))
                {
                    OdbcCommand cmd = new OdbcCommand();
                    con.Open();
                    cmd.Connection = con;

                    #region Query
                    string query = @"INSERT INTO tbl_moneda (MpnedaDolar,MonedaEuro,MonedaQuetzal)VALUE(?,?,?);";
                    #endregion
                    cmd.CommandType = CommandType.Text;
                    cmd.CommandText = query;

                    cmd.Parameters.Add("@MpnedaDolar", OdbcType.Double).Value = MpnedaDolar;
                    cmd.Parameters.Add("@MonedaEuro", OdbcType.Double).Value = MonedaEuro;
                    cmd.Parameters.Add("@MonedaQuetzal", OdbcType.Double).Value = MonedaQuetzal;
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
}
