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
    public class BLL_Curso
    {
        MAP_Curso MAP_Curso;
        MAP_Inasistencia MAP_Inasistencia;
        MAP_Evaluacion_de_Alumno MAP_Evaluacion_de_Alumno;
        public BLL_Curso()
        {
            MAP_Curso = new MAP_Curso();
            MAP_Inasistencia = new MAP_Inasistencia();
            MAP_Evaluacion_de_Alumno = new MAP_Evaluacion_de_Alumno();
        }

        public int Comprobar_Unicidad_Codigo(string pNombre)
        {
            return MAP_Curso.Comprobar_Unicidad_Nombre(pNombre);
        }

        public void Crear_Curso(string pNombre, int pAño, Turno pTurno)
        {
            try
            {
                Curso C = new Curso(pNombre, pAño, pTurno, true, true);
                MAP_Curso.Crear_Curso(C);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public List<Curso> Ver_Cursos_Activos()
        {
            try
            {
                return MAP_Curso.Ver_Cursos_Activos();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Curso> Ver_Cursos_Inactivos()
        {
            try
            {
                return MAP_Curso.Ver_Cursos_Inactivos();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }    
        public void Dar_De_Baja_Curso(Curso pCurso)
        {
            try
            {
                MAP_Curso.Dar_De_Baja_Curso(pCurso);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Modificar_Curso(Curso pCurso)
        {
            try
            {
                MAP_Curso.Modificar_Curso(pCurso);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Curso> Ver_Cursos_Codigo(List<Curso> pLC, string pCodigo)
        {
            IEnumerable<Curso> IEC = from X in pLC
                                      where X.Codigo.ToString().StartsWith(pCodigo)
                                      select X;

            List<Curso> ListaDeConsulta = IEC.ToList();

            return ListaDeConsulta;
        }
        public List<Curso> Ver_Cursos_Nombre(List<Curso> pLC, string pNombre)
        {
            IEnumerable<Curso> IEC = from X in pLC
                                     where X.Nombre.StartsWith(pNombre)
                                     select X;

            List<Curso> ListaDeConsulta = IEC.ToList();

            return ListaDeConsulta;
        }
        public List<Curso> Ver_Cursos_Año(List<Curso> pLC, string pAño)
        {
            IEnumerable<Curso> IEC = from X in pLC
                                     where X.Año.ToString().StartsWith(pAño)
                                     select X;

            List<Curso> ListaDeConsulta = IEC.ToList();

            return ListaDeConsulta;
        }
        public List<Curso> Ver_Cursos_Turno(List<Curso> pLC, string pTurno)
        {
            IEnumerable<Curso> IEC = from X in pLC
                                     where X.Turno.Nombre.StartsWith(pTurno)
                                     select X;

            List<Curso> ListaDeConsulta = IEC.ToList();

            return ListaDeConsulta;
        }
        public List<Curso> Ver_Cursos_Insc_Abierta(List<Curso> pLC)
        {
            IEnumerable<Curso> IEC = from X in pLC
                                     where X.InscripcionAbierta == true
                                     select X;

            List<Curso> ListaDeConsulta = IEC.ToList();

            return ListaDeConsulta;
        }
        public List<Curso> Ver_Cursos_Insc_Cerrada(List<Curso> pLC)
        {
            IEnumerable<Curso> IEC = from X in pLC
                                     where X.InscripcionAbierta == false
                                     select X;

            List<Curso> ListaDeConsulta = IEC.ToList();

            return ListaDeConsulta;
        }

        public List<Alumno> Ver_Alumnos_del_Curso(Curso pCurso)
        {
            try
            {
                return MAP_Curso.Ver_Alumnos_del_Curso(pCurso);

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public List<Dictado> Ver_Dictados_del_Curso(Curso pCurso)
        {
            try
            {
                return MAP_Curso.Ver_Dictados_del_Curso(pCurso);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Curso Obtener_Curso_de_Materia(Materia pMateria)
        {
            try
            {
                return MAP_Curso.Obtener_Curso_de_Materia(pMateria);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Curso Obtener_Curso_de_Dictado(Dictado pDictado)
        {
            try
            {
                return MAP_Curso.Obtener_Curso_de_Dictado(pDictado);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Cerrar_Inscripcion_Curso(Curso pCurso)
        {
            try
            {
                MAP_Curso.Cerrar_Inscripcion_Curso(pCurso);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Curso> Ver_Cursos_Con_Inscripciones_Cerradas()
        {
            try
            {
                return MAP_Curso.Ver_Cursos_Con_Inscripciones_Cerradas();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Curso> Ver_Cursos_Con_Inscripciones_Abiertas()
        {
            try
            {
                return MAP_Curso.Ver_Cursos_Con_Inscripciones_Abiertas();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Curso> Ver_Cursos_Con_Inscripciones_Cerradas_Curso_Inactivo()
        {
            try
            {
                return MAP_Curso.Ver_Cursos_Con_Inscripciones_Cerradas_Curso_Inactivo();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Curso> Ver_Cursos_Con_Inscripciones_Abiertas_Curso_Inactivo()
        {
            try
            {
                return MAP_Curso.Ver_Cursos_Con_Inscripciones_Abiertas_Curso_Inactivo();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public bool Verificar_Docente_es_Alumno_del_Curso(Docente pDocente, Curso pCurso)
        {
            try
            {
                return MAP_Curso.Verificar_Docente_es_Alumno_del_Curso(pDocente, pCurso);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public bool Verificar_Alumno_es_Docente_del_Curso(Alumno pAlumno, Curso pCurso)
        {
            try
            {
                return MAP_Curso.Verificar_Alumno_es_Docente_del_Curso(pAlumno, pCurso);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Dictionary<string, bool> Ver_Estado_de_Alumnos_de_Curso(Curso pCurso)
        {
            try
            {
                return MAP_Inasistencia.Ver_Estado_de_Alumnos_de_Curso(pCurso);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Dictionary<Materia, List<Evaluacion_de_Alumno>> Obtener_Docente_Materia_Evaluacion_de_Curso(Curso pCurso)
        {
            try
            {
                return MAP_Evaluacion_de_Alumno.Obtener_Docente_Materia_Evaluacion_de_Curso(pCurso);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public int Obtener_Promedio_Curso(Curso pCurso)
        {
            try
            {
                return MAP_Curso.Obtener_Promedio_Curso(pCurso);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        //here boy
        public List<Evaluacion> Obtener_Evaluaciones_de_Curso(Curso pCurso)
        {
            try
            {
                return MAP_Curso.Obtener_Evaluaciones_de_Curso(pCurso);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Dictionary<Evaluacion, bool> ObtenerEvaluacionesRealizadas(List<Evaluacion> pEvaluaciones)
        {
            try
            {
                return MAP_Curso.ObtenerEvaluacionesRealizadas(pEvaluaciones);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public string Obtener_Conclusion(int pPromedio, int pIdioma)
        {
            try
            {
                string Conclusion = "";        
                
                if (pIdioma == 1)
                {
                    if (pPromedio <= 5)
                    {
                        Conclusion = "Promedio Total: " + pPromedio.ToString() + "\r\nRendimiento: Necesita mejorar";
                    }
                    else if (pPromedio <= 8)
                    {
                        Conclusion = "Promedio Total: " + pPromedio.ToString() + "\r\nRendimiento: Suficiente";
                    }
                    else
                    {
                        Conclusion = "Promedio Total: " + pPromedio.ToString() + "\r\nRendimiento: Destacado";
                    }
                }

                else if (pIdioma == 2)
                {
                    if (pPromedio <= 5)
                    {
                        Conclusion = "Total Average: " + pPromedio.ToString() + "\r\nPerformance: Needs improvement";
                    }
                    else if (pPromedio <= 8)
                    {
                        Conclusion = "Total Average:  " + pPromedio.ToString() + "\r\nPerformance: Enough";
                    }
                    else
                    {
                        Conclusion = "Total Average: " + pPromedio.ToString() + "\r\nPerformance: Outstanding";
                    }
                }



                return Conclusion;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }


    }
}
