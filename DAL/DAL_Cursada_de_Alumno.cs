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
    public class DAL_Cursada_de_Alumno : SQLKit
    {
        public DAL_Cursada_de_Alumno() : base()
        {

        }
        public void Agregar_Cursada(Cursada_de_Alumno pCursada)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "INSERT INTO Cursada_de_Alumno(CurAlu_Alu_Legajo, CurAlu_Cur_Codigo, CurAlu_Libre) VALUES (@pAluID, @pCurID, 0)";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pAluID", pCursada.Alumno.Legajo);
                Comando.Parameters.AddWithValue("pCurID", pCursada.Curso.Codigo);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public bool Verficar_Existencia_Cursada(Alumno pAlumno, Curso pCurso)
        {
            try
            {
                bool B = false;

                Conectarse();

                Comando.CommandText = "SELECT COUNT (CurAlu_Codigo) FROM Cursada_de_Alumno WHERE CurAlu_Alu_Legajo = @pAluID AND CurAlu_Cur_Codigo = @pCurID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pAluID", pAlumno.Legajo);
                Comando.Parameters.AddWithValue("pCurID", pCurso.Codigo);

                int Cant = (int)Comando.ExecuteScalar();

                if (Cant>0)
                {
                    B = true;
                }

                Comando.ExecuteNonQuery();

                Desconectarse();

                return B;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Verficar_Cursadas_de_Alumno(Alumno pAlumno)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT CurAlu_Codigo, Cur_Codigo, Cur_Nombre, Cur_Ano, Tur_Nombre, Cur_Activo, CurAlu_Libre FROM Alumno, Curso, Cursada_de_Alumno, Turno WHERE Alu_Legajo = CurAlu_Alu_Legajo AND Cur_Codigo = CurAlu_Cur_Codigo AND Alu_Legajo = @pAluID AND Cur_Tur_Codigo = Tur_Codigo";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pAluID", pAlumno.Legajo);

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Buscar_Cursada_de_Alumno(Alumno pAlumno, Curso pCurso)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT CurAlu_Codigo, CurAlu_Libre FROM Cursada_de_Alumno, Curso, Alumno WHERE Alu_Legajo = CurAlu_Alu_Legajo AND CurAlu_Alu_Legajo = @pAluID AND Cur_Codigo = CurAlu_Cur_Codigo AND CurAlu_Cur_Codigo = @pCurID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pAluID", pAlumno.Legajo);
                Comando.Parameters.AddWithValue("pCurID", pCurso.Codigo);

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Modificar_Estado_de_Cursada(Cursada_de_Alumno pCursada, bool pEstado)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Cursada_de_Alumno SET CurAlu_Libre = @pEstado WHERE CurAlu_Codigo = @pCurID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pCurID", pCursada.Codigo);
                Comando.Parameters.AddWithValue("pEstado", pEstado);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public int ObtenerPromedioDeCursada(Cursada_de_Alumno pCursada)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT COALESCE(AVG(EvaAlu_Calificacion), 0) FROM Evaluacion_de_Alumno WHERE EvaAlu_CurAlu_Codigo = @pCurID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pCurID", pCursada.Codigo);

                int Promedio = (int)Comando.ExecuteScalar();

                Desconectarse();

                return Promedio;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }



    }
}

