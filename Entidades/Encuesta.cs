using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Encuesta
    {
        public Encuesta()
        {

        }

        public Encuesta(int pCodigo, bool pActivo, DateTime pFecha)
        {
            Codigo = pCodigo;
            Activo = pActivo;
            Fecha_Creacion = pFecha;

            Preguntas = new List<Pregunta_de_Encuesta>();
        }
        public Encuesta(bool pActivo, DateTime pFecha)
        {
            Activo = pActivo;
            Fecha_Creacion = pFecha;

            Preguntas = new List<Pregunta_de_Encuesta>();
        }
        public Encuesta(bool pActivo, DateTime pFecha, List<Pregunta_de_Encuesta> pPreguntas)
        {
            Activo = pActivo;
            Fecha_Creacion = pFecha;

            Preguntas = pPreguntas;
        }

        private bool Activo;
        public int Codigo { get; set; }
        public DateTime Fecha_Creacion { get; set; }

        private List<Pregunta_de_Encuesta> Preguntas;

        public List<Pregunta_de_Encuesta> VerPreguntas()
        {
            return this.Preguntas;
        }

        public bool Retornar_Activo()
        {
            return this.Activo;
        }
    }
}
