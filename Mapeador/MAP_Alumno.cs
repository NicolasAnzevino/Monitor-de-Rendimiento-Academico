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
    public class MAP_Alumno
    {
        DAL_Alumno DAL_Alumno;
        public MAP_Alumno()
        {
            DAL_Alumno = new DAL_Alumno();
        }
        public void Agregar_Alumno(string pLegajo, int pDNI, string pCorreoElectronico, string pNombre, string pApellido, int pTurno, DateTime pFechaIngreso, DateTime pFechaNacimiento, Usuario pUsuario)
        {
            try
            {
                DAL_Alumno.Agregar_Alumno(pLegajo, pDNI, pCorreoElectronico, pNombre, pApellido, pTurno, pFechaIngreso, pFechaNacimiento, pUsuario);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public bool Verificar_Unicidad_Legajo(string pLegajo)
        {
            try
            {
                return DAL_Alumno.Verificar_Unicidad_Legajo(pLegajo);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Alumno> Ver_Alumnos_Activos()
        {
            try
            {
                DataTable DT = DAL_Alumno.Ver_Alumnos_Activos();
                List<Alumno> LA = new List<Alumno>();

                foreach (DataRow DR in DT.Rows)
                {
                    LA.Add(new Alumno(DR.Field<string>(0),DR.Field<int>(1),DR.Field<string>(2),DR.Field<string>(3),DR.Field<string>(7),DR.Field<string>(4),DR.Field<DateTime>(5),DR.Field<DateTime>(6), true));
                }

                return LA;
                
            }
            catch (Exception ex) {  throw new Exception(ex.Message); }
        }
        public List<Alumno> Ver_Alumnos_Inactivos()
        {
            try
            {
                DataTable DT = DAL_Alumno.Ver_Alumnos_Inactivos();
                List<Alumno> LA = new List<Alumno>();

                foreach (DataRow DR in DT.Rows)
                {
                    LA.Add(new Alumno(DR.Field<string>(0), DR.Field<int>(1), DR.Field<string>(2), DR.Field<string>(3), DR.Field<string>(7), DR.Field<string>(4), DR.Field<DateTime>(5), DR.Field<DateTime>(6), false));
                }

                return LA;

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Dar_De_Baja_Alumno(Alumno pAlumno)
        {
            try
            {
                DAL_Alumno.Dar_De_Baja_Alumno(pAlumno);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Modificar_Alumno(Usuario pUsuario)
        {
            try
            {
                DAL_Alumno.Modificar_Alumno(pUsuario);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Modificar_Alumno(Alumno pAlumno)
        {
            try
            {
                DAL_Alumno.Modificar_Alumno(pAlumno);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }        
        public void Modificar_Alumno(Docente pDocente, int pUserID)
        {
            try
            {
                DAL_Alumno.Modificar_Alumno(pDocente, pUserID);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public int Obtener_ID_Usuario_Alumno(Alumno pAlumno)
        {
            try
            {
                return DAL_Alumno.Obtener_ID_Usuario_Alumno(pAlumno);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Dar_De_Alta_Alumno(Alumno pAlumno)
        {
            try
            {
                DAL_Alumno.Dar_De_Alta_Alumno(pAlumno);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Alumno> Ver_Alumnos_de_Materia(Materia pMateria)
        {
            try
            {
                DataTable DT = DAL_Alumno.Ver_Alumnos_de_Materia(pMateria);
                List<Alumno> LA = new List<Alumno>();

                foreach (DataRow DR in DT.Rows)
                {
                    LA.Add(new Alumno(DR.Field<string>(0), DR.Field<int>(1), DR.Field<string>(2), DR.Field<string>(3)));
                }

                return LA;

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Alumno Obtener_Alumno_Por_ID_Usuario(int pID)
        {
            try
            {
                DataTable DT = DAL_Alumno.Obtener_Alumno_Por_ID_Usuario(pID);
                Alumno Alumno;

                if (DT.Rows.Count>0)
                {
                    Alumno = new Alumno(DT.Rows[0].Field<string>(0), DT.Rows[0].Field<int>(1), DT.Rows[0].Field<string>(2), DT.Rows[0].Field<string>(4), DT.Rows[0].Field<string>(8), DT.Rows[0].Field<string>(3), DT.Rows[0].Field<DateTime>(5), DT.Rows[0].Field<DateTime>(6), true);
                }
                else
                {
                    Alumno = null;
                }

                return Alumno;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Dar_De_Alta_Alumno(Usuario pUsuario)
        {
            try
            {
                DAL_Alumno.Dar_De_Alta_Alumno(pUsuario);
            }
            catch (Exception ex) {  throw new Exception(ex.Message); }
        }
        public void Dar_De_Baja_Alumno(Usuario pUsuario)
        {
            try
            {
                DAL_Alumno.Dar_De_Baja_Alumno(pUsuario);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

    }
}
