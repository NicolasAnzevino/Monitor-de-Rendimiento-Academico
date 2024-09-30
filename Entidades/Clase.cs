using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Clase
    {
        public Clase()
        {
            
        }
        public Clase(int pCodigo, string pDescripcion, DateTime pFecha, Dictado pDictado, List<Tema> pTemas)
        {
            Codigo = pCodigo;
            Descripcion = pDescripcion;
            Fecha = pFecha;
            Dictado = pDictado;
            Temas = pTemas;
        }
        public Clase(string pDescripcion, DateTime pFecha, Dictado pDictado, List<Tema> pTemas)
        {
            Descripcion = pDescripcion;
            Fecha = pFecha;
            Dictado = pDictado;
            Temas = pTemas;
        }

        public Clase(int pCodigo, string pDescripcion, DateTime pFecha, List<Tema> pTemas)
        {
            Codigo = pCodigo;
            Descripcion = pDescripcion;
            Fecha = pFecha;
            Temas = pTemas;
        }
        public Clase(int pCodigo, string pDescripcion, DateTime pFecha)
        {
            Codigo = pCodigo;
            Descripcion = pDescripcion;
            Fecha = pFecha;

            Temas = new List<Tema>();
        }


        public int Codigo { get; set; }
        public string Descripcion { get; set; }
        public DateTime Fecha { get; set; }
        public Dictado Dictado { get; set; }
        public List<Tema> Temas;

    }
}
