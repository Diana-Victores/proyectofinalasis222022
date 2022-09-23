using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Controlador;
using System.Data.Odbc;

namespace BusquedaInteligente
{
    public partial class Busqueda : Form
    {
        OdbcConnection cn = new OdbcConnection("Dsn=Colchoneria");
        string campo = "";
        string csimple = "";
        string where = "";
        string and = "";
        string group = "";
        string final = "";
        string orden = "";

        public Busqueda()
        {
            InitializeComponent();
        }


        /*private void button1_Click(object sender, EventArgs e)
         {
             bool resultado = crud.InsertBusqueda(textBox12.Text, textBox14.Text, textBox15.Text, textBox11.Text);
             if (resultado)
             {
                 MessageBox.Show("Datos guardados");
             }
         }
        */
        //CRUD crud = new CRUD();

        private void ConsultasInteligentes_Load(object sender, EventArgs e)
        {

            llenarcboquery();
            llenarcomboeditar();
        }

        public void llenarcomboeditar()
        {
            //OdbcConnection cn = new OdbcConnection("Dsn=Colchoneria");
            //cn.Open();
            //cbonombreconsulta.Items.Clear();
            //OdbcDataReader datareader = cn.llenarcbonombreconsulta();
            //while (datareader.Read())
            //{
            //    cbonombreconsulta.Items.Add(datareader[0].ToString());
            //    cn.Close();
            //}
        }
        private void cbonombreconsulta_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtNombreConsulta.Text = cbonombreconsulta.SelectedItem.ToString();
            groupBox2.Enabled = true;

        }

        private void cboTablaConsultaSimple_SelectedIndexChanged(object sender, EventArgs e)
        {
            //txttablaeditar.Text = cboTablaConsultaSimple.SelectedItem.ToString();
            //llenarcombosactualizar();
            //chkSelectTodosConsultaSimple.Enabled = true;
        }

        public void tablaseditar()
        {
            //cboTabla.Items.Clear();
            //OdbcDataReader datareader = cn.llenarcbo();
            //while (datareader.Read())
            //{
            //    //cboTablaConsultaSimple.Items.Add(datareader[0].ToString());
            //}
        }
        private void chkSelectTodosConsultaSimple_CheckedChanged(object sender, EventArgs e)
        {

            //if (chkSelectTodosConsultaSimple.Checked == true)
            //{
            //    txtAliasEDITAR.Text = "";
            //    txtAliasEDITAR.Enabled = false;
            //    cboxCampoEDTR.Text = "";
            //    cboxCampoEDTR.Enabled = false;
            //    txtcamposelectoseditar.Text = "";
            //}
            //else
            //{
            //    txtAliasEDITAR.Text = "";
            //    txtAliasEDITAR.Enabled = true;
            //    cboxCampoEDTR.Text = "";
            //    cboxCampoEDTR.Enabled = true;
            //}
        }

        private void chkcondicioneseditar_CheckedChanged(object sender, EventArgs e)
        {
            //if ((chkcondicioneseditar.Checked == true) && (csimpleeditar != ""))
            //{
            //    groupBox3.Enabled = true;
            //    groupBox6.Enabled = true;
            //}
            //else
            //{
            //    groupBox3.Enabled = false;
            //    groupBox6.Enabled = false;
            //    chkcondicioneseditar.Checked = false;
            //}
        }

