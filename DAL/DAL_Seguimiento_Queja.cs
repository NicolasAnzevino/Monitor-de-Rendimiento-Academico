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
    public class DAL_Seguimiento_Queja : SQLKit
    {
        public DAL_Seguimiento_Queja() : base()
        {

        }

        public DataTable Ver_Seguimiento_de_Queja(int pID)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Seg_Estado, Seg_Fecha FROM Seguimiento_Queja, Queja WHERE Seg_Queja_Codigo = @pIDQueja";

                Comando.Parameters.Clear();        
                Comando.Parameters.AddWithValue("pIDQueja", pID);

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Agregar_Seguimiento(int pID, Seguimiento_Queja pSQ)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "INSERT INTO Seguimiento_Queja(Seg_Estado, Seg_Fecha, Seg_Queja_Codigo) VALUES(@pEstado, @pFecha, @pIDQueja)";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pEstado", pSQ.Estado);
                Comando.Parameters.AddWithValue("pFecha", pSQ.Fecha);
                Comando.Parameters.AddWithValue("pIDQueja", pID);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
    }
}
