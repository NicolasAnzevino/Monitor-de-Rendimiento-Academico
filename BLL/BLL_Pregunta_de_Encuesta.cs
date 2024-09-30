using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Servicios;
using Mapeador;

namespace BLL
{
    public class BLL_Pregunta_de_Encuesta
    {
        MAP_Pregunta_de_Encuesta MAP_Pregunta_de_Encuesta;
        MAP_Respuesta_de_Encuesta MAP_Respuesta_de_Encuesta;
        public BLL_Pregunta_de_Encuesta()
        {
            MAP_Pregunta_de_Encuesta = new MAP_Pregunta_de_Encuesta();
            MAP_Respuesta_de_Encuesta = new MAP_Respuesta_de_Encuesta();
        }

        public List<Pregunta_de_Encuesta> Ver_Preguntas_de_Encuesta(Encuesta pEncuesta)
        {
            try
            {
                return MAP_Pregunta_de_Encuesta.Ver_Preguntas_de_Encuesta(pEncuesta);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Respuesta_de_Encuesta Asignar_Valoracion(int pValor, string pDesc)
        {
            try
            {
                Respuesta_de_Encuesta Respuesta = new Respuesta_de_Encuesta(pValor, pDesc);
                return Respuesta;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Enviar_Respuestas_de_Encuesta(Dictionary<int, Respuesta_de_Encuesta> pDiccionario, Alumno pAlumno, Encuesta pEncuesta)
        {
            try
            {
                MAP_Respuesta_de_Encuesta.Enviar_Respuestas_de_Encuesta(pDiccionario, pAlumno, pEncuesta);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Dictionary<string, List<Pregunta_de_Encuesta>> Ver_Preguntas_de_Encuesta_con_Respuesta(Encuesta pEncuesta, List<Alumno> pAlumnos)
        {
            try
            {
                return MAP_Pregunta_de_Encuesta.Ver_Preguntas_de_Encuesta_con_Respuesta(pEncuesta, pAlumnos);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}

