using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Alumno
    {
        public Alumno()
        {
            
        }

        public Alumno(string pLegajo, int pDNI, string pNombre, string pApellido, string pTurno, string pCorreo_Electronico, DateTime pFecha_Ingreso, DateTime pFecha_Nacimiento, bool pActivo)
        {
            Legajo = pLegajo;
            DNI = pDNI;
            Nombre = pNombre;
            Apellido = pApellido;
            Turno = new Turno(pTurno);
            Correo_Electronico = pCorreo_Electronico;
            Fecha_Ingreso = pFecha_Ingreso;
            Fecha_Nacimiento = pFecha_Nacimiento;
            Activo = pActivo;

            Cursadas = new List<Cursada_de_Alumno>();
            Encuestas = new List<Encuesta_de_Alumno>();
        }
        public Alumno(string pLegajo, int pDNI, string pApellido, string pNombre)
        {
            Legajo = pLegajo;
            DNI = pDNI;
            Apellido = pApellido;
            Nombre = pNombre;
        }

        public string Legajo { get; set; }
        public int DNI { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public Turno Turno { get; set; }
        public string Correo_Electronico { get; set; }
        public DateTime Fecha_Ingreso { get; set; }
        public DateTime Fecha_Nacimiento { get; set; }

        private bool Activo;

        private List<Cursada_de_Alumno> Cursadas;

        private List<Encuesta_de_Alumno> Encuestas;

        public List<Cursada_de_Alumno> VerCursadas()
        {
            return this.Cursadas;
        }

        public List<Encuesta_de_Alumno> VerEncuestas()
        {
            return this.Encuestas;
        }



    }
}
