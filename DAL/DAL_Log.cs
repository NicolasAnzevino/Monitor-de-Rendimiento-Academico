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
    public class DAL_Log : SQLKit
    {
        public DAL_Log() : base()
        {

        }

        public void Escribir(int pIDUsuario, string pDescripcion, DateTime pDateTime, int pValoracion)
        {
            Conectarse();

            Comando.CommandText = "INSERT INTO Bitacora(Bita_Fecha, Bita_Descripcion, Bita_Nivel_Importancia, Bita_User_Codigo) VALUES (@pDateTime, @pDesc, @pNivelImportancia, @pUserID)";

            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("pDateTime", pDateTime);
            Comando.Parameters.AddWithValue("pDesc", pDescripcion);
            Comando.Parameters.AddWithValue("pNivelImportancia", pValoracion);
            Comando.Parameters.AddWithValue("pUserID", pIDUsuario);

            Comando.ExecuteNonQuery();

            Desconectarse();
        }

        public DataTable Ver_Logs()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT TOP 100 Bita_Codigo, Bita_Descripcion, Bita_Fecha, Bita_Nivel_Importancia, User_Nombre, User_DNI, User_Apellido, User_Nombre_Real FROM Bitacora, Usuario WHERE User_Codigo = Bita_User_Codigo ORDER BY Bita_Codigo DESC";

                DataTable DT = new DataTable();
                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Logs_Fecha(DateTime pFecha)
        {
            try
            {
                Conectarse();

                DateTime pFecha2 = new DateTime(pFecha.Year, pFecha.Month, pFecha.Day);

                TimeSpan TS = new TimeSpan(23, 59, 59);

                pFecha2 = pFecha2.Date + TS;

                Comando.CommandText = $"SELECT Bita_Codigo, Bita_Descripcion, Bita_Fecha, Bita_Nivel_Importancia, User_Nombre, User_DNI, User_Apellido, User_Nombre_Real FROM Bitacora, Usuario WHERE User_Codigo = Bita_User_Codigo AND Bita_Fecha BETWEEN '{pFecha}' AND '{pFecha2}' ORDER BY Bita_Codigo DESC";

                DataTable DT = new DataTable();

                Comando.Parameters.Clear();
                //Comando.Parameters.AddWithValue("pFecha", pFecha);

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
    }
}
