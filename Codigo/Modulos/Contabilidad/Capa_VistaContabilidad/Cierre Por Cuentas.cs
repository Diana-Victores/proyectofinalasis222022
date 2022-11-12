using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

//Josue Amaya 0901-19-12421

namespace Capa_VistaContabilidad
{
    public partial class Cierre_Por_Cuentas : Form
    {
        Capa_ControladorContabilidad.controlador cn = new Capa_ControladorContabilidad.controlador();
        String ctaselected;
        float totalA = 0;
        float totalP = 0;

        public Cierre_Por_Cuentas()
        {
            InitializeComponent();
            CargarCuentas(dgv_ctas);
            groupBoxM.Enabled = false;
            groupBoxA.Enabled = false;
            CargarCuentas(dgv_ctas);
        }

        private void CargarCuentas(DataGridView dataGridView)
        {
            DataTable dt = new DataTable();
            cn.ctas(dt);
            dgv_ctas.DataSource = dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chckbox_manual_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxM.Enabled = true;

            if (groupBoxM.Enabled == true)
            {
                groupBoxA.Enabled = false;
            }
        }

        private void chckbox_auto_CheckedChanged(object sender, EventArgs e)
        {
            groupBoxA.Enabled = true;

            if (groupBoxA.Enabled == true)
            {
                groupBoxM.Enabled = false;
            }

        }

        private void bnt_closecta_Click(object sender, EventArgs e)
        {
            CierreXCtaConf cierrecta = new CierreXCtaConf();
            cierrecta.lbl_namecta.Text = ctaselected;
            cierrecta.txt_totact.Text = totalA.ToString(); ;
            cierrecta.txt_totpas.Text = totalP.ToString(); ;
            cierrecta.MdiParent = this.MdiParent;
            cierrecta.StartPosition = FormStartPosition.CenterScreen;
            cierrecta.Show();
        }

        private void btn_seleccionarcta_Click(object sender, EventArgs e)
        {
            ctaselected = dgv_ctas.CurrentCell.Value.ToString();
            lbl_cta.Text = ctaselected.ToString();
        }

        public void Cierre_Por_Cuentas_Load(object sender, EventArgs e)
        {
        } 

        private void btn_addactman_Click(object sender, EventArgs e)
        {
            String razon;
            float monto;
            String fecha;
            String cuenta;

            razon = txt_razonact.Text;
            monto = float.Parse(txt_montoact.Text);
            fecha = dateTimePicker1.Text;
            cuenta = lbl_cta.Text;

            bool resultado = cn.guardarcta(razon,monto,fecha,cuenta,null);
            if (resultado)
            {
                String confirmacion = "Movimiento Agregago Exitosamente";
                MessageBox.Show(confirmacion);
                totalA = totalA + monto;
                txt_razonact.Text = "";
                txt_montoact.Text = "";
            }
        }



        private void bnt_addpassman_Click(object sender, EventArgs e)
        {
            String razon;
            float monto;
            String fecha;
            String cuenta;

            razon = txt_razonpas.Text;
            monto = float.Parse(txt_montopas.Text);
            cuenta = lbl_cta.Text;
            fecha = dateTimePicker2.Text;
            bool resultado = cn.guardarctaP(null,razon,monto,cuenta,fecha);
            if (resultado)
            {
                String confirmacion = "Movimiento Agregago Exitosamente";
                MessageBox.Show(confirmacion);
                totalP = totalP + monto;
                txt_razonpas.Text = "";
                txt_montopas.Text = "";
            }

        }

        private void bnt_aceptact_Click(object sender, EventArgs e)
        {
            totalA = float.Parse(txt_totact.Text);
        }

        private void bnt_consultarCierreCtas_Click(object sender, EventArgs e)
        {
            ConsultaCCtas cctas = new ConsultaCCtas();
            cctas.MdiParent = this.MdiParent;
            cctas.StartPosition = FormStartPosition.CenterScreen;
            cctas.Show();
        }

        private void bnt_aceptpass_Click(object sender, EventArgs e)
        {
            totalP = float.Parse(txt_totpas.Text);
        }
    }
}
