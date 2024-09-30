using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Tema
    {
        public Tema()
        {

        }
        public Tema(int pCodigo, string pNombre, string pDescripcion)
        {
            Codigo = pCodigo;
            Nombre = pNombre;
            Descripcion = pDescripcion; 
        }
        public Tema(string pNombre, string pDescripcion)
        {
            Nombre = pNombre;
            Descripcion = pDescripcion;
        }
        public Tema(int pCodigo, string pNombre)
        {
            Codigo = pCodigo;
            Nombre = pNombre;            
        }

        public int Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }        
    }
}
