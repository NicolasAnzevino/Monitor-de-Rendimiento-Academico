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
    public class MAP_Tema
    {
        DAL_Tema DAL_Tema;
        public MAP_Tema()
        {
            DAL_Tema = new DAL_Tema();
        }

        public List<Tema> Ver_Temas()
        {
            try
            {
                List<Tema> LT = new List<Tema>();
                DataTable DT = DAL_Tema.Ver_Temas();

                foreach (DataRow DR in DT.Rows)
                {
                    LT.Add(new Tema(DR.Field<int>(0), DR.Field<string>(1), DR.Field<string>(2)));
                }

                return LT;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public List<Tema> Ver_Temas_De_Materia(Materia pMateria)
        {
            try
            {
                List<Tema> LT = new List<Tema>();
                DataTable DT = DAL_Tema.Ver_Temas_De_Materia(pMateria);

                foreach (DataRow DR in DT.Rows)
                {
                    LT.Add(new Tema(DR.Field<int>(0), DR.Field<string>(1), DR.Field<string>(2)));
                }

                return LT;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Agregar_Tema(Tema pTema)
        {
            try
            {
                DAL_Tema.Agregar_Tema(pTema);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public int Comprobar_Unicidad_Nombre(string pNombre)
        {
            try
            {
                return DAL_Tema.Comprobar_Unicidad_Nombre(pNombre);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Modificar_Tema(Tema pTema)
        {
            try
            {
                DAL_Tema.Modificar_Tema(pTema);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Tema> Ver_Temas_de_Evaluacion(Evaluacion pEvaluacion)
        {
            try
            {
                DataTable DT = DAL_Tema.Ver_Temas_de_Evaluacion(pEvaluacion);
                List<Tema> LT = new List<Tema>();

                foreach (DataRow DR in DT.Rows)
                {
                    LT.Add(new Tema(DR.Field<int>(0), DR.Field<string>(1)));
                }

                return LT;

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public int Comprobar_Existencia_Clases(Tema pTema)
        {
            try
            {
                return DAL_Tema.Comprobar_Existencia_Clases(pTema);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public int Comprobar_Existencia_Evaluaciones(Tema pTema)
        {
            try
            {
                return DAL_Tema.Comprobar_Existencia_Evaluaciones(pTema);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
