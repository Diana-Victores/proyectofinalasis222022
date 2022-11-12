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

        //private void navegador1_Load(object sender, EventArgs e)
        //{
        //    NavegadorVista.Navegador.idApp = "8009";
        //    TextBox[] Grupotextbox = { txrtMQzt, txtDolar , txtEuro };
        //    TextBox[] Idtextbox = { txrtMQzt };
        //    navegador1.textbox = Grupotextbox;
        //    navegador1.tabla = dataGridView1;
        //    navegador1.textboxi = Idtextbox;
        //    navegador1.actual = this;
        //    navegador1.cargar(dataGridView1, Grupotextbox, "Colchoneria");
        //}

        private void button1_Click(object sender, EventArgs e)
        {
            double quetzales, dolar, euro;
            try
            {
                quetzales = Convert.ToDouble(textBox1.Text);
                dolar = quetzales / 0.13;
                euro = quetzales / 0.13;
                textBox2.Text = quetzales.ToString();
                textBox4.Text = quetzales.ToString();
                textBox3.Text = dolar.ToString();
                textBox5.Text = euro.ToString();
            }
            catch (Exception error)
            {
                MessageBox.Show(error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = String.Empty;
            textBox2.Text = String.Empty;
            textBox3.Text = String.Empty;
            textBox4.Text = String.Empty;
            textBox5.Text = String.Empty;
            textBox1.Focus();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("¿Desea salir?", "Confirmar salida", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            float MpnedaDolar, MonedaEuro, MonedaQuetzal;

            MpnedaDolar = float.Parse(textBox3.Text);
            MonedaEuro = float.Parse(textBox5.Text);
            MonedaQuetzal = float.Parse(textBox3.Text);

            bool resultado = crud.InsertMoneda(MpnedaDolar, MonedaEuro, MonedaQuetzal);
            if (resultado)
            {
                string confirmacion = "Moneda Agregada Correctamente";
                MessageBox.Show(confirmacion);
            }
        }
    }
}
