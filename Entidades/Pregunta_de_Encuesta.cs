using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Pregunta_de_Encuesta
    {
        public Pregunta_de_Encuesta()
        {
            Respuestas = new List<Respuesta_de_Encuesta>();
        }

        public Pregunta_de_Encuesta(int pCodigo, string pPregunta)
        {
            Codigo = pCodigo;
            Pregunta = pPregunta;
            Respuestas = new List<Respuesta_de_Encuesta>();
        }
        public Pregunta_de_Encuesta(string pPregunta)
        {
            Pregunta = pPregunta;
            Respuestas = new List<Respuesta_de_Encuesta>();
        }

        public int Codigo { get; set; }
        public string Pregunta { get; set; }

        public List<Respuesta_de_Encuesta> Respuestas;
    }
}
