
namespace Capa_VistaContabilidad
{
    partial class ConsultaCCtas
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.bnt_consultarCierreCtas = new FontAwesome.Sharp.IconButton();
            this.dtime_consulta = new System.Windows.Forms.DateTimePicker();
            this.cbo_boxctas = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_boxnamecont = new System.Windows.Forms.TextBox();
            this.txt_boxcodcont = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_boxtotH = new System.Windows.Forms.TextBox();
            this.txt_boxtotD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgv_haber = new System.Windows.Forms.DataGridView();
            this.dgv_debe = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_haber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_debe)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bnt_consultarCierreCtas);
            this.groupBox1.Controls.Add(this.dtime_consulta);
            this.groupBox1.Controls.Add(this.cbo_boxctas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(33, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(733, 94);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Busqueda";
            // 
            // bnt_consultarCierreCtas
            // 
            this.bnt_consultarCierreCtas.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.bnt_consultarCierreCtas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.bnt_consultarCierreCtas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bnt_consultarCierreCtas.IconSize = 45;
            this.bnt_consultarCierreCtas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bnt_consultarCierreCtas.Location = new System.Drawing.Point(652, 19);
            this.bnt_consultarCierreCtas.Name = "bnt_consultarCierreCtas";
            this.bnt_consultarCierreCtas.Size = new System.Drawing.Size(75, 68);
            this.bnt_consultarCierreCtas.TabIndex = 36;
            this.bnt_consultarCierreCtas.Text = "Consultar Cierre";
            this.bnt_consultarCierreCtas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bnt_consultarCierreCtas.UseVisualStyleBackColor = true;
            this.bnt_consultarCierreCtas.Click += new System.EventHandler(this.bnt_consultarCierreCtas_Click);
            // 
            // dtime_consulta
            // 
            this.dtime_consulta.CustomFormat = "yyyy-MM-dd";
            this.dtime_consulta.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtime_consulta.Location = new System.Drawing.Point(426, 37);
            this.dtime_consulta.Name = "dtime_consulta";
            this.dtime_consulta.Size = new System.Drawing.Size(117, 20);
            this.dtime_consulta.TabIndex = 3;
            this.dtime_consulta.ValueChanged += new System.EventHandler(this.dtime_consulta_ValueChanged);
            // 
            // cbo_boxctas
            // 
            this.cbo_boxctas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_boxctas.FormattingEnabled = true;
            this.cbo_boxctas.Location = new System.Drawing.Point(127, 35);
            this.cbo_boxctas.Name = "cbo_boxctas";
            this.cbo_boxctas.Size = new System.Drawing.Size(151, 21);
            this.cbo_boxctas.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(330, 44);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(90, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Fecha De Cierre :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(21, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Seleccione Cuenta:";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.txt_boxtotH);
            this.groupBox2.Controls.Add(this.txt_boxtotD);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.dgv_haber);
            this.groupBox2.Controls.Add(this.dgv_debe);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(33, 113);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(733, 325);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultados Busqueda";
            this.groupBox2.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_boxnamecont);
            this.groupBox3.Controls.Add(this.txt_boxcodcont);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(24, 260);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(687, 47);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Datos Responsable";
            // 
            // txt_boxnamecont
            // 
            this.txt_boxnamecont.Location = new System.Drawing.Point(499, 18);
            this.txt_boxnamecont.Name = "txt_boxnamecont";
            this.txt_boxnamecont.ReadOnly = true;
            this.txt_boxnamecont.Size = new System.Drawing.Size(143, 20);
            this.txt_boxnamecont.TabIndex = 12;
            // 
            // txt_boxcodcont
            // 
            this.txt_boxcodcont.Location = new System.Drawing.Point(210, 15);
            this.txt_boxcodcont.Name = "txt_boxcodcont";
            this.txt_boxcodcont.ReadOnly = true;
            this.txt_boxcodcont.Size = new System.Drawing.Size(121, 20);
            this.txt_boxcodcont.TabIndex = 11;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(112, 21);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(92, 13);
            this.label8.TabIndex = 7;
            this.label8.Text = "Codigo Contador :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(397, 22);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(96, 13);
            this.label9.TabIndex = 8;
            this.label9.Text = "Nombre Contador :";
            // 
            // txt_boxtotH
            // 
            this.txt_boxtotH.Location = new System.Drawing.Point(611, 229);
            this.txt_boxtotH.Name = "txt_boxtotH";
            this.txt_boxtotH.ReadOnly = true;
            this.txt_boxtotH.Size = new System.Drawing.Size(100, 20);
            this.txt_boxtotH.TabIndex = 10;
            // 
            // txt_boxtotD
            // 
            this.txt_boxtotD.Location = new System.Drawing.Point(264, 229);
            this.txt_boxtotD.Name = "txt_boxtotD";
            this.txt_boxtotD.ReadOnly = true;
            this.txt_boxtotD.Size = new System.Drawing.Size(100, 20);
            this.txt_boxtotD.TabIndex = 9;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(534, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Total HABER :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(189, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Total DEBE :";
            // 
            // dgv_haber
            // 
            this.dgv_haber.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_haber.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_haber.Location = new System.Drawing.Point(376, 73);
            this.dgv_haber.Name = "dgv_haber";
            this.dgv_haber.Size = new System.Drawing.Size(335, 150);
            this.dgv_haber.TabIndex = 4;
            // 
            // dgv_debe
            // 
            this.dgv_debe.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_debe.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_debe.Location = new System.Drawing.Point(24, 73);
            this.dgv_debe.Name = "dgv_debe";
            this.dgv_debe.Size = new System.Drawing.Size(340, 150);
            this.dgv_debe.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(512, 46);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 24);
            this.label5.TabIndex = 2;
            this.label5.Text = "HABER";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(173, 46);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(65, 24);
            this.label4.TabIndex = 1;
            this.label4.Text = "DEBE";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(315, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 24);
            this.label3.TabIndex = 0;
            this.label3.Text = "CUENTA ";
            // 
            // ConsultaCCtas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConsultaCCtas";
            this.Text = "Consulta Cierre Por Cuentas";
            this.Load += new System.EventHandler(this.ConsultaCCtas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_haber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_debe)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.DateTimePicker dtime_consulta;
        private System.Windows.Forms.ComboBox cbo_boxctas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dgv_haber;
        private System.Windows.Forms.DataGridView dgv_debe;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton bnt_consultarCierreCtas;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txt_boxnamecont;
        private System.Windows.Forms.TextBox txt_boxcodcont;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txt_boxtotH;
        private System.Windows.Forms.TextBox txt_boxtotD;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
    }
}