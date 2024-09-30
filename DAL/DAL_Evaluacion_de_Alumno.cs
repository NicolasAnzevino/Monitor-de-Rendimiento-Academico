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
    public class DAL_Evaluacion_de_Alumno : SQLKit
    {
        public DAL_Evaluacion_de_Alumno() : base()
        {

        }

        public DataTable Retornar_Evaluaciones_de_Alumno()
        {
            try
            {
                Conectarse();

                DataTable DT = new DataTable();

                Comando.CommandText = "SELECT EvaAlu_Codigo, EvaAlu_Calificacion, EvaAlu_CurAlu_Codigo,	EvaAlu_Doc_Legajo,	EvaAlu_Eva_Codigo,	FORMAT(EvaAlu_Fecha,'dd/MM/yyyy') as EvaAlu_Fecha,	EvaAlu_DVH FROM Evaluacion_de_Alumno";

                SqlDataReader DR = Comando.ExecuteReader();
                DT.Load(DR);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public void Actualizar_Digito_Verificador_Vertical(string pDigitoVerificador)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Digito_Verificador_Vertical SET DVV_DIGITO_HASH = @pHash WHERE DVV_Nombre_Tabla = 'Evaluacion_de_Alumno'";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pHash", pDigitoVerificador);
                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public DataTable Retornar_DVV(string pNombreTabla)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT * FROM Digito_Verificador_Vertical WHERE DVV_Nombre_Tabla = @DVVName";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("@DVVName", pNombreTabla);

                DataTable DT = new DataTable();
                SqlDataReader DR = Comando.ExecuteReader();
                DT.Load(DR);

                if (DT.Rows.Count != 1) { DT = null; }

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public void Actualizar_Digito_Verificador_Horizontal(int pEvalID, string pDigitoVerificador)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Evaluacion_de_Alumno SET EvaAlu_DVH = @pHash WHERE EvaAlu_Codigo = @pCodigoUsuario";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pCodigoUsuario", pEvalID);
                Comando.Parameters.AddWithValue("pHash", pDigitoVerificador);
                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public int Obtener_Max_ID_EvaluacionAlu_Crear_EvaluacionAlu()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT MAX(EvaAlu_Codigo) FROM Evaluacion_de_Alumno";
                int ID = (int)Comando.ExecuteScalar();

                ID++;

                Desconectarse();

                return ID;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Agregar_Evaluacion_de_Alumno(DataRow pDR, DateTime pFecha)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "INSERT INTO Evaluacion_de_Alumno(EvaAlu_Codigo, EvaAlu_Calificacion, EvaAlu_CurAlu_Codigo, EvaAlu_Doc_Legajo, EvaAlu_Eva_Codigo, EvaAlu_Fecha, EvaAlu_DVH) VALUES (@pEvaAluID, @pCalif, @pCurID, @pDocID, @pEvaID, @pFecha ,@DVH)";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("@pEvaAluID", pDR.ItemArray[0]);
                Comando.Parameters.AddWithValue("@pCalif", pDR.ItemArray[1]);
                Comando.Parameters.AddWithValue("@pCurID", pDR.ItemArray[2]);
                Comando.Parameters.AddWithValue("@pDocID", pDR.ItemArray[3]);
                Comando.Parameters.AddWithValue("@pEvaID", pDR.ItemArray[4]);
                Comando.Parameters.AddWithValue("@pFecha", pFecha);
                Comando.Parameters.AddWithValue("@DVH", pDR.ItemArray[6]);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public bool Verificar_Existencia_Evaluaciones_Alumno(int pID)
        {
            try
            {
                Conectarse();

                bool B = false; //false no existe, true sí

                Comando.CommandText = "SELECT COUNT(EvaAlu_Codigo) FROM Evaluacion_de_Alumno WHERE EvaAlu_Eva_Codigo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("@pID", pID);

                int ID = (int)Comando.ExecuteScalar();

                if (ID > 0)
                {
                    B = true;
                }

                Desconectarse();

                return B;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Evaluaciones_de_Cursada(Cursada_de_Alumno pCursada)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT EvaAlu_Codigo, Eva_Codigo, EvaAlu_Fecha, EvaAlu_Calificacion, Mat_Nombre, Doc_Legajo, Doc_Apellido, Doc_Nombre, Mat_Codigo, Eva_Titulo FROM Evaluacion, Evaluacion_de_Alumno, Materia, Curso, Docente WHERE Mat_Cur_Codigo = Cur_Codigo AND Eva_Mat_Codigo = Mat_Codigo AND EvaAlu_Doc_Legajo = Doc_Legajo AND EvaAlu_Eva_Codigo = Eva_Codigo AND EvaAlu_CurAlu_Codigo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("@pID", pCursada.Codigo);

                DataTable DT = new DataTable();
                SqlDataReader DR = Comando.ExecuteReader();
                DT.Load(DR);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Evaluaciones_de_Cursada_de_Materia(Cursada_de_Alumno pCursada, Materia pMateria)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT EvaAlu_Codigo, Eva_Codigo, EvaAlu_Fecha, EvaAlu_Calificacion, Mat_Nombre, Doc_Legajo, Doc_Apellido, Doc_Nombre, Mat_Codigo, Eva_Titulo, Eva_Fecha FROM Evaluacion, Evaluacion_de_Alumno, Materia, Curso, Docente WHERE Mat_Cur_Codigo = Cur_Codigo AND Eva_Mat_Codigo = Mat_Codigo AND EvaAlu_Doc_Legajo = Doc_Legajo AND EvaAlu_Eva_Codigo = Eva_Codigo AND EvaAlu_CurAlu_Codigo = @pCurID AND Mat_Codigo = @pMatID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("@pCurID", pCursada.Codigo);
                Comando.Parameters.AddWithValue("@pMatID", pMateria.Codigo);

                DataTable DT = new DataTable();
                SqlDataReader DR = Comando.ExecuteReader();
                DT.Load(DR);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Eliminar_Evaluacion_de_Alumno(Evaluacion_de_Alumno pEvaAlu)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "DELETE Evaluacion_de_Alumno WHERE EvaAlu_Codigo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("@pID", pEvaAlu.Codigo);               

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Modificar_Evaluacion_de_Alumno(DataRow pDR, DateTime pFecha)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Evaluacion_de_Alumno SET EvaAlu_Calificacion = @pCalif, EvaAlu_CurAlu_Codigo = @pCurID, EvaAlu_Doc_Legajo = @pDocID, EvaAlu_Eva_Codigo = @pEvaID, EvaAlu_Fecha = @pFecha, EvaAlu_DVH = @DVH WHERE EvaAlu_Codigo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("@pID", pDR.ItemArray[0]);
                Comando.Parameters.AddWithValue("@pCalif", pDR.ItemArray[1]);
                Comando.Parameters.AddWithValue("@pCurID", pDR.ItemArray[2]);
                Comando.Parameters.AddWithValue("@pDocID", pDR.ItemArray[3]);
                Comando.Parameters.AddWithValue("@pEvaID", pDR.ItemArray[4]);
                Comando.Parameters.AddWithValue("@pFecha", pFecha);
                Comando.Parameters.AddWithValue("@DVH", pDR.ItemArray[6]);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Obtener_Eva_Alu(Evaluacion_de_Alumno pEvaAlu)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT EvaAlu_Codigo, EvaAlu_Calificacion, EvaAlu_CurAlu_Codigo, EvaAlu_Doc_Legajo, EvaAlu_Eva_Codigo, EvaAlu_Fecha FROM Evaluacion_de_Alumno WHERE EvaAlu_Codigo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("@pID", pEvaAlu.Codigo);

                DataTable DT = new DataTable();
                SqlDataReader DR = Comando.ExecuteReader();
                DT.Load(DR);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Obtener_Eva_Alu_Rendimiento(Cursada_de_Alumno pCursada)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Eva_Codigo ,EvaAlu_Codigo, Eva_Titulo, EvaAlu_Calificacion ,EvaAlu_Fecha, Mat_Codigo, Mat_Nombre, Doc_Legajo, Doc_Apellido, Doc_Nombre FROM Evaluacion, Evaluacion_de_Alumno, Materia, Docente, Cursada_de_Alumno WHERE CurAlu_Codigo = EvaAlu_CurAlu_Codigo AND Doc_Legajo = EvaAlu_Doc_Legajo AND Eva_Codigo = EvaAlu_Eva_Codigo AND Eva_Mat_Codigo = Mat_Codigo AND CurAlu_Codigo = @pID ORDER BY EvaAlu_Fecha";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("@pID", pCursada.Codigo);

                DataTable DT = new DataTable();
                SqlDataReader DR = Comando.ExecuteReader();
                DT.Load(DR);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Evaluaciones_de_Alumno_de_Materia(Materia pMateria)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT EvaAlu_Codigo, EvaAlu_Calificacion, EvaAlu_Eva_Codigo, EvaAlu_Fecha, Eva_Codigo, Eva_Titulo, Eva_Fecha, Doc_Legajo, Doc_Apellido, Doc_Nombre FROM Evaluacion_de_Alumno, Evaluacion, Docente, Materia WHERE EvaAlu_Doc_Legajo = Doc_Legajo AND EvaAlu_Eva_Codigo = Eva_Codigo AND Eva_Mat_Codigo = Mat_Codigo AND Mat_Codigo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("@pID", pMateria.Codigo);

                DataTable DT = new DataTable();
                SqlDataReader DR = Comando.ExecuteReader();
                DT.Load(DR);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public bool Verificar_Repeticion_Evaluacion(DateTime pFecha, Evaluacion pEvaluacion, Cursada_de_Alumno pCur)
        {
            try
            {
                Conectarse();

                bool Existe = false; //No hay -> false || Hay -> true

                Comando.CommandText = "SELECT COUNT(EvaAlu_Codigo) FROM Evaluacion_de_Alumno WHERE EvaAlu_Eva_Codigo = @pEvaID AND EvaAlu_CurAlu_Codigo = @pCurID AND EvaAlu_Fecha = @pFecha";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("@pEvaID", pEvaluacion.Codigo);
                Comando.Parameters.AddWithValue("@pCurID", pCur.Codigo);
                Comando.Parameters.AddWithValue("@pFecha", pFecha);

                int Cant = (int)Comando.ExecuteScalar();

                if (Cant>0)
                {
                    Existe = true;
                }

                Desconectarse();

                return Existe;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Obtener_Calificacciones_Docente_Tema(Docente pDocente, Evaluacion pEvaluacion)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT EvaAlu_Codigo, EvaAlu_Calificacion, EvaAlu_Fecha FROM Evaluacion_de_Alumno WHERE EvaAlu_Eva_Codigo = @pEvaID AND EvaAlu_Doc_Legajo = @pDocID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pDocID", pDocente.Legajo);
                Comando.Parameters.AddWithValue("pEvaID", pEvaluacion.Codigo);

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Obtener_Docente_Materia_Evaluacion_de_Curso_de_Materia(Curso pCurso, int pIDMateria)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Doc_Legajo, Doc_Apellido, Doc_Nombre AS Docente, CAST(Mat_Codigo as VARCHAR) AS Mat_Codigo, Mat_Nombre, EvaAlu_Calificacion, EvaAlu_Fecha FROM Docente, Materia, Evaluacion_de_Alumno, Evaluacion, Cursada_de_Alumno, Dictado, Curso WHERE EvaAlu_Doc_Legajo = Doc_Legajo AND Cur_Codigo = CurAlu_Cur_Codigo AND EvaAlu_CurAlu_Codigo = CurAlu_Codigo AND Eva_Mat_Codigo = Mat_Codigo AND Dic_Mat_Codigo = Mat_Codigo AND Dic_Cur_Codigo = Cur_Codigo AND EvaAlu_Eva_Codigo = Eva_Codigo AND Cur_Codigo = @pCurID AND Mat_Codigo = @pMatID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pCurID", pCurso.Codigo);
                Comando.Parameters.AddWithValue("pMatID", pIDMateria);

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Obtener_Materias_Evaluadas_Curso(Curso pCurso)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT DISTINCT Mat_Codigo FROM Docente, Materia, Evaluacion_de_Alumno, Evaluacion, Cursada_de_Alumno, Dictado, Curso WHERE EvaAlu_Doc_Legajo = Doc_Legajo AND Cur_Codigo = CurAlu_Cur_Codigo AND EvaAlu_CurAlu_Codigo = CurAlu_Codigo AND Eva_Mat_Codigo = Mat_Codigo AND Dic_Mat_Codigo = Mat_Codigo AND Dic_Cur_Codigo = Cur_Codigo AND EvaAlu_Eva_Codigo = Eva_Codigo AND Cur_Codigo = @pCurID";
                
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pCurID", pCurso.Codigo);
                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Obtener_Docentes_de_Evaluaciones_de_Materia_Curso(Curso pCurso, int pIDMateria)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT DISTINCT Doc_Legajo, Doc_DNI, Doc_Apellido, Doc_Nombre FROM Docente, Materia, Evaluacion_de_Alumno, Evaluacion, Cursada_de_Alumno, Dictado, Curso WHERE EvaAlu_Doc_Legajo = Doc_Legajo AND Cur_Codigo = CurAlu_Cur_Codigo AND EvaAlu_CurAlu_Codigo = CurAlu_Codigo AND Eva_Mat_Codigo = Mat_Codigo AND Dic_Mat_Codigo = Mat_Codigo AND Dic_Cur_Codigo = Cur_Codigo AND EvaAlu_Eva_Codigo = Eva_Codigo AND Cur_Codigo = @pCurID AND Mat_Codigo = @pMatID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pCurID", pCurso.Codigo);
                Comando.Parameters.AddWithValue("pMatID", pIDMateria);

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Obtener_Cursos_y_Materias_Evaluados_por_Docente(Docente pDocente)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT DISTINCT TOP 5 Cur_Codigo, Cur_Nombre, Cur_Ano, Tur_Nombre, Mat_Codigo, Mat_Nombre FROM Docente, Turno, Materia, Evaluacion_de_Alumno, Evaluacion, Cursada_de_Alumno, Dictado, Curso WHERE EvaAlu_Doc_Legajo = Doc_Legajo AND Cur_Codigo = CurAlu_Cur_Codigo AND EvaAlu_CurAlu_Codigo = CurAlu_Codigo AND Eva_Mat_Codigo = Mat_Codigo AND Dic_Mat_Codigo = Mat_Codigo AND Dic_Cur_Codigo = Cur_Codigo AND EvaAlu_Eva_Codigo = Eva_Codigo AND Tur_Codigo = Cur_Tur_Codigo AND Doc_Legajo = @pDocID ORDER BY Cur_Codigo DESC";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pDocID", pDocente.Legajo);
                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Obtener_Evaluaciones_de_Materia_Curso_Docente(Docente pDocente, Curso pCurso, Materia pMateria)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT EvaAlu_Calificacion, EvaAlu_Fecha FROM Docente, Materia, Evaluacion_de_Alumno, Evaluacion, Cursada_de_Alumno, Dictado, Curso WHERE EvaAlu_Doc_Legajo = Doc_Legajo AND Cur_Codigo = CurAlu_Cur_Codigo AND EvaAlu_CurAlu_Codigo = CurAlu_Codigo AND Eva_Mat_Codigo = Mat_Codigo AND Dic_Mat_Codigo = Mat_Codigo AND Dic_Cur_Codigo = Cur_Codigo AND EvaAlu_Eva_Codigo = Eva_Codigo AND Cur_Codigo = @pCurID AND Mat_Codigo = @pMatID AND EvaAlu_Doc_Legajo = @pDocID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pDocID", pDocente.Legajo);
                Comando.Parameters.AddWithValue("pCurID", pCurso.Codigo);
                Comando.Parameters.AddWithValue("pMatID", pMateria.Codigo);
                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public bool Verificar_Evaluacion_Tiene_Calificaciones(Evaluacion pEvaluacion)
        {
            try
            {
                Conectarse();

                bool Palanca = false; //true -> si hay, false -> no

                Comando.CommandText = "SELECT COUNT(EvaAlu_Codigo) FROM Evaluacion_de_Alumno WHERE EvaAlu_Eva_Codigo = @pEvaID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pEvaID", pEvaluacion.Codigo);

                if ((int)Comando.ExecuteScalar() > 0)
                {
                    Palanca = true;
                }

                Desconectarse();

                return Palanca;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Obtener_Calificaciones_de_Evaluacion(Evaluacion pEvaluacion)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT EvaAlu_Codigo, EvaAlu_Fecha, EvaAlu_Calificacion FROM Evaluacion_De_Alumno WHERE EvaAlu_Eva_Codigo = @pEvaID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pEvaID", pEvaluacion.Codigo);
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
