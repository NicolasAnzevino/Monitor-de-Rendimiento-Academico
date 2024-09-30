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
    public class MAP_Evaluacion_de_Alumno
    {
        DAL_Evaluacion_de_Alumno DAL_Evaluacion_de_Alumno;
        DAL_Tema DAL_Tema;
        public MAP_Evaluacion_de_Alumno()
        {
            DAL_Evaluacion_de_Alumno = new DAL_Evaluacion_de_Alumno();
            DAL_Tema = new DAL_Tema();
        }

        public void Agregar_Evaluacion_de_Alumno(Evaluacion_de_Alumno pEvaluacion, Cursada_de_Alumno pCursada)
        {
            try
            {
                DataTable DT = new DataTable();

                DataColumn DC1 = new DataColumn("EvaAlu_Codigo", typeof(int));
                DataColumn DC2 = new DataColumn("EvaAlu_Calificacion", typeof(int));
                DataColumn DC3 = new DataColumn("EvaAlu_CurAlu_Codigo", typeof(int));
                DataColumn DC4 = new DataColumn("EvaAlu_Doc_Legajo", typeof(string));
                DataColumn DC5 = new DataColumn("EvaAlu_Eva_Codigo", typeof(int));
                DataColumn DC6 = new DataColumn("EvaAlu_Fecha", typeof(string));
                DataColumn DC7 = new DataColumn("EvaAlu_DVH", typeof(string));

                DT.Columns.Add(DC1); DT.Columns.Add(DC2); DT.Columns.Add(DC3); DT.Columns.Add(DC4); DT.Columns.Add(DC5); DT.Columns.Add(DC6); DT.Columns.Add(DC7);

                DataRow DR = DT.NewRow();

                DR.ItemArray = new object[] { DAL_Evaluacion_de_Alumno.Obtener_Max_ID_EvaluacionAlu_Crear_EvaluacionAlu(), pEvaluacion.Calificacion, pCursada.Codigo, pEvaluacion.Docente.Legajo, pEvaluacion.Evaluacion.Codigo, pEvaluacion.Fecha.ToString("dd/MM/yyyy"), "" };

                string DigitoVerificador = SecurityManager.HashearRegistro(DR);

                DR.SetField<string>(6, DigitoVerificador);

                DAL_Evaluacion_de_Alumno.Agregar_Evaluacion_de_Alumno(DR, pEvaluacion.Fecha);

                string DigitoVerificadorVertical = SecurityManager.HashearTabla(DAL_Evaluacion_de_Alumno.Retornar_Evaluaciones_de_Alumno());
                DAL_Evaluacion_de_Alumno.Actualizar_Digito_Verificador_Vertical(DigitoVerificadorVertical);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public bool Verificar_Existencia_Evaluaciones_Alumno(int pID)
        {
            try
            {
                return DAL_Evaluacion_de_Alumno.Verificar_Existencia_Evaluaciones_Alumno(pID);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public List<Evaluacion_de_Alumno> Ver_Evaluaciones_de_Cursada(Cursada_de_Alumno pCursada)
        {
            try
            {
                DataTable DT = DAL_Evaluacion_de_Alumno.Ver_Evaluaciones_de_Cursada(pCursada);
                List<Evaluacion_de_Alumno> LA = new List<Evaluacion_de_Alumno>();

                foreach (DataRow DR in DT.Rows)
                {
                    Evaluacion_de_Alumno EA = new Evaluacion_de_Alumno(DR.Field<int>(0), DR.Field<DateTime>(2), DR.Field<int>(3));
                    EA.Docente.Legajo = DR.Field<string>(5);
                    EA.Docente.Nombre = DR.Field<string>(6);
                    EA.Docente.Apellido = DR.Field<string>(7);
                    EA.Evaluacion.Codigo = DR.Field<int>(1);
                    EA.Evaluacion.Titulo = DR.Field<string>(9);
                    EA.Evaluacion.Materia = new Materia(DR.Field<int>(8), DR.Field<string>(4));

                    DataTable DTTemas = DAL_Tema.Ver_Temas_de_Evaluacion_Completo(EA.Evaluacion);
                    List<Tema> LT = new List<Tema>();

                    foreach (DataRow DRTema in DTTemas.Rows)
                    {
                        LT.Add(new Tema(DRTema.Field<int>(0), DRTema.Field<string>(1), DRTema.Field<string>(2)));
                    }

                    foreach (Tema T in LT)
                    {
                        EA.Evaluacion.VerTemas().Add(T);
                    }

                    LA.Add(EA);
                }

                return LA;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Evaluacion_de_Alumno> Ver_Evaluaciones_de_Cursada_de_Materia(Cursada_de_Alumno pCursada, Materia pMateria)
        {
            try
            {
                DataTable DT = DAL_Evaluacion_de_Alumno.Ver_Evaluaciones_de_Cursada_de_Materia(pCursada, pMateria);
                List<Evaluacion_de_Alumno> LA = new List<Evaluacion_de_Alumno>();

                foreach (DataRow DR in DT.Rows)
                {
                    Evaluacion_de_Alumno EA = new Evaluacion_de_Alumno(DR.Field<int>(0), DR.Field<DateTime>(2), DR.Field<int>(3));
                    EA.Docente.Legajo = DR.Field<string>(5);
                    EA.Docente.Nombre = DR.Field<string>(6);
                    EA.Docente.Apellido = DR.Field<string>(7);
                    EA.Evaluacion.Codigo = DR.Field<int>(1);
                    EA.Evaluacion.Titulo = DR.Field<string>(9);
                    EA.Evaluacion.Fecha = DR.Field<DateTime>(10);
                    EA.Evaluacion.Materia = new Materia(DR.Field<int>(8), DR.Field<string>(4));

                    DataTable DTTemas = DAL_Tema.Ver_Temas_de_Evaluacion_Completo(EA.Evaluacion);
                    List<Tema> LT = new List<Tema>();

                    foreach (DataRow DRTema in DTTemas.Rows)
                    {
                        LT.Add(new Tema(DRTema.Field<int>(0), DRTema.Field<string>(1), DRTema.Field<string>(2)));
                    }

                    foreach (Tema T in LT)
                    {
                        EA.Evaluacion.VerTemas().Add(T);
                    }

                    LA.Add(EA);
                }

                return LA;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Eliminar_Evaluacion_de_Alumno(Evaluacion_de_Alumno pEvaAlu)
        {
            try
            {
                DAL_Evaluacion_de_Alumno.Eliminar_Evaluacion_de_Alumno(pEvaAlu);

                string DigitoVerificadorVertical = SecurityManager.HashearTabla(DAL_Evaluacion_de_Alumno.Retornar_Evaluaciones_de_Alumno());
                DAL_Evaluacion_de_Alumno.Actualizar_Digito_Verificador_Vertical(DigitoVerificadorVertical);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Modificar_Evaluacion_de_Alumno(Evaluacion_de_Alumno pEvaAlu)
        {
            try
            {
                DataTable DTEvaluacionAlumno = DAL_Evaluacion_de_Alumno.Obtener_Eva_Alu(pEvaAlu);

                DataTable DT = new DataTable();

                DataColumn DC1 = new DataColumn("EvaAlu_Codigo", typeof(int));
                DataColumn DC2 = new DataColumn("EvaAlu_Calificacion", typeof(int));
                DataColumn DC3 = new DataColumn("EvaAlu_CurAlu_Codigo", typeof(int));
                DataColumn DC4 = new DataColumn("EvaAlu_Doc_Legajo", typeof(string));
                DataColumn DC5 = new DataColumn("EvaAlu_Eva_Codigo", typeof(int));
                DataColumn DC6 = new DataColumn("EvaAlu_Fecha", typeof(string));
                DataColumn DC7 = new DataColumn("EvaAlu_DVH", typeof(string));

                DT.Columns.Add(DC1); DT.Columns.Add(DC2); DT.Columns.Add(DC3); DT.Columns.Add(DC4); DT.Columns.Add(DC5); DT.Columns.Add(DC6); DT.Columns.Add(DC7);

                DataRow DR = DT.NewRow();

                string Fecha = pEvaAlu.Fecha.ToString("dd/MM/yyyy");

                DR.ItemArray = new object[] { DTEvaluacionAlumno.Rows[0].Field<int>(0), pEvaAlu.Calificacion, DTEvaluacionAlumno.Rows[0].Field<int>(2), DTEvaluacionAlumno.Rows[0].Field<string>(3), DTEvaluacionAlumno.Rows[0].Field<int>(4), Fecha, "" };

                string DigitoVerificador = SecurityManager.HashearRegistro(DR);

                DR.SetField<string>(6, DigitoVerificador);

                DAL_Evaluacion_de_Alumno.Modificar_Evaluacion_de_Alumno(DR, pEvaAlu.Fecha);

                string DigitoVerificadorVertical = SecurityManager.HashearTabla(DAL_Evaluacion_de_Alumno.Retornar_Evaluaciones_de_Alumno());
                DAL_Evaluacion_de_Alumno.Actualizar_Digito_Verificador_Vertical(DigitoVerificadorVertical);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Evaluacion_de_Alumno> Obtener_Eva_Alu_Rendimiento(Cursada_de_Alumno pCursada)
        {
            try
            {
                DataTable DTEvaluacionesAlu = DAL_Evaluacion_de_Alumno.Obtener_Eva_Alu_Rendimiento(pCursada);
                List<Evaluacion_de_Alumno> LEA = new List<Evaluacion_de_Alumno>();

                foreach (DataRow DR in DTEvaluacionesAlu.Rows)
                {
                    Evaluacion_de_Alumno EA = new Evaluacion_de_Alumno(DR.Field<int>(1), DR.Field<DateTime>(4), DR.Field<int>(3));
                    EA.Evaluacion.Codigo = DR.Field<int>(0);
                    EA.Evaluacion.Titulo = DR.Field<string>(2);
                    EA.Evaluacion.Materia = new Materia(DR.Field<int>(5), DR.Field<string>(6));
                    EA.Docente = new Docente(DR.Field<string>(7), DR.Field<string>(9), DR.Field<string>(8));

                    DataTable DTTemas = DAL_Tema.Ver_Temas_de_Evaluacion_Completo(EA.Evaluacion);
                    List<Tema> LT = new List<Tema>();

                    foreach (DataRow DRTema in DTTemas.Rows)
                    {
                        LT.Add(new Tema(DRTema.Field<int>(0), DRTema.Field<string>(1), DRTema.Field<string>(2)));
                    }

                    foreach (Tema T in LT)
                    {
                        EA.Evaluacion.VerTemas().Add(T);
                    }

                    LEA.Add(EA);
                }

                return LEA;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Evaluacion_de_Alumno> Ver_Evaluaciones_de_Alumno_de_Materia(Materia pMateria)
        {
            try
            {
                DataTable DT = DAL_Evaluacion_de_Alumno.Ver_Evaluaciones_de_Alumno_de_Materia(pMateria);
                List<Evaluacion_de_Alumno> LE = new List<Evaluacion_de_Alumno>();

                foreach (DataRow DR in DT.Rows)
                {
                    Evaluacion_de_Alumno Eva = new Evaluacion_de_Alumno(DR.Field<int>(0), DR.Field<DateTime>(3), DR.Field<int>(1));
                    Eva.Evaluacion = new Evaluacion(DR.Field<int>(4), DR.Field<string>(5), DR.Field<DateTime>(6), pMateria);
                    Eva.Docente = new Docente(DR.Field<string>(7), DR.Field<string>(9), DR.Field<string>(8));

                    LE.Add(Eva);
                }

                return LE;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public bool Verificar_Repeticion_Evaluacion(DateTime pFecha, Evaluacion pEvaluacion, Cursada_de_Alumno pCur)
        {
            try
            {
                return DAL_Evaluacion_de_Alumno.Verificar_Repeticion_Evaluacion(pFecha, pEvaluacion, pCur);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Evaluacion_de_Alumno> Obtener_Calificacciones_Docente_Tema(Docente pDocente, Evaluacion pEvaluacion)
        {
            try
            {
                DataTable DT = DAL_Evaluacion_de_Alumno.Obtener_Calificacciones_Docente_Tema(pDocente, pEvaluacion);
                List<Evaluacion_de_Alumno> LE = new List<Evaluacion_de_Alumno>();

                foreach (DataRow DR in DT.Rows)
                {
                    LE.Add(new Evaluacion_de_Alumno(DR.Field<int>(0), DR.Field<DateTime>(2), DR.Field<int>(1)));
                }

                return LE;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Dictionary<Materia, List<Evaluacion_de_Alumno>> Obtener_Docente_Materia_Evaluacion_de_Curso(Curso pCurso)
        {
            try
            {
                Dictionary<Materia, List<Evaluacion_de_Alumno>> MateriaCalificaciones = new Dictionary<Materia, List<Evaluacion_de_Alumno>>();
                DataTable MateriasEvaluadas = DAL_Evaluacion_de_Alumno.Obtener_Materias_Evaluadas_Curso(pCurso); //Obtengo las Materias que fueron evaluadas

                List<Docente> LD = new List<Docente>();

                if (MateriasEvaluadas.Rows.Count > 0)
                {
                    foreach (DataRow DR in MateriasEvaluadas.Rows)
                    {
                        DataTable DTMateria = DAL_Evaluacion_de_Alumno.Obtener_Docente_Materia_Evaluacion_de_Curso_de_Materia(pCurso, DR.Field<int>(0));
                        DataTable DTDocentes = DAL_Evaluacion_de_Alumno.Obtener_Docentes_de_Evaluaciones_de_Materia_Curso(pCurso, DR.Field<int>(0));

                        foreach (DataRow DRDocente in DTDocentes.Rows)
                        {
                            if (!LD.Exists(X=>X.Legajo == DRDocente.Field<string>(0)))
                            {
                                LD.Add(new Docente(DRDocente.Field<string>(0), DRDocente.Field<string>(2), DRDocente.Field<string>(3)));
                            }                            
                        }

                        int CodigoMateria = int.Parse(DTMateria.Rows[0].Field<string>(3));

                        Materia Materia = new Materia(CodigoMateria, DTMateria.Rows[0].Field<string>(4));

                        MateriaCalificaciones.Add(Materia, new List<Evaluacion_de_Alumno>());

                        foreach (DataRow DR2 in DTMateria.Rows)
                        {
                            MateriaCalificaciones[Materia].Add(new Evaluacion_de_Alumno(DR2.Field<int>(5), LD.Find(X => X.Legajo == DR2.Field<string>(0)), DR2.Field<DateTime>(6)));
                        }
                    }
                }

                return MateriaCalificaciones;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public Dictionary<Materia, List<Evaluacion_de_Alumno>> Obtener_Curso_Materia_Evaluacion_de_Docente(Docente pDocente)
        {
            try
            {
                Dictionary<Materia, List<Evaluacion_de_Alumno>> Diccionario = new Dictionary<Materia, List<Evaluacion_de_Alumno>>();

                DataTable DTMateriasCurso = DAL_Evaluacion_de_Alumno.Obtener_Cursos_y_Materias_Evaluados_por_Docente(pDocente);

                List<Curso> LC = new List<Curso>();
                List<Materia> LMAuxilar = new List<Materia>();

                foreach (DataRow DR in DTMateriasCurso.Rows)
                {
                    if (!LC.Exists(X=> X.Codigo == DR.Field<int>(0)))
                    {
                        LC.Add(new Curso(DR.Field<int>(0), DR.Field<string>(1), DR.Field<int>(2), DR.Field<string>(3)));
                    }
                }

                foreach (DataRow DR in DTMateriasCurso.Rows)
                {
                    Materia M = new Materia(DR.Field<int>(4), DR.Field<string>(5), LC.Find(X=> X.Codigo == DR.Field<int>(0)));
                    Diccionario.Add(M, new List<Evaluacion_de_Alumno>());
                    LMAuxilar.Add(M);
                }

                foreach (Materia Materia in LMAuxilar)
                {
                    DataTable DT2 = DAL_Evaluacion_de_Alumno.Obtener_Evaluaciones_de_Materia_Curso_Docente(pDocente, Materia.RetornarCurso(), Materia);

                    foreach (DataRow DR2 in DT2.Rows)
                    {
                        Diccionario[Materia].Add(new Evaluacion_de_Alumno(DR2.Field<int>(0), pDocente, DR2.Field<DateTime>(1)));
                    }
                }   

                return Diccionario;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Obtener_Calificaciones_de_Evaluacion(Dictionary<Evaluacion, List<Evaluacion_de_Alumno>> pEvaluaciones)
        {
            try
            {
                foreach (KeyValuePair<Evaluacion, List<Evaluacion_de_Alumno>> item in pEvaluaciones)
                {
                    DataTable DT = DAL_Evaluacion_de_Alumno.Obtener_Calificaciones_de_Evaluacion(item.Key);

                    foreach (DataRow DR in DT.Rows)
                    {
                        Evaluacion_de_Alumno Eval = new Evaluacion_de_Alumno(DR.Field<int>(0), DR.Field<DateTime>(1), DR.Field<int>(2));
                        Eval.Evaluacion = item.Key;
                        item.Value.Add(Eval);
                    }                    
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
