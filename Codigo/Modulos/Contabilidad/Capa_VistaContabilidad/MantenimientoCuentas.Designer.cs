
namespace Capa_VistaContabilidad
{
    partial class MantenimientoCuentas
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
            this.navegador_ctas = new NavegadorVista.Navegador();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.textNombreCuenta = new System.Windows.Forms.TextBox();
            this.textTCuenta = new System.Windows.Forms.TextBox();
            this.btnTipoCuenta = new System.Windows.Forms.Button();
            this.btnTCuenta = new System.Windows.Forms.Button();
            this.textStatus = new System.Windows.Forms.TextBox();
            this.cboNombreCuenta = new System.Windows.Forms.ComboBox();
            this.cboTCuneta = new System.Windows.Forms.ComboBox();
            this.textSaldo = new System.Windows.Forms.TextBox();
            this.textAbono = new System.Windows.Forms.TextBox();
            this.textCargo = new System.Windows.Forms.TextBox();
            this.textIDCuenta = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.dgvCuentasM = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentasM)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.navegador_ctas);
            this.groupBox1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.groupBox1.Location = new System.Drawing.Point(15, 17);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(820, 196);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Navegador";
            // 
            // navegador_ctas
            // 
            this.navegador_ctas.Location = new System.Drawing.Point(18, 17);
            this.navegador_ctas.Margin = new System.Windows.Forms.Padding(5, 3, 5, 3);
            this.navegador_ctas.Name = "navegador_ctas";
            this.navegador_ctas.Size = new System.Drawing.Size(784, 172);
            this.navegador_ctas.TabIndex = 1;
            this.navegador_ctas.Load += new System.EventHandler(this.navegador_ctas_Load);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.textNombreCuenta);
            this.groupBox2.Controls.Add(this.textTCuenta);
            this.groupBox2.Controls.Add(this.btnTipoCuenta);
            this.groupBox2.Controls.Add(this.btnTCuenta);
            this.groupBox2.Controls.Add(this.textStatus);
            this.groupBox2.Controls.Add(this.cboNombreCuenta);
            this.groupBox2.Controls.Add(this.cboTCuneta);
            this.groupBox2.Controls.Add(this.textSaldo);
            this.groupBox2.Controls.Add(this.textAbono);
            this.groupBox2.Controls.Add(this.textCargo);
            this.groupBox2.Controls.Add(this.textIDCuenta);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.groupBox2.Location = new System.Drawing.Point(22, 233);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(813, 171);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Datos";
            // 
            // textNombreCuenta
            // 
            this.textNombreCuenta.Location = new System.Drawing.Point(359, 100);
            this.textNombreCuenta.Name = "textNombreCuenta";
            this.textNombreCuenta.Size = new System.Drawing.Size(100, 21);
            this.textNombreCuenta.TabIndex = 21;
            this.textNombreCuenta.Tag = "pkid_encabezadocuenta";
            // 
            // textTCuenta
            // 
            this.textTCuenta.Location = new System.Drawing.Point(359, 55);
            this.textTCuenta.Name = "textTCuenta";
            this.textTCuenta.Size = new System.Drawing.Size(100, 21);
            this.textTCuenta.TabIndex = 20;
            this.textTCuenta.Tag = "pkid_tipocuenta";
            // 
            // btnTipoCuenta
            // 
            this.btnTipoCuenta.Location = new System.Drawing.Point(305, 99);
            this.btnTipoCuenta.Name = "btnTipoCuenta";
            this.btnTipoCuenta.Size = new System.Drawing.Size(33, 23);
            this.btnTipoCuenta.TabIndex = 19;
            this.btnTipoCuenta.Text = "?";
            this.btnTipoCuenta.UseVisualStyleBackColor = true;
            this.btnTipoCuenta.Click += new System.EventHandler(this.btnTipoCuenta_Click);
            // 
            // btnTCuenta
            // 
            this.btnTCuenta.Location = new System.Drawing.Point(305, 59);
            this.btnTCuenta.Name = "btnTCuenta";
            this.btnTCuenta.Size = new System.Drawing.Size(33, 23);
            this.btnTCuenta.TabIndex = 18;
            this.btnTCuenta.Text = "?";
            this.btnTCuenta.UseVisualStyleBackColor = true;
            this.btnTCuenta.Click += new System.EventHandler(this.btnTCuenta_Click);
            // 
            // textStatus
            // 
            this.textStatus.Location = new System.Drawing.Point(521, 95);
            this.textStatus.Name = "textStatus";
            this.textStatus.Size = new System.Drawing.Size(121, 21);
            this.textStatus.TabIndex = 13;
            this.textStatus.Tag = "status_cuenta";
            // 
            // cboNombreCuenta
            // 
            this.cboNombreCuenta.FormattingEnabled = true;
            this.cboNombreCuenta.Location = new System.Drawing.Point(174, 94);
            this.cboNombreCuenta.Name = "cboNombreCuenta";
            this.cboNombreCuenta.Size = new System.Drawing.Size(121, 22);
            this.cboNombreCuenta.TabIndex = 12;
            this.cboNombreCuenta.Tag = "nombre_cuenta";
            this.cboNombreCuenta.SelectedIndexChanged += new System.EventHandler(this.cboNombreCuenta_SelectedIndexChanged);
            // 
            // cboTCuneta
            // 
            this.cboTCuneta.FormattingEnabled = true;
            this.cboTCuneta.Location = new System.Drawing.Point(174, 55);
            this.cboTCuneta.Name = "cboTCuneta";
            this.cboTCuneta.Size = new System.Drawing.Size(121, 22);
            this.cboTCuneta.TabIndex = 11;
            this.cboTCuneta.Tag = "pkid_tipocuenta";
            this.cboTCuneta.SelectedIndexChanged += new System.EventHandler(this.cboTCuneta_SelectedIndexChanged);
            // 
            // textSaldo
            // 
            this.textSaldo.Location = new System.Drawing.Point(521, 55);
            this.textSaldo.Name = "textSaldo";
            this.textSaldo.Size = new System.Drawing.Size(121, 21);
            this.textSaldo.TabIndex = 10;
            this.textSaldo.Tag = "saldo_cuenta";
            // 
            // textAbono
            // 
            this.textAbono.Location = new System.Drawing.Point(521, 20);
            this.textAbono.Name = "textAbono";
            this.textAbono.Size = new System.Drawing.Size(121, 21);
            this.textAbono.TabIndex = 9;
            this.textAbono.Tag = "abono_cuenta";
            // 
            // textCargo
            // 
            this.textCargo.Location = new System.Drawing.Point(174, 129);
            this.textCargo.Name = "textCargo";
            this.textCargo.Size = new System.Drawing.Size(121, 21);
            this.textCargo.TabIndex = 8;
            this.textCargo.Tag = "cargo_cuenta";
            // 
            // textIDCuenta
            // 
            this.textIDCuenta.Location = new System.Drawing.Point(174, 19);
            this.textIDCuenta.Name = "textIDCuenta";
            this.textIDCuenta.Size = new System.Drawing.Size(121, 21);
            this.textIDCuenta.TabIndex = 7;
            this.textIDCuenta.Tag = "pkid_cuenta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label7.Location = new System.Drawing.Point(461, 95);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(54, 17);
            this.label7.TabIndex = 6;
            this.label7.Text = "Status";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label6.Location = new System.Drawing.Point(465, 59);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(49, 17);
            this.label6.TabIndex = 5;
            this.label6.Text = "Saldo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label5.Location = new System.Drawing.Point(460, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 17);
            this.label5.TabIndex = 4;
            this.label5.Text = "Abono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label4.Location = new System.Drawing.Point(31, 125);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 17);
            this.label4.TabIndex = 3;
            this.label4.Text = "Cargo";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label3.Location = new System.Drawing.Point(26, 95);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(95, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Tipo Cuenta";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label2.Location = new System.Drawing.Point(26, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(122, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nombre Cuenta";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial Rounded MT Bold", 11.25F);
            this.label1.Location = new System.Drawing.Point(22, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID Cuentas";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.dgvCuentasM);
            this.groupBox3.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F);
            this.groupBox3.Location = new System.Drawing.Point(25, 419);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(810, 206);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Detalle";
            // 
            // dgvCuentasM
            // 
            this.dgvCuentasM.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCuentasM.Location = new System.Drawing.Point(17, 15);
            this.dgvCuentasM.Name = "dgvCuentasM";
            this.dgvCuentasM.Size = new System.Drawing.Size(775, 174);
            this.dgvCuentasM.TabIndex = 0;
            this.dgvCuentasM.Tag = "tbl_cuentas";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(720, 22);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 22;
            this.button1.Text = "Ayuda";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // MantenimientoCuentas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.ClientSize = new System.Drawing.Size(868, 652);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "MantenimientoCuentas";
            this.Text = "MantenimientoCuentas";
            this.Load += new System.EventHandler(this.MantenimientoCuentas_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCuentasM)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textStatus;
        private System.Windows.Forms.ComboBox cboNombreCuenta;
        private System.Windows.Forms.ComboBox cboTCuneta;
        private System.Windows.Forms.TextBox textSaldo;
        private System.Windows.Forms.TextBox textAbono;
        private System.Windows.Forms.TextBox textCargo;
        private System.Windows.Forms.TextBox textIDCuenta;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.DataGridView dgvCuentasM;
        private System.Windows.Forms.TextBox textNombreCuenta;
        private System.Windows.Forms.TextBox textTCuenta;
        private System.Windows.Forms.Button btnTipoCuenta;
        private System.Windows.Forms.Button btnTCuenta;
        private NavegadorVista.Navegador navegador_ctas;
        private System.Windows.Forms.Button button1;
    }
}