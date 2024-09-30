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
    public class BLL_Materia
    {
        MAP_Materia MAP_Materia;
        MAP_Evaluacion MAP_Evaluacion;
        MAP_Evaluacion_de_Alumno MAP_Evaluacion_de_Alumno;
        MAP_Tema MAP_Tema;
        public BLL_Materia()
        {
            MAP_Materia = new MAP_Materia();
            MAP_Evaluacion = new MAP_Evaluacion();
            MAP_Tema = new MAP_Tema();
            MAP_Evaluacion_de_Alumno = new MAP_Evaluacion_de_Alumno();
        }
        public int Comprobar_Unicidad_Nombre_Materia(string pNombre)
        {
            try
            {
                return MAP_Materia.Comprobar_Unicidad_Nombre(pNombre);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void Crear_Materia(string pNombre, int pCantHoras)
        {
            try
            {
                Materia M = new Materia(pNombre, pCantHoras, true);

                MAP_Materia.Crear_Materia(M);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Materia> Ver_Materias_Activas()
        {
            try
            {
                return MAP_Materia.Ver_Materias_Activas();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Materia> Ver_Materias_Inactivas()
        {
            try
            {
                return MAP_Materia.Ver_Materias_Inactivas();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Materia> Ver_Materias_Activas_Sin_Curso()
        {
            try
            {
                return MAP_Materia.Ver_Materias_Activas_Sin_Curso();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Tema> Ver_Temas()
        {
            try
            {
                return MAP_Tema.Ver_Temas();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public List<Tema> Ver_Temas_De_Materia(Materia pMateria)
        {
            try
            {
                return MAP_Tema.Ver_Temas_De_Materia(pMateria);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Tema Agregar_Tema(string pNombre, string pDescripcion)
        {
            try
            {
                Tema T = new Tema(pNombre, pDescripcion);
                MAP_Tema.Agregar_Tema(T);

                return T;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public int Comprobar_Unicidad_Nombre_Tema(string pNombre)
        {
            try
            {
                return MAP_Tema.Comprobar_Unicidad_Nombre(pNombre);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Agregar_Tema_A_Materia(Materia pMateria, Tema pTema)
        {
            try
            {
                MAP_Materia.Agregar_Tema_A_Materia(pMateria, pTema);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Quitar_Tema_De_Materia(Materia pMateria, Tema pTema)
        {
            try
            {
                MAP_Materia.Quitar_Tema_De_Materia(pMateria, pTema);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Dar_De_Baja_Materia(Materia pMateria)
        {
            try
            {
                MAP_Materia.Dar_De_Baja_Materia(pMateria);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Modificar_Materia(Materia pMateria)
        {
            try
            {
                MAP_Materia.Modificar_Materia(pMateria);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Modificar_Tema(Tema pTema)
        {
            try
            {
                MAP_Tema.Modificar_Tema(pTema);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public List<Evaluacion> Ver_Evaluaciones_de_Materia(Materia pMateria)
        {
            try
            {
                List<Evaluacion> LE = MAP_Evaluacion.Ver_Evaluaciones_de_Materia(pMateria);

                foreach (Evaluacion E in LE)
                {
                    List<Tema> TemasDeEvaluacion = MAP_Tema.Ver_Temas_de_Evaluacion(E);

                    foreach (Tema T in TemasDeEvaluacion)
                    {
                        E.VerTemas().Add(T);
                    }
                }

                return LE;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Crear_Evaluacion_de_Materia(string pTitulo, DateTime pFecha, List<Tema> pTemas, Materia pMateria)
        {
            try
            {
                Evaluacion E = new Evaluacion(pTitulo, pFecha, pMateria);
                MAP_Evaluacion.Crear_Evaluacion_de_Materia(E, pTemas);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        
        public List<Tema> Ver_Temas_de_Evaluacion(Evaluacion pEvaluacion)
        {
            try
            {
                return MAP_Tema.Ver_Temas_de_Evaluacion(pEvaluacion);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Modificar_Evaluacion(Evaluacion pEvaluacion, List<Tema> pTemas)
        {
            try
            {
                MAP_Evaluacion.Modificar_Evaluacion(pEvaluacion, pTemas);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Borrar_Evaluacion(Evaluacion pEvaluacion)
        {
            try
            {
                MAP_Evaluacion.Borrar_Evaluacion(pEvaluacion);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Materia Obtener_Materia_de_Dictado(Dictado pDictado)
        {
            try
            {
                return MAP_Materia.Obtener_Materia_de_Dictado(pDictado);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Evaluacion_de_Alumno> Ver_Evaluaciones_de_Alumno_de_Materia(Materia pMateria)
        {
            try
            {
                return MAP_Evaluacion_de_Alumno.Ver_Evaluaciones_de_Alumno_de_Materia(pMateria);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Evaluacion> Obtener_Evaluaciones_de_Calificacion(List<Evaluacion_de_Alumno> pLEA)
        {
            try
            {
                List<Evaluacion> LE = new List<Evaluacion>();

                foreach (Evaluacion_de_Alumno EA in pLEA)
                {
                    if (!(LE.Exists(X=> X.Codigo == EA.Evaluacion.Codigo)))
                    {
                        LE.Add(EA.Evaluacion);
                    }
                }

                return LE;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Evaluacion_de_Alumno> Obtener_Calificaciones_de_Evaluacion(List<Evaluacion_de_Alumno> pLEA, Evaluacion pEvaluacion)
        {
            IEnumerable<Evaluacion_de_Alumno> IEA = from X in pLEA
                                                    where X.Evaluacion.Titulo == pEvaluacion.Titulo
                                                    select X;

            List<Evaluacion_de_Alumno> ListaDeConsulta = IEA.ToList();

            return ListaDeConsulta;
        }
        public List<Evaluacion_de_Alumno> Obtener_Calificaciones_corregidas_por_Docente(List<Evaluacion_de_Alumno> pLEA, Docente pDocente)
        {
            IEnumerable<Evaluacion_de_Alumno> IEA = from X in pLEA
                                                    where X.Docente.Legajo == pDocente.Legajo
                                                    select X;

            List<Evaluacion_de_Alumno> ListaDeConsulta = IEA.ToList();

            return ListaDeConsulta;
        }
        public int Obtener_Cant_Calificaciones_Aprobadas(List<Evaluacion_de_Alumno> pLEA)
        {
            int Cantidad = 0;

            foreach (Evaluacion_de_Alumno EA in pLEA)
            {
                if (EA.Calificacion >=6)
                {
                    Cantidad++;
                }
            }
            return Cantidad;
        }
        public int Obtener_Cant_Calificaciones_Reprobadas(List<Evaluacion_de_Alumno> pLEA)
        {
            int Cantidad = 0;

            foreach (Evaluacion_de_Alumno EA in pLEA)
            {
                if (EA.Calificacion < 6)
                {
                    Cantidad++;
                }
            }
            return Cantidad;
        }
        public List<Evaluacion_de_Alumno> Obtener_Calificaciones_corregidas_por_Docente_de_Evaluacion(List<Evaluacion_de_Alumno> pLEA, Docente pDocente, Evaluacion pEvaluacion)
        {
            IEnumerable<Evaluacion_de_Alumno> IEA = from X in pLEA
                                                    where (X.Docente.Legajo == pDocente.Legajo) && (X.Evaluacion.Codigo == pEvaluacion.Codigo)
                                                    select X;

            List<Evaluacion_de_Alumno> ListaDeConsulta = IEA.ToList();

            return ListaDeConsulta;
        }
        public void Dar_De_Baja_Materias_de_Curso(List<Dictado> pLD)
        {
            try
            {
                MAP_Materia.Dar_De_Baja_Materias_de_Curso(pLD);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public bool Verificar_Evaluaciones_Materia(Materia pMateria)
        {
            try
            {
                return MAP_Materia.Verificar_Evaluaciones_Materia(pMateria);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Materia> Ver_Materias_Activas_Con_Curso()
        {
            try
            {
                List<Materia> LM = MAP_Materia.Ver_Materias_Activas_Con_Curso();

                foreach (Materia Materia in LM)
                {
                    List<Tema> LT = MAP_Tema.Ver_Temas_De_Materia(Materia);

                    foreach (Tema Tema in LT)
                    {
                        Materia.VerTemas().Add(Tema);
                    }
                }

                return LM;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Materia> Ver_Materias_Inactivas_Con_Curso()
        {
            try
            {
                List<Materia> LM = MAP_Materia.Ver_Materias_Inactivas_Con_Curso();

                foreach (Materia Materia in LM)
                {
                    MAP_Tema.Ver_Temas_De_Materia(Materia);
                }

                return LM;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Evaluacion> Obtener_Evaluaciones_Docente_Tema(Docente pDocente, Tema pTema)
        {
            try
            {
                return MAP_Evaluacion.Obtener_Evaluaciones_Docente_Tema(pDocente, pTema);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public List<Materia> Ver_Materias_Codigo(List<Materia> pLM, string pCodigo)
        {
            IEnumerable<Materia> IEM = from X in pLM
                                     where X.Codigo.ToString().StartsWith(pCodigo)
                                     select X;

            List<Materia> ListaDeConsulta = IEM.ToList();

            return ListaDeConsulta;
        }

        public List<Materia> Ver_Materias_Nombre(List<Materia> pLM, string pNombre)
        {
            IEnumerable<Materia> IEM = from X in pLM
                                       where X.Nombre.ToString().StartsWith(pNombre)
                                       select X;

            List<Materia> ListaDeConsulta = IEM.ToList();

            return ListaDeConsulta;
        }

        public List<Materia> Ver_Materias_Horas(List<Materia> pLM, int pCantHoras)
        {
            IEnumerable<Materia> IEM = from X in pLM
                                       where X.Cant_Horas_Semanales.ToString().StartsWith(pCantHoras.ToString())
                                       select X;

            List<Materia> ListaDeConsulta = IEM.ToList();

            return ListaDeConsulta;
        }
        public List<Materia> Ver_Materias_Sin_Curso(List<Materia> pLM)
        {
            IEnumerable<Materia> IEM = from X in pLM
                                       where X.RetornarCurso().Codigo == 0
                                       select X;

            List<Materia> ListaDeConsulta = IEM.ToList();

            return ListaDeConsulta;
        }
        public List<Materia> Ver_Materias_Curso(List<Materia> pLM, string pCurso)
        {
            IEnumerable<Materia> IEM;

            if (pCurso == "")
            {
                IEM = from X in pLM
                where X.RetornarCurso().Codigo != 0
                select X;
            }
            else
            {
                IEM = from X in pLM
                      where X.RetornarCurso().Codigo != 0
                      select X;

                IEM = from X in IEM
                where X.RetornarCurso().Nombre.StartsWith(pCurso)
                select X;
            }            
            
            List<Materia> ListaDeConsulta = IEM.ToList();

            return ListaDeConsulta;
        }
        public List<Tema> Ver_Temas_Codigo(List<Tema> pLT, string pCodigo)
        {
            IEnumerable<Tema> IET = from X in pLT
                                       where X.Codigo.ToString().StartsWith(pCodigo)
                                       select X;

            List<Tema> ListaDeConsulta = IET.ToList();

            return ListaDeConsulta;
        }
        public List<Tema> Ver_Temas_Nombre(List<Tema> pLT, string pNombre)
        {
            IEnumerable<Tema> IET = from X in pLT
                                    where X.Nombre.ToString().StartsWith(pNombre)
                                    select X;

            List<Tema> ListaDeConsulta = IET.ToList();

            return ListaDeConsulta;
        }
        public int Obtener_Promedio_Evaluacion(List<Evaluacion_de_Alumno> pLEA)
        {
            int Cantidad = 0;

            foreach (Evaluacion_de_Alumno EA in pLEA)
            {
                Cantidad += EA.Calificacion;
            }

            Cantidad = Cantidad / pLEA.Count;

            return Cantidad;
        }
        public int Comprobar_Existencia_Clases(Tema pTema)
        {
            try
            {
                return MAP_Tema.Comprobar_Existencia_Clases(pTema);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public int Comprobar_Existencia_Evaluaciones(Tema pTema)
        {
            try
            {
                return MAP_Tema.Comprobar_Existencia_Evaluaciones(pTema);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

    }
}
