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
    public class DAL_Encuesta_de_Alumno : SQLKit
    {
        public DAL_Encuesta_de_Alumno() : base()
        {

        }
        public void Enviar_Encuesta_a_Curso(List<Alumno> pAlumnos, int pID)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "INSERT INTO Encuesta_de_Alumno(EncAlu_Enc_Codigo, EncAlu_Alu_Legajo, EncAlu_Activo) VALUES (@pEncID, @pAluID, 1)";

                foreach (Alumno Alumno in pAlumnos)
                {
                    Comando.Parameters.Clear();
                    Comando.Parameters.AddWithValue("pEncID", pID);
                    Comando.Parameters.AddWithValue("pAluID", Alumno.Legajo);
                    Comando.ExecuteNonQuery();
                }

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Encuestas_Alummo(string pID)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Enc_Codigo, Enc_Fecha_Creacion FROM Encuesta, Encuesta_de_Alumno WHERE EncAlu_Enc_Codigo = Enc_Codigo AND EncAlu_Alu_Legajo = @pID AND Enc_Activo = 1 AND EncAlu_Activo = 1";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pID);

                DataTable DT = new DataTable();
                SqlDataReader DR = Comando.ExecuteReader();
                DT.Load(DR);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Estado_Resolucion_Alumnos(int pID)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Alu_Legajo, EncAlu_Activo FROM Alumno, Encuesta_de_Alumno, Encuesta WHERE Enc_Codigo = EncAlu_Enc_Codigo AND Enc_Codigo = @pID AND Alu_Legajo = EncAlu_Alu_Legajo";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pID);

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
