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
    public class MAP_Encuesta
    {
        DAL_Encuesta DAL_Encuesta;
        public MAP_Encuesta()
        {
            DAL_Encuesta = new DAL_Encuesta();
        }
        public int Crear_Encuesta(Encuesta pEncuesta, Curso pCurso)
        {
            try
            {
                int ID = DAL_Encuesta.Crear_Encuesta(pEncuesta, pCurso);

                DAL_Encuesta.Establecer_Preguntas_de_Encuesta(pEncuesta, ID);

                return ID;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Encuesta> Ver_Encuestas_de_Curso(Curso pCurso)
        {
            try
            {
                DataTable DT = DAL_Encuesta.Ver_Encuestas_de_Curso(pCurso);
                List<Encuesta> LE = new List<Encuesta>();

                foreach (DataRow DR in DT.Rows)
                {
                    LE.Add(new Encuesta(DR.Field<int>(0), true, DR.Field<DateTime>(1)));
                }

                return LE;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Dar_de_Baja_Encuesta(Encuesta pEncuesta)
        {
            try
            {
                DAL_Encuesta.Dar_de_Baja_Encuesta(pEncuesta);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}

