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
    public class BLL_Encuesta
    {
        MAP_Encuesta MAP_Encuesta;
        public BLL_Encuesta()
        {
            MAP_Encuesta = new MAP_Encuesta();
        }
        public int Crear_Encuesta(List<string> pPreguntas, Curso pCurso)
        {
            try
            {
                List<Pregunta_de_Encuesta> PreguntasDeEncuesta = new List<Pregunta_de_Encuesta>();

                foreach (string S in pPreguntas)
                {
                    PreguntasDeEncuesta.Add(new Pregunta_de_Encuesta(S));
                }

                Encuesta Encuesta = new Encuesta(true, DateTime.Now, PreguntasDeEncuesta);

                int ID = MAP_Encuesta.Crear_Encuesta(Encuesta, pCurso);

                return ID;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Encuesta> Ver_Encuestas_de_Curso(Curso pCurso)
        {
            try
            {
                return MAP_Encuesta.Ver_Encuestas_de_Curso(pCurso);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Dar_de_Baja_Encuesta(Encuesta pEncuesta)
        {
            try
            {
                MAP_Encuesta.Dar_de_Baja_Encuesta(pEncuesta);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
