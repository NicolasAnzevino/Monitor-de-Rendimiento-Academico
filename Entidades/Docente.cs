using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Docente
    {
        public Docente()
        {

        }

        public Docente(string pLegajo, bool pActivo, string pNombre, string pApellido, int pDNI)
        {
            Legajo = pLegajo;
            Activo = pActivo;
            Nombre = pNombre;
            Apellido = pApellido;
            DNI = pDNI;

            Dictados = new List<Dictado>();
            Evaluaciones = new List<Evaluacion_de_Alumno>();
        }

        public Docente(string pLegajo, string pNombre, string pApellido)
        {
            Legajo = pLegajo;
            Nombre = pNombre;
            Apellido = pApellido;

            Dictados = new List<Dictado>();
            Evaluaciones = new List<Evaluacion_de_Alumno>();
        }

        public bool Activo;
        public string Nombre { get; set; }
        public string Apellido { get; set;  }
        public int DNI { get; set; }
        public string Legajo { get; set; }

        private List<Dictado> Dictados;
        private List<Evaluacion_de_Alumno> Evaluaciones;

        public List<Dictado> VerDictados()
        {
            return this.Dictados;
        }

        public List<Evaluacion_de_Alumno> VerEvaluaciones()
        {
            return this.Evaluaciones;
        }

    }
}
