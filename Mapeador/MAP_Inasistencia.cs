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
    public class MAP_Inasistencia
    {
        DAL_Inasistencia DAL_Inasistencia;
        public MAP_Inasistencia()
        {
            DAL_Inasistencia = new DAL_Inasistencia();
        }

        public Dictionary<int, decimal> Obtener_Cant_Inasistencias(List<Alumno> pLA)
        {
            try
            {
                Dictionary<int, decimal> Diccionario = new Dictionary<int, decimal>();

                foreach (Alumno Alumno in pLA)
                {
                    Diccionario.Add(Alumno.VerCursadas()[0].Codigo, DAL_Inasistencia.Obtener_Cant_Inasistencias(Alumno.VerCursadas()[0]));
                }

                return Diccionario;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Obtener_Inasistencias_Alumnos(List<Alumno> pLA)
        {
            try
            {
                foreach (Alumno pAlumno in pLA)
                {
                    DataTable DT = DAL_Inasistencia.Obtener_Inasistencias_Alumnos(pAlumno.VerCursadas()[0]);

                    foreach (DataRow DR in DT.Rows)
                    {
                        Inasistencia I = new Inasistencia(DR.Field<int>(0), DR.Field<DateTime>(1), DR.Field<string>(2), DR.Field<decimal>(3), DR.Field<string>(4));

                        pAlumno.VerCursadas()[0].VerInasistencias().Add(I);
                    }
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Enviar_Inasistencias(List<Alumno> pLA, Curso pCurso)
        {
            try
            {
                DAL_Inasistencia.Eliminar_Inasistencias_Actuales(pCurso);

                if (pLA.Count>0)
                {
                    foreach (Alumno Alumno in pLA)
                    {
                        if (Alumno.VerCursadas()[0].VerInasistencias().Count > 0)
                        {
                            DAL_Inasistencia.Enviar_Inasistencias(Alumno.VerCursadas()[0], pCurso);
                        }
                    }
                }                
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Inasistencia> Ver_Inasistencia_Alumno(Cursada_de_Alumno pCursada)
        {
            try
            {
                List<Inasistencia> LI = new List<Inasistencia>();
                DataTable DT = DAL_Inasistencia.Ver_Inasistencia_Alumno(pCursada);

                foreach (DataRow DR in DT.Rows)
                {
                    LI.Add(new Inasistencia(DR.Field<int>(0), DR.Field<DateTime>(1), DR.Field<string>(2), DR.Field<decimal>(3), DR.Field<string>(4)));
                }

                return LI;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void Eliminar_Inasistencia(Inasistencia pInasistencia)
        {
            try
            {
                DAL_Inasistencia.Eliminar_Inasistencia(pInasistencia);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public decimal Obtener_Total_Inasistencias_de_Cursada(Cursada_de_Alumno pCursada)
        {
            try
            {
                return DAL_Inasistencia.Obtener_Cant_Inasistencias(pCursada);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Modificar_Inasistencia(Cursada_de_Alumno pCursada, Inasistencia pInasistencia)
        {
            try
            {
                DAL_Inasistencia.Modificar_Inasistencia(pCursada, pInasistencia);
            }
            catch (Exception ex) {  throw new Exception(ex.Message); }
        }
        public void Agregar_Inasistencia(Cursada_de_Alumno pCursada, Inasistencia pInasistencia)
        {
            try
            {
                DAL_Inasistencia.Agregar_Inasistencia(pCursada, pCursada.Curso);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public int Verificar_Inasistencia(Cursada_de_Alumno pCursada, DateTime pFecha)
        {
            try
            {
                return DAL_Inasistencia.Verificar_Inasistencia(pCursada, pFecha);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Dictionary<string, bool> Ver_Estado_de_Alumnos_de_Curso(Curso pCurso)
        {
            try
            {
                Dictionary<string, bool> Diccionario = new Dictionary<string, bool>();
                DataTable DT = DAL_Inasistencia.Ver_Estado_de_Alumnos_de_Curso(pCurso);

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
