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
    public class MAP_Encuesta_de_Alumno
    {
        DAL_Encuesta_de_Alumno DAL_Encuesta_de_Alumno;
        public MAP_Encuesta_de_Alumno()
        {
            DAL_Encuesta_de_Alumno = new DAL_Encuesta_de_Alumno();
        }

        public void Enviar_Encuesta_a_Curso(List<Alumno> pAlumnos, int pID)
        {
            try
            {
                DAL_Encuesta_de_Alumno.Enviar_Encuesta_a_Curso(pAlumnos, pID);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Encuesta> Ver_Encuestas_Alummo(string pID)
        {
            try
            {
                DataTable DT = DAL_Encuesta_de_Alumno.Ver_Encuestas_Alummo(pID);
                List<Encuesta> LE = new List<Encuesta>();

                foreach (DataRow DR in DT.Rows)
                {
                    LE.Add(new Encuesta(DR.Field<int>(0), true, DR.Field<DateTime>(1)));
                }

                return LE;                
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Dictionary<string, bool> Ver_Estado_Resolucion_Alumnos(int pID)
        {
            try
            {
                DataTable DT = DAL_Encuesta_de_Alumno.Ver_Estado_Resolucion_Alumnos(pID);

                Dictionary<string, bool> Diccionario = new Dictionary<string, bool>();

                foreach (DataRow DR in DT.Rows)
                {
                    Diccionario.Add(DR.Field<string>(0), DR.Field<bool>(1));
                }

                return Diccionario;                
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }        
    }
}
