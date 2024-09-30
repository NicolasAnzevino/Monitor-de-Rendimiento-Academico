using System;
using System.Runtime;
using System.Collections.Generic;
using System.Data.Linq.SqlClient;
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
    public class BLL_Alumno
    {
        MAP_Alumno MAP_Alumno;
        public BLL_Alumno()
        {
            MAP_Alumno = new MAP_Alumno();
        }

        public void Agregar_Alumno(string pLegajo, int pDNI, string pCorreoElectronico, string pNombre, string pApellido, int pTurno, DateTime pFechaIngreso, DateTime pFechaNacimiento, Usuario pUsuario)
        {
            try
            {
                MAP_Alumno.Agregar_Alumno(pLegajo, pDNI, pCorreoElectronico, pNombre, pApellido, pTurno, pFechaIngreso, pFechaNacimiento, pUsuario);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public bool Verificar_Unicidad_Legajo(string pLegajo)
        {
            try
            {
                return MAP_Alumno.Verificar_Unicidad_Legajo(pLegajo);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Alumno> Ver_Alumnos_Activos()
        {
            try
            {
                return MAP_Alumno.Ver_Alumnos_Activos();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Alumno> Ver_Alumnos_Inactivos()
        {
            try
            {
                return MAP_Alumno.Ver_Alumnos_Inactivos();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Dar_De_Baja_Alumno(Alumno pAlumno)
        {
            try
            {
                MAP_Alumno.Dar_De_Baja_Alumno(pAlumno);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public List<Alumno> Ver_Alumnos_Legajo(List<Alumno> pLA, string pLegajo)
        {
            IEnumerable<Alumno> IEA = from X in pLA
                                      where X.Legajo == pLegajo
                                      select X;

            List<Alumno> ListaDeConsulta = IEA.ToList();

            return ListaDeConsulta;
        }

        public List<Alumno> Ver_Alumnos_DNI(List<Alumno> pLA, int pDNI)
        {
            IEnumerable<Alumno> IEA = from X in pLA
                                      where X.DNI.ToString().StartsWith(pDNI.ToString())
                                      select X;

            List<Alumno> ListaDeConsulta = IEA.ToList();

            return ListaDeConsulta;
        }

        public List<Alumno> Ver_Alumnos_Apellido(List<Alumno> pLA, string pApellido)
        {
            IEnumerable<Alumno> IEA = from X in pLA
                                      where X.Apellido.StartsWith(pApellido)
                                      select X;

            List<Alumno> ListaDeConsulta = IEA.ToList();

            return ListaDeConsulta;
        }

        public List<Alumno> Ver_Alumnos_Nombre(List<Alumno> pLA, string pNombre)
        {
            IEnumerable<Alumno> IEA = from X in pLA
                                      where X.Nombre.StartsWith(pNombre)
                                      select X;

            List<Alumno> ListaDeConsulta = IEA.ToList();

            return ListaDeConsulta;
        }

        public List<Alumno> Ver_Alumnos_Turno(List<Alumno> pLA, string pTurno)
        {
            IEnumerable<Alumno> IEA = from X in pLA
                                      where X.Turno.ToString().StartsWith(pTurno)
                                      select X;

            List<Alumno> ListaDeConsulta = IEA.ToList();

            return ListaDeConsulta;
        }
        public List<Alumno> Ver_Alumnos_Regulares(List<Alumno> pLA, Dictionary<string,bool> pDiccionario)
        {
            List<Alumno> ListaDeConsulta = new List<Alumno>();

            foreach (KeyValuePair<string,bool> item in pDiccionario)
            {
                if (item.Value == false)
                {
                    if (pLA.Exists(X=> X.Legajo == item.Key))
                    {
                        ListaDeConsulta.Add(pLA.Find(X => X.Legajo == item.Key));
                    }                    
                }
            }           
           
            return ListaDeConsulta;
        }

        public List<Alumno> Ver_Alumnos_Libres(List<Alumno> pLA, Dictionary<string, bool> pDiccionario)
        {
            List<Alumno> ListaDeConsulta = new List<Alumno>();

            foreach (KeyValuePair<string, bool> item in pDiccionario)
            {
                if (item.Value == true)
                {
                    if (pLA.Exists(X => X.Legajo == item.Key))
                    {
                        ListaDeConsulta.Add(pLA.Find(X => X.Legajo == item.Key));
                    }
                }
            }

            return ListaDeConsulta;
        }

        public void Modificar_Alumno(Alumno pAlumno)
        {
            try
            {
                MAP_Alumno.Modificar_Alumno(pAlumno);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Modificar_Alumno(Usuario pUsuario)
        {
            try
            {
                MAP_Alumno.Modificar_Alumno(pUsuario);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Modificar_Alumno(Docente pDocente, int pUserID)
        {
            try
            {
                MAP_Alumno.Modificar_Alumno(pDocente, pUserID);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public int Obtener_ID_Usuario_Alumno(Alumno pAlumno)
        {
            try
            {
                return MAP_Alumno.Obtener_ID_Usuario_Alumno(pAlumno);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Dar_De_Alta_Alumno(Alumno pAlumno)
        {
            try
            {
                MAP_Alumno.Dar_De_Alta_Alumno(pAlumno);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public List<Alumno> Ver_Alumnos_de_Materia(Materia pMateria)
        {
            try
            {
                return MAP_Alumno.Ver_Alumnos_de_Materia(pMateria);                
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Alumno Obtener_Alumno_Por_ID_Usuario(int pID)
        {
            try
            {
                return MAP_Alumno.Obtener_Alumno_Por_ID_Usuario(pID);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Dar_De_Alta_Alumno(Usuario pUsuario)
        {
            try
            {
                MAP_Alumno.Dar_De_Alta_Alumno(pUsuario);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Dar_De_Baja_Alumno(Usuario pUsuario)
        {
            try
            {
                MAP_Alumno.Dar_De_Baja_Alumno(pUsuario);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }

}
