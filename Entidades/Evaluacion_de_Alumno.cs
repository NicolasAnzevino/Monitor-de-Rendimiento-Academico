using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Evaluacion_de_Alumno
    {
        public Evaluacion_de_Alumno()
        {

        }
        public Evaluacion_de_Alumno(int pCodigo, int pCalificacion, DateTime pFecha, Alumno pAlumno, Docente pDocente, Evaluacion pEvaluacion)
        {
            Codigo = pCodigo;
            Calificacion = pCalificacion;
            Alumno = pAlumno;
            Fecha = pFecha;
            Docente = pDocente;
            Evaluacion = pEvaluacion;
        }
        public Evaluacion_de_Alumno(int pCalificacion, DateTime pFecha, Docente pDocente, Evaluacion pEvaluacion)
        {
            Calificacion = pCalificacion;
            Fecha = pFecha;
            Docente = pDocente;
            Evaluacion = pEvaluacion;
        }
        public Evaluacion_de_Alumno(int pCodigo, DateTime pFecha, int pCalificacion)
        {
            Codigo = pCodigo;
            Fecha = pFecha;
            Calificacion = pCalificacion;
            Docente = new Docente();
            Evaluacion = new Evaluacion();
        }
        public Evaluacion_de_Alumno(int pCalificacion, Docente pDocente, DateTime pFecha)
        {
            Calificacion = pCalificacion;
            Docente = pDocente;
            Fecha = pFecha;
        }
        public Evaluacion_de_Alumno(int pCalificacion, Docente pDocente)
        {
            Calificacion = pCalificacion;
            Docente = pDocente;
        }

        public Alumno Alumno;
        public int Calificacion { get; set; }
        public int Codigo { get; set; }
        public DateTime Fecha { get; set; }
        public Docente Docente;
        public Evaluacion Evaluacion;
    }
}
