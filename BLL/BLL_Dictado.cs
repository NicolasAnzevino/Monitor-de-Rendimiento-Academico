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
    public class BLL_Dictado
    {
        MAP_Dictado MAP_Dictado;
        public BLL_Dictado()
        {
            MAP_Dictado = new MAP_Dictado();
        }

        public void Crear_Dictado(Curso pCurso, Materia pMateria, List<Docente> pDocentes)
        {
            try
            {
                Dictado Dictado = new Dictado();
                Dictado.Curso = pCurso;
                Dictado.Materia = pMateria;

                foreach (Docente D in pDocentes)
                {
                    Dictado.VerDocentes().Add(D);
                }

                MAP_Dictado.Crear_Dictado(Dictado);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public List<Dictado> Ver_Dictados_Activos()
        {
            try
            {
                return MAP_Dictado.Ver_Dictados_Activos();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Dictado> Ver_Dictados_Inactivos()
        {
            try
            {
                return MAP_Dictado.Ver_Dictados_Inactivos();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Dictado> Ver_Dictados_del_Docente_Activos(int pID)
        {
            try
            {
                return MAP_Dictado.Ver_Dictados_del_Docente_Activos(pID);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Dictado> Ver_Dictados_del_Docente_Inactivos(int pID)
        {
            try
            {
                return MAP_Dictado.Ver_Dictados_del_Docente_Inactivos(pID);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Modificar_Dictado(Dictado pDictado, Curso pCurso, Materia pMateria, Materia pNuevaMateria, List<Docente> pDocentes)
        {
            try
            {
                MAP_Dictado.Modificar_Dictado(pDictado, pCurso, pMateria, pNuevaMateria, pDocentes);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Reasignar_Docentes_a_Dictado(Dictado pDictado, Curso pCurso, List<Docente> pDocentes)
        {
            try
            {
                MAP_Dictado.Reasignar_Docentes_a_Dictado(pDictado, pCurso, pDocentes);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Dictado> Ver_Dictados_Codigo(List<Dictado> pLD, string pCodigo)
        {
            IEnumerable<Dictado> IED = from X in pLD
                                     where X.Codigo.ToString().StartsWith(pCodigo)
                                     select X;

            List<Dictado> ListaDeConsulta = IED.ToList();

            return ListaDeConsulta;
        }
        public List<Dictado> Ver_Dictados_Materia(List<Dictado> pLD, string pMateria)
        {
            IEnumerable<Dictado> IED = from X in pLD
                                       where X.Materia.Nombre.StartsWith(pMateria)
                                       select X;

            List<Dictado> ListaDeConsulta = IED.ToList();

            return ListaDeConsulta;
        }
        public List<Dictado> Ver_Dictados_Curso(List<Dictado> pLD, string pCurso)
        {
            IEnumerable<Dictado> IED = from X in pLD
                                       where X.Curso.Nombre.StartsWith(pCurso)
                                       select X;

            List<Dictado> ListaDeConsulta = IED.ToList();

            return ListaDeConsulta;
        }
        public List<Dictado> Ver_Dictados_Docente(List<Dictado> pLD, string pDocente)
        {
            List<Dictado> ListaDeConsulta = new List<Dictado>();

            foreach (Dictado D in pLD)
            {
                if (D.VerDocentes().Exists(X=> X.Apellido.StartsWith(pDocente) == true))
                {
                    ListaDeConsulta.Add(D);
                }

                else if(D.VerDocentes().Exists(X => X.Nombre.StartsWith(pDocente) == true))
                {
                    ListaDeConsulta.Add(D);
                }
            }

            return ListaDeConsulta;
        }
        public void Agregar_Clase(string pDescripcion, DateTime pFecha, List<Tema> pLT, Dictado pDictado)
        {
            try
            {
                Clase Clase = new Clase(pDescripcion, pFecha, pDictado, pLT);
                MAP_Dictado.Agregar_Clase(Clase);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Clase> Ver_Clases_de_Dictado(Dictado pDictado)
        {
            try
            {
                return MAP_Dictado.Ver_Clases_de_Dictado(pDictado);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public int Verificar_Existencia_de_Clase(DateTime pDateTime, Dictado pDictado)
        {
            try
            {
                return MAP_Dictado.Verificar_Existencia_de_Clase(pDateTime, pDictado);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Clase> Ver_Clases_Fecha(List<Clase> pLC, DateTime pFecha)
        {
            IEnumerable<Clase> IEC = from X in pLC
                                      where X.Fecha == pFecha
                                      select X;

            List<Clase> ListaDeConsulta = IEC.ToList();

            return ListaDeConsulta;
        }
        



    }
}
