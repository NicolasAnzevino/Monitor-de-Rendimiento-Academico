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
    public class SessionManager
    {
        private SessionManager() // A BORRAR DESPUES!!!
        {
            
        }

        private SessionManager(int pLangID) // A BORRAR DESPUES!!!
        {
            Idioma = pLangID;
        }

        private SessionManager(object[] pO)
        {
            Idioma = (int)pO[4];    
        }

        public Usuario User { get; set; }
        public int Idioma { get; set; }

        private static SessionManager _Instance;
        private static Dictionary<int, SessionManager> _Instances = new Dictionary<int, SessionManager>(); //Singleton con diccionario (MULTITON PA LOS AMIGOS)


        public static SessionManager getInstance(int pKey) //getInstance con BD (El bueno :D)
        {
            if (!_Instances.ContainsKey(pKey))
            {
                _Instances.Add(pKey, new SessionManager(TranslatorManager.ObtenerIdiomaDeUsuario(pKey)));
            }

            return _Instances[pKey];
        }


    }
}
