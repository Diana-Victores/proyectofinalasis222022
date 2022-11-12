
namespace Capa_VistaContabilidad
{
    partial class ConsultaCGeneral
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
            this.bnt_consultarCierreCtas = new FontAwesome.Sharp.IconButton();
            this.label2 = new System.Windows.Forms.Label();
            this.cbo_boxMes = new System.Windows.Forms.ComboBox();
            this.dgv_DebeCG = new System.Windows.Forms.DataGridView();
            this.dgv_HaberCG = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txt_boxnamecont = new System.Windows.Forms.TextBox();
            this.txt_boxcodcont = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_boxtotH = new System.Windows.Forms.TextBox();
            this.txt_boxtotD = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DebeCG)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HaberCG)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // bnt_consultarCierreCtas
            // 
            this.bnt_consultarCierreCtas.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.bnt_consultarCierreCtas.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.bnt_consultarCierreCtas.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bnt_consultarCierreCtas.IconSize = 45;
            this.bnt_consultarCierreCtas.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.bnt_consultarCierreCtas.Location = new System.Drawing.Point(663, 18);
            this.bnt_consultarCierreCtas.Name = "bnt_consultarCierreCtas";
            this.bnt_consultarCierreCtas.Size = new System.Drawing.Size(75, 68);
            this.bnt_consultarCierreCtas.TabIndex = 36;
            this.bnt_consultarCierreCtas.Text = "Consultar Cierre";
            this.bnt_consultarCierreCtas.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bnt_consultarCierreCtas.UseVisualStyleBackColor = true;
            this.bnt_consultarCierreCtas.Click += new System.EventHandler(this.bnt_consultarCierreCtas_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(188, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(129, 20);
            this.label2.TabIndex = 38;
            this.label2.Text = "Seleccione Mes :";
            // 
            // cbo_boxMes
            // 
            this.cbo_boxMes.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_boxMes.FormattingEnabled = true;
            this.cbo_boxMes.Items.AddRange(new object[] {
            "Enero",
            "Febrero",
            "Marzo",
            "Abril",
            "Mayo",
            "Junio",
            "Julio",
            "Agosto",
            "Septiembre",
            "Octubre",
            "Noviembre",
            "Diciembre"});
            this.cbo_boxMes.Location = new System.Drawing.Point(353, 37);
            this.cbo_boxMes.Name = "cbo_boxMes";
            this.cbo_boxMes.Size = new System.Drawing.Size(146, 21);
            this.cbo_boxMes.TabIndex = 40;
            // 
            // dgv_DebeCG
            // 
            this.dgv_DebeCG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_DebeCG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_DebeCG.Location = new System.Drawing.Point(18, 73);
            this.dgv_DebeCG.Name = "dgv_DebeCG";
            this.dgv_DebeCG.Size = new System.Drawing.Size(357, 150);
            this.dgv_DebeCG.TabIndex = 41;
            // 
            // dgv_HaberCG
            // 
            this.dgv_HaberCG.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgv_HaberCG.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_HaberCG.Location = new System.Drawing.Point(381, 73);
            this.dgv_HaberCG.Name = "dgv_HaberCG";
            this.dgv_HaberCG.Size = new System.Drawing.Size(357, 150);
            this.dgv_HaberCG.TabIndex = 42;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(251, 16);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(177, 25);
            this.label3.TabIndex = 44;
            this.label3.Text = "Cierre Contable";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 25);
            this.label1.TabIndex = 43;
            this.label1.Text = "DEBE";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(532, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(89, 25);
            this.label4.TabIndex = 45;
            this.label4.Text = "HABER";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.bnt_consultarCierreCtas);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.cbo_boxMes);
            this.groupBox1.Location = new System.Drawing.Point(25, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(749, 92);
            this.groupBox1.TabIndex = 46;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Datos Consulta";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.txt_boxtotH);
            this.groupBox2.Controls.Add(this.txt_boxtotD);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.dgv_HaberCG);
            this.groupBox2.Controls.Add(this.dgv_DebeCG);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Location = new System.Drawing.Point(25, 124);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(749, 326);
            this.groupBox2.TabIndex = 47;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Resultado Consulta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(434, 16);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(56, 25);
            this.label5.TabIndex = 46;
            this.label5.Text = "Mes";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txt_boxnamecont);
            this.groupBox3.Controls.Add(this.txt_boxcodcont);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Location = new System.Drawing.Point(18, 261);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(720, 47);
            this.groupBox3.TabIndex = 47;
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
            this.txt_boxtotH.Location = new System.Drawing.Point(638, 229);
            this.txt_boxtotH.Name = "txt_boxtotH";
            this.txt_boxtotH.ReadOnly = true;
            this.txt_boxtotH.Size = new System.Drawing.Size(100, 20);
            this.txt_boxtotH.TabIndex = 51;
            // 
            // txt_boxtotD
            // 
            this.txt_boxtotD.Location = new System.Drawing.Point(275, 229);
            this.txt_boxtotD.Name = "txt_boxtotD";
            this.txt_boxtotD.ReadOnly = true;
            this.txt_boxtotD.Size = new System.Drawing.Size(100, 20);
            this.txt_boxtotD.TabIndex = 50;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(561, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(77, 13);
            this.label7.TabIndex = 49;
            this.label7.Text = "Total HABER :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(200, 232);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 48;
            this.label6.Text = "Total DEBE :";
            // 
            // ConsultaCGeneral
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(800, 462);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "ConsultaCGeneral";
            this.Text = "ConsultaCGeneral";
            this.Load += new System.EventHandler(this.ConsultaCGeneral_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_DebeCG)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_HaberCG)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private FontAwesome.Sharp.IconButton bnt_consultarCierreCtas;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cbo_boxMes;
        private System.Windows.Forms.DataGridView dgv_DebeCG;
        private System.Windows.Forms.DataGridView dgv_HaberCG;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
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