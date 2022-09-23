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
using Capa_Modelo;

namespace Capa_Vista
{
    public partial class Busqueda_Avanzada : Form
    {
        //Conexion cn = new Conexion();
        OdbcConnection cn = new OdbcConnection("Dsn=Colchoneria");
        public Busqueda_Avanzada()
        {
            InitializeComponent();
            CargarTablas();
        }
        public void CargarTablas()
        {
            cn.Open();
            cbo_buscaren.DataSource = cn.GetSchema("Tables");
            cbo_buscaren.DisplayMember = "TABLE_NAME";
            cn.Close();

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
                try
                {
                    string cadena = " SELECT " + dato + " FROM " + tableN;
                    OdbcDataAdapter datos = new OdbcDataAdapter(cadena, cn);
                    datos.Fill(dt);

                    if (dt.Rows.Count > 0)
                    {
                        panelResultado.Visible = true;
                        dgvDato.DataSource = dt;

                    }
                }
                catch
                {
                    String textalert = " El dato : " + dato + " No se encuentra en la tabla: " + tableN;
                    MessageBox.Show(textalert);
                    txt_buscar.Text = "";
                }
            }
        }

        private void Busqueda_Avanzada_Load(object sender, EventArgs e)
        {

        }
    }
}
