using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HPII_Prac3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Metodo que abre un nuevo formulario pero sin necesidad de tener que cambiar de formularios       
        /// </summary>
        /// <param name="form"></param>
        public void AbrirFormulario(Form form)
        {
            if (panelContenedor.Controls.Count > 0)
                panelContenedor.Controls.Clear();
            form.TopLevel = false;
            form.Dock = DockStyle.Fill;
            form.FormBorderStyle = FormBorderStyle.None;
            panelContenedor.Controls.Add(form);
            form.Show();

        }

        private void panelBotones_Paint(object sender, PaintEventArgs e)
        {

        }
      
       
        private void btnAgendar_Click(object sender, EventArgs e)
        {
            CitaDocente citaDocente = new CitaDocente();
            AbrirFormulario(citaDocente);
        }

        private void btnConsultarPorFecha_Click(object sender, EventArgs e)
        {
            BuscarPorFecha buscarPorFecha = new BuscarPorFecha();
            AbrirFormulario(buscarPorFecha);
        }

        private void btnConsultarPorDocente_Click(object sender, EventArgs e)
        {
            BuscarPorDocente bd = new BuscarPorDocente();
            AbrirFormulario(bd);
        }
    }
}
