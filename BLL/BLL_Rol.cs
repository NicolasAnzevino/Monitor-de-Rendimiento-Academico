using System;
using System.Collections.Generic;
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
    public class BLL_Rol
    {
        MAP_Rol MAP_Rol;

        public BLL_Rol()
        {
            MAP_Rol = new MAP_Rol();
        }
        public List<Rol> Ver_Roles()
        {
            return MAP_Rol.Ver_Roles();
        }
        public Rol Buscar_Rol(int pID)
        {
            return MAP_Rol.Buscar_Rol(pID);
        }

        public List<Permiso> Ver_Permisos()
        {
            return MAP_Rol.Ver_Permisos();
        }
        public List<Permiso> Ver_Permisos_New()
        {
            return MAP_Rol.Ver_Permisos_New();
        }


        public bool Verificar_Nombre(string pNombre)
        {
            try
            {
                return MAP_Rol.Verificar_Nombre(pNombre);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Agregar_Rol(string pNombre, List<Permiso> pLP)
        {
            try
            {
                MAP_Rol.Agregar_Rol(pNombre, pLP);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Rol> Ver_Roles_Con_Permisos()
        {
            List<Rol> Roles = MAP_Rol.Ver_Roles();

            foreach (Rol R in Roles)
            {
                MAP_Rol.AsignarPermisos(R);
            }

            return Roles;
        }

    }
}
