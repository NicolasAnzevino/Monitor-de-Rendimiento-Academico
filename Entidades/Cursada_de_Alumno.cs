using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Cursada_de_Alumno
    {
        public Cursada_de_Alumno()
        {

        }
        public Cursada_de_Alumno(int pCodigo, Alumno pAlumno, Curso pCurso)
        {
            Alumno = pAlumno;
            Codigo = pCodigo;
            Curso = pCurso;
            Evaluaciones = new List<Evaluacion_de_Alumno>();
            Inasistencias = new List<Inasistencia>();
        }
        public Cursada_de_Alumno(int pCodigo, Alumno pAlumno, Curso pCurso, bool pEstado)
        {
            Alumno = pAlumno;
            Codigo = pCodigo;
            Curso = pCurso;
            Libre = pEstado;
            Evaluaciones = new List<Evaluacion_de_Alumno>();
            Inasistencias = new List<Inasistencia>();
        }


        public Cursada_de_Alumno(Alumno pAlumno, Curso pCurso)
        {
            Alumno = pAlumno;
            Curso = pCurso;
            Evaluaciones = new List<Evaluacion_de_Alumno>();
            Inasistencias = new List<Inasistencia>();
        }
        public Cursada_de_Alumno(int pCodigo, Curso pCurso)
        {
            Codigo = pCodigo;
            Curso = pCurso;
            Evaluaciones = new List<Evaluacion_de_Alumno>();
            Inasistencias = new List<Inasistencia>();
        }
        public Cursada_de_Alumno(int pCodigo, Curso pCurso, bool pLibre)
        {
            Codigo = pCodigo;
            Curso = pCurso;
            Libre = pLibre;
            Evaluaciones = new List<Evaluacion_de_Alumno>();
            Inasistencias = new List<Inasistencia>();
        }

        public Alumno Alumno { get; set; }
        public int Codigo { get; set; }
        public Curso Curso { get; set; }

        public bool Libre { get; set; }

        private List<Evaluacion_de_Alumno> Evaluaciones;

        private List<Inasistencia> Inasistencias;

        public List<Evaluacion_de_Alumno> VerEvaluaciones()
        {
            return this.Evaluaciones;
        }
        public List<Inasistencia> VerInasistencias()
        {
            return this.Inasistencias;
        }

    }
}
