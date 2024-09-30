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
    public class DAL_Evaluacion : SQLKit
    {
        public DAL_Evaluacion() : base()
        {

        }

        public DataTable Ver_Evaluaciones_de_Materia(Materia pMateria)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Eva_Codigo, Eva_Titulo, Eva_Fecha, Eva_Mat_Codigo FROM Evaluacion, Materia WHERE Mat_Codigo = Eva_Mat_Codigo AND Mat_Codigo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pMateria.Codigo);

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public int Crear_Evaluacion_de_Materia(Evaluacion pEvaluacion)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "INSERT INTO Evaluacion(Eva_Titulo, Eva_Fecha, Eva_Mat_Codigo) VALUES (@pTitulo, @pFecha, @pMatID)";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pTitulo", pEvaluacion.Titulo);
                Comando.Parameters.AddWithValue("pFecha", pEvaluacion.Fecha);
                Comando.Parameters.AddWithValue("pMatID", pEvaluacion.Materia.Codigo);

                Comando.ExecuteNonQuery();

                Comando.CommandText = "SELECT MAX(Eva_Codigo) FROM Evaluacion";
                int ID = (int)Comando.ExecuteScalar();

                Comando.ExecuteNonQuery();

                Desconectarse();

                return ID;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        //arreglar
        public void Establecer_Temas_de_Evalaucion(List<Tema> pTemas, int pIDEvaluacion)
        {
            try
            {
                Conectarse();

                
                //Comando.CommandText = "INSERT INTO EvaluacionTema(EvaTem_Eva_Codigo, EvaTem_Tem_Codigo) VALUES (@pEvaID, @pTemID)";

                Comando.CommandText = "INSERT INTO EvaluacionTema(EvaTem_Eva_Codigo, EvaTem_Tem_Codigo) VALUES";

                foreach (Tema T in pTemas)
                {
                    Comando.Parameters.Clear();
                    Comando.CommandText += " (@pEvaID, @pTemID),";
                    Comando.Parameters.AddWithValue("pEvaID", pIDEvaluacion);
                    Comando.Parameters.AddWithValue("pTemID", T.Codigo);
                }

                Comando.CommandText = Comando.CommandText.Substring(0, Comando.CommandText.Length - 1);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Establecer_Temas_de_Evaluacion(Tema pTema, int pIDEvaluacion)
        {
            try
            {
                Conectarse();               

                Comando.CommandText = "INSERT INTO EvaluacionTema(EvaTem_Eva_Codigo, EvaTem_Tem_Codigo) VALUES (@pEvaID, @pTemID)";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pEvaID", pIDEvaluacion);
                Comando.Parameters.AddWithValue("pTemID", pTema.Codigo);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Modificar_Evaluacion(Evaluacion pEvaluacion)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Evaluacion SET Eva_Fecha = @pFecha, Eva_Titulo = @pTitulo WHERE Eva_Codigo = @pID";                

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pFecha", pEvaluacion.Fecha);
                Comando.Parameters.AddWithValue("pTitulo", pEvaluacion.Titulo);
                Comando.Parameters.AddWithValue("pID", pEvaluacion.Codigo);

                Comando.ExecuteNonQuery();

                Comando.CommandText = "DELETE EvaluacionTema WHERE EvaTem_Eva_Codigo = @pID";

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Borrar_Evaluacion(Evaluacion pEvaluacion)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "DELETE Evaluacion WHERE Eva_Codigo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pEvaluacion.Codigo);

                Comando.ExecuteNonQuery();

                Comando.CommandText = "DELETE EvaluacionTema WHERE EvaTem_Eva_Codigo = @pID";

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Obtener_Evaluaciones_Docente_Tema(Docente pDocente, Tema pTema)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT DISTINCT Eva_Codigo, Eva_Titulo, Eva_Fecha, Cur_Codigo, Cur_Nombre, Cur_Ano, Tur_Nombre, Mat_Codigo, Mat_Nombre FROM Evaluacion, Curso, Materia, EvaluacionTema, Tema, Docente, Evaluacion_de_Alumno, Turno WHERE Mat_Cur_Codigo = Cur_Codigo AND Eva_Mat_Codigo = Mat_Codigo AND Tem_Codigo = EvaTem_Tem_Codigo AND Eva_Codigo = EvaTem_Eva_Codigo AND EvaAlu_Doc_Legajo = Doc_Legajo AND EvaAlu_Eva_Codigo = Eva_Codigo AND Doc_Legajo = @pDocID AND Tem_Codigo = @pTemID AND Cur_Tur_Codigo = Tur_Codigo";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pDocID", pDocente.Legajo);
                Comando.Parameters.AddWithValue("pTemID", pTema.Codigo);

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