        private void comboBox7_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (comboBox7.SelectedIndex == 1)
            {
                panel2.Enabled = true;
            }
            else
            {
                panel2.Enabled = false;
                radioButton2.Checked = false;
                radioButton1.Checked = false;
            }
        }

        string query = "registro_consultas";
        public void llenarcboquery()
        {
            //comboBox9.Items.Clear();
            //cbocopiaquery.Items.Clear();
            //OdbcDataReader datareader = cn.llenarcboq(query);
            //while (datareader.Read())
            //{
            //    comboBox9.Items.Add(datareader[0].ToString());
            //    cbocopiaquery.Items.Add(datareader[1].ToString());
            //}
        }
        private void btnNuevo_Click(object sender, EventArgs e)
        {
            //bool resultado = crud.InsertBusqueda(textBox12.Text, textBox14.Text, textBox15.Text, textBox11.Text);
            //if (resultado)
            {
                MessageBox.Show("Datos guardados");
            }

        }

        private void iconButton7_Click(object sender, EventArgs e)
        {
            //textBox12.Clear();
            //textBox14.Clear();
            //textBox15.Clear();
            //textBox11.Clear();


        }

        //CRUDC crudc = new CRUDC();
        private void iconButton3_Click(object sender, EventArgs e)
        {
            //bool resultado = crudc.InsertBusquedaCompleja(textBox16.Text, textBox17.Text, textBox10.Text);
            //if (resultado)
            {
                MessageBox.Show("Datos guardados");
            }
        }

        private void iconButton8_Click(object sender, EventArgs e)
        {
            textBox16.Clear();
            //textBox17.Clear();
            textBox10.Clear();

        }

        private void iconButton4_Click(object sender, EventArgs e)
        {

            {
                MessageBox.Show("Datos guardados");
            }
        }

        private void iconButton9_Click(object sender, EventArgs e)
        {
            //textBox18.Clear();
            //textBox19.Clear();
            textBox9.Clear();
        }

        private void iconButton5_Click(object sender, EventArgs e)
        {
            {

                {
                    MessageBox.Show("Datos guardados");
                }
            }
        }

        private void iconButton10_Click(object sender, EventArgs e)
        {
            //textBox20.Clear();
            //textBox21.Clear();
            textBox8.Clear();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            //textBox20.Clear();
            //textBox21.Clear();
            //textBox8.Clear();
            //textBox18.Clear();
            //textBox19.Clear();
            //textBox9.Clear();
            //textBox16.Clear();
            //textBox17.Clear();
            //textBox10.Clear();
            //textBox12.Clear();
            //textBox14.Clear();
            //textBox15.Clear();
            //textBox11.Clear();

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (e.RowIndex != -1)
                {
                    if (dataGridView1.Columns[e.ColumnIndex].Name == "ColumnDgvModificar")
                    {
                        //textBox1.Text = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        txtAliasEDITAR.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
                        txtNombreConsulta.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
                        dataGridView1.Rows.RemoveAt(e.RowIndex);
                    }

                    if (dataGridView1.Columns[e.ColumnIndex].Name == "ColumnDgvElimnar")
                    {
                        string ope = dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString();
                        //bool resultado = CRUD.EliminarBusqueda(ope);
                        //if (resultado)
                        {
                            dataGridView1.Rows.RemoveAt(e.RowIndex);
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void panel18_Paint(object sender, PaintEventArgs e)
        {

        }

        private void iconButton2_Click(object sender, EventArgs e)
        {

        }
        //se necesita actualizaciones para terminar boton eliminar
        //Diana Victores 9959-19-1471
        public void actualizaconsultas()
        {

        }

        //boton eliminar
        //diana victores

        private void iconButton12_Click(object sender, EventArgs e)
        {
            //cn.ejecutarconsulta(textConsultaBusqueda.Text);
            //MessageBox.Show("Las consultas con nombre " + textConsultaBusqueda.Text + " Han sido eliminadas");
            //actualizaconsultas();

            //textConsultaBusqueda.Text = "";
        }

        private void iconButton11_Click(object sender, EventArgs e)
        {
            finalEditar = csimpleEditar + " " + whereEditar + " " + andEditar + " " + groupEditar + ";";
            if (csimpleEditar == "")
            {
                MessageBox.Show("Consulta incorrecta");
            }
            else
            {
                MessageBox.Show("Consulta Almacenada");
                //cn.textBox10(txtNombreConsulta.Text, finalEditar);
                llenarcboquery();
            }
            textBox10.Text = "";
            chkcondicioneseditar.Checked = false;
            richTextBox2.Text = "";
            txtAliasEDITAR.Text = "";
            transfiera = "";
            csimpleEditar = "";
            whereEditar = "";
            andEditar = "";
            groupEditar = "";
            cbonombreconsulta.Text = "";
            cbonombreconsulta.Enabled = true;

        }
        string transfiera = "";
        string camposeditar = "";
        string csimpleEditar = "";
        string whereEditar = "";
        string andEditar = "";
        string ordenEditar = "";
        string groupEditar = "";
        string finalEditar = "";
        private void iconButton26_Click(object sender, EventArgs e)
        {
            transfiera = textConsultaBusqueda.Text;
            cbonombreconsulta.Text = transfiera;
            txtNombreConsulta.Text = transfiera;
            groupBox2.Enabled = true;
            panel20.Hide();
            panel1.Show();

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
    }
}



