using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Curso
    {
        public Curso()
        {
            Turno = new Turno();

            Cursadas = new List<Cursada_de_Alumno>();
            Dictados = new List<Dictado>();
            Materias = new List<Materia>();
        }
        public Curso(int pCodigo, string pNombre, int pAño, string pTurno, bool pActivo)
        {
            Codigo = pCodigo;
            Nombre = pNombre;
            Activo = pActivo;
            Año = pAño;
            Turno = new Turno(pTurno);

            Cursadas = new List<Cursada_de_Alumno>();
            Dictados = new List<Dictado>();
            Materias = new List<Materia>();
        }
        public Curso(int pCodigo, string pNombre, int pAño, string pTurno, bool pActivo, bool pInscripcionAbierta)
        {
            Codigo = pCodigo;
            Nombre = pNombre;
            Activo = pActivo;
            Año = pAño;
            Turno = new Turno(pTurno);
            InscripcionAbierta = pInscripcionAbierta;

            Cursadas = new List<Cursada_de_Alumno>();
            Dictados = new List<Dictado>();
            Materias = new List<Materia>();
        }
        public Curso(string pNombre, int pAño, Turno pTurno, bool pActivo, bool pInscripcionAbierta)
        {
            Nombre = pNombre;
            Activo = pActivo;
            Año = pAño;
            Turno = pTurno;
            InscripcionAbierta = pInscripcionAbierta;

            Cursadas = new List<Cursada_de_Alumno>();
            Dictados = new List<Dictado>();
            Materias = new List<Materia>();
        }
        public Curso(int pCodigo, string pNombre)
        {
            Codigo = pCodigo;
            Nombre = pNombre;
        }
        public Curso(int pCodigo, string pNombre, int pAño, string pTurno)
        {
            Codigo = pCodigo;
            Nombre = pNombre;
            Año = pAño;
            Turno = new Turno(pTurno);
        }


        public int Codigo { get; set; }
        private bool Activo;
        public int Año { get; set; }
        public string Nombre { get; set; }
        public Turno Turno { get; set; }
        public bool InscripcionAbierta;

        private List<Cursada_de_Alumno> Cursadas;
        private List<Dictado> Dictados;
        private List<Materia> Materias;

        public bool RetornarActivo()
        {
            return this.Activo;
        }

        public List<Cursada_de_Alumno> VerCursadas()
        {
            return this.Cursadas;
        }

        public List<Dictado> VerDictados()
        {
            return this.Dictados;
        }

        public List<Materia> VerMaterias()
        {
            return this.Materias;
        }

    }
}
