using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Entidades;
using Servicios;
using DAL;

namespace Mapeador
{
    public class MAP_Respuesta_de_Encuesta
    {
        DAL_Respuesta_de_Encuesta DAL_Respuesta_de_Encuesta;
        public MAP_Respuesta_de_Encuesta()
        {
            DAL_Respuesta_de_Encuesta = new DAL_Respuesta_de_Encuesta();
        }
    
        public void Enviar_Respuestas_de_Encuesta(Dictionary<int, Respuesta_de_Encuesta> pDiccionario, Alumno pAlumno, Encuesta pEncuesta)
        {
            try
            {
                DAL_Respuesta_de_Encuesta.Enviar_Respuestas_de_Encuesta(pDiccionario, pAlumno, pEncuesta);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
