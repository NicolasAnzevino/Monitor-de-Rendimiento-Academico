using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Dictado
    {
        public Dictado()
        {
            Docentes = new List<Docente>();
        }
        public Dictado(int pCodigo, Curso pCurso, Materia pMateria)
        {
            Codigo = pCodigo;
            Curso = pCurso;
            Materia = pMateria;

            Docentes = new List<Docente>();
        }
        public Dictado(int pCodigo)
        {
            Codigo = pCodigo;

            Curso = new Curso();
            Materia = new Materia();
            Docentes = new List<Docente>();            
        }

        public int Codigo { get; set; }
        public Curso Curso { get; set; }
        public Materia Materia { get; set; }

        private List<Docente> Docentes;

        public List<Docente> VerDocentes()
        {
            return this.Docentes;
        }
    }
}
