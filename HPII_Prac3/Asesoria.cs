using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HPII_Prac3
{
    class Asesoria
    {
        string NombreE;
        string NombreD;
        int idAsesoria;
        string fecha;
        int hora;
        int CC;
        int CCD;
        public Asesoria()
        {

        }

        public Asesoria(int idAsesoria, string fecha, int hora, int cC, int cCD)
        {
            this.idAsesoria = idAsesoria;
            this.fecha = fecha;
            this.hora = hora;
            CC = cC;
            CCD = cCD;
        }

        public string NombreE1 { get => NombreE; set => NombreE = value; }
        public string NombreD1 { get => NombreD; set => NombreD = value; }
        public int IdAsesoria { get => idAsesoria; set => idAsesoria = value; }
        public string Fecha { get => fecha; set => fecha = value; }
        public int Hora { get => hora; set => hora = value; }
        public int CC1 { get => CC; set => CC = value; }
        public int CCD1 { get => CCD; set => CCD = value; }
    }
}
