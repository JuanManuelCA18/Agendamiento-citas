
namespace HPII_Prac3
{
    partial class BuscarPorFecha
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
            this.fechaAsesoria = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.dgvAsesoria = new System.Windows.Forms.DataGridView();
            this.NombreEst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaAsesoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsesoria)).BeginInit();
            this.SuspendLayout();
            // 
            // fechaAsesoria
            // 
            this.fechaAsesoria.CustomFormat = "dd/MM/yyyy";
            this.fechaAsesoria.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.fechaAsesoria.Location = new System.Drawing.Point(211, 39);
            this.fechaAsesoria.Name = "fechaAsesoria";
            this.fechaAsesoria.Size = new System.Drawing.Size(200, 20);
            this.fechaAsesoria.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(141, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Por favor ingresa una fecha:";
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(451, 33);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(65, 36);
            this.materialFlatButton1.TabIndex = 3;
            this.materialFlatButton1.Text = "Buscar";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // dgvAsesoria
            // 
            this.dgvAsesoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsesoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreEst,
            this.nombreDocente,
            this.horaAsesoria});
            this.dgvAsesoria.Location = new System.Drawing.Point(118, 92);
            this.dgvAsesoria.Name = "dgvAsesoria";
            this.dgvAsesoria.ReadOnly = true;
            this.dgvAsesoria.Size = new System.Drawing.Size(341, 254);
            this.dgvAsesoria.TabIndex = 4;
            this.dgvAsesoria.Visible = false;
            // 
            // NombreEst
            // 
            this.NombreEst.HeaderText = "Nombre del estudiante";
            this.NombreEst.Name = "NombreEst";
            this.NombreEst.ReadOnly = true;
            // 
            // nombreDocente
            // 
            this.nombreDocente.HeaderText = "Docente";
            this.nombreDocente.Name = "nombreDocente";
            this.nombreDocente.ReadOnly = true;
            // 
            // horaAsesoria
            // 
            this.horaAsesoria.HeaderText = "Hora";
            this.horaAsesoria.Name = "horaAsesoria";
            this.horaAsesoria.ReadOnly = true;
            // 
            // BuscarPorFecha
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 435);
            this.Controls.Add(this.dgvAsesoria);
            this.Controls.Add(this.materialFlatButton1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.fechaAsesoria);
            this.Name = "BuscarPorFecha";
            this.Text = "BuscarPorFecha";
            this.Load += new System.EventHandler(this.BuscarPorFecha_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsesoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DateTimePicker fechaAsesoria;
        private System.Windows.Forms.Label label1;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.DataGridView dgvAsesoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEst;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaAsesoria;
    }
}