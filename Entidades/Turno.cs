using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Turno
    {
        public Turno()
        {

        }
        public Turno(int pID, string pNombre)
        {
            ID = pID;
            Nombre = pNombre;
        }
        public Turno(string pNombre)
        {
            Nombre = pNombre;
        }

        public int ID { get; set; }
        public string Nombre { get; set; }

        public override string ToString()
        {
            return this.Nombre;
        }
    }
}
