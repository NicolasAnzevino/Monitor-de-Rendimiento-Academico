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
    public class DAL_Encuesta : SQLKit
    {
        public DAL_Encuesta() : base()
        {

        }
        public int Crear_Encuesta(Encuesta pEncuesta, Curso pCurso)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "INSERT INTO Encuesta (Enc_Fecha_Creacion, Enc_Activo, Enc_Cur_Codigo) VALUES (@pFecha, @pActivo, @pCurID)";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pFecha", pEncuesta.Fecha_Creacion);
                Comando.Parameters.AddWithValue("pActivo", pEncuesta.Retornar_Activo());
                Comando.Parameters.AddWithValue("@pCurID", pCurso.Codigo);

                Comando.ExecuteNonQuery();

                Comando.CommandText = "SELECT MAX(Enc_Codigo) FROM Encuesta";
                int ID = (int)Comando.ExecuteScalar();

                Comando.ExecuteNonQuery();

                Desconectarse();

                return ID;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Establecer_Preguntas_de_Encuesta(Encuesta pEncuesta, int pID)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "INSERT INTO Pregunta_de_Encuesta (Pre_Pregunta, Pre_Enc_Codigo) VALUES (@pPregunta, @pID)";

                foreach (Pregunta_de_Encuesta Pregunta in pEncuesta.VerPreguntas())
                {
                    Comando.Parameters.Clear();
                    Comando.Parameters.AddWithValue("pPregunta", Pregunta.Pregunta);
                    Comando.Parameters.AddWithValue("pID", pID);
                    Comando.ExecuteNonQuery();
                }               

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Encuestas_de_Curso(Curso pCurso)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Enc_Codigo, Enc_Fecha_Creacion FROM Encuesta WHERE Enc_Activo = 1 AND Enc_Cur_Codigo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pCurso.Codigo);

                DataTable DT = new DataTable();
                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Dar_de_Baja_Encuesta(Encuesta pEncuesta)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Encuesta SET Enc_Activo = 0 WHERE Enc_Codigo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pEncuesta.Codigo);
                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }       
    }
}
