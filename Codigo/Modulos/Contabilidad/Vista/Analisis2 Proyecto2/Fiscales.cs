using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Analisis2_Proyecto2
{
    public partial class Fiscales : MetroFramework.Forms.MetroForm
    {
        public Fiscales()
        {
            InitializeComponent();
        }

        private void Fiscales_Load(object sender, EventArgs e)
        {

        }

        private void btnMenuP_Click(object sender, EventArgs e)
        {
            this.Hide();
            ContenedorCF contenedor = new ContenedorCF();
            contenedor.Show();
        }
    }
}
