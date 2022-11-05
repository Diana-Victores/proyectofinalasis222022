﻿/*Diana Victores
 9959-19-1471
Mantenimiento Cuentas*/

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
    public partial class MantenimientoCuentas : Form
    {
        controlador cn = new controlador();
        public MantenimientoCuentas()
        {
            InitializeComponent();
        }

        private void navegador1_Load(object sender, EventArgs e)
        {
            NavegadorVista.Navegador.idApp = "8002";
            TextBox[] Grupotextbox = { textIDCuenta, textTCuenta,
                textNombreCuenta,textCargo, textAbono, textSaldo, textStatus };
            TextBox[] Idtextbox = { textIDCuenta, textTCuenta };
            navegador1.textbox = Grupotextbox;
            navegador1.tabla = dgvCuentasM;
            navegador1.textboxi = Idtextbox;
            navegador1.actual = this;
            navegador1.cargar(dgvCuentasM, Grupotextbox, "colchoneria");
        }

        private void btnTCuenta_Click(object sender, EventArgs e)
        {
            cn.llenarcombo("tbl_tipocuenta", cboTCuneta, 1);
        }

        private void btnTipoCuenta_Click(object sender, EventArgs e)
        {
            cn.llenarcombo("tbl_cuentas", cboNombreCuenta, 2);
        }

        private void cboTCuneta_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tamaño = cboTCuneta.Items.Count;


            for (int x = 0; x < tamaño; x++)
            {
                if (cboTCuneta.SelectedIndex.Equals(x))
                {
                    textTCuenta.Text = Convert.ToString(cboTCuneta.SelectedItem);
                }
            }
        }

        private void cboNombreCuenta_SelectedIndexChanged(object sender, EventArgs e)
        {
            int tamaño = cboNombreCuenta.Items.Count;


            for (int x = 0; x < tamaño; x++)
            {
                if (cboNombreCuenta.SelectedIndex.Equals(x))
                {
                    textNombreCuenta.Text = Convert.ToString(cboNombreCuenta.SelectedItem);
                }
            }
        }

        private void MantenimientoCuentas_Load(object sender, EventArgs e)
        {
            cn.llenarcombo("tbl_tipocuenta", cboTCuneta, 1);
            cn.llenarcombo("tbl_cuentas", cboNombreCuenta, 2);
        }
    }
}
