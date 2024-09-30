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
    public class DAL_Turno : SQLKit
    {
        public DAL_Turno() : base()
        {

        }
        public DataTable Ver_Turnos()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Tur_Codigo, Tur_Nombre FROM Turno";
                Comando.Parameters.Clear();

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public int Comprobar_Unicidad_Turno(string pNombre)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT COUNT(Tur_Codigo) FROM Turno WHERE Tur_Nombre = @pNombre";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pNombre", pNombre);

                int Existen = (int)Comando.ExecuteScalar();

                Desconectarse();

                return Existen;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Agregar_Turno(Turno pTurno)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "INSERT INTO Turno(Tur_Nombre) VALUES (@pTurNombre)";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pTurNombre", pTurno.Nombre);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

    }
}
