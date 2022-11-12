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
    public partial class ConsultaCGeneral : Form
    {
        Capa_ControladorContabilidad.controlador ccon = new Capa_ControladorContabilidad.controlador();
        public ConsultaCGeneral()
        {
            InitializeComponent();
        }

        private void ConsultaCGeneral_Load(object sender, EventArgs e)
        {

        }

        private void bnt_consultarCierreCtas_Click(object sender, EventArgs e)
        {
            String mes = "";
            String finicio = "";
            String ffin = "";
            mes = cbo_boxMes.Text;

            if (string.IsNullOrEmpty(mes))
            {
                String mensaje = "Error, debe seleccionar un mes para poder realizar la consulta. Intente de nuevo";
                MessageBox.Show(mensaje);
            }
            else
            {
                if (mes.Equals("Enero"))
                {
                    finicio = "2022-01-01";
                    ffin = "2022-01-31";
                }
                if (mes.Equals("Febrero"))
                {
                    finicio = "2022-02-01";
                    ffin = "2022-02-28";
                }
                if (mes.Equals("Marzo"))
                {
                    finicio = "2022-03-01";
                    ffin = "2022-03-31";
                }
                if (mes.Equals("Abril"))
                {
                    finicio = "2022-04-01";
                    ffin = "2022-04-30";
                }
                if (mes.Equals("Mayo"))
                {
                    finicio = "2022-05-01";
                    ffin = "2022-05-31";
                }
                if (mes.Equals("Junio"))
                {
                    finicio = "2022-06-01";
                    ffin = "2022-06-30";
                }
                if (mes.Equals("Julio"))
                {
                    finicio = "2022-07-01";
                    ffin = "2022-07-31";
                }
                if (mes.Equals("Agosto"))
                {
                    finicio = "2022-08-01";
                    ffin = "2022-08-31";
                }
                if (mes.Equals("Septiembre"))
                {
                    finicio = "2022-09-01";
                    ffin = "2022-09-30";
                }
                if (mes.Equals("Octubre"))
                {
                    finicio = "2022-10-01";
                    ffin = "2022-10-31";
                }
                if (mes.Equals("Noviembre"))
                {
                    finicio = "2022-11-01";
                    ffin = "2022-11-30";
                }
                if (mes.Equals("Diciembre"))
                {
                    finicio = "2022-12-01";
                    ffin = "2022-12-31";
                }
            }
            ConsultarCierreG(finicio, ffin, dgv_DebeCG, dgv_HaberCG);
            ConsultarContador(txt_boxcodcont,txt_boxnamecont,finicio,ffin);
            Totales(dgv_DebeCG, dgv_HaberCG, txt_boxtotD, txt_boxtotH);

            label5.Text = mes;
            }

        private void Totales(DataGridView dgv_DebeCG, DataGridView dgv_HaberCG, TextBox txt_boxtotD, TextBox txt_boxtotH)
        {
            float suma1 = 0;
            float suma2 = 0;
            foreach (DataGridViewRow row in dgv_DebeCG.Rows)
            {
                if (row.Cells[2].Value != null)
                    suma1 = (float)row.Cells[2].Value + suma1;
                txt_boxtotD.Text = suma1.ToString();
            }
            foreach (DataGridViewRow row in dgv_HaberCG.Rows)
            {
                if (row.Cells[2].Value != null)
                    suma2 = (float)row.Cells[2].Value + suma2;
                txt_boxtotH.Text = suma2.ToString();
            }
        }

        private void ConsultarContador(TextBox txt_boxcodcont, TextBox txt_boxnamecont, string finicio, string ffin)
        {
            ccon.ConsultaCont2(finicio,ffin,txt_boxcodcont,txt_boxnamecont);
        }

        private void ConsultarCierreG(string finicio, string ffin, DataGridView dgv_DebeCG, DataGridView dgv_HaberCG)
        {
            DataTable dt1 = new DataTable();
            DataTable dt2 = new DataTable();
            ccon.ConsultaCG(finicio,ffin,dt1,dt2);
            dgv_DebeCG.DataSource = dt1;
            dgv_HaberCG.DataSource = dt2;
        }

        private void dateTimePicker1_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
