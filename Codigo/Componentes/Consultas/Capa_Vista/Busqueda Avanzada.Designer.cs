
namespace Capa_Vista
{
    partial class Busqueda_Avanzada
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
            this.pnl_BuscarBA = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_CancelarBA = new FontAwesome.Sharp.IconButton();
            this.btn_BuscarBA = new FontAwesome.Sharp.IconButton();
            this.txt_buscar = new System.Windows.Forms.TextBox();
            this.cbo_buscaren = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvDato = new System.Windows.Forms.DataGridView();
            this.panelResultado = new System.Windows.Forms.Panel();
            this.btn_SalirBA = new FontAwesome.Sharp.IconButton();
            this.bnt_nuevaBA = new FontAwesome.Sharp.IconButton();
            this.label3 = new System.Windows.Forms.Label();
            this.pnl_BuscarBA.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDato)).BeginInit();
            this.panelResultado.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnl_BuscarBA
            // 
            this.pnl_BuscarBA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.pnl_BuscarBA.Controls.Add(this.label4);
            this.pnl_BuscarBA.Controls.Add(this.btn_CancelarBA);
            this.pnl_BuscarBA.Controls.Add(this.btn_BuscarBA);
            this.pnl_BuscarBA.Controls.Add(this.txt_buscar);
            this.pnl_BuscarBA.Controls.Add(this.cbo_buscaren);
            this.pnl_BuscarBA.Controls.Add(this.label1);
            this.pnl_BuscarBA.Controls.Add(this.label2);
            this.pnl_BuscarBA.Location = new System.Drawing.Point(16, 15);
            this.pnl_BuscarBA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnl_BuscarBA.Name = "pnl_BuscarBA";
            this.pnl_BuscarBA.Size = new System.Drawing.Size(544, 318);
            this.pnl_BuscarBA.TabIndex = 9;
            this.pnl_BuscarBA.Paint += new System.Windows.Forms.PaintEventHandler(this.pnl_BuscarBA_Paint);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(179, 22);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(195, 25);
            this.label4.TabIndex = 33;
            this.label4.Text = "Busqueda Avanzada";
            // 
            // btn_CancelarBA
            // 
            this.btn_CancelarBA.IconChar = FontAwesome.Sharp.IconChar.XmarkCircle;
            this.btn_CancelarBA.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(203)))), ((int)(((byte)(50)))), ((int)(((byte)(52)))));
            this.btn_CancelarBA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_CancelarBA.IconSize = 60;
            this.btn_CancelarBA.Location = new System.Drawing.Point(389, 217);
            this.btn_CancelarBA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_CancelarBA.Name = "btn_CancelarBA";
            this.btn_CancelarBA.Size = new System.Drawing.Size(85, 84);
            this.btn_CancelarBA.TabIndex = 32;
            this.btn_CancelarBA.Text = "Cancelar";
            this.btn_CancelarBA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_CancelarBA.UseVisualStyleBackColor = true;
            this.btn_CancelarBA.Click += new System.EventHandler(this.btn_CancelarBA_Click);
            // 
            // btn_BuscarBA
            // 
            this.btn_BuscarBA.IconChar = FontAwesome.Sharp.IconChar.Search;
            this.btn_BuscarBA.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.btn_BuscarBA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_BuscarBA.IconSize = 60;
            this.btn_BuscarBA.Location = new System.Drawing.Point(295, 217);
            this.btn_BuscarBA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_BuscarBA.Name = "btn_BuscarBA";
            this.btn_BuscarBA.Size = new System.Drawing.Size(85, 84);
            this.btn_BuscarBA.TabIndex = 31;
            this.btn_BuscarBA.Text = "Buscar";
            this.btn_BuscarBA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_BuscarBA.UseVisualStyleBackColor = true;
            this.btn_BuscarBA.Click += new System.EventHandler(this.btn_BuscarBA_Click);
            // 
            // txt_buscar
            // 
            this.txt_buscar.Location = new System.Drawing.Point(192, 81);
            this.txt_buscar.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txt_buscar.Name = "txt_buscar";
            this.txt_buscar.Size = new System.Drawing.Size(281, 22);
            this.txt_buscar.TabIndex = 6;
            // 
            // cbo_buscaren
            // 
            this.cbo_buscaren.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_buscaren.FormattingEnabled = true;
            this.cbo_buscaren.Location = new System.Drawing.Point(192, 133);
            this.cbo_buscaren.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.cbo_buscaren.Name = "cbo_buscaren";
            this.cbo_buscaren.Size = new System.Drawing.Size(281, 24);
            this.cbo_buscaren.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(68, 79);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Buscar :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 134);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(108, 25);
            this.label2.TabIndex = 5;
            this.label2.Text = "Buscar En:";
            // 
            // dgvDato
            // 
            this.dgvDato.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDato.Location = new System.Drawing.Point(19, 36);
            this.dgvDato.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.dgvDato.Name = "dgvDato";
            this.dgvDato.RowHeadersWidth = 51;
            this.dgvDato.Size = new System.Drawing.Size(505, 181);
            this.dgvDato.TabIndex = 0;
            // 
            // panelResultado
            // 
            this.panelResultado.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(232)))), ((int)(((byte)(247)))), ((int)(((byte)(253)))));
            this.panelResultado.Controls.Add(this.btn_SalirBA);
            this.panelResultado.Controls.Add(this.bnt_nuevaBA);
            this.panelResultado.Controls.Add(this.label3);
            this.panelResultado.Controls.Add(this.dgvDato);
            this.panelResultado.Location = new System.Drawing.Point(588, 15);
            this.panelResultado.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panelResultado.Name = "panelResultado";
            this.panelResultado.Size = new System.Drawing.Size(544, 318);
            this.panelResultado.TabIndex = 11;
            this.panelResultado.Visible = false;
            // 
            // btn_SalirBA
            // 
            this.btn_SalirBA.IconChar = FontAwesome.Sharp.IconChar.PersonWalkingArrowRight;
            this.btn_SalirBA.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.btn_SalirBA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btn_SalirBA.IconSize = 60;
            this.btn_SalirBA.Location = new System.Drawing.Point(439, 224);
            this.btn_SalirBA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btn_SalirBA.Name = "btn_SalirBA";
            this.btn_SalirBA.Size = new System.Drawing.Size(85, 84);
            this.btn_SalirBA.TabIndex = 34;
            this.btn_SalirBA.Text = "Salir";
            this.btn_SalirBA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_SalirBA.UseVisualStyleBackColor = true;
            this.btn_SalirBA.Click += new System.EventHandler(this.btn_SalirBA_Click);
            // 
            // bnt_nuevaBA
            // 
            this.bnt_nuevaBA.IconChar = FontAwesome.Sharp.IconChar.MagnifyingGlassPlus;
            this.bnt_nuevaBA.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(123)))), ((int)(((byte)(180)))), ((int)(((byte)(227)))));
            this.bnt_nuevaBA.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.bnt_nuevaBA.IconSize = 60;
            this.bnt_nuevaBA.Location = new System.Drawing.Point(344, 224);
            this.bnt_nuevaBA.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bnt_nuevaBA.Name = "bnt_nuevaBA";
            this.bnt_nuevaBA.Size = new System.Drawing.Size(85, 84);
            this.bnt_nuevaBA.TabIndex = 33;
            this.bnt_nuevaBA.Text = "Nueva";
            this.bnt_nuevaBA.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.bnt_nuevaBA.UseVisualStyleBackColor = true;
            this.bnt_nuevaBA.Click += new System.EventHandler(this.bnt_nuevaBA_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 7);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(184, 25);
            this.label3.TabIndex = 6;
            this.label3.Text = "Datos de Busqueda";
            // 
            // Busqueda_Avanzada
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.ClientSize = new System.Drawing.Size(1157, 359);
            this.Controls.Add(this.panelResultado);
            this.Controls.Add(this.pnl_BuscarBA);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Busqueda_Avanzada";
            this.Text = "Busqueda Avanzada";
            this.pnl_BuscarBA.ResumeLayout(false);
            this.pnl_BuscarBA.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDato)).EndInit();
            this.panelResultado.ResumeLayout(false);
            this.panelResultado.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnl_BuscarBA;
        private System.Windows.Forms.TextBox txt_buscar;
        private System.Windows.Forms.ComboBox cbo_buscaren;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvDato;
        private System.Windows.Forms.Panel panelResultado;
        private FontAwesome.Sharp.IconButton btn_BuscarBA;
        private FontAwesome.Sharp.IconButton btn_CancelarBA;
        private System.Windows.Forms.Label label4;
        private FontAwesome.Sharp.IconButton btn_SalirBA;
        private FontAwesome.Sharp.IconButton bnt_nuevaBA;
        private System.Windows.Forms.Label label3;
    }
}