
namespace HPII_Prac3
{
    partial class BuscarPorDocente
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
            this.dgvAsesoria = new System.Windows.Forms.DataGridView();
            this.NombreEst = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDocente = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.horaAsesoria = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsesoria)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvAsesoria
            // 
            this.dgvAsesoria.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAsesoria.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.NombreEst,
            this.nombreDocente,
            this.horaAsesoria});
            this.dgvAsesoria.Location = new System.Drawing.Point(114, 106);
            this.dgvAsesoria.Name = "dgvAsesoria";
            this.dgvAsesoria.ReadOnly = true;
            this.dgvAsesoria.Size = new System.Drawing.Size(341, 254);
            this.dgvAsesoria.TabIndex = 8;
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
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(337, 37);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(65, 36);
            this.materialFlatButton1.TabIndex = 7;
            this.materialFlatButton1.Text = "Buscar";
            this.materialFlatButton1.UseVisualStyleBackColor = true;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(166, 46);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(155, 21);
            this.comboBox1.TabIndex = 9;
            // 
            // BuscarPorDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 435);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.dgvAsesoria);
            this.Controls.Add(this.materialFlatButton1);
            this.Name = "BuscarPorDocente";
            this.Text = "BuscarPorDocente";
            this.Load += new System.EventHandler(this.BuscarPorDocente_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAsesoria)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvAsesoria;
        private System.Windows.Forms.DataGridViewTextBoxColumn NombreEst;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDocente;
        private System.Windows.Forms.DataGridViewTextBoxColumn horaAsesoria;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.ComboBox comboBox1;
    }
}