using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace Entidades
{
    public class Usuario
    {
        public Usuario() { }

        public Usuario(string pNombre)
        {
            Nombre = pNombre;
        }

        public Usuario(int pID, string pNombre, string pContraseña)
        {
            ID = pID;
            Nombre = pNombre;
            Contraseña = pContraseña;
        }
        public Usuario(int pID, string pNombre)
        {
            ID = pID;
            Nombre = pNombre;
        }


        public Usuario(string pNombre, string pContraseña) //Constructor para registrar usuario!
        {
            Nombre = pNombre;
            Contraseña = pContraseña;
        }

        public Usuario(object[] pO)
        {
            ID = (int)pO[0];
            Nombre = (string)pO[1];
            Contraseña = (string)pO[2];
            DadoDeBaja = (bool)pO[6]; //Por si las dudas
        }

        public Usuario(int pID, string pNombre, int pDNI, string pApellido, string pNombreReal)
        {
            ID = pID;
            Nombre = pNombre;
            DNI = pDNI;
            Apellido = pApellido;
            NombreReal = pNombreReal;
        }
        
        public int ID { get; set; }
        public string Nombre { get; set; }
        [ScriptIgnore]
        public string Contraseña { get; set; }
        [ScriptIgnore]
        public Rol Rol { get; set; }

        public string NombreReal;
        public string Apellido;
        public int DNI;
        [ScriptIgnore]
        public bool DadoDeBaja;
    }
}
