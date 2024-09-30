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
    public class MAP_Evaluacion
    {
        DAL_Evaluacion DAL_Evaluacion;
        public MAP_Evaluacion()
        {
            DAL_Evaluacion = new DAL_Evaluacion();
        }

        public List<Evaluacion> Ver_Evaluaciones_de_Materia(Materia pMateria)
        {
            try
            {
                DataTable DT = DAL_Evaluacion.Ver_Evaluaciones_de_Materia(pMateria);
                List<Evaluacion> LE = new List<Evaluacion>();

                foreach (DataRow DR in DT.Rows)
                {
                    LE.Add(new Evaluacion(DR.Field<int>(0), DR.Field<string>(1), DR.Field<DateTime>(2), pMateria));
                }

                return LE;
                
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void Crear_Evaluacion_de_Materia(Evaluacion pEvaluacion, List<Tema> pTemas)
        {
            try
            {
                int IDEvaluacion = DAL_Evaluacion.Crear_Evaluacion_de_Materia(pEvaluacion);

                //intentar mejroarlo
                //DAL_Evaluacion.Establecer_Temas_de_Evalaucion(pTemas, IDEvaluacion);

                foreach (Tema T in pTemas)
                {
                    DAL_Evaluacion.Establecer_Temas_de_Evaluacion(T, IDEvaluacion);
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Modificar_Evaluacion(Evaluacion pEvaluacion, List<Tema> pTemas)
        {
            try
            {
                DAL_Evaluacion.Modificar_Evaluacion(pEvaluacion);

                foreach (Tema T in pTemas)
                {
                    DAL_Evaluacion.Establecer_Temas_de_Evaluacion(T, pEvaluacion.Codigo);
                }

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Borrar_Evaluacion(Evaluacion pEvaluacion)
        {
            try
            {
                DAL_Evaluacion.Borrar_Evaluacion(pEvaluacion);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Evaluacion> Obtener_Evaluaciones_Docente_Tema(Docente pDocente, Tema pTema)
        {
            try
            {
                DataTable DT = DAL_Evaluacion.Obtener_Evaluaciones_Docente_Tema(pDocente, pTema);
                List<Evaluacion> LE = new List<Evaluacion>();

                foreach (DataRow DR in DT.Rows)
                {
                    Curso C = new Curso(DR.Field<int>(3), DR.Field<string>(4), DR.Field<int>(5), DR.Field<string>(6));
                    Materia M = new Materia(DR.Field<int>(7), DR.Field<string>(8), 1, true, C);
                    Evaluacion E = new Evaluacion(DR.Field<int>(0), DR.Field<string>(1), DR.Field<DateTime>(2), M);

                    LE.Add(E);
                }

                return LE;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
