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
    public class DAL_Queja : SQLKit
    {
        public DAL_Queja() : base()
        {

        }

        public void Crear_Queja(Queja pQueja)
        {
            try
            {
                Conectarse();
                
                Comando.CommandText = "INSERT INTO Queja(Queja_Asunto, Queja_Descripcion, Queja_Fecha ,Queja_Activo, Queja_User_Codigo) VALUES (@pAsunto, @pDesc, @pFecha ,1, @pIDUsuario)";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pAsunto", pQueja.Asunto);
                Comando.Parameters.AddWithValue("pDesc", pQueja.Descripcion);
                Comando.Parameters.AddWithValue("pFecha", pQueja.Fecha);
                Comando.Parameters.AddWithValue("pIDUsuario", pQueja.Retornar_IDUsuario());

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) {Desconectarse(); throw new Exception(ex.Message); }
        }

        public void Actualizar_Estado_Queja(int pID)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Queja SET Queja_Activo = 0 WHERE Queja_Codigo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pID);
                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public DataTable Ver_Quejas_Activas()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Queja_Codigo, Queja_Asunto, Queja_Descripcion, Queja_Fecha, User_Codigo, User_Nombre, User_Nombre_Real, User_Apellido, User_DNI FROM Queja, Usuario WHERE Queja_User_Codigo = User_Codigo AND Queja_Activo = 1 ORDER BY Queja_Codigo DESC";

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public DataTable Ver_Quejas_Usuario(int pID)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT DISTINCT Queja_Codigo, Queja_Asunto, Queja_Descripcion, Queja_Fecha, Queja_Activo FROM Queja, Usuario WHERE Queja_User_Codigo = @pID ORDER BY Queja_Codigo DESC";

                DataTable DT = new DataTable();

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pID);

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
    }
}
