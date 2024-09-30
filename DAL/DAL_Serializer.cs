using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Entidades;

namespace DAL
{
    public class DAL_Serializer : SQLKit
    {
        public DAL_Serializer() : base()
        {

        }

        public void GuardarModificacionUsuario(string pUsuarioSinModificar, string pUsuarioModificado, Usuario pUsuarioResponsable)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "INSERT INTO Usuario_Serializado(UserSer_Usuario_Sin_Modificar, UserSer_Usuario_Modificado, UserSer_Usuario_Responsable) VALUES (@pUSinMod, @pUMod, @pResp)";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pUSinMod", pUsuarioSinModificar);
                Comando.Parameters.AddWithValue("pUMod", pUsuarioModificado);
                Comando.Parameters.AddWithValue("pResp", "Código: " + pUsuarioResponsable.ID + " - Nombre: " + pUsuarioResponsable.Nombre + " - Rol: " + pUsuarioResponsable.Rol.Nombre + " - Fecha: " + DateTime.Today.Date.ToString("d/M/yyyy"));

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public DataTable ObtenerUsuariosSerializados()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT TOP 1000 UserSer_Usuario_Sin_Modificar, UserSer_Usuario_Modificado, UserSer_Usuario_Responsable FROM Usuario_Serializado";
                
                DataTable DT = new DataTable();
                SqlDataReader DR = Comando.ExecuteReader();
                DT.Load(DR);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
    }
}
