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
    public class MAP_Dictado
    {
        DAL_Dictado DAL_Dictado;
        DAL_Materia DAL_Materia;
        DAL_Tema DAL_Tema;
        public MAP_Dictado()
        {
            DAL_Dictado = new DAL_Dictado();
            DAL_Materia = new DAL_Materia();
            DAL_Tema = new DAL_Tema();
        }

        public void Crear_Dictado(Dictado pDictado)
        {
            try
            {
                DAL_Dictado.Crear_Dictado(pDictado);

                int ID = DAL_Dictado.Obtener_ID_Dictado(pDictado);

                foreach (Docente D in pDictado.VerDocentes())
                {
                    DAL_Dictado.Asignar_Docente_Dictado(D, ID, pDictado.Curso);
                }                
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Dictado> Ver_Dictados_Activos()
        {
            try
            {
                List<Dictado> LD = new List<Dictado>();
                DataTable DTDictados = DAL_Dictado.Ver_Dictados_Activos();

                foreach (DataRow DR in DTDictados.Rows)
                {
                    Dictado D = new Dictado(DR.Field<int>(0));

                    D.Materia.Nombre = DR.Field<string>(1);
                    D.Curso.Nombre = DR.Field<string>(2);

                    LD.Add(D);
                }

                foreach (Dictado D in LD)
                {
                    DataTable DTDocentes = DAL_Dictado.Ver_Docentes_De_Dictado(D);

                    foreach (DataRow datarowDocentes in DTDocentes.Rows)
                    {
                        D.VerDocentes().Add(new Docente(datarowDocentes.Field<string>(0), datarowDocentes.Field<string>(1), datarowDocentes.Field<string>(2)));
                    }                   
                }

                return LD;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Dictado> Ver_Dictados_Inactivos()
        {
            try
            {
                List<Dictado> LD = new List<Dictado>();
                DataTable DTDictados = DAL_Dictado.Ver_Dictados_Inactivos();

                foreach (DataRow DR in DTDictados.Rows)
                {
                    Dictado D = new Dictado(DR.Field<int>(0));

                    D.Materia.Nombre = DR.Field<string>(1);
                    D.Curso.Nombre = DR.Field<string>(2);

                    LD.Add(D);
                }

                foreach (Dictado D in LD)
                {
                    DataTable DTDocentes = DAL_Dictado.Ver_Docentes_De_Dictado(D);

                    foreach (DataRow datarowDocentes in DTDocentes.Rows)
                    {
                        D.VerDocentes().Add(new Docente(datarowDocentes.Field<string>(0), datarowDocentes.Field<string>(1), datarowDocentes.Field<string>(2)));
                    }
                }

                return LD;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public List<Dictado> Ver_Dictados_del_Docente_Activos(int pID)
        {
            try
            {
                List<Dictado> LD = new List<Dictado>();
                DataTable DT = DAL_Dictado.Ver_Dictados_del_Docente_Activos(pID);

                foreach (DataRow DR in DT.Rows)
                {
                    Dictado D = new Dictado(DR.Field<int>(0));
                    D.Curso = new Curso(DR.Field<int>(3), DR.Field<string>(4), DR.Field<int>(5), DR.Field<string>(6));
                    D.Materia = new Materia(DR.Field<int>(1), DR.Field<string>(2));
                    
                    LD.Add(D);
                }

                foreach (Dictado D in LD)
                {
                    DataTable DTDocentes = DAL_Dictado.Ver_Docentes_De_Dictado(D);

                    foreach (DataRow datarowDocentes in DTDocentes.Rows)
                    {
                        D.VerDocentes().Add(new Docente(datarowDocentes.Field<string>(0), datarowDocentes.Field<string>(1), datarowDocentes.Field<string>(2)));
                    }
                }

                return LD;

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Dictado> Ver_Dictados_del_Docente_Inactivos(int pID)
        {
            try
            {
                List<Dictado> LD = new List<Dictado>();
                DataTable DT = DAL_Dictado.Ver_Dictados_del_Docente_Inactivos(pID);

                foreach (DataRow DR in DT.Rows)
                {
                    Dictado D = new Dictado(DR.Field<int>(0));
                    D.Curso = new Curso(DR.Field<int>(3), DR.Field<string>(4));
                    D.Materia = new Materia(DR.Field<int>(1), DR.Field<string>(2));

                    LD.Add(D);
                }

                foreach (Dictado D in LD)
                {
                    DataTable DTDocentes = DAL_Dictado.Ver_Docentes_De_Dictado(D);

                    foreach (DataRow datarowDocentes in DTDocentes.Rows)
                    {
                        D.VerDocentes().Add(new Docente(datarowDocentes.Field<string>(0), datarowDocentes.Field<string>(1), datarowDocentes.Field<string>(2)));
                    }
                }

                return LD;

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Modificar_Dictado(Dictado pDictado, Curso pCurso, Materia pMateria, Materia pMateriaNueva, List<Docente> pDocentes)
        {
            try
            {
                DAL_Materia.Quitar_Curso_de_Materia(pMateria);
                DAL_Dictado.Limpiar_Docentes_de_Dictado(pDictado);

                foreach (Docente D in pDocentes)
                {
                    DAL_Dictado.Asignar_Docente_Dictado(D, pDictado.Codigo, pCurso);
                }

                DAL_Materia.Asignar_Curso_a_Materia(pMateriaNueva, pCurso);
                DAL_Dictado.Actualizar_Dictado(pDictado, pMateriaNueva, pCurso);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Reasignar_Docentes_a_Dictado(Dictado pDictado, Curso pCurso, List<Docente> pDocentes)
        {
            try
            {
                DAL_Dictado.Limpiar_Docentes_de_Dictado(pDictado);

                foreach (Docente D in pDocentes)
                {
                    DAL_Dictado.Asignar_Docente_Dictado(D, pDictado.Codigo, pCurso);
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Agregar_Clase(Clase pClase)
        {
            try
            {
                int IDClase = DAL_Dictado.Agregar_Clase(pClase);

                foreach (Tema T in pClase.Temas)
                {
                    DAL_Dictado.Establecer_Temas_de_Clase(T, IDClase);
                }                
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Clase> Ver_Clases_de_Dictado(Dictado pDictado)
        {
            try
            {
                List<Clase> LC = new List<Clase>();
                DataTable DT = DAL_Dictado.Ver_Clases_de_Dictado(pDictado);

                foreach (DataRow DR in DT.Rows)
                {
                    Clase Clase = new Clase(DR.Field<int>(0), DR.Field<string>(2), DR.Field<DateTime>(1));

                    DataTable DTTemas = DAL_Tema.Ver_Temas_de_Clase(Clase);

                    foreach (DataRow dr in DTTemas.Rows)
                    {
                        Tema T = new Tema(dr.Field<int>(0), dr.Field<string>(1), dr.Field<string>(2));
                        Clase.Temas.Add(T);
                    }

                    LC.Add(Clase);
                }

                return LC;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public int Verificar_Existencia_de_Clase(DateTime pDateTime, Dictado pDictado)
        {
            try
            {
                return DAL_Dictado.Verificar_Existencia_de_Clase(pDateTime, pDictado);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
