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
    public class DAL_Respuesta_de_Encuesta : SQLKit
    {
        public DAL_Respuesta_de_Encuesta() : base()
        {

        }
        public void Enviar_Respuestas_de_Encuesta(Dictionary<int, Respuesta_de_Encuesta> pDiccionario, Alumno pAlumno, Encuesta pEncuesta)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "INSERT INTO Respuesta_de_Encuesta (Res_Puntaje, Res_Descripcion, Res_Pre_Codigo, Res_Alu_Legajo) VALUES (@pPuntaje, @pDesc, @pPregID, @pAluID)";

                foreach (KeyValuePair<int, Respuesta_de_Encuesta> RE in pDiccionario)
                {
                    Comando.Parameters.Clear();
                    Comando.Parameters.AddWithValue("pPuntaje", RE.Value.Respuesta);
                    Comando.Parameters.AddWithValue("pDesc", RE.Value.Descripcion);
                    Comando.Parameters.AddWithValue("pPregID", RE.Key);
                    Comando.Parameters.AddWithValue("pAluID", pAlumno.Legajo);
                    Comando.ExecuteNonQuery();
                }

                Comando.CommandText = "UPDATE Encuesta_de_Alumno SET EncAlu_Activo = 0 WHERE EncAlu_Enc_Codigo = @pEncID AND EncAlu_Alu_Legajo = @pAluID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pEncID", pEncuesta.Codigo);
                Comando.Parameters.AddWithValue("pAluID", pAlumno.Legajo);
                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
    }
}
