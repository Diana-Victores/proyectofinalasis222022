//Joselyne Aracely Rivera Cifuentes
//    0901-17-5
//Proceso Presupuesto
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Capa_VistaContabilidad
{
    public partial class MantenimientoMoneda : Form
    {
        public MantenimientoMoneda()
        {
            InitializeComponent();
        }
        Capa_ControladorContabilidad.controlador crud = new Capa_ControladorContabilidad.controlador();

        private void button1_Click(object sender, EventArgs e)
        {
            double quetzales, dolar, euro;
            try
            {
                quetzales = Convert.ToDouble(txtCantidad.Text);
                dolar = quetzales / 0.13;
                euro = quetzales / 0.13;
                txrtMQzt.Text = quetzales.ToString();
                txrtMQzts.Text = quetzales.ToString();
                txtDolar.Text = dolar.ToString();
                txtEuro.Text = euro.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            txtCantidad.Text = String.Empty;
            txrtMQzt.Text = String.Empty;
            txtDolar.Text = String.Empty;
            txrtMQzts.Text = String.Empty;
            txtEuro.Text = String.Empty;
            txtCantidad.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "8009";
            TextBox[] Grupotextbox = { txrtMQzt, txtDolar , txtEuro };
            TextBox[] Idtextbox = { txrtMQzt };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dataGridView1;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dataGridView1, Grupotextbox, "Colchoneria");
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float MpnedaDolar, MonedaEuro, MonedaQuetzal;

            MpnedaDolar = float.Parse(txtDolar.Text);
            MonedaEuro = float.Parse(txtEuro.Text);
            MonedaQuetzal = float.Parse(txtEuro.Text);

            bool resultado = crud.InsertMoneda(MpnedaDolar, MonedaEuro, MonedaQuetzal);
            if (resultado)
            {
                string confirmacion = "Moneda Agregada Correctamente";
                MessageBox.Show(confirmacion);
            }
        }
    }
}
