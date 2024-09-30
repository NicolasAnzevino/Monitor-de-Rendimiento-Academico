using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Web.Script.Serialization;
using System.Threading.Tasks;
using Entidades;
using DAL;

namespace Servicios
{
    public class SerializerManager
    {
        public static void GuardarModificacionUsuario(Usuario pUsuario, string pNombre, string pApellido, int pDNI, Rol pRol, Usuario pUResponsable)
        {
            DAL_Serializer DAL_Serializer = new DAL_Serializer();
            string UsuarioSinModificar = SerializarAJSON<Usuario>(pUsuario);
            Usuario UsuarioAdicional = new Usuario(pUsuario.ID, pUsuario.Nombre, pDNI, pApellido, pNombre);
            UsuarioAdicional.Rol = pRol;
            string UsuarioModificado = SerializarAJSON<Usuario>(UsuarioAdicional);

            DAL_Serializer.GuardarModificacionUsuario(UsuarioSinModificar, UsuarioModificado, pUResponsable);
        }

        public static string SerializarAJSON<T>(T pValor)
        {
            JavaScriptSerializer JSS = new JavaScriptSerializer();
            string Valor = JSS.Serialize(pValor);

            return Valor;
        }
        public static T DeserializarAJSON<T>(T pObject, string pTexto)
        {
            JavaScriptSerializer JSS = new JavaScriptSerializer();
            pObject = JSS.Deserialize<T>(pTexto);
            return pObject;
        }

        public static string Ver_Usuarios_Serializados()
        {
            try
            {
                DAL_Serializer DAL_Serializer = new DAL_Serializer();
                string Informe = "";
                Usuario U1 = new Usuario();
                Usuario U2 = new Usuario();

                DataTable DT = DAL_Serializer.ObtenerUsuariosSerializados();

                foreach (DataRow DR in DT.Rows)
                {
                    Informe += "———————————————————————————————————————————————————————————————————————————" + "\r\n";
                    U1 = DeserializarAJSON<Usuario>(U1, DR.Field<string>(0));
                    Informe += "Usuario antes de ser modificado: " + "DNI: " + U1.DNI.ToString() + " - Nombre Real: " + U1.NombreReal + " - Apellido: " + U1.Apellido + "\r\n";
                    U2 = DeserializarAJSON<Usuario>(U2, DR.Field<string>(1));
                    Informe += "Usuario luego de ser modificado: " + "DNI: " + U2.DNI.ToString() + " - Nombre Real: " + U2.NombreReal + " - Apellido: " + U2.Apellido + "\r\n";
                    Informe += "Usuario Responsable: " + DR.Field<string>(2) + "\r\n";
                    Informe += "———————————————————————————————————————————————————————————————————————————" + "\r\n";
                }

                return Informe;                
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }


    }
}
