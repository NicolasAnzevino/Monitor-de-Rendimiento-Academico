using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace Servicios
{
    public class LogManager
    {
        public static void Escribir(int pIDUsuario, string pDescripcion, int pValoracion)
        {
            try
            {
                DAL_Log ABD_Log = new DAL_Log();
                ABD_Log.Escribir(pIDUsuario, pDescripcion, DateTime.Now, pValoracion);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public static DataTable Ver_Logs()
        {
            try
            {
                DAL_Log ABD_Log = new DAL_Log();
                return ABD_Log.Ver_Logs();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public static DataTable Ver_Logs_Fecha(DateTime pFecha)
        {
            try
            {
                DAL_Log ABD_Log = new DAL_Log();
                return ABD_Log.Ver_Logs_Fecha(pFecha);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
