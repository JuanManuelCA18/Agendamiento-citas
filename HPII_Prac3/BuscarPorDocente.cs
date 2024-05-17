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
    public partial class BuscarPorDocente : Form
    {
        GestionDB dB = new GestionDB();
        public BuscarPorDocente()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            dgvAsesoria.Visible = true;
            // dB = new GestionDB();
            var Docentes = dB.BuscarAsesoriaXDocente(comboBox1.Text);
            for (int i = 0; i < Docentes.Count; i++)
            {
                dgvAsesoria.Rows.Insert(i, Docentes[i].NombreE1, Docentes[i].NombreD1, Docentes[i].Hora);                
            }
        }

        private void BuscarPorDocente_Load(object sender, EventArgs e)
        {
            dB = new GestionDB();
            var nomDocen = dB.listarNom("select * from Docente", 1);
            comboBox1.DataSource = nomDocen;
        }
    }
}
