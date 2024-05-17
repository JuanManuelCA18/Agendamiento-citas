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
    public partial class BuscarPorFecha : Form
    {
        List<Asesoria> asesorias = new List<Asesoria>();
        public BuscarPorFecha()
        {
            InitializeComponent();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            dgvAsesoria.Visible = true;
            GestionDB dB = new GestionDB();

            var Fechas = dB.BuscarAsesoriaXFecha(fechaAsesoria.Text);//Enviamos la fecha y hacemos la consulta
            for (int i = 0; i < Fechas.Count; i++)
            {
                dgvAsesoria.Rows.Insert(i, Fechas[i].NombreE1, Fechas[i].NombreD1, Fechas[i].Hora);//Agregamos la consulta de la base de datos al data griev view
            }
            

        }


        private void BuscarPorFecha_Load(object sender, EventArgs e)
        {
            fechaAsesoria.Format = DateTimePickerFormat.Custom;//Cambiamos el formato a la fecha
            fechaAsesoria.CustomFormat = "MM/dd/yyyy";
        }
    }
}
