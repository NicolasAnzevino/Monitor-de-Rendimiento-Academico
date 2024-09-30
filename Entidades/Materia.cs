using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Materia
    {
        public Materia()
        {
            Evaluaciones = new List<Evaluacion>();
            Temas = new List<Tema>();
            Curso = new Curso();
        }

        public Materia(int pCodigo, string pNombre, int pCant_Horas_Semanales, bool pActivo)
        {
            Codigo = pCodigo;
            Nombre = pNombre;
            Cant_Horas_Semanales = pCant_Horas_Semanales;
            Activo = pActivo;

            Evaluaciones = new List<Evaluacion>();
            Temas = new List<Tema>();
            Curso = new Curso();
        }

        public Materia(string pNombre, int pCant_Horas_Semanales, bool pActivo)
        { 
            Nombre = pNombre;
            Cant_Horas_Semanales = pCant_Horas_Semanales;
            Activo = pActivo;

            Evaluaciones = new List<Evaluacion>();
            Temas = new List<Tema>();
            Curso = new Curso();
        }

        public Materia(int pCodigo, string pNombre)
        {
            Codigo = pCodigo;
            Nombre = pNombre;
            Temas = new List<Tema>();
        }
        public Materia(int pCodigo, string pNombre, Curso pCurso)
        {
            Codigo = pCodigo;
            Nombre = pNombre;
            Temas = new List<Tema>();
            Curso = pCurso;
        }
        public Materia(int pCodigo, string pNombre, int pHorasSemanales, bool pActivo, Curso pCurso)
        {
            Codigo = pCodigo;
            Nombre = pNombre;
            Cant_Horas_Semanales = pHorasSemanales;
            Activo = pActivo;
            Curso = pCurso;
            Temas = new List<Tema>();
        }


        private bool Activo;
        public int Cant_Horas_Semanales { get; set; }
        public int Codigo { get; set; }
        public string Nombre { get; set; }      

        private Curso Curso;

        private List<Evaluacion> Evaluaciones;
        private List<Tema> Temas;

        public Curso RetornarCurso()
        {
            return this.Curso;
        }
        public void AsignarCurso(Curso pCurso)
        {
            this.Curso = pCurso;
        }
        public List<Evaluacion> VerEvaluaciones()
        {
            return this.Evaluaciones;
        }
        public List<Tema> VerTemas()
        {
            return this.Temas;
        }

        public bool RetornarActivo()
        {
            return this.Activo;
        }
    }
}
