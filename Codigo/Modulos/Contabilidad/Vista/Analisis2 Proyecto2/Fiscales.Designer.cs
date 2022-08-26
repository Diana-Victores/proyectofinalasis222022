
namespace Analisis2_Proyecto2
{
    partial class Fiscales
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fiscales));
            this.panel1 = new System.Windows.Forms.Panel();
            this.Pprincipal = new System.Windows.Forms.Panel();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btnMenuP = new System.Windows.Forms.Button();
            this.btnSalirFisc = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.Info;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.panel1.Controls.Add(this.btnSalirFisc);
            this.panel1.Controls.Add(this.btnMenuP);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Location = new System.Drawing.Point(0, 5);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1279, 67);
            this.panel1.TabIndex = 0;
            // 
            // Pprincipal
            // 
            this.Pprincipal.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("Pprincipal.BackgroundImage")));
            this.Pprincipal.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.Pprincipal.Location = new System.Drawing.Point(0, 78);
            this.Pprincipal.Name = "Pprincipal";
            this.Pprincipal.Size = new System.Drawing.Size(1279, 493);
            this.Pprincipal.TabIndex = 1;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.Info;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 6F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(-2, 44);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(116, 21);
            this.button1.TabIndex = 1;
            this.button1.Text = "Datos fiscales Terceros";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(34, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(45, 43);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // btnMenuP
            // 
            this.btnMenuP.Location = new System.Drawing.Point(1174, 3);
            this.btnMenuP.Name = "btnMenuP";
            this.btnMenuP.Size = new System.Drawing.Size(98, 26);
            this.btnMenuP.TabIndex = 0;
            this.btnMenuP.Text = "Menu Principal";
            this.btnMenuP.UseVisualStyleBackColor = true;
            this.btnMenuP.Click += new System.EventHandler(this.btnMenuP_Click);
            // 
            // btnSalirFisc
            // 
            this.btnSalirFisc.Location = new System.Drawing.Point(1174, 34);
            this.btnSalirFisc.Name = "btnSalirFisc";
            this.btnSalirFisc.Size = new System.Drawing.Size(98, 26);
            this.btnSalirFisc.TabIndex = 3;
            this.btnSalirFisc.Text = "Cerrar";
            this.btnSalirFisc.UseVisualStyleBackColor = true;
            // 
            // Fiscales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(1278, 571);
            this.Controls.Add(this.Pprincipal);
            this.Controls.Add(this.panel1);
            this.Name = "Fiscales";
            this.Text = "Fiscales";
            this.Load += new System.EventHandler(this.Fiscales_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSalirFisc;
        private System.Windows.Forms.Button btnMenuP;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel Pprincipal;
    }
}