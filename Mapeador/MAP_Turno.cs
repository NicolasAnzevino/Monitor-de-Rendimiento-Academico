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
    public class MAP_Turno
    {
        DAL_Turno DAL_Turno;
        public MAP_Turno()
        {
            DAL_Turno = new DAL_Turno();
        }
        public List<Turno> Ver_Turnos()
        {
            try
            {
                List<Turno> LT = new List<Turno>();
                DataTable DT = DAL_Turno.Ver_Turnos();

                foreach (DataRow DR in DT.Rows)
                {
                    LT.Add(new Turno(DR.Field<int>(0), DR.Field<string>(1)));
                }

                return LT;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public int Comprobar_Unicidad_Turno(string pNombre)
        {
            try
            {
                return DAL_Turno.Comprobar_Unicidad_Turno(pNombre);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Agregar_Turno(Turno pTurno)
        {
            try
            {
                DAL_Turno.Agregar_Turno(pTurno);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

    }
}
