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
    public class DAL_Pregunta_de_Encuesta : SQLKit
    {
        public DAL_Pregunta_de_Encuesta() : base()
        {

        }
        public DataTable Ver_Preguntas_de_Encuesta(Encuesta pEncuesta)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Pre_Codigo, Pre_Pregunta FROM Pregunta_de_Encuesta WHERE Pre_Enc_Codigo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pEncuesta.Codigo);

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Preguntas_de_Encuesta_con_Respuesta(Encuesta pEncuesta, Alumno pAlumno)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Pre_Codigo, Pre_Pregunta, Res_Codigo, Res_Puntaje, Res_Descripcion, Res_Alu_Legajo FROM Pregunta_de_Encuesta, Respuesta_de_Encuesta WHERE Res_Pre_Codigo = Pre_Codigo AND Pre_Enc_Codigo = @pEncID AND Res_Alu_Legajo = @pAluID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pEncID", pEncuesta.Codigo);
                Comando.Parameters.AddWithValue("pAluID", pAlumno.Legajo);

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
    }
}
