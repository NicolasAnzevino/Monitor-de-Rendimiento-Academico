using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Evaluacion
    {
        public Evaluacion()
        {
            Temas = new List<Tema>();
        }

        public Evaluacion(int pCodigo, string pTitulo, DateTime pFecha, Materia pMateria)
        {
            Codigo = pCodigo;
            Titulo = pTitulo;
            Fecha = pFecha;
            Materia = pMateria;

            Temas = new List<Tema>();
        }
        public Evaluacion(string pTitulo, DateTime pFecha, Materia pMateria)
        {
            Titulo = pTitulo;
            Fecha = pFecha;
            Materia = pMateria;

            Temas = new List<Tema>();
        }
        public Evaluacion(int pCodigo, string pTitulo, Materia pMateria)
        {
            Codigo = pCodigo;
            Titulo = pTitulo;
            Materia = pMateria;

            Temas = new List<Tema>();
        }

        public int Codigo { get; set; }
        public string Titulo { get; set; }
        public DateTime Fecha { get; set; }

        public Materia Materia;

        private List<Tema> Temas;

        public List<Tema> VerTemas()
        {
            return this.Temas;
        }

    }
}
