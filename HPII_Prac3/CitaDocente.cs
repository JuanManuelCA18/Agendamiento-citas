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
    public partial class CitaDocente : Form
    {
        List<int> CCDoc = new List<int>();
        List<int> CCEst = new List<int>();
        GestionDB dB;
        int posN, Posc;
        public CitaDocente()
        {
            InitializeComponent();
        }

        private void CitaDocente_Load(object sender, EventArgs e)
        {
            
        }
        private void btn_BuscarEst_Click(object sender, EventArgs e)
        {
            dB = new GestionDB();//Llamamos la clase la cual nos gestiona la base de datos
            CCEst = dB.listarCC("select * from Estudiante",0);//Llamamos un metodo el cual nos lista las cedulas de manera generica, en 
            //este caso llamamos todos las cedulas de los estudiantes
          
            for (int i = 0; i < CCEst.Count; i++)
            {
                if(int.Parse(txtCodigo.Text) == CCEst[i])
                {
                    groupBoxAgendarCita.Visible = true;
                    txtNombreEst.Text = dB.listarNom("select * from Estudiante",1)[i].ToString();// Y este de igual manera generica pero listando los nombres
                }
            }

            var nomDocen = dB.listarNom("select * from Docente", 1);
            cbDocentes.DataSource = nomDocen;//Llenamos el combobox con todos los nombres de los docentes

            dB = new GestionDB();
            CCDoc = dB.listarCC("select * from Docente", 0);//Guardamos todas las cedulas de los docentes

        }

        private void groupBoxAgendarCita_Enter(object sender, EventArgs e)
        {

        }

        private void txtNombreEst_Click(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void materialLabel1_Click(object sender, EventArgs e)
        {

        }

        void Limpiar()
        {
            txtCodigo.Text = "";
            asunto.Text = "";
            groupBoxAgendarCita.Visible = false;
        }

        private void materialFlatButton2_Click(object sender, EventArgs e)
        {
            Limpiar();
        }

        private void materialFlatButton1_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(cbDocentes.Text) || 
                string.IsNullOrEmpty(fecha.Text) ||
                string.IsNullOrEmpty(asunto.Text))
                MessageBox.Show("No deje campos sin llenar");
            else
            {
                //Empezamos a cargar los objetos para ser guardados en la base de datos
                Random rnd = new Random();
                Asesoria asesoria = new Asesoria();
                asesoria.NombreE1 = txtNombreEst.Text;
                asesoria.NombreD1 = cbDocentes.SelectedItem.ToString();
                asesoria.Fecha = fecha.Text;
                if (rbHora10.Checked == true)
                    asesoria.Hora = 10;
                else if (rbHora12.Checked == true)
                    asesoria.Hora = 12;
                else if (rbHora14.Checked == true)
                    asesoria.Hora = 14;
                else if (rbHora16.Checked == true)
                    asesoria.Hora = 16;
                asesoria.CC1 = int.Parse(txtCodigo.Text);
                asesoria.CCD1 = CCDoc[cbDocentes.SelectedIndex];

                int res = dB.GuardarAsesoria(asesoria);//Guardamos en la base de datos
                if (res > 0)
                    MessageBox.Show("Asesoria guardada con exito");
                else
                    MessageBox.Show("No se pudo guardar la asesoria " + dB.ToString());

                Limpiar();
            }




        }


       
    }
}
