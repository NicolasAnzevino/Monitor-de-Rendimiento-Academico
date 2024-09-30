using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Seguimiento_Queja
    {
        public Seguimiento_Queja()
        {

        }

        public Seguimiento_Queja(int pID, string pEstado, DateTime pFecha)
        {
            ID = pID;
            Estado = pEstado;
            Fecha = pFecha;
        }
        public Seguimiento_Queja(object[] pO)
        {
            ID = (int)pO[0];
            Estado = (string)pO[1];
            Fecha = (DateTime)pO[2];
        }
        public Seguimiento_Queja(string pEstado, DateTime pFecha)
        {
            Estado = pEstado;
            Fecha = pFecha;
        }

        public int ID { get; set; }
        public string Estado { get; set; }
        public DateTime Fecha { get; set; }
        
    }
}
