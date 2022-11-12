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
    public partial class EstadosFinancieros: Form
    {
        public EstadosFinancieros()
        {
            InitializeComponent();
        }
        Capa_ControladorContabilidad.controlador crud = new Capa_ControladorContabilidad.controlador();
        private void button1_Click(object sender, EventArgs e)
        {
            float _Pk, _Edi, _Mue, _Equi, _Maqui, _Herra, _Eqco;


            _Pk = float.Parse(textBox7.Text);
            _Edi = float.Parse(textBox1.Text);
            _Mue = float.Parse(textBox2.Text);
            _Equi = float.Parse(textBox3.Text);
            _Maqui = float.Parse(textBox6.Text);
            _Herra = float.Parse(textBox5.Text);
            _Eqco = float.Parse(textBox4.Text);

            bool resultado = crud.InsertEF(_Pk, _Edi, _Mue, _Equi, _Maqui, _Herra, _Eqco);
            if (resultado)
            {
                MessageBox.Show("Dartos ingresados");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            float _Pk, _Edi, _Mue, _Equi, _Maqui, _Herra, _Eqco;


            _Pk = float.Parse(textBox7.Text);
            _Edi = float.Parse(textBox1.Text);
            _Mue = float.Parse(textBox2.Text);
            _Equi = float.Parse(textBox3.Text);
            _Maqui = float.Parse(textBox6.Text);
            _Herra = float.Parse(textBox5.Text);
            _Eqco = float.Parse(textBox4.Text);

            bool resultado = crud.UpdateEF(_Pk, _Edi, _Mue, _Equi, _Maqui, _Herra, _Eqco);
            if (resultado)
            {
                MessageBox.Show("Dartos ingresados");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            float _Pk;


            _Pk = float.Parse(textBox7.Text);

            bool resultado = crud.DeleteEF(_Pk);
            if (resultado)
            {
                MessageBox.Show("Dartos ingresados");
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            String col = "";
            String data = "";
            if (string.IsNullOrEmpty(textBox7.Text))
            {
                if (string.IsNullOrEmpty(textBox1.Text))
                {
                    if (string.IsNullOrEmpty(textBox2.Text))
                    {
                        if (string.IsNullOrEmpty(textBox3.Text))
                        {
                            if (string.IsNullOrEmpty(textBox6.Text))
                            {
                                if (string.IsNullOrEmpty(textBox5.Text))
                                {
                                    if (string.IsNullOrEmpty(textBox4.Text))
                                    {
                                        String textalert = " El campo buscar, se encuentra vacio. Debe llenar un solo campo para realizar la busqueda";
                                        MessageBox.Show(textalert);
                                    }
                                    else
                                    {
                                        data = textBox4.Text;
                                        col = "EquipoComputo";
                                    }
                                }
                                else
                                {
                                    data = textBox5.Text;
                                    col = "Herramientas";
                                }
                            }
                            else
                            {
                                data = textBox6.Text;
                                col = "Maquinaria";
                            }
                        }
                        else
                        {
                            data = textBox3.Text;
                            col = "Equipos";
                        }
                    }
                    else
                    {
                        data = textBox2.Text;
                        col = "Muebles";
                    }
                }
                else
                {
                    data = textBox7.Text;
                    col = "Edificaciones";
                }
            }
            else
            {
                data = textBox7.Text;
                col = "Codigo";
            }
            DataTable dt = new DataTable();
            //crud.BuscarProducto(data, col, dt);
            crud.BuscarDato(data, col, dt);
            dataGridView1.DataSource = dt;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            
            textBox2.Clear();
            textBox3.Clear();
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            textBox7.Clear();
        }

        private void btn_actualizar_Click(object sender, EventArgs e)
        {
            String table = "";
            DataTable dt = new DataTable();
            table = "tbl_EstadosFinancieros";
            crud.ActualizarEF(table, dt);
            dataGridView1.DataSource = dt;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
    
}
