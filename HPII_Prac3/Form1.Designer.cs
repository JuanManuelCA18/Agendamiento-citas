
namespace HPII_Prac3
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelBotones = new System.Windows.Forms.Panel();
            this.btnConsultarPorFecha = new System.Windows.Forms.Button();
            this.btnConsultarPorDocente = new System.Windows.Forms.Button();
            this.btnAgendar = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panelContenedor = new System.Windows.Forms.Panel();
            this.panelBotones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panelBotones
            // 
            this.panelBotones.BackColor = System.Drawing.Color.Chocolate;
            this.panelBotones.Controls.Add(this.btnConsultarPorFecha);
            this.panelBotones.Controls.Add(this.btnConsultarPorDocente);
            this.panelBotones.Controls.Add(this.btnAgendar);
            this.panelBotones.Controls.Add(this.pictureBox1);
            this.panelBotones.Location = new System.Drawing.Point(1, -2);
            this.panelBotones.Name = "panelBotones";
            this.panelBotones.Size = new System.Drawing.Size(191, 478);
            this.panelBotones.TabIndex = 0;
            this.panelBotones.Paint += new System.Windows.Forms.PaintEventHandler(this.panelBotones_Paint);
            // 
            // btnConsultarPorFecha
            // 
            this.btnConsultarPorFecha.Location = new System.Drawing.Point(11, 200);
            this.btnConsultarPorFecha.Name = "btnConsultarPorFecha";
            this.btnConsultarPorFecha.Size = new System.Drawing.Size(157, 51);
            this.btnConsultarPorFecha.TabIndex = 5;
            this.btnConsultarPorFecha.Text = "Consultar agenda por fecha";
            this.btnConsultarPorFecha.UseVisualStyleBackColor = true;
            this.btnConsultarPorFecha.Click += new System.EventHandler(this.btnConsultarPorFecha_Click);
            // 
            // btnConsultarPorDocente
            // 
            this.btnConsultarPorDocente.Location = new System.Drawing.Point(11, 279);
            this.btnConsultarPorDocente.Name = "btnConsultarPorDocente";
            this.btnConsultarPorDocente.Size = new System.Drawing.Size(157, 51);
            this.btnConsultarPorDocente.TabIndex = 4;
            this.btnConsultarPorDocente.Text = "Consultar agenda por docente";
            this.btnConsultarPorDocente.UseVisualStyleBackColor = true;
            this.btnConsultarPorDocente.Click += new System.EventHandler(this.btnConsultarPorDocente_Click);
            // 
            // btnAgendar
            // 
            this.btnAgendar.Location = new System.Drawing.Point(11, 122);
            this.btnAgendar.Name = "btnAgendar";
            this.btnAgendar.Size = new System.Drawing.Size(157, 51);
            this.btnAgendar.TabIndex = 3;
            this.btnAgendar.Text = "Agendar cita con docente";
            this.btnAgendar.UseVisualStyleBackColor = true;
            this.btnAgendar.Click += new System.EventHandler(this.btnAgendar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::HPII_Prac3.Properties.Resources.calendario1;
            this.pictureBox1.Location = new System.Drawing.Point(49, 11);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(83, 76);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // panelContenedor
            // 
            this.panelContenedor.Location = new System.Drawing.Point(190, -2);
            this.panelContenedor.Name = "panelContenedor";
            this.panelContenedor.Size = new System.Drawing.Size(635, 478);
            this.panelContenedor.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(824, 476);
            this.Controls.Add(this.panelContenedor);
            this.Controls.Add(this.panelBotones);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panelBotones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelBotones;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btnConsultarPorFecha;
        private System.Windows.Forms.Button btnConsultarPorDocente;
        private System.Windows.Forms.Button btnAgendar;
        private System.Windows.Forms.Panel panelContenedor;
    }
}

