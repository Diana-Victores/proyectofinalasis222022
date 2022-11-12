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
    public partial class ConsultaCCtas : Form
    {
        Capa_ControladorContabilidad.controlador ccon = new Capa_ControladorContabilidad.controlador();
        public ConsultaCCtas()
        {
            InitializeComponent();
        }

        private void bnt_consultarCierreCtas_Click(object sender, EventArgs e)
        {
            String cuenta, fecha;
            cuenta = cbo_boxctas.Text;
            fecha = dtime_consulta.Text;
            ConsultarCCuentas(cuenta,fecha,dgv_debe,dgv_haber,dtime_consulta.Text);
            ConsultarContador(txt_boxcodcont,txt_boxnamecont,fecha,cuenta);
            label3.Text = cuenta;
            Totales(dgv_debe, dgv_haber, txt_boxtotD, txt_boxtotH);
        }

        private void ConsultarContador(TextBox txt_boxcodcont, TextBox txt_boxnamecont, string fecha, string cuenta)
        {
            ccon.ConsultaConta(txt_boxcodcont,txt_boxnamecont,fecha,cuenta);
        }

        private void Totales(DataGridView dgv_debe, DataGridView dgv_haber, TextBox txt_boxtotD, TextBox txt_boxtotH)
        {
            float suma1 = 0;
            float suma2 = 0;
            foreach (DataGridViewRow row in dgv_debe.Rows)
            {
                if (row.Cells[2].Value != null) 
                    suma1 = (float)row.Cells[2].Value + suma1;
                txt_boxtotD.Text = suma1.ToString();
            }
            foreach (DataGridViewRow row in dgv_haber.Rows)
            {
                if (row.Cells[2].Value != null)
                    suma2 = (float)row.Cells[2].Value + suma2;
                txt_boxtotH.Text = suma2.ToString();
            }
        }

        private void ConsultarCCuentas(string cuenta, String fecha, DataGridView dgv_debe, DataGridView dgv_haber, string text)
        {
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            ccon.ConsultarCtas(cuenta,fecha, dt1,dt2,dtime_consulta);
            dgv_debe.DataSource = dt1;
            dgv_haber.DataSource = dt2;
        }

        private void ConsultaCCtas_Load(object sender, EventArgs e)
        {
            CargarCombo(cbo_boxctas);
        }

        private void CargarCombo(ComboBox cbo_boxctas)
        {
            ccon.CargarComboCtas(cbo_boxctas);
        }

        private void dtime_consulta_ValueChanged(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }
    }
}
