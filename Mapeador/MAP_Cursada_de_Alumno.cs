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
    public class MAP_Cursada_de_Alumno
    {
        DAL_Cursada_de_Alumno DAL_Cursada_De_Alumno;
        public MAP_Cursada_de_Alumno()
        {
            DAL_Cursada_De_Alumno = new DAL_Cursada_de_Alumno();
        }

        public void Agregar_Cursada(Cursada_de_Alumno pCursada)
        {
            try
            {
                DAL_Cursada_De_Alumno.Agregar_Cursada(pCursada);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public bool Verficar_Existencia_Cursada(Alumno pAlumno, Curso pCurso)
        {
            try
            {
                return DAL_Cursada_De_Alumno.Verficar_Existencia_Cursada(pAlumno, pCurso);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Cursada_de_Alumno> Ver_Cursadas_de_Alumno(Alumno pAlumno)
        {
            try
            {
                DataTable DT = DAL_Cursada_De_Alumno.Verficar_Cursadas_de_Alumno(pAlumno);

                List<Cursada_de_Alumno> LC = new List<Cursada_de_Alumno>();

                foreach (DataRow DR in DT.Rows)
                {
                    Curso Curso = new Curso(DR.Field<int>(1), DR.Field<string>(2), DR.Field<int>(3), DR.Field<string>(4), DR.Field<bool>(5));
                    Cursada_de_Alumno CA = new Cursada_de_Alumno(DR.Field<int>(0), Curso, DR.Field<bool>(6));

                    LC.Add(CA);
                }

                return LC;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Cursada_de_Alumno Buscar_Cursada_de_Alumno(Alumno pAlumno, Curso pCurso)
        {
            try
            {
                DataTable DT = DAL_Cursada_De_Alumno.Buscar_Cursada_de_Alumno(pAlumno, pCurso);
                Cursada_de_Alumno CA = new Cursada_de_Alumno(DT.Rows[0].Field<int>(0), pAlumno, pCurso, DT.Rows[0].Field<bool>(1));

                return CA;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Ver_Cursadas_de_Curso(List<Alumno> pAlumnos)
        {
            try
            {
                foreach (Alumno Alumno in pAlumnos)
                {
                    DataTable DT = DAL_Cursada_De_Alumno.Verficar_Cursadas_de_Alumno(Alumno);

                    foreach (DataRow DR in DT.Rows)
                    {
                        Curso Curso = new Curso(DR.Field<int>(1), DR.Field<string>(2), DR.Field<int>(3), DR.Field<string>(4), DR.Field<bool>(5));
                        Cursada_de_Alumno CA = new Cursada_de_Alumno(DR.Field<int>(0), Curso, DR.Field<bool>(6));

                        Alumno.VerCursadas().Add(CA);
                    }
                }              
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Modificar_Estado_de_Cursada(Cursada_de_Alumno pCursada, bool pEstado)
        {
            try
            {
                DAL_Cursada_De_Alumno.Modificar_Estado_de_Cursada(pCursada, pEstado);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public int ObtenerPromedioDeCursada(Cursada_de_Alumno pCursada)
        {
            try
            {
                return DAL_Cursada_De_Alumno.ObtenerPromedioDeCursada(pCursada);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }



    }
}
