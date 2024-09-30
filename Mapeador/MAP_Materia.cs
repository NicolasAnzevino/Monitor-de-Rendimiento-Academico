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
    public class MAP_Materia
    {
        DAL_Materia DAL_Materia;
        DAL_Curso DAL_Curso;
        public MAP_Materia()
        {
            DAL_Materia = new DAL_Materia();
            DAL_Curso = new DAL_Curso();
        }

        public int Comprobar_Unicidad_Nombre(string pNombre)
        {
            try
            {
                return DAL_Materia.Comprobar_Unicidad_Nombre(pNombre); 
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void Crear_Materia(Materia pMateria)
        {
            try
            {
                DAL_Materia.Crear_Materia(pMateria);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public List<Materia> Ver_Materias_Activas()
        {
            try
            {
                DataTable DTCursosMateriasActivas = DAL_Curso.Obtener_Cursos_de_Materias_Activas();
                List<Curso> LC = new List<Curso>();               

                foreach (DataRow DR in DTCursosMateriasActivas.Rows)
                {
                    Curso C = new Curso();
                    C.Codigo = DR.Field<int>(0);
                    C.Nombre = DR.Field<string>(1);
                    C.Turno.Nombre = DR.Field<string>(2);

                    LC.Add(C);
                }

                List<Materia> LM = new List<Materia>();
                DataTable DT = DAL_Materia.Ver_Materias_Activas();

                foreach (DataRow DR in DT.Rows)
                {
                    Materia M = new Materia(DR.Field<int>(0), DR.Field<string>(1), DR.Field<int>(2), true, new Curso(0, "-"));

                    if ((!DR.IsNull("Mat_Cur_Codigo")))
                    {
                        M.AsignarCurso(LC.Find(X => X.Codigo == DR.Field<int>(4)));                   
                    }

                    LM.Add(M);
                }

                return LM;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public List<Materia> Ver_Materias_Inactivas()
        {
            try
            {
                DataTable DTCursosMateriasActivas = DAL_Curso.Obtener_Cursos_de_Materias_Inactivas();
                List<Curso> LC = new List<Curso>();

                foreach (DataRow DR in DTCursosMateriasActivas.Rows)
                {
                    Curso C = new Curso();
                    C.Codigo = DR.Field<int>(0);
                    C.Nombre = DR.Field<string>(1);
                    C.Turno.Nombre = DR.Field<string>(2);

                    LC.Add(C);
                }

                List<Materia> LM = new List<Materia>();
                DataTable DT = DAL_Materia.Ver_Materias_Inactivas();

                foreach (DataRow DR in DT.Rows)
                {
                    Materia M = new Materia(DR.Field<int>(0), DR.Field<string>(1), DR.Field<int>(2), true, new Curso(0, "-"));

                    if ((!DR.IsNull("Mat_Cur_Codigo")))
                    {
                        M.AsignarCurso(LC.Find(X => X.Codigo == DR.Field<int>(4)));
                    }

                    LM.Add(M);
                }

                return LM;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Materia> Ver_Materias_Activas_Sin_Curso()
        {
            try
            {
                List<Materia> LM = new List<Materia>();
                DataTable DT = DAL_Materia.Ver_Materias_Activas_Sin_Curso();

                foreach (DataRow DR in DT.Rows)
                {
                    LM.Add(new Materia(DR.Field<int>(0), DR.Field<string>(1), DR.Field<int>(2), true));
                }

                return LM;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void Agregar_Tema_A_Materia(Materia pMateria, Tema pTema)
        {
            try
            {
                DAL_Materia.Agregar_Tema_A_Materia(pMateria, pTema);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Quitar_Tema_De_Materia(Materia pMateria, Tema pTema)
        {
            try
            {
                DAL_Materia.Quitar_Tema_De_Materia(pMateria, pTema);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Dar_De_Baja_Materia(Materia pMateria)
        {
            try
            {
                DAL_Materia.Dar_De_Baja_Materia(pMateria);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Modificar_Materia(Materia pMateria)
        {
            try
            {
                DAL_Materia.Modificar_Materia(pMateria);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Materia Obtener_Materia_de_Dictado(Dictado pDictado)
        {
            try
            {
                DataTable DT = DAL_Materia.Obtener_Materia_de_Dictado(pDictado);

                Materia Materia = new Materia(DT.Rows[0].Field<int>(0), DT.Rows[0].Field<string>(1), DT.Rows[0].Field<int>(2), DT.Rows[0].Field<bool>(3));

                return Materia;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Dar_De_Baja_Materias_de_Curso(List<Dictado> pLD)
        {
            try
            {
                DAL_Materia.Dar_De_Baja_Materias_de_Curso(pLD);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public bool Verificar_Evaluaciones_Materia(Materia pMateria)
        {
            try
            {
                return DAL_Materia.Verificar_Evaluaciones_Materia(pMateria);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Materia> Ver_Materias_Activas_Con_Curso()
        {
            try
            {
                List<Materia> LM = new List<Materia>();
                DataTable DT = DAL_Materia.Ver_Materias_Activas_Con_Curso();

                foreach (DataRow DR in DT.Rows)
                {
                    Curso C = new Curso(DR.Field<int>(4), DR.Field<string>(5));
                    Materia M = new Materia(DR.Field<int>(0), DR.Field<string>(1), DR.Field<int>(2), true, C);

                    LM.Add(M);
                }

                return LM;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Materia> Ver_Materias_Inactivas_Con_Curso()
        {
            try
            {
                List<Materia> LM = new List<Materia>();
                DataTable DT = DAL_Materia.Ver_Materias_Inactivas_Con_Curso();

                foreach (DataRow DR in DT.Rows)
                {
                    Curso C = new Curso(DR.Field<int>(4), DR.Field<string>(5));
                    Materia M = new Materia(DR.Field<int>(0), DR.Field<string>(1), DR.Field<int>(2), false, C);

                    LM.Add(M);
                }

                return LM;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }


    }
}
