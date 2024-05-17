
namespace HPII_Prac3
{
    partial class CitaDocente
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
            this.txtCodigo = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.btn_BuscarEst = new MaterialSkin.Controls.MaterialFlatButton();
            this.groupBoxAgendarCita = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.rbHora12 = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbHora16 = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbHora14 = new MaterialSkin.Controls.MaterialRadioButton();
            this.rbHora10 = new MaterialSkin.Controls.MaterialRadioButton();
            this.materialFlatButton2 = new MaterialSkin.Controls.MaterialFlatButton();
            this.materialFlatButton1 = new MaterialSkin.Controls.MaterialFlatButton();
            this.asunto = new System.Windows.Forms.RichTextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.fecha = new System.Windows.Forms.DateTimePicker();
            this.cbDocentes = new System.Windows.Forms.ComboBox();
            this.txtNombreEst = new MaterialSkin.Controls.MaterialSingleLineTextField();
            this.groupBoxAgendarCita.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtCodigo
            // 
            this.txtCodigo.Depth = 0;
            this.txtCodigo.Hint = "Cedula del estudiante";
            this.txtCodigo.Location = new System.Drawing.Point(55, 13);
            this.txtCodigo.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.PasswordChar = '\0';
            this.txtCodigo.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtCodigo.SelectedText = "";
            this.txtCodigo.SelectionLength = 0;
            this.txtCodigo.SelectionStart = 0;
            this.txtCodigo.Size = new System.Drawing.Size(159, 23);
            this.txtCodigo.TabIndex = 1;
            this.txtCodigo.TabStop = false;
            this.txtCodigo.UseSystemPasswordChar = false;
            // 
            // btn_BuscarEst
            // 
            this.btn_BuscarEst.AutoSize = true;
            this.btn_BuscarEst.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btn_BuscarEst.BackColor = System.Drawing.Color.Gray;
            this.btn_BuscarEst.Depth = 0;
            this.btn_BuscarEst.Location = new System.Drawing.Point(294, 6);
            this.btn_BuscarEst.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.btn_BuscarEst.MouseState = MaterialSkin.MouseState.HOVER;
            this.btn_BuscarEst.Name = "btn_BuscarEst";
            this.btn_BuscarEst.Primary = false;
            this.btn_BuscarEst.Size = new System.Drawing.Size(65, 36);
            this.btn_BuscarEst.TabIndex = 2;
            this.btn_BuscarEst.Text = "Buscar";
            this.btn_BuscarEst.UseVisualStyleBackColor = false;
            this.btn_BuscarEst.Click += new System.EventHandler(this.btn_BuscarEst_Click);
            // 
            // groupBoxAgendarCita
            // 
            this.groupBoxAgendarCita.Controls.Add(this.label3);
            this.groupBoxAgendarCita.Controls.Add(this.rbHora12);
            this.groupBoxAgendarCita.Controls.Add(this.rbHora16);
            this.groupBoxAgendarCita.Controls.Add(this.rbHora14);
            this.groupBoxAgendarCita.Controls.Add(this.rbHora10);
            this.groupBoxAgendarCita.Controls.Add(this.materialFlatButton2);
            this.groupBoxAgendarCita.Controls.Add(this.materialFlatButton1);
            this.groupBoxAgendarCita.Controls.Add(this.asunto);
            this.groupBoxAgendarCita.Controls.Add(this.label2);
            this.groupBoxAgendarCita.Controls.Add(this.label1);
            this.groupBoxAgendarCita.Controls.Add(this.fecha);
            this.groupBoxAgendarCita.Controls.Add(this.cbDocentes);
            this.groupBoxAgendarCita.Controls.Add(this.txtNombreEst);
            this.groupBoxAgendarCita.Location = new System.Drawing.Point(35, 42);
            this.groupBoxAgendarCita.Name = "groupBoxAgendarCita";
            this.groupBoxAgendarCita.Size = new System.Drawing.Size(521, 381);
            this.groupBoxAgendarCita.TabIndex = 3;
            this.groupBoxAgendarCita.TabStop = false;
            this.groupBoxAgendarCita.Visible = false;
            this.groupBoxAgendarCita.Enter += new System.EventHandler(this.groupBoxAgendarCita_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 13);
            this.label3.TabIndex = 18;
            this.label3.Text = "Por favor seleccione una hora:\r\n";
            // 
            // rbHora12
            // 
            this.rbHora12.AutoSize = true;
            this.rbHora12.Depth = 0;
            this.rbHora12.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbHora12.Location = new System.Drawing.Point(241, 166);
            this.rbHora12.Margin = new System.Windows.Forms.Padding(0);
            this.rbHora12.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbHora12.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbHora12.Name = "rbHora12";
            this.rbHora12.Ripple = true;
            this.rbHora12.Size = new System.Drawing.Size(45, 30);
            this.rbHora12.TabIndex = 17;
            this.rbHora12.TabStop = true;
            this.rbHora12.Text = "12";
            this.rbHora12.UseVisualStyleBackColor = true;
            // 
            // rbHora16
            // 
            this.rbHora16.AutoSize = true;
            this.rbHora16.Depth = 0;
            this.rbHora16.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbHora16.Location = new System.Drawing.Point(374, 166);
            this.rbHora16.Margin = new System.Windows.Forms.Padding(0);
            this.rbHora16.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbHora16.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbHora16.Name = "rbHora16";
            this.rbHora16.Ripple = true;
            this.rbHora16.Size = new System.Drawing.Size(45, 30);
            this.rbHora16.TabIndex = 16;
            this.rbHora16.TabStop = true;
            this.rbHora16.Text = "16";
            this.rbHora16.UseVisualStyleBackColor = true;
            // 
            // rbHora14
            // 
            this.rbHora14.AutoSize = true;
            this.rbHora14.Depth = 0;
            this.rbHora14.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbHora14.Location = new System.Drawing.Point(306, 166);
            this.rbHora14.Margin = new System.Windows.Forms.Padding(0);
            this.rbHora14.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbHora14.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbHora14.Name = "rbHora14";
            this.rbHora14.Ripple = true;
            this.rbHora14.Size = new System.Drawing.Size(45, 30);
            this.rbHora14.TabIndex = 15;
            this.rbHora14.TabStop = true;
            this.rbHora14.Text = "14";
            this.rbHora14.UseVisualStyleBackColor = true;
            // 
            // rbHora10
            // 
            this.rbHora10.AutoSize = true;
            this.rbHora10.Checked = true;
            this.rbHora10.Depth = 0;
            this.rbHora10.Font = new System.Drawing.Font("Roboto", 10F);
            this.rbHora10.Location = new System.Drawing.Point(181, 166);
            this.rbHora10.Margin = new System.Windows.Forms.Padding(0);
            this.rbHora10.MouseLocation = new System.Drawing.Point(-1, -1);
            this.rbHora10.MouseState = MaterialSkin.MouseState.HOVER;
            this.rbHora10.Name = "rbHora10";
            this.rbHora10.Ripple = true;
            this.rbHora10.Size = new System.Drawing.Size(45, 30);
            this.rbHora10.TabIndex = 14;
            this.rbHora10.TabStop = true;
            this.rbHora10.Text = "10";
            this.rbHora10.UseVisualStyleBackColor = true;
            // 
            // materialFlatButton2
            // 
            this.materialFlatButton2.AutoSize = true;
            this.materialFlatButton2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton2.BackColor = System.Drawing.Color.Gray;
            this.materialFlatButton2.Depth = 0;
            this.materialFlatButton2.Location = new System.Drawing.Point(264, 340);
            this.materialFlatButton2.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton2.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton2.Name = "materialFlatButton2";
            this.materialFlatButton2.Primary = false;
            this.materialFlatButton2.Size = new System.Drawing.Size(66, 36);
            this.materialFlatButton2.TabIndex = 11;
            this.materialFlatButton2.Text = "Limpiar";
            this.materialFlatButton2.UseVisualStyleBackColor = false;
            this.materialFlatButton2.Click += new System.EventHandler(this.materialFlatButton2_Click);
            // 
            // materialFlatButton1
            // 
            this.materialFlatButton1.AutoSize = true;
            this.materialFlatButton1.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.materialFlatButton1.BackColor = System.Drawing.Color.Gray;
            this.materialFlatButton1.Depth = 0;
            this.materialFlatButton1.Location = new System.Drawing.Point(134, 339);
            this.materialFlatButton1.Margin = new System.Windows.Forms.Padding(4, 6, 4, 6);
            this.materialFlatButton1.MouseState = MaterialSkin.MouseState.HOVER;
            this.materialFlatButton1.Name = "materialFlatButton1";
            this.materialFlatButton1.Primary = false;
            this.materialFlatButton1.Size = new System.Drawing.Size(60, 36);
            this.materialFlatButton1.TabIndex = 4;
            this.materialFlatButton1.Text = "Enviar";
            this.materialFlatButton1.UseVisualStyleBackColor = false;
            this.materialFlatButton1.Click += new System.EventHandler(this.materialFlatButton1_Click);
            // 
            // asunto
            // 
            this.asunto.Location = new System.Drawing.Point(66, 230);
            this.asunto.Name = "asunto";
            this.asunto.Size = new System.Drawing.Size(328, 100);
            this.asunto.TabIndex = 10;
            this.asunto.Text = "";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(39, 204);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Asunto:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(175, 115);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(111, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Selecciona una fecha";
            // 
            // fecha
            // 
            this.fecha.CustomFormat = "dd/MM/yyyy";
            this.fecha.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fecha.Location = new System.Drawing.Point(134, 131);
            this.fecha.Name = "fecha";
            this.fecha.Size = new System.Drawing.Size(200, 20);
            this.fecha.TabIndex = 6;
            this.fecha.Value = new System.DateTime(2022, 11, 13, 12, 13, 11, 0);
            // 
            // cbDocentes
            // 
            this.cbDocentes.FormattingEnabled = true;
            this.cbDocentes.Location = new System.Drawing.Point(157, 66);
            this.cbDocentes.Name = "cbDocentes";
            this.cbDocentes.Size = new System.Drawing.Size(153, 21);
            this.cbDocentes.TabIndex = 5;
            this.cbDocentes.Text = "Selecciona un docente";
            // 
            // txtNombreEst
            // 
            this.txtNombreEst.Depth = 0;
            this.txtNombreEst.Enabled = false;
            this.txtNombreEst.Hint = "Nombre del estudiante";
            this.txtNombreEst.Location = new System.Drawing.Point(151, 19);
            this.txtNombreEst.MouseState = MaterialSkin.MouseState.HOVER;
            this.txtNombreEst.Name = "txtNombreEst";
            this.txtNombreEst.PasswordChar = '\0';
            this.txtNombreEst.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.txtNombreEst.SelectedText = "";
            this.txtNombreEst.SelectionLength = 0;
            this.txtNombreEst.SelectionStart = 0;
            this.txtNombreEst.Size = new System.Drawing.Size(159, 23);
            this.txtNombreEst.TabIndex = 4;
            this.txtNombreEst.TabStop = false;
            this.txtNombreEst.UseSystemPasswordChar = false;
            this.txtNombreEst.Click += new System.EventHandler(this.txtNombreEst_Click);
            // 
            // CitaDocente
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(602, 435);
            this.Controls.Add(this.groupBoxAgendarCita);
            this.Controls.Add(this.btn_BuscarEst);
            this.Controls.Add(this.txtCodigo);
            this.Name = "CitaDocente";
            this.Text = "CitaDocente";
            this.Load += new System.EventHandler(this.CitaDocente_Load);
            this.groupBoxAgendarCita.ResumeLayout(false);
            this.groupBoxAgendarCita.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MaterialSkin.Controls.MaterialSingleLineTextField txtCodigo;
        private MaterialSkin.Controls.MaterialFlatButton btn_BuscarEst;
        private System.Windows.Forms.GroupBox groupBoxAgendarCita;
        private System.Windows.Forms.DateTimePicker fecha;
        private System.Windows.Forms.ComboBox cbDocentes;
        private MaterialSkin.Controls.MaterialSingleLineTextField txtNombreEst;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton2;
        private MaterialSkin.Controls.MaterialFlatButton materialFlatButton1;
        private System.Windows.Forms.RichTextBox asunto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private MaterialSkin.Controls.MaterialRadioButton rbHora12;
        private MaterialSkin.Controls.MaterialRadioButton rbHora16;
        private MaterialSkin.Controls.MaterialRadioButton rbHora14;
        private MaterialSkin.Controls.MaterialRadioButton rbHora10;
    }
}