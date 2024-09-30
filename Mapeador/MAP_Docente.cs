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
    public class MAP_Docente
    {
        DAL_Docente DAL_Docente;
        public MAP_Docente()
        {
            DAL_Docente = new DAL_Docente();
        }
        public void Agregar_Docente(Docente pDocente, int pUserID)
        {
            try
            {
                DAL_Docente.Agregar_Docente(pDocente, pUserID);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Modificar_Docente(Docente pDocente, int pID)
        {
            try
            {
                DAL_Docente.Modificar_Docente(pDocente, pID);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Modificar_Docente(Usuario pUsuario)
        {
            try
            {
                DAL_Docente.Modificar_Docente(pUsuario);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Modificar_Docente(Alumno pAlumno, int pID)
        {
            try
            {
                DAL_Docente.Modificar_Docente(pAlumno, pID);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public bool Verificar_Unicidad_Legajo(string pLegajo)
        {
            try
            {
                return DAL_Docente.Verificar_Unicidad_Legajo(pLegajo);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Docente> Ver_Docentes_Activos()
        {
            try
            {
                List<Docente> LD = new List<Docente>();
                DataTable DT = DAL_Docente.Ver_Docentes_Activos();

                foreach (DataRow DR in DT.Rows)
                {
                    LD.Add(new Docente(DR.Field<string>(0), true, DR.Field<string>(2), DR.Field<string>(3), DR.Field<int>(1)));
                }

                return LD;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Docente> Ver_Docentes_Inactivos()
        {
            try
            {
                List<Docente> LD = new List<Docente>();
                DataTable DT = DAL_Docente.Ver_Docentes_Inactivos();

                foreach (DataRow DR in DT.Rows)
                {
                    LD.Add(new Docente(DR.Field<string>(0), false, DR.Field<string>(2), DR.Field<string>(3), DR.Field<int>(1)));
                }

                return LD;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Dar_De_Baja_Docente(Docente pDocente)
        {
            try
            {
                DAL_Docente.Dar_De_Baja_Docente(pDocente);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Dar_De_Alta_Docente(Docente pDocente)
        {
            try
            {
                DAL_Docente.Dar_De_Alta_Docente(pDocente);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public int Obtener_ID_Usuario_Docente(Docente pDocente)
        {
            try
            {
                return DAL_Docente.Obtener_ID_Usuario_Docente(pDocente);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Docente Obtener_Docente_Por_ID_Usuario(int pID)
        {
            try
            {
                DataTable DT = DAL_Docente.Obtener_Docente_Por_ID_Usuario(pID);

                Docente D = new Docente(DT.Rows[0].Field<string>(0), DT.Rows[0].Field<bool>(4), DT.Rows[0].Field<string>(2), DT.Rows[0].Field<string>(3), DT.Rows[0].Field<int>(1));

                return D;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Docente> Ver_Docentes_Evaluaron_Tema(Tema pTema)
        {
            try
            {
                DataTable DT = DAL_Docente.Ver_Docentes_Evaluaron_Tema(pTema);
                List<Docente> LD = new List<Docente>();

                foreach (DataRow DR in DT.Rows)
                {
                    LD.Add(new Docente(DR.Field<string>(0), DR.Field<bool>(1), DR.Field<string>(3), DR.Field<string>(4), DR.Field<int>(2)));
                }

                return LD;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Dar_De_Baja_Docente(Usuario pUsuario)
        {
            try
            {
                DAL_Docente.Dar_De_Baja_Docente(pUsuario);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Dar_De_Alta_Docente(Usuario pUsuario)
        {
            try
            {
                DAL_Docente.Dar_De_Alta_Docente(pUsuario);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public int Obtener_Promedio_Docente(Docente pDocente)
        {
            try
            {
                return DAL_Docente.Obtener_Promedio_Docente(pDocente);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public int Obtener_Cant_Evaluaciones_Corregidas(Docente pDocente)
        {
            try
            {
                return DAL_Docente.Obtener_Cant_Evaluaciones_Corregidas(pDocente);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public int Obtener_Promedio_Docente_Hasta_Fecha(Docente pDocente, DateTime pDateTime)
        {
            try
            {
                return DAL_Docente.Obtener_Promedio_Docente_Hasta_Fecha(pDocente, pDateTime);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

    }
}
