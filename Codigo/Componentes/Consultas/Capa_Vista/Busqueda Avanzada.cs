using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Odbc;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_Vista
{
    public partial class Busqueda_Avanzada : Form
    {
        // Conexion cn = new Conexion();
        public Busqueda_Avanzada()
        {
            InitializeComponent();
        }
        public void CargarTablas()
        {
            OdbcConnection conx = new OdbcConnection("Dsn=Colchoneria");
            conx.Open();
            cbo_buscaren.DataSource = conx.GetSchema("Tables");
            cbo_buscaren.DisplayMember = "TABLE_NAME";

            conx.Close();

        }

        private void btn_SalirBA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bnt_nuevaBA_Click(object sender, EventArgs e)
        {
            panelResultado.Visible = false;
            txt_buscar.Text = "";

        }

        private void btn_CancelarBA_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_BuscarBA_Click(object sender, EventArgs e)
        {
            String dato;
            String tableN;

            dato = txt_buscar.Text;
            tableN = cbo_buscaren.Text;

            BuscarT(dato, tableN);
        }

        private void BuscarT(string dato, string tableN)
        {
            if (string.IsNullOrEmpty(dato))
            {
                String textalert = " El campo buscar, se encuentra vacio ";
                MessageBox.Show(textalert);
            }
            else
            {
                DataTable dt = new DataTable();
                //try
                //{
                //    string cadena = " SELECT " + dato + " FROM " + tableN;
                //    OdbcDataAdapter datos = new OdbcDataAdapter(cadena, cn.conexion());
                //    datos.Fill(dt);

                //    if (dt.Rows.Count > 0)
                //    {
                //        panelResultado.Visible = true;
                //        dgvDato.DataSource = dt;

                //    }
                //}
                //catch
                //{
                //    String textalert = " El dato : " + dato + " No se encuentra en la tabla: " + tableN;
                //    MessageBox.Show(textalert);
                //    txt_buscar.Text = "";
                //}
            }
        }

        private void pnl_BuscarBA_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
