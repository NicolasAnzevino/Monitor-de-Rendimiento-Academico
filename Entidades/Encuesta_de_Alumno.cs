using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Encuesta_de_Alumno
    {
        public Encuesta_de_Alumno()
        {

        }

        public Encuesta_de_Alumno(int pCodigo, Encuesta pEncuesta)
        {
            Codigo = pCodigo;
            Encuesta = pEncuesta;
        }

        public int Codigo { get; set; }
        public Encuesta Encuesta;
        public bool Activo { get; set; }
    }
}
