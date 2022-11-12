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
    public partial class CierreXCtaConf : Form
    {
        Capa_ControladorContabilidad.controlador cn = new Capa_ControladorContabilidad.controlador();
        public CierreXCtaConf()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void CierreXCtaConf_Load(object sender, EventArgs e)
        {
           
        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            lbl_namecta.Text = "Nombre Cuenta";
            txt_totact.Text = "";
            txt_totpas.Text = "";
            txt_codcont.Text = "";
            txt_namecont.Text = "";
            txt_dateclose.Text = "";
        }

        private void bnt_savectas_Click(object sender, EventArgs e)
        {
            float totp, totac;
            string cod, name, fec, cuenta;

            cuenta = lbl_namecta.Text;
            totp = float.Parse(txt_totpas.Text);
            totac = float.Parse(txt_totact.Text);
            cod = txt_codcont.Text;
            name = txt_namecont.Text;
            fec = txt_dateclose.Text;

            bool resultado = cn.confcierre(null, cuenta, totp, totac, cod, name, fec);
            if (resultado)
            {
                String confirmacion = "Cierre De Cuenta : " + cuenta + " Cerrado Exitosamente ";
                MessageBox.Show(confirmacion);
                lbl_namecta.Text = "Cuenta";
                txt_totpas.Text = "";
                txt_totact.Text = "";
                txt_codcont.Text = "";
                txt_namecont.Text = "";
            }
        }
    }
}
