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
    public partial class ProcesoPresupuesto : Form
    {
        public ProcesoPresupuesto()
        {
            InitializeComponent();
        }
        Capa_ControladorContabilidad.controlador crud = new Capa_ControladorContabilidad.controlador();
        float gt, gs, gm;


        private void button1_Click_1(object sender, EventArgs e)
        {
            String Mes;
            float gastosCorrientes, gastosPersol, gastosFinancieros, TransferenciaCorriente, TransferenciaCapital, ActivosFijos, ActivosFinancieros, PasivosFinancieros, Total_Presupuesto;

            Mes = dtime_act.Text;
            gastosCorrientes = float.Parse(textBox2.Text);
            gastosPersol = float.Parse(textBox3.Text);
            gastosFinancieros = float.Parse(textBox4.Text);
            TransferenciaCorriente = float.Parse(textBox5.Text);
            TransferenciaCapital = float.Parse(textBox6.Text);
            ActivosFijos = float.Parse(textBox7.Text);
            ActivosFinancieros = float.Parse(textBox8.Text);
            PasivosFinancieros = float.Parse(textBox9.Text);
            Total_Presupuesto = float.Parse(textBox9.Text);

            bool resultado = crud.InsertPres(null, Mes, gastosCorrientes, gastosPersol, gastosFinancieros, TransferenciaCorriente, TransferenciaCapital, ActivosFijos, ActivosFinancieros, PasivosFinancieros, Total_Presupuesto);
            if (resultado)
            {
                string confirmacion = "Presupuesto Agregado Correctamente";
                MessageBox.Show(confirmacion);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            String Mes;
            float gastosCorrientes, gastosPersol, gastosFinancieros, TransferenciaCorriente, TransferenciaCapital, ActivosFijos, ActivosFinancieros, PasivosFinancieros, Total_Presupuesto;

            Mes = dtime_act.Text;
            gastosCorrientes = float.Parse(textBox2.Text);
            gastosPersol = float.Parse(textBox3.Text);
            gastosFinancieros = float.Parse(textBox4.Text);
            TransferenciaCorriente = float.Parse(textBox5.Text);
            TransferenciaCapital = float.Parse(textBox6.Text);
            ActivosFijos = float.Parse(textBox7.Text);
            ActivosFinancieros = float.Parse(textBox8.Text);
            PasivosFinancieros = float.Parse(textBox9.Text);
            Total_Presupuesto = float.Parse(textBox9.Text);

            bool resultado = crud.UpdatePres(null, Mes, gastosCorrientes, gastosPersol, gastosFinancieros, TransferenciaCorriente, TransferenciaCapital, ActivosFijos, ActivosFinancieros, PasivosFinancieros, Total_Presupuesto);
            if (resultado)
            {
                string confirmacion = "Presupuesto Agregado Correctamente";
                MessageBox.Show(confirmacion);
            }

        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool resultado = crud.DeletePres(dtime_act.Text);
            if (resultado)
            {
                String table = "";
                DataTable dt = new DataTable();
                table = "tbl_presupuesto";
                crud.ActualizarT(table, dt);
                dataGridView1.DataSource = dt;
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            String table = "";
            DataTable dt = new DataTable();
            table = "tbl_presupuesto";
            crud.ActualizarPres(table, dt);
            dataGridView1.DataSource = dt;
        }

        private void PocesoPresupuesto_Load(object sender, EventArgs e)
        {
            total.Text = "0.00";
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {
           
            gt = float.Parse(textBox2.Text);
            gs = float.Parse(total.Text);
            gm = gt + gs;
            total.Text = gm.ToString();
        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {
           
            gt = float.Parse(textBox3.Text);
            gs = float.Parse(total.Text);
            gm = gt + gs;
            total.Text = gm.ToString();
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            
            gt = float.Parse(textBox4.Text);
            gs = float.Parse(total.Text);
            gm = gt + gs;
            total.Text = gm.ToString();
        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {
            
            gt = float.Parse(textBox5.Text);
            gs = float.Parse(total.Text);
            gm = gt + gs;
            total.Text = gm.ToString();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
            gt = float.Parse(textBox6.Text);
            gs = float.Parse(total.Text);
            gm = gt + gs;
            total.Text = gm.ToString();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {
            
            gt = float.Parse(textBox7.Text);
            gs = float.Parse(total.Text);
            gm = gt + gs;
            total.Text = gm.ToString();
        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            
            gt = float.Parse(textBox8.Text);
            gs = float.Parse(total.Text);
            gm = gt + gs;
            total.Text = gm.ToString();
        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {
            
            gt = float.Parse(textBox9.Text);
            gs = float.Parse(total.Text);
            gm = gt + gs;
            total.Text = gm.ToString();
        }
    }
}
