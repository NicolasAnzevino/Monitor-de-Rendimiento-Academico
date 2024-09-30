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
    public class MAP_Pregunta_de_Encuesta
    {
        DAL_Pregunta_de_Encuesta DAL_Pregunta_de_Encuesta;
        public MAP_Pregunta_de_Encuesta()
        {
            DAL_Pregunta_de_Encuesta = new DAL_Pregunta_de_Encuesta();
        }
        public List<Pregunta_de_Encuesta> Ver_Preguntas_de_Encuesta(Encuesta pEncuesta)
        {
            try
            {
                DataTable DT = DAL_Pregunta_de_Encuesta.Ver_Preguntas_de_Encuesta(pEncuesta);
                List<Pregunta_de_Encuesta> LP = new List<Pregunta_de_Encuesta>();

                foreach (DataRow DR in DT.Rows)
                {
                    LP.Add(new Pregunta_de_Encuesta(DR.Field<int>(0), DR.Field<string>(1)));
                }

                return LP;
                
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Dictionary<string, List<Pregunta_de_Encuesta>> Ver_Preguntas_de_Encuesta_con_Respuesta(Encuesta pEncuesta, List<Alumno> pAlumnos)
        {
            try
            {
                Dictionary<string, List<Pregunta_de_Encuesta>> Diccionario = new Dictionary<string, List<Pregunta_de_Encuesta>>();

                foreach (Alumno Alumno in pAlumnos)
                {
                    DataTable DT = DAL_Pregunta_de_Encuesta.Ver_Preguntas_de_Encuesta_con_Respuesta(pEncuesta, Alumno);               

                    foreach (DataRow DR in DT.Rows)
                    {
                        if (!(Diccionario.ContainsKey(DR.Field<string>(5))))
                        {
                            Diccionario.Add(DR.Field<string>(5), new List<Pregunta_de_Encuesta>());
                            Pregunta_de_Encuesta P = new Pregunta_de_Encuesta(DR.Field<int>(0), DR.Field<string>(1));
                            P.Respuestas.Add(new Respuesta_de_Encuesta(DR.Field<int>(2), DR.Field<int>(3), DR.Field<string>(4), Alumno));
                            Diccionario[DR.Field<string>(5)].Add(P);
                        }
                        else
                        {
                            Pregunta_de_Encuesta P = new Pregunta_de_Encuesta(DR.Field<int>(0), DR.Field<string>(1));
                            P.Respuestas.Add(new Respuesta_de_Encuesta(DR.Field<int>(2), DR.Field<int>(3), DR.Field<string>(4), Alumno));
                            Diccionario[DR.Field<string>(5)].Add(P);
                        }
                    }
                }

                return Diccionario;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
