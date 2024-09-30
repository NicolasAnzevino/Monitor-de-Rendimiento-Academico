using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Respuesta_de_Encuesta
    {
        public Respuesta_de_Encuesta()
        {

        }
        public Respuesta_de_Encuesta(int pCodigo, int pRespuesta, string pDescripcion, Alumno pAlumno)
        {
            Codigo = pCodigo;
            Respuesta = pRespuesta;
            Descripcion = pDescripcion;

            Alumno = pAlumno;
        }
        public Respuesta_de_Encuesta(int pRespuesta, string pDescripcion)
        {
            Respuesta = pRespuesta;
            Descripcion = pDescripcion;
        }

        public int Codigo { get; set; }
        public int Respuesta { get; set; }
        public string Descripcion { get; set; }

        private Alumno Alumno;

        public Alumno RetornarAlumno()
        {
            return this.Alumno;
        }
    }
}
