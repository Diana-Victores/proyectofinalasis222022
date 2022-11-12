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
    //Jonathan Xuyá
    
    public partial class MantinimientoEstadosFinancieros : Form
    {
        public MantinimientoEstadosFinancieros()
        {
            InitializeComponent();
        }

        Capa_ControladorContabilidad.controlador crud = new Capa_ControladorContabilidad.controlador();
        private void button1_Click(object sender, EventArgs e)
        {
            bool resultado = crud.InsertEstado(textBox7.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox6.Text, textBox5.Text, textBox4.Text);
            if (resultado)
            {
                dataGridView1.Rows.Add(new object[] { textBox7.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox6.Text, textBox5.Text, textBox4.Text });
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool resultado = crud.UpdateEstado(textBox7.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox6.Text, textBox5.Text, textBox4.Text);
            if (resultado)
            {
                dataGridView1.Rows.Add(new object[] { textBox7.Text, textBox1.Text, textBox2.Text, textBox3.Text, textBox6.Text, textBox5.Text, textBox4.Text });
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            bool resultado = crud.DeleteEstado(textBox7.Text);
            if (resultado)
            {
                dataGridView1.Rows.Add(new object[] { textBox7.Text });
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
                    data = textBox1.Text;
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
            textBox1.Clear();
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
            crud.ActualizarE(table, dt);
            dataGridView1.DataSource = dt;
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
