
namespace Capa_VistaContabilidad
{
    partial class MantenimientoDetallePolizaContable
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
            this.navegador1 = new NavegadorVista.Navegador();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.textIDOpe = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textFecha = new System.Windows.Forms.TextBox();
            this.textIDCuenta = new System.Windows.Forms.TextBox();
            this.textIDTPoliza = new System.Windows.Forms.TextBox();
            this.textConcepto = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textSaldo = new System.Windows.Forms.TextBox();
            this.textIDPoliza = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvPolizaDetalle = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizaDetalle)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.navegador1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(800, 219);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navegador";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // navegador1
            // 
            this.navegador1.Location = new System.Drawing.Point(12, 20);
            this.navegador1.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.navegador1.Name = "navegador1";
            this.navegador1.Size = new System.Drawing.Size(781, 180);
            this.navegador1.TabIndex = 0;
            this.navegador1.Load += new System.EventHandler(this.navegador1_Load);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textIDOpe);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.textFecha);
            this.groupBox2.Controls.Add(this.textIDCuenta);
            this.groupBox2.Controls.Add(this.textIDTPoliza);
            this.groupBox2.Controls.Add(this.textConcepto);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.textSaldo);
            this.groupBox2.Controls.Add(this.textIDPoliza);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.groupBox2.Location = new System.Drawing.Point(13, 252);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(793, 220);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(700, 20);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 3;
            this.button1.Text = "Ayuda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // textIDOpe
            // 
            this.textIDOpe.Location = new System.Drawing.Point(528, 109);
            this.textIDOpe.Name = "textIDOpe";
            this.textIDOpe.Size = new System.Drawing.Size(107, 21);
            this.textIDOpe.TabIndex = 19;
            this.textIDOpe.Tag = "Pk_TipoOperacion";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label1.Location = new System.Drawing.Point(385, 109);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(120, 17);
            this.label1.TabIndex = 18;
            this.label1.Text = "Tipo Operacion";
            // 
            // textFecha
            // 
            this.textFecha.Location = new System.Drawing.Point(96, 83);
            this.textFecha.Name = "textFecha";
            this.textFecha.Size = new System.Drawing.Size(255, 21);
            this.textFecha.TabIndex = 17;
            this.textFecha.Tag = "fechaPoliza";
            // 
            // textIDCuenta
            // 
            this.textIDCuenta.Location = new System.Drawing.Point(528, 77);
            this.textIDCuenta.Name = "textIDCuenta";
            this.textIDCuenta.Size = new System.Drawing.Size(107, 21);
            this.textIDCuenta.TabIndex = 16;
            this.textIDCuenta.Tag = "pkid_cuenta";
            // 
            // textIDTPoliza
            // 
            this.textIDTPoliza.Location = new System.Drawing.Point(528, 37);
            this.textIDTPoliza.Name = "textIDTPoliza";
            this.textIDTPoliza.Size = new System.Drawing.Size(107, 21);
            this.textIDTPoliza.TabIndex = 15;
            this.textIDTPoliza.Tag = "Pk_TipoPoliza";
            // 
            // textConcepto
            // 
            this.textConcepto.Location = new System.Drawing.Point(95, 110);
            this.textConcepto.Multiline = true;
            this.textConcepto.Name = "textConcepto";
            this.textConcepto.Size = new System.Drawing.Size(256, 67);
            this.textConcepto.TabIndex = 13;
            this.textConcepto.Tag = "concepto";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label6.Location = new System.Drawing.Point(425, 83);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(80, 17);
            this.label6.TabIndex = 11;
            this.label6.Text = "ID Cuenta";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label5.Location = new System.Drawing.Point(385, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(107, 17);
            this.label5.TabIndex = 8;
            this.label5.Text = "ID Tipo Poliza";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label4.Location = new System.Drawing.Point(18, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 17);
            this.label4.TabIndex = 7;
            this.label4.Text = "ID Poliza";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label3.Location = new System.Drawing.Point(456, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 17);
            this.label3.TabIndex = 6;
            this.label3.Text = "Saldo";
            // 
            // textSaldo
            // 
            this.textSaldo.Location = new System.Drawing.Point(528, 136);
            this.textSaldo.Name = "textSaldo";
            this.textSaldo.Size = new System.Drawing.Size(107, 21);
            this.textSaldo.TabIndex = 4;
            this.textSaldo.Tag = "saldo";
            // 
            // textIDPoliza
            // 
            this.textIDPoliza.Location = new System.Drawing.Point(96, 41);
            this.textIDPoliza.Name = "textIDPoliza";
            this.textIDPoliza.Size = new System.Drawing.Size(158, 21);
            this.textIDPoliza.TabIndex = 3;
            this.textIDPoliza.Tag = "Pk_PolizaEncabezado";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(39, 77);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(51, 17);
            this.label12.TabIndex = 2;
            this.label12.Text = "Docto";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(12, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Concepto";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvPolizaDetalle);
            this.groupBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.groupBox3.Location = new System.Drawing.Point(12, 490);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(792, 209);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle";
            // 
            // dgvPolizaDetalle
            // 
            this.dgvPolizaDetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPolizaDetalle.Location = new System.Drawing.Point(6, 20);
            this.dgvPolizaDetalle.Name = "dgvPolizaDetalle";
            this.dgvPolizaDetalle.RowHeadersWidth = 51;
            this.dgvPolizaDetalle.Size = new System.Drawing.Size(770, 170);
            this.dgvPolizaDetalle.TabIndex = 0;
            this.dgvPolizaDetalle.Tag = "tbl_polizadetalle";
            // 
            // MantenimientoDetallePolizaContable
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(833, 749);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MantenimientoDetallePolizaContable";
            this.Text = "Poliza Contable Detalle";
            this.Load += new System.EventHandler(this.MantenimientoPolizaContable_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvPolizaDetalle)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox textSaldo;
        private System.Windows.Forms.TextBox textIDPoliza;
        private NavegadorVista.Navegador navegador1;
        private System.Windows.Forms.TextBox textConcepto;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvPolizaDetalle;
        private System.Windows.Forms.TextBox textIDCuenta;
        private System.Windows.Forms.TextBox textIDTPoliza;
        private System.Windows.Forms.TextBox textFecha;
        private System.Windows.Forms.TextBox textIDOpe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
    }
}