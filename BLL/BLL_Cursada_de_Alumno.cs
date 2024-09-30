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
    public class BLL_Cursada_de_Alumno
    {
        MAP_Cursada_de_Alumno MAP_Cursada_De_Alumno;
        MAP_Evaluacion_de_Alumno MAP_Evaluacion_de_Alumno;
        MAP_Inasistencia MAP_Inasistencia;
        public BLL_Cursada_de_Alumno()
        {
            MAP_Cursada_De_Alumno = new MAP_Cursada_de_Alumno();
            MAP_Evaluacion_de_Alumno = new MAP_Evaluacion_de_Alumno();
            MAP_Inasistencia = new MAP_Inasistencia();
        }
        public void Agregar_Cursada(Alumno pAlumno, Curso pCurso)
        {
            try
            {
                Cursada_de_Alumno C = new Cursada_de_Alumno(pAlumno, pCurso);

                MAP_Cursada_De_Alumno.Agregar_Cursada(C);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public bool Verficar_Existencia_Cursada(Alumno pAlumno, Curso pCurso)
        {
            try
            {
                return MAP_Cursada_De_Alumno.Verficar_Existencia_Cursada(pAlumno, pCurso);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public List<Cursada_de_Alumno> Ver_Cursadas_de_Alumno(Alumno pAlumno)
        {
            try
            {
                return MAP_Cursada_De_Alumno.Ver_Cursadas_de_Alumno(pAlumno);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Cursada_de_Alumno Buscar_Cursada_de_Alumno(Alumno pAlumno, Curso pCurso)
        {
            try
            {
                return MAP_Cursada_De_Alumno.Buscar_Cursada_de_Alumno(pAlumno, pCurso);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void Agregar_Evaluacion_de_Alumno(DateTime pFecha, int pCalificacion, Docente pDocente, Cursada_de_Alumno pCursada, Evaluacion pEvaluacion)
        {
            try
            {
                Evaluacion_de_Alumno Evaluacion_de_Alumno = new Evaluacion_de_Alumno(pCalificacion, pFecha, pDocente, pEvaluacion);
                MAP_Evaluacion_de_Alumno.Agregar_Evaluacion_de_Alumno(Evaluacion_de_Alumno, pCursada);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public bool Verificar_Existencia_Evaluaciones_Alumno(int pID)
        {
            try
            {
                return MAP_Evaluacion_de_Alumno.Verificar_Existencia_Evaluaciones_Alumno(pID);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Evaluacion_de_Alumno> Ver_Evaluaciones_de_Cursada(Cursada_de_Alumno pCursada)
        {
            try
            {
                return MAP_Evaluacion_de_Alumno.Ver_Evaluaciones_de_Cursada(pCursada);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Evaluacion_de_Alumno> Ver_EvaAlu_Materia(List<Evaluacion_de_Alumno> pLEA, string pMateria)
        {
            IEnumerable<Evaluacion_de_Alumno> IEA = from X in pLEA
                                      where X.Evaluacion.Materia.Nombre.StartsWith(pMateria)
                                      select X;

            List<Evaluacion_de_Alumno> ListaDeConsulta = IEA.ToList();

            return ListaDeConsulta;
        }
        public List<Evaluacion_de_Alumno> Ver_EvaAlu_Calificacion(List<Evaluacion_de_Alumno> pLEA, int pCalificacion)
        {
            IEnumerable<Evaluacion_de_Alumno> IEA = from X in pLEA
                                                    where X.Calificacion.ToString().StartsWith(pCalificacion.ToString())
                                                    select X;

            List<Evaluacion_de_Alumno> ListaDeConsulta = IEA.ToList();

            return ListaDeConsulta;
        }
        public List<Evaluacion_de_Alumno> Ver_EvaAlu_Fecha(List<Evaluacion_de_Alumno> pLEA, DateTime pFecha)
        {
            IEnumerable<Evaluacion_de_Alumno> IEA = from X in pLEA
                                                    where X.Fecha.ToShortDateString().StartsWith(pFecha.ToShortDateString())
                                                    select X;

            List<Evaluacion_de_Alumno> ListaDeConsulta = IEA.ToList();

            return ListaDeConsulta;
        }
        public List<Evaluacion_de_Alumno> Ver_Evaluaciones_de_Cursada_de_Materia(Cursada_de_Alumno pCursada, Materia pMateria)
        {
            try
            {
                return MAP_Evaluacion_de_Alumno.Ver_Evaluaciones_de_Cursada_de_Materia(pCursada, pMateria);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Eliminar_Evaluacion_de_Alumno(Evaluacion_de_Alumno pEvaAlu)
        {
            try
            {
                MAP_Evaluacion_de_Alumno.Eliminar_Evaluacion_de_Alumno(pEvaAlu);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Modificar_Evaluacion_de_Alumno(Evaluacion_de_Alumno pEvaAlu)
        {
            try
            {
                MAP_Evaluacion_de_Alumno.Modificar_Evaluacion_de_Alumno(pEvaAlu);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Ver_Cursadas_de_Curso(List<Alumno> pAlumnos)
        {
            try
            {
                MAP_Cursada_De_Alumno.Ver_Cursadas_de_Curso(pAlumnos);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Evaluacion_de_Alumno> Obtener_Eva_Alu_Rendimiento(Cursada_de_Alumno pCursada)
        {
            try
            {
                return MAP_Evaluacion_de_Alumno.Obtener_Eva_Alu_Rendimiento(pCursada);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public int Obtener_Cant_Aprobados(List<Evaluacion_de_Alumno> pLEA)
        {
            try
            {
                int Cant = 0;

                foreach (Evaluacion_de_Alumno EA in pLEA)
                {
                    if (EA.Calificacion >= 6)
                    {
                        Cant++;
                    }
                }

                return Cant;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public int Obtener_Cant_Reprobados(List<Evaluacion_de_Alumno> pLEA)
        {
            try
            {
                int Cant = 0;

                foreach (Evaluacion_de_Alumno EA in pLEA)
                {
                    if (EA.Calificacion < 6)
                    {
                        Cant++;
                    }
                }

                return Cant;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<string> Obtener_Materias_Mejor_Rendimiento(List<Evaluacion_de_Alumno> pLEA)
        {
            try
            {
                Dictionary<string, int> DiccionarioAprobados = new Dictionary<string, int>();

                List<int> CalificacionesMateria = new List<int>();

                List<Materia> Materias = new List<Materia>();

                foreach (Evaluacion_de_Alumno EVA in pLEA)
                {
                    if (!(Materias.Exists(X=> X.Nombre == EVA.Evaluacion.Materia.Nombre)))
                    {
                        Materias.Add(EVA.Evaluacion.Materia);
                    }
                }

                foreach (Materia M in Materias)
                {
                    IEnumerable<Evaluacion_de_Alumno> IEA = from X in pLEA
                                                            where X.Evaluacion.Materia.Nombre == M.Nombre
                                                            select X;

                    int promedio = 0;

                    foreach (Evaluacion_de_Alumno EA in IEA)
                    {
                        promedio += EA.Calificacion;
                    }

                    promedio = promedio / IEA.Count();

                    DiccionarioAprobados.Add(M.Nombre, promedio);
                }

                List<string> MateriasBuenRendimiento = new List<string>();

                int max = 0;
                string Materia = "";

                foreach (KeyValuePair<string,int> item in DiccionarioAprobados)
                {
                    if (max == 0)
                    {
                        if (item.Value>=6)
                        {
                            max = item.Value;
                            Materia = item.Key;
                        }                        
                    }
                    else
                    {
                        if (item.Value > max)
                        {
                            max = item.Value;
                            Materia = item.Key;
                        }
                    }
                }

                MateriasBuenRendimiento.Add(Materia);

                DiccionarioAprobados.Remove(Materia);

                foreach (KeyValuePair<string, int> item in DiccionarioAprobados)
                {
                    if (item.Value==max)
                    {
                        MateriasBuenRendimiento.Add(item.Key);
                    }
                }

                return MateriasBuenRendimiento;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<string> Obtener_Materias_Peor_Rendimiento(List<Evaluacion_de_Alumno> pLEA)
        {
            try
            {
                Dictionary<string, int> DiccionarioAprobados = new Dictionary<string, int>();

                List<int> CalificacionesMateria = new List<int>();

                List<Materia> Materias = new List<Materia>();

                foreach (Evaluacion_de_Alumno EVA in pLEA)
                {
                    if (!(Materias.Exists(X => X.Nombre == EVA.Evaluacion.Materia.Nombre)))
                    {
                        Materias.Add(EVA.Evaluacion.Materia);
                    }
                }

                foreach (Materia M in Materias)
                {
                    IEnumerable<Evaluacion_de_Alumno> IEA = from X in pLEA
                                                            where X.Evaluacion.Materia.Nombre == M.Nombre
                                                            select X;

                    int promedio = 0;

                    foreach (Evaluacion_de_Alumno EA in IEA)
                    {
                        promedio += EA.Calificacion;
                    }

                    promedio = promedio / IEA.Count();

                    DiccionarioAprobados.Add(M.Nombre, promedio);
                }

                List<string> MateriasBuenRendimiento = new List<string>();

                int max = 0;
                string Materia = "";

                foreach (KeyValuePair<string, int> item in DiccionarioAprobados)
                {
                    if (max == 0)
                    {
                        if (item.Value < 6)
                        {
                            max = item.Value;
                            Materia = item.Key;
                        }
                    }
                    else
                    {
                        if (item.Value < max)
                        {
                            max = item.Value;
                            Materia = item.Key;
                        }
                    }
                }

                MateriasBuenRendimiento.Add(Materia);

                DiccionarioAprobados.Remove(Materia);

                foreach (KeyValuePair<string, int> item in DiccionarioAprobados)
                {
                    if (item.Value == max)
                    {
                        MateriasBuenRendimiento.Add(item.Key);
                    }
                }

                return MateriasBuenRendimiento;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public int Obtener_Cant_Materias(List<Evaluacion_de_Alumno> pLEA)
        {
            try
            {
                List<string> LM = new List<string>();

                foreach (Evaluacion_de_Alumno EA in pLEA)
                {
                    if (!(LM.Exists(X=> X == EA.Evaluacion.Materia.Nombre)))
                    {
                        LM.Add(EA.Evaluacion.Materia.Nombre);
                    }
                }

                return LM.Count();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public string Obtener_Conclusion(List<Evaluacion_de_Alumno> pLEA, int pIdioma)
        {
            try
            {
                int total = 0;
                string Conclusion = "";

                foreach (Evaluacion_de_Alumno EVAL in pLEA)
                {
                    total += EVAL.Calificacion;
                }

                total = total / pLEA.Count();

                if (pIdioma==1)
                {
                    if (total <= 5)
                    {
                        Conclusion = "Promedio Total: " + total.ToString() + "\r\nRendimiento: Necesita mejorar";
                    }
                    else if (total <= 8)
                    {
                        Conclusion = "Promedio Total: " + total.ToString() + "\r\nRendimiento: Suficiente";
                    }
                    else
                    {
                        Conclusion = "Promedio Total: " + total.ToString() + "\r\nRendimiento: Destacado";
                    }
                }

                else if (pIdioma==2)
                {
                    if (total <= 5)
                    {
                        Conclusion = "Total Average: " + total.ToString() + "\r\nPerformance: Needs improvement";
                    }
                    else if (total <= 8)
                    {
                        Conclusion = "Total Average:  " + total.ToString() + "\r\nPerformance: Enough";
                    }
                    else
                    {
                        Conclusion = "Total Average: " + total.ToString() + "\r\nPerformance: Outstanding";
                    }
                }

                

                return Conclusion;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public int Obtener_Promedio(List<Evaluacion_de_Alumno> pLEA)
        {
            try
            {
                int total = 0;

                foreach (Evaluacion_de_Alumno EVAL in pLEA)
                {
                    total += EVAL.Calificacion;
                }

                total = total / pLEA.Count();

                return total;                
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public bool Verificar_Repeticion_Evaluacion(DateTime pFecha, Evaluacion pEvaluacion, Cursada_de_Alumno pCur)
        {
            try
            {
                return MAP_Evaluacion_de_Alumno.Verificar_Repeticion_Evaluacion(pFecha, pEvaluacion, pCur);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Evaluacion_de_Alumno> Obtener_Calificacciones_Docente_Tema(Docente pDocente, Evaluacion pEvaluacion)
        {
            try
            {
                return MAP_Evaluacion_de_Alumno.Obtener_Calificacciones_Docente_Tema(pDocente, pEvaluacion);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Evaluacion_de_Alumno> Ver_Califiaciones_de_Materia(List<Evaluacion_de_Alumno> pLEA, string pMateria)
        {
            IEnumerable<Evaluacion_de_Alumno> IEA = from X in pLEA
                                                    where X.Evaluacion.Materia.Nombre.ToString() == pMateria
                                                    select X;

            List<Evaluacion_de_Alumno> ListaDeConsulta = IEA.ToList();

            return ListaDeConsulta;
        }
        public List<Evaluacion_de_Alumno> Ver_Califiaciones_por_Fecha(List<Evaluacion_de_Alumno> pLEA, DateTime pFecha1, DateTime pFecha2)
        {
            IEnumerable<Evaluacion_de_Alumno> IEA = from X in pLEA
                                                    where (X.Fecha >= pFecha1 && X.Fecha <= pFecha2)
                                                    select X;

            List<Evaluacion_de_Alumno> ListaDeConsulta = IEA.ToList();

            return ListaDeConsulta;
        }

        public void Agregar_Inasistencia(Cursada_de_Alumno pCA, DateTime pFecha, decimal pValor, string pDescripcion, string pJustificacion)
        {
            try
            {
                if (!pCA.VerInasistencias().Exists(X => X.Fecha == pFecha))
                {
                    Inasistencia Inasistencia = new Inasistencia(pFecha, pDescripcion, pValor, pJustificacion);

                    pCA.VerInasistencias().Add(Inasistencia);
                }
                else { throw new Exception("Ya se ingresó una Inasistencia en el día de la Fecha"); }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }            
        }
        public void Quitar_Inasistencia(Cursada_de_Alumno pCA)
        {
            try
            {
                if (pCA.VerInasistencias().Exists(X => X.Fecha == DateTime.Today))
                {
                    pCA.VerInasistencias().Remove(pCA.VerInasistencias().Find(X => X.Fecha == DateTime.Today));
                }
                else { throw new Exception("No hay una inasistencia en el día de la Fecha"); }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public Dictionary<int,decimal> Obtener_Cant_Inasistencias(List<Alumno> pLA)
        {
            try
            {
                return MAP_Inasistencia.Obtener_Cant_Inasistencias(pLA);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Obtener_Inasistencias_Alumnos(List<Alumno> pLA)
        {
            try
            {
                MAP_Inasistencia.Obtener_Inasistencias_Alumnos(pLA);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Enviar_Inasistencias(List<Alumno> pLA, Curso pCurso)
        {
            try
            {
                MAP_Inasistencia.Enviar_Inasistencias(pLA, pCurso);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Modificar_Estado_de_Cursada(Cursada_de_Alumno pCursada, bool pEstado)
        {
            try
            {
                MAP_Cursada_De_Alumno.Modificar_Estado_de_Cursada(pCursada, pEstado);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Inasistencia> Ver_Inasistencia_Alumno(Cursada_de_Alumno pCursada)
        {
            try
            {
                return MAP_Inasistencia.Ver_Inasistencia_Alumno(pCursada);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Inasistencia> Ver_Inasistencias_Fecha(List<Inasistencia> pLI, DateTime pFecha)
        {
            IEnumerable<Inasistencia> IEI = from X in pLI
                                                    where X.Fecha.ToShortDateString().StartsWith(pFecha.ToShortDateString())
                                                    select X;            
            
            List<Inasistencia> ListaDeConsulta = IEI.ToList();          

            return ListaDeConsulta;
        }
        public void Eliminar_Inasistencia(Inasistencia pInasistencia)
        {
            try
            {
                MAP_Inasistencia.Eliminar_Inasistencia(pInasistencia);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public decimal Obtener_Total_Inasistencias_de_Cursada(Cursada_de_Alumno pCursada)
        {
            try
            {
               return MAP_Inasistencia.Obtener_Total_Inasistencias_de_Cursada(pCursada);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Modificar_Inasistencia(Cursada_de_Alumno pCursada, Inasistencia pInasistencia)
        {
            try
            {
                MAP_Inasistencia.Modificar_Inasistencia(pCursada, pInasistencia);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Agregar_Inasistencia(Cursada_de_Alumno pCursada, Inasistencia pInasistencia)
        {
            try
            {
                MAP_Inasistencia.Agregar_Inasistencia(pCursada, pInasistencia);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public int Verificar_Inasistencia(Cursada_de_Alumno pCursada, DateTime pFecha)
        {
            try
            {
                return MAP_Inasistencia.Verificar_Inasistencia(pCursada, pFecha);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }       

        public Dictionary<Materia, List<Evaluacion_de_Alumno>> Obtener_Curso_Materia_Evaluacion_de_Docente(Docente pDocente)
        {
            try
            {
                return MAP_Evaluacion_de_Alumno.Obtener_Curso_Materia_Evaluacion_de_Docente(pDocente);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public DateTime ObtenerFechaMasReciente_Docente(Docente pDocente, List<Evaluacion_de_Alumno> pLEA)
        {
            DateTime Fecha = new DateTime(2001, 01, 01);

            foreach (Evaluacion_de_Alumno EVA in pLEA)
            {
                if (EVA.Docente == pDocente)
                {
                    if (Fecha < EVA.Fecha)
                    {
                        Fecha = EVA.Fecha;
                    }
                }
            }          

            return Fecha;
        }
        public void Obtener_Calificaciones_de_Evaluacion(Dictionary<Evaluacion, List<Evaluacion_de_Alumno>> pEvaluaciones)
        {
            try
            {
                MAP_Evaluacion_de_Alumno.Obtener_Calificaciones_de_Evaluacion(pEvaluaciones);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public int ObtenerPromedioDeCursada(Cursada_de_Alumno pCursada)
        {
            try
            {
                return MAP_Cursada_De_Alumno.ObtenerPromedioDeCursada(pCursada);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public string Comparar_Rendimientos_Curso_Docente(int pPromedioCurso, int pPromedioDocente, int pIdioma)
        {
            try
            {
                int PromedioDocente = 0;

                PromedioDocente = pPromedioDocente;

                string Conclusion = "";

                //11   
                if (pPromedioCurso == 1 && PromedioDocente == 1 || pPromedioCurso == 1 && PromedioDocente == 2 ||pPromedioCurso == 1 && PromedioDocente == 3 ||pPromedioCurso == 2 && PromedioDocente == 1 || pPromedioCurso == 2 && PromedioDocente == 2 || pPromedioCurso == 2 && PromedioDocente == 3 ||pPromedioCurso == 3 && PromedioDocente == 1 || pPromedioCurso == 3 && PromedioDocente == 2 || pPromedioCurso == 3 && PromedioDocente == 3)
                {
                    if (pIdioma == 1) { Conclusion = "Tanto el Promedio del Curso como del Docente es muy bajo"; }
                    else if (pIdioma == 2) { Conclusion = "Both the Average of the Course and the Teacher is very low"; }
                }
                else if (pPromedioCurso == 4 && PromedioDocente == 1 || pPromedioCurso == 4 && PromedioDocente == 2 || pPromedioCurso == 4 && PromedioDocente == 3)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es muy bueno, mientras que el del docente es muy bajo"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is very good, while the teacher's is very low"; }
                }
                else if (pPromedioCurso == 5 && PromedioDocente == 1 || pPromedioCurso == 5 && PromedioDocente == 2 || pPromedioCurso == 5 && PromedioDocente == 3)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es medio, mientras que el del docente es muy bajo"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is medium, while the teacher's is very low"; }
                }
                else if (pPromedioCurso == 6 && PromedioDocente == 1 || pPromedioCurso == 6 && PromedioDocente == 2 || pPromedioCurso == 6 && PromedioDocente == 3)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es suficiente, mientras que el del docente es muy bajo"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is sufficient, while the teacher's is very low"; }
                }
                else if (pPromedioCurso == 7 && PromedioDocente == 1 || pPromedioCurso == 7 && PromedioDocente == 2 || pPromedioCurso == 7 && PromedioDocente == 3)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es bueno, mientras que el del docente es muy bajo"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is good, while the teacher's is very low"; }
                }
                else if (pPromedioCurso == 8 && PromedioDocente == 1 || pPromedioCurso == 8 && PromedioDocente == 2 || pPromedioCurso == 8 && PromedioDocente == 3)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es muy bueno, mientras que el del docente es muy bajo"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is very good, while the teacher's is very low"; }
                }
                else if (pPromedioCurso == 9 || pPromedioCurso == 10 && PromedioDocente == 1 || pPromedioCurso == 9 || pPromedioCurso == 10 && PromedioDocente == 2 || pPromedioCurso == 9 || pPromedioCurso == 10 && PromedioDocente == 3)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es Sobresaliente, mientras que el del docente es muy bajo"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is Outstanding, while the teacher's is very low"; }
                }
                //14
                else if (pPromedioCurso == 1 && PromedioDocente == 4 || pPromedioCurso == 2 && PromedioDocente == 4 || pPromedioCurso == 3 && PromedioDocente == 4)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es muy bajo, mientras que el del docente es bajo"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is very low, while the teacher's is low"; }
                }
                else if (pPromedioCurso == 4 && PromedioDocente == 4)
                {
                    if (pIdioma == 1) { Conclusion = "Tanto el Promedio del Curso como el del Docente es bajo"; }
                    else if (pIdioma == 2) { Conclusion = "Both Course Average and Teacher Average is low"; }
                }
                else if (pPromedioCurso == 5 && PromedioDocente == 4)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es medio, mientras que el del docente es bajo"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is medium, while that of the teacher is low"; }
                }
                else if (pPromedioCurso == 6 && PromedioDocente == 4)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es suficiente, mientras que el del docente es bajo"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is sufficient, while the teacher's is low"; }
                }
                else if (pPromedioCurso == 7 && PromedioDocente == 4)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es bueno, mientras que el del docente es bajo"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is good, while the teacher's is low"; }
                }
                else if (pPromedioCurso == 8 && PromedioDocente == 4)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es muy bueno, mientras que el del docente es bajo"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is very good, while the teacher's is low"; }
                }
                else if (pPromedioCurso == 9 && PromedioDocente == 4 || pPromedioCurso == 10 && PromedioDocente == 4)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es Sobresaliente, mientras que el del docente es bajo"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is Outstanding, while the teacher's is low"; }
                }
                //15
                else if (pPromedioCurso == 1 && PromedioDocente == 5 || pPromedioCurso == 2 && PromedioDocente == 5 || pPromedioCurso == 3 && PromedioDocente == 5)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es muy bajo, mientras que el del docente es medio"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is very low, while that of the teacher is medium"; }
                }
                else if (pPromedioCurso == 4 && PromedioDocente == 5)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es bajo, mientras que el del docente es medio"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is low, while that of the teacher is medium"; }
                }
                else if (pPromedioCurso == 5 && PromedioDocente == 5)
                {
                    if (pIdioma == 1) { Conclusion = "Tanto el Promedio del Curso como el del Docente es medio"; }
                    else if (pIdioma == 2) { Conclusion = "Both the Course Average and the Teacher Average is medium"; }
                }
                else if (pPromedioCurso == 6 && PromedioDocente == 5)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es suficiente, mientras que el del docente es medio"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is sufficient, while the teacher's average is medium"; }
                }
                else if (pPromedioCurso == 7 && PromedioDocente == 5)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es bueno, mientras que el del docente es medio"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is good, while the teacher's average is medium"; }
                }
                else if (pPromedioCurso == 8 && PromedioDocente == 5)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es muy bueno, mientras que el del docente es medio"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is very good, while the teacher's average is medium"; }
                }
                else if (pPromedioCurso == 9 && PromedioDocente == 5 || pPromedioCurso == 10 && PromedioDocente == 5)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es Sobresaliente, mientras que el del docente es medio"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is Outstanding, while the teacher's average is medium"; }
                }
                //14
                else if (pPromedioCurso == 1 && PromedioDocente == 6 || pPromedioCurso == 2 && PromedioDocente == 6 || pPromedioCurso == 3 && PromedioDocente == 6)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es muy bajo, mientras que el del docente es suficiente"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is very low, while the teacher's is sufficient"; }
                }
                else if (pPromedioCurso == 4 && PromedioDocente == 6)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es bajo, mientras que el del docente es suficiente"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is low, while the teacher's is sufficient"; }
                }
                else if (pPromedioCurso == 5 && PromedioDocente == 6)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es medio, mientras que el del docente es suficiente"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is medium, while the teacher's is sufficient"; }
                }
                else if (pPromedioCurso == 6 && PromedioDocente == 6)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es suficiente, mientras que el del docente es suficiente"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is sufficient, while the teacher's is sufficient"; }
                }
                else if (pPromedioCurso == 7 && PromedioDocente == 6)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es bueno, mientras que el del docente es suficiente"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is good, while the teacher's is sufficient"; }
                }
                else if (pPromedioCurso == 8 && PromedioDocente == 6)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es muy bueno, mientras que el del docente es suficiente"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is very good, while the teacher's is sufficient"; }

                }
                else if (pPromedioCurso == 9 && PromedioDocente == 6 || pPromedioCurso == 10 && PromedioDocente == 6)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es Sobresaliente, mientras que el del docente es suficiente"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is Outstanding, while the teacher's is sufficient"; }
                }
                //17
                else if (pPromedioCurso == 1 && PromedioDocente == 7)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es muy bajo, mientras que el del docente es bueno"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is very low, while the teacher's is good"; }
                }
                else if (pPromedioCurso == 4 && PromedioDocente == 7)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es bajo, mientras que el del docente es bueno"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is low, while the teacher's is good"; }
                }
                else if (pPromedioCurso == 5 && PromedioDocente == 7)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es medio, mientras que el del docente es bueno"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is medium, while the teacher's is good"; }
                }
                else if (pPromedioCurso == 6 && PromedioDocente == 7)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es suficiente, mientras que el del docente es bueno"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is sufficient, while the teacher's is good"; }
                }
                else if (pPromedioCurso == 7 && PromedioDocente == 7)
                {
                    if (pIdioma == 1) { Conclusion = "Tanto el Promedio del Curso como del docente son buenos"; }
                    else if (pIdioma == 2) { Conclusion = "Both Course and Teacher Average are good"; }
                }
                else if (pPromedioCurso == 8 && PromedioDocente == 7)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es muy bueno, mientras que el del docente es bueno"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is very good, while the teacher's is good"; }
                }
                else if (pPromedioCurso == 9 && PromedioDocente == 7 || pPromedioCurso == 10 && PromedioDocente == 7)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es Sobresaliente, mientras que el del docente es bueno"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is Outstanding, while the teacher's is good"; }
                }
                //18
                else if (pPromedioCurso == 1 && PromedioDocente == 8 || pPromedioCurso == 2 && PromedioDocente == 8 || pPromedioCurso == 3 && PromedioDocente == 8)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es muy bajo, mientras que el del docente es muy bueno"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is very low, while the teacher's is very good"; }
                }
                else if (pPromedioCurso == 4 && PromedioDocente == 8)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es bajo, mientras que el del docente es muy bueno"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is low, while the teacher's is very good"; }
                }
                else if (pPromedioCurso == 5 && PromedioDocente == 8)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es medio, mientras que el del docente es muy bueno"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is medium, while the teacher's is very good"; }
                }
                else if (pPromedioCurso == 6 && PromedioDocente == 8)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es suficiente, mientras que el del docente es muy bueno"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is sufficient, while the teacher's is very good"; }
                }
                else if (pPromedioCurso == 7 && PromedioDocente == 8)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es bueno, mientras que el del docente es muy bueno"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is good, while the teacher's is very good"; }
                }
                else if (pPromedioCurso == 8 && PromedioDocente == 8)
                {
                    if (pIdioma == 1) { Conclusion = "Tanto el Promedio del Curso como el del Docente es muy bueno"; }
                    else if (pIdioma == 2) { Conclusion = "Both the Course Average and the Teacher Average is very good"; }
                }
                else if (pPromedioCurso == 9 && PromedioDocente == 8 || pPromedioCurso == 10 && PromedioDocente == 8)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es Sobresaliente, mientras que el del docente es muy bueno"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is Outstanding, while the teacher's is very good"; }
                }
                else if (pPromedioCurso == 1 && PromedioDocente == 9 || pPromedioCurso == 2 && PromedioDocente == 9 || pPromedioCurso == 3 && PromedioDocente == 9 || pPromedioCurso == 1 && PromedioDocente == 10 || pPromedioCurso == 2 && PromedioDocente == 10 || pPromedioCurso == 3 && PromedioDocente == 10)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es muy bajo, mientras que el del docente es Sobresaliente"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is very low, while the teacher's is Outstanding"; }
                }
                else if (pPromedioCurso == 4 && PromedioDocente == 9 || pPromedioCurso == 4 && PromedioDocente == 10)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es bajo, mientras que el del docente es Sobresaliente"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is low, while the teacher's is Outstanding"; }
                }
                else if (pPromedioCurso == 5 && PromedioDocente == 9 || pPromedioCurso == 5 && PromedioDocente == 10)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es medio, mientras que el del docente es Sobresaliente"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is medium, while the teacher's is Outstanding"; }
                }
                else if (pPromedioCurso == 6 && PromedioDocente == 9 || pPromedioCurso == 6 && PromedioDocente == 10)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es suficiente, mientras que el del docente es Sobresaliente"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is sufficient, while the teacher's is Outstanding"; }
                }
                else if (pPromedioCurso == 7 && PromedioDocente == 9 || pPromedioCurso == 7 && PromedioDocente == 10)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es bueno, mientras que el del docente es Sobresaliente"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is good, while the teacher's is Outstanding"; }
                }
                else if (pPromedioCurso == 8 && PromedioDocente == 9 || pPromedioCurso == 8 && PromedioDocente == 10)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es muy bueno, mientras que el del docente es Sobresaliente"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is very good, while the teacher's is Outstanding"; }
                }
                else if (pPromedioCurso == 9 && PromedioDocente == 9 || pPromedioCurso == 9 && PromedioDocente == 10 && pPromedioCurso == 10 && PromedioDocente == 10 || pPromedioCurso == 10 && PromedioDocente == 9)
                {
                    if (pIdioma == 1) { Conclusion = "Tanto el Promedio del Curso como el del Docente es Sobresaliente"; }
                    else if (pIdioma == 2) { Conclusion = "Both Course Average and Teacher Average is Outstanding"; }
                }
                //11
                else if (pPromedioCurso == 1 && PromedioDocente == 1 ||pPromedioCurso == 1 && PromedioDocente == 2 || pPromedioCurso == 1 && PromedioDocente == 3 || pPromedioCurso == 2 && PromedioDocente == 1 ||pPromedioCurso == 2 && PromedioDocente == 2 ||pPromedioCurso == 2 && PromedioDocente == 3 || pPromedioCurso == 3 && PromedioDocente == 1 ||pPromedioCurso == 3 && PromedioDocente == 2 ||pPromedioDocente == 3 && PromedioDocente == 3)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es muy bajo, mientras que el del docente es muy bajo"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is very low, while the teacher's is very low"; }
                }
                else if (pPromedioCurso == 1 && PromedioDocente == 4 || pPromedioCurso == 2 && PromedioDocente == 4 || pPromedioCurso == 3 && PromedioDocente == 4)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es muy bajo, mientras que el del docente es bajo"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is very low, while the teacher's is low"; }
                }
                else if (pPromedioCurso == 1 && PromedioDocente == 5 || pPromedioCurso == 2 && PromedioDocente == 5 || pPromedioCurso == 3 && PromedioDocente == 5)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es muy bajo, mientras que el del docente es medio"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is very low, while that of the teacher is medium"; }
                }
                else if (pPromedioCurso == 1 && PromedioDocente == 6 || pPromedioCurso == 2 && PromedioDocente == 6 || pPromedioCurso == 3 && PromedioDocente == 6)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es muy bajo, mientras que el del docente es suficiente"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is very low, while the teacher's is sufficient"; }
                }
                else if (pPromedioCurso == 1 && PromedioDocente == 7 || pPromedioCurso == 2 && PromedioDocente == 7 || pPromedioCurso == 3 && PromedioDocente == 7)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es muy bajo, mientras que el del docente es bueno"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is very low, while the teacher's is good"; }
                }
                else if (pPromedioCurso == 1 && PromedioDocente == 8 || pPromedioCurso == 2 && PromedioDocente == 8 || pPromedioCurso == 3 && PromedioDocente == 8)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es muy bajo, mientras que el del docente es muy bueno"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is very low, while the teacher's is very good"; }
                }
                else if (pPromedioCurso == 1 && PromedioDocente == 9 || pPromedioCurso == 2 && PromedioDocente == 9 ||pPromedioCurso == 3 && PromedioDocente == 9 || pPromedioCurso == 1 && PromedioDocente == 10 || pPromedioCurso == 2 && PromedioDocente == 10 || pPromedioCurso == 3 && PromedioDocente == 10)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es muy bajo, mientras que el del docente es Sobresaliente"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is very low, while the teacher's is Outstanding"; }
                }
                //41
                else if (pPromedioCurso == 4 && PromedioDocente == 1 || pPromedioCurso == 4 && PromedioDocente == 2 || pPromedioCurso == 4 && PromedioDocente == 3)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es bajo, mientras que el del docente es muy bajo"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is low, while the teacher's is very low"; }
                }
                else if (pPromedioCurso == 4 && PromedioDocente == 4)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es bajo, mientras que el del docente es bajo"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is low, while the teacher's is low"; }
                }
                else if (pPromedioCurso == 4 && PromedioDocente == 5)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es bajo, mientras que el del docente es medio"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is low, while the teacher's is medium"; }
                }
                else if (pPromedioCurso == 4 && PromedioDocente == 6)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es bajo, mientras que el del docente es suficiente"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is low, while the teacher's is sufficient"; }
                }
                else if (pPromedioCurso == 4 && PromedioDocente == 7)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es bajo, mientras que el del docente es bueno"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is low, while the teacher's is good"; }
                }
                else if (pPromedioCurso == 4 && PromedioDocente == 8)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es bajo, mientras que el del docente es muy bueno"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is low, while the teacher's is very good"; }
                }
                else if (pPromedioCurso == 4 && PromedioDocente == 9 || pPromedioCurso == 4 && PromedioDocente == 10)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es bajo, mientras que el del docente es Sobresaliente"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is low, while the teacher's is Outstanding"; }
                }
                else if (pPromedioCurso == 5 && PromedioDocente == 1 || pPromedioCurso == 5 && PromedioDocente == 2 || pPromedioCurso == 5 && PromedioDocente == 3)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es medio, mientras que el del docente es muy bajo"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is medium, while the teacher's is very low"; }
                }
                else if (pPromedioCurso == 5 && PromedioDocente == 4)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es medio, mientras que el del docente es bajo"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is medium, while that of the teacher is low"; }
                }
                else if (pPromedioCurso == 5 && PromedioDocente == 5)
                {
                    if (pIdioma == 1) { Conclusion = "Tanto el Promedio del Curso como del Docente es medio"; }
                    else if (pIdioma == 2) { Conclusion = "Both the Average of the Course and the Teacher is medium"; }
                }
                else if (pPromedioCurso == 5 && PromedioDocente == 6)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es medio, mientras que el del docente es suficiente"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is medium, while the teacher's is sufficient"; }
                }
                else if (pPromedioCurso == 5 && PromedioDocente == 7)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es medio, mientras que el del docente es bueno"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is medium, while the teacher's is good"; }
                }
                else if (pPromedioCurso == 5 && PromedioDocente == 8)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es medio, mientras que el del docente es muy bueno"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is medium, while the teacher's is very good"; }
                }
                else if (pPromedioCurso == 5 && PromedioDocente == 9 || pPromedioCurso == 5 && PromedioDocente == 10)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es medio, mientras que el del docente es Sobresaliente"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is medium, while the teacher's is Outstanding"; }
                }
                else if (pPromedioCurso == 6 && PromedioDocente == 1 || pPromedioCurso == 6 && PromedioDocente == 2 || pPromedioCurso == 6 && PromedioDocente == 3)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es suficiente, mientras que el del docente es muy bajo"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is sufficient, while the teacher's is very low"; }
                }
                else if (pPromedioCurso == 6 && PromedioDocente == 4)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es suficiente, mientras que el del docente es bajo"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is sufficient, while the teacher's is low"; }
                }
                else if (pPromedioCurso == 6 && PromedioDocente == 5)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es suficiente, mientras que el del docente es medio"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is sufficient, while the teacher's is medium"; }
                }
                else if (pPromedioCurso == 6 && PromedioDocente == 6)
                {
                    if (pIdioma == 1) { Conclusion = "Tanto el Promedio del Curso como el del Docente son suficientes"; }
                    else if (pIdioma == 2) { Conclusion = "Both Course Average and Teacher Average are sufficient"; }
                }
                else if (pPromedioCurso == 6 && PromedioDocente == 7)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es suficiente, mientras que el del docente es bueno"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is sufficient, while the teacher's is good"; }
                }
                else if (pPromedioCurso == 6 && PromedioDocente == 8)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es suficiente, mientras que el del docente es muy bueno"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is sufficient, while the teacher's is very good"; }
                }
                else if (pPromedioCurso == 6 && PromedioDocente == 9 || pPromedioCurso == 6 && PromedioDocente == 10)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es suficiente, mientras que el del docente es sobresaliente"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is sufficient, while the teacher's is Outstanding"; }
                }
                else if (pPromedioCurso == 7 && PromedioDocente == 1 || pPromedioCurso == 7 && PromedioDocente == 2 || pPromedioCurso == 7 && PromedioDocente == 3)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es bueno, pero el del docente es muy bajo"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is good, but the teacher's is very low"; }
                }
                else if (pPromedioCurso == 7 && PromedioDocente == 4)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es bueno, mientras que el docente es bajo"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is good, while the teacher is low"; }
                }
                else if (pPromedioCurso == 7 && PromedioDocente == 5)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es bueno, mientras que el docente es medio"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is good, while the teacher is medium"; }
                }
                else if (pPromedioCurso == 7 && PromedioDocente == 6)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es bueno, mientras que el docente es suficiente"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is good, while the teacher is sufficent"; }
                }
                else if (pPromedioCurso == 7 && PromedioDocente == 7)
                {
                    if (pIdioma == 1) { Conclusion = "Tanto el Promedio del Curso como el del Docente son buenos"; }
                    else if (pIdioma == 2) { Conclusion = "Both Course Average and Teacher Average are good"; }
                }
                else if (pPromedioCurso == 7 && PromedioDocente == 8)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es bueno, mientras que el docente es muy bueno"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is good, while the teacher is very good"; }
                }
                else if (pPromedioCurso == 7 && PromedioDocente == 9 || pPromedioCurso == 7 && PromedioDocente == 10)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es bueno, mientras que el docente es sobresaliente"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is good, while the teacher is Outstanding"; }
                }
                //81
                else if (pPromedioCurso == 8 && PromedioDocente == 1 || pPromedioCurso == 8 && PromedioDocente == 2 || pPromedioCurso == 8 && PromedioDocente == 3)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es muy bueno, mientras que el del docente es muy bajo"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is very good, while the teacher's is very low"; }
                }
                else if (pPromedioCurso == 8 && PromedioDocente == 4)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es muy bueno, mientras que el del docente es bajo"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is very good, while the teacher's is low"; }
                }
                else if (pPromedioCurso == 8 && PromedioDocente == 5)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es muy bueno, mientras que el del docente es medio"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is very good, while the teacher's is medium"; }
                }
                else if (pPromedioCurso == 8 && PromedioDocente == 6)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es muy bueno, mientras que el del docente es suficiente"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is very good, while the teacher's is sufficient"; }
                }
                else if (pPromedioCurso == 8 && PromedioDocente == 7)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es muy bueno, mientras que el del docente es bueno"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is very good, while the teacher's is good"; }
                }
                else if (pPromedioCurso == 8 && PromedioDocente == 8)
                {
                    if (pIdioma == 1) { Conclusion = "Tanto el Promedio del Curso como el del Docente es muy bueno"; }
                    else if (pIdioma == 2) { Conclusion = "Both the Course Average and the Teacher Average is very good"; }
                }
                else if (pPromedioCurso == 8 && PromedioDocente == 9 || pPromedioCurso == 8 && PromedioDocente == 10)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es muy bueno, mientras que el del docente es sobresaliente"; }
                    else if (pIdioma == 2) { Conclusion = "Both the Course Average and the Teacher Average is very Outstanding"; }
                }
                else if (pPromedioCurso == 9 && PromedioDocente == 1 || pPromedioCurso == 10 && PromedioDocente == 1)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es sobresaliente pero el del docente es muy bajo"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is outstanding but the teacher's is very low"; }
                }
                else if (pPromedioCurso == 9 && PromedioDocente == 2 || pPromedioCurso == 10 && PromedioDocente == 2)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es sobresaliente pero el del docente es muy bajo"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is outstanding but the teacher's is very low"; }
                }
                else if (pPromedioCurso == 9 && PromedioDocente == 3 || pPromedioCurso == 10 && PromedioDocente == 3)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es sobresaliente pero el del docente es muy bajo"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is outstanding but the teacher's is very low"; }
                }
                else if (pPromedioCurso == 9 && PromedioDocente == 4 || pPromedioCurso == 10 && PromedioDocente == 4)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es sobresaliente pero el del docente es bajo"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is outstanding but the teacher's is low"; }
                }
                else if (pPromedioCurso == 9 && PromedioDocente == 5 || pPromedioCurso == 10 && PromedioDocente == 5)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es sobresaliente pero el del docente es medio"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is outstanding but the teacher's is medium"; }
                }
                else if (pPromedioCurso == 9 && PromedioDocente == 6 || pPromedioCurso == 10 && PromedioDocente == 6)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es sobresaliente mientras que el del docente es suficiente"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is outstanding while the teacher's is sufficient"; }
                }
                else if (pPromedioCurso == 9 && PromedioDocente == 7 || pPromedioCurso == 10 && PromedioDocente == 7)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es sobresaliente mientras que el del docente es bueno"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is outstanding while the teacher's is good"; }
                }
                else if (pPromedioCurso == 9 && PromedioDocente == 8 || pPromedioCurso == 10 && PromedioDocente == 8)
                {
                    if (pIdioma == 1) { Conclusion = "El Promedio del Curso es sobresaliente mientras que el del docente es muy bueno"; }
                    else if (pIdioma == 2) { Conclusion = "The Course Average is outstanding while the teacher's is very good"; }
                }
                else if (pPromedioCurso == 9 && PromedioDocente == 9 || pPromedioCurso == 10 && PromedioDocente == 9)
                {
                    if (pIdioma == 1) { Conclusion = "Tanto el Promedio del Curso como el de los Docentes es sobresaliente"; }
                    else if (pIdioma == 2) { Conclusion = "Both the Average of the Course and that of the Teachers is outstanding"; }
                }
                else if (pPromedioCurso == 9 && PromedioDocente == 10 || pPromedioCurso == 10 && PromedioDocente == 10)
                {
                    if (pIdioma == 1) { Conclusion = "Tanto el Promedio del Curso como el de los Docentes es sobresaliente"; }
                    else if (pIdioma == 2) { Conclusion = "Both the Average of the Course and that of the Teachers is outstanding"; }
                }

                return Conclusion;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
      
    }
}
