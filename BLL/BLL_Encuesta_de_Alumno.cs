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
    public class BLL_Encuesta_de_Alumno
    {
        MAP_Encuesta_de_Alumno MAP_Encuesta_de_Alumno;
        public BLL_Encuesta_de_Alumno()
        {
            MAP_Encuesta_de_Alumno = new MAP_Encuesta_de_Alumno();
        }
        public void Enviar_Encuesta_a_Curso(List<Alumno> pAlumnos, int pID)
        {
            try
            {
                MAP_Encuesta_de_Alumno.Enviar_Encuesta_a_Curso(pAlumnos, pID);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Encuesta> Ver_Encuestas_Alummo(string pID)
        {
            try
            {
                return MAP_Encuesta_de_Alumno.Ver_Encuestas_Alummo(pID);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Dictionary<string, bool> Ver_Estado_Resolucion_Alumnos(int pID)
        {
            try
            {
                return MAP_Encuesta_de_Alumno.Ver_Estado_Resolucion_Alumnos(pID);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
