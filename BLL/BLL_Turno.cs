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
    public class BLL_Turno
    {
        MAP_Turno MAP_Turno;
        public BLL_Turno()
        {
            MAP_Turno = new MAP_Turno();
        }
        public List<Turno> Ver_Turnos()
        {
            try
            {
                return MAP_Turno.Ver_Turnos();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public int Comprobar_Unicidad_Turno(string pNombre)
        {
            try
            {
                return MAP_Turno.Comprobar_Unicidad_Turno(pNombre);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Agregar_Turno(string pNombre)
        {
            try
            {
                Turno T = new Turno(pNombre);
                MAP_Turno.Agregar_Turno(T);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
