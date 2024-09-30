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
    public class MAP_Curso
    {
        DAL_Curso DAL_Curso;
        DAL_Evaluacion_de_Alumno DAL_Evaluacion_de_Alumno;

        public MAP_Curso()
        {
            DAL_Curso = new DAL_Curso();
            DAL_Evaluacion_de_Alumno = new DAL_Evaluacion_de_Alumno();
        }

        public int Comprobar_Unicidad_Nombre(string pNombre)
        {
            return DAL_Curso.Comprobar_Unicidad_Nombre(pNombre);
        }
        public void Crear_Curso(Curso pCurso)
        {
            try
            {
                DAL_Curso.Crear_Curso(pCurso);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Curso> Ver_Cursos_Activos()
        {
            try
            {
                DataTable DT = DAL_Curso.Ver_Cursos_Activos();

                List<Curso> LC = new List<Curso>();

                foreach (DataRow DR in DT.Rows)
                {
                    LC.Add(new Curso(DR.Field<int>(0), DR.Field<string>(1), DR.Field<int>(2), DR.Field<string>(3), true, DR.Field<bool>(4)));
                }

                return LC;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Curso> Ver_Cursos_Inactivos()
        {
            try
            {
                DataTable DT = DAL_Curso.Ver_Cursos_Inactivos();

                List<Curso> LC = new List<Curso>();

                foreach (DataRow DR in DT.Rows)
                {
                    LC.Add(new Curso(DR.Field<int>(0), DR.Field<string>(1), DR.Field<int>(2), DR.Field<string>(3), false, DR.Field<bool>(4)));
                }

                return LC;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Dar_De_Baja_Curso(Curso pCurso)
        {
            try
            {
                DAL_Curso.Dar_De_Baja_Curso(pCurso);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Modificar_Curso(Curso pCurso)
        {
            try
            {
                DAL_Curso.Modificar_Curso(pCurso);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Alumno> Ver_Alumnos_del_Curso(Curso pCurso)
        {
            try
            {
                DataTable DT = DAL_Curso.Ver_Alumnos_del_Curso(pCurso);
                List<Alumno> LA = new List<Alumno>();

                foreach (DataRow DR in DT.Rows)
                {
                    LA.Add(new Alumno(DR.Field<string>(0), DR.Field<int>(1), DR.Field<string>(2), DR.Field<string>(3), DR.Field<string>(7), DR.Field<string>(4), DR.Field<DateTime>(5), DR.Field<DateTime>(6), true));
                }

                return LA;

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Dictado> Ver_Dictados_del_Curso(Curso pCurso)
        {
            try
            {
                DAL_Dictado DAL_Dictado = new DAL_Dictado();

                DataTable DT = DAL_Curso.Ver_Dictados_del_Curso(pCurso);
                List<Dictado> LD = new List<Dictado>();

                foreach (DataRow DR in DT.Rows)
                {
                    Dictado Dictado = new Dictado(DR.Field<int>(0));
                    Dictado.Materia = new Materia(DR.Field<int>(1), DR.Field<string>(2));

                    DataTable DTDocentes = DAL_Dictado.Ver_Docentes_De_Dictado(Dictado);

                    foreach (DataRow dataRow in DTDocentes.Rows)
                    {
                        Dictado.VerDocentes().Add(new Docente(dataRow.Field<string>(0), dataRow.Field<string>(1), dataRow.Field<string>(2)));
                    }

                    LD.Add(Dictado);
                }

                return LD;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Curso Obtener_Curso_de_Materia(Materia pMateria)
        {
            try
            {
                DataTable DT = DAL_Curso.Obtener_Curso_de_Materia(pMateria);

                Curso C = new Curso(DT.Rows[0].Field<int>(0), DT.Rows[0].Field<string>(1));

                return C;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Curso Obtener_Curso_de_Dictado(Dictado pDictado)
        {
            try
            {
                DataTable DT = DAL_Curso.Obtener_Curso_de_Dictado(pDictado);

                Curso C = new Curso(DT.Rows[0].Field<int>(0), DT.Rows[0].Field<string>(1), DT.Rows[0].Field<int>(2), DT.Rows[0].Field<string>(3));

                return C;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Cerrar_Inscripcion_Curso(Curso pCurso)
        {
            try
            {
                DAL_Curso.Cerrar_Inscripcion_Curso(pCurso);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Curso> Ver_Cursos_Con_Inscripciones_Abiertas()
        {
            try
            {
                DataTable DT = DAL_Curso.Ver_Cursos_Con_Inscripciones_Abiertas();

                List<Curso> LC = new List<Curso>();

                foreach (DataRow DR in DT.Rows)
                {
                    LC.Add(new Curso(DR.Field<int>(0), DR.Field<string>(1), DR.Field<int>(2), DR.Field<string>(3)));
                }

                return LC;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Curso> Ver_Cursos_Con_Inscripciones_Cerradas()
        {
            try
            {
                DataTable DT = DAL_Curso.Ver_Cursos_Con_Inscripciones_Cerradas();

                List<Curso> LC = new List<Curso>();

                foreach (DataRow DR in DT.Rows)
                {
                    LC.Add(new Curso(DR.Field<int>(0), DR.Field<string>(1), DR.Field<int>(2), DR.Field<string>(3)));
                }

                return LC;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public bool Verificar_Docente_es_Alumno_del_Curso(Docente pDocente, Curso pCurso)
        {
            try
            {
                return DAL_Curso.Verificar_Docente_es_Alumno_del_Curso(pDocente, pCurso);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public bool Verificar_Alumno_es_Docente_del_Curso(Alumno pAlumno, Curso pCurso)
        {
            try
            {
                return DAL_Curso.Verificar_Alumno_es_Docente_del_Curso(pAlumno, pCurso);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Curso> Ver_Cursos_Con_Inscripciones_Cerradas_Curso_Inactivo()
        {
            try
            {
                DataTable DT = DAL_Curso.Ver_Cursos_Con_Inscripciones_Cerradas_Curso_Inactivo();

                List<Curso> LC = new List<Curso>();

                foreach (DataRow DR in DT.Rows)
                {
                    LC.Add(new Curso(DR.Field<int>(0), DR.Field<string>(1), DR.Field<int>(2), DR.Field<string>(3)));
                }

                return LC;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Curso> Ver_Cursos_Con_Inscripciones_Abiertas_Curso_Inactivo()
        {
            try
            {
                DataTable DT = DAL_Curso.Ver_Cursos_Con_Inscripciones_Abiertas_Curso_Inactivo();

                List<Curso> LC = new List<Curso>();

                foreach (DataRow DR in DT.Rows)
                {
                    LC.Add(new Curso(DR.Field<int>(0), DR.Field<string>(1), DR.Field<int>(2), DR.Field<string>(3)));
                }

                return LC;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public int Obtener_Promedio_Curso(Curso pCurso)
        {
            try
            {
                return DAL_Curso.Obtener_Promedio_Curso(pCurso);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Evaluacion> Obtener_Evaluaciones_de_Curso(Curso pCurso)
        {
            try
            {
                List<Evaluacion> Evaluaciones = new List<Evaluacion>();
                List<Materia> Materias = new List<Materia>();

                DataTable DTMaterias = DAL_Curso.Obtener_Materias_de_Evaluaciones_de_Curso(pCurso);

                foreach (DataRow DRMateria in DTMaterias.Rows)
                {
                    Materias.Add(new Materia(DRMateria.Field<int>(0), DRMateria.Field<string>(1)));
                }

                DataTable DTEvaluaciones = DAL_Curso.Obtener_Evaluaciones_de_Curso(pCurso);

                foreach (DataRow DREvaluacion in DTEvaluaciones.Rows)
                {
                    Evaluaciones.Add(new Evaluacion(DREvaluacion.Field<int>(0), DREvaluacion.Field<string>(1), DREvaluacion.Field<DateTime>(4), Materias.Find(X => X.Codigo == DREvaluacion.Field<int>(2))));
                }

                return Evaluaciones;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Dictionary<Evaluacion, bool> ObtenerEvaluacionesRealizadas(List<Evaluacion> pEvaluaciones)
        {
            try
            {
                Dictionary<Evaluacion, bool> Diccionario = new Dictionary<Evaluacion, bool>();

                foreach (Evaluacion evaluacion in pEvaluaciones)
                {
                    Diccionario.Add(evaluacion, DAL_Evaluacion_de_Alumno.Verificar_Evaluacion_Tiene_Calificaciones(evaluacion));
                }

                return Diccionario;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
      
    }
}
