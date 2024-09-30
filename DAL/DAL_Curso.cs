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
    public class DAL_Curso : SQLKit
    {
        public DAL_Curso() : base()
        {

        }

        public int Comprobar_Unicidad_Nombre(string pNombre)
        {
            Conectarse();

            int Count = 0;

            Comando.CommandText = "SELECT COUNT(Cur_Nombre) FROM Curso WHERE Cur_Nombre = @pNombre";

            Comando.Parameters.Clear();
            Comando.Parameters.AddWithValue("pNombre", pNombre);

            Count = (int)Comando.ExecuteScalar();

            Desconectarse();

            return Count;
        }
        public void Crear_Curso(Curso pCurso)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "INSERT INTO Curso(Cur_Nombre, Cur_Ano, Cur_Tur_Codigo, Cur_Activo, Cur_Inscripciones_Abiertas) VALUES (@pCurNombre, @pCurAno, @pCurTurno, @pCurActivo, @pCurInsc)";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pCurNombre", pCurso.Nombre);
                Comando.Parameters.AddWithValue("pCurAno", pCurso.Año);
                Comando.Parameters.AddWithValue("pCurTurno", pCurso.Turno.ID);
                Comando.Parameters.AddWithValue("pCurActivo", pCurso.RetornarActivo());
                Comando.Parameters.AddWithValue("pCurInsc", pCurso.InscripcionAbierta);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public DataTable Ver_Cursos_Activos()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Cur_Codigo, Cur_Nombre, Cur_Ano, Tur_Nombre, Cur_Inscripciones_Abiertas FROM Curso, Turno WHERE Cur_Activo = 1 AND Cur_Tur_Codigo = Tur_Codigo";

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public DataTable Ver_Cursos_Inactivos()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Cur_Codigo, Cur_Nombre, Cur_Ano, Tur_Nombre, Cur_Inscripciones_Abiertas FROM Curso, Turno WHERE Cur_Activo = 0 AND Cur_Tur_Codigo = Tur_Codigo";

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void Dar_De_Baja_Curso(Curso pCurso)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Curso SET Cur_Activo = 0 WHERE Cur_Codigo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pCurso.Codigo);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Modificar_Curso(Curso pCurso)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Curso SET Cur_Nombre = @pNombre, Cur_Ano = @pAno, Cur_Tur_Codigo = @pTurno WHERE Cur_Codigo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pCurso.Codigo);
                Comando.Parameters.AddWithValue("pNombre", pCurso.Nombre);
                Comando.Parameters.AddWithValue("pAno", pCurso.Año);
                Comando.Parameters.AddWithValue("pTurno", pCurso.Turno.ID);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Alumnos_del_Curso(Curso pCurso)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Alu_Legajo, Alu_DNI, Alu_Nombre, Alu_Apellido, Alu_Correo_Electronico, Alu_Fecha_Ingreso, Alu_Fecha_Nacimiento, Tur_Nombre, Alu_Activo, Alu_User_Codigo FROM Alumno, Curso, Cursada_de_Alumno, Turno WHERE CurAlu_Alu_Legajo = Alu_Legajo AND Cur_Codigo = CurAlu_Cur_Codigo AND Cur_Codigo = @pCurID AND Cur_Tur_Codigo = Tur_Codigo AND Alu_Tur_Codigo = Tur_Codigo";
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
        public DataTable Ver_Dictados_del_Curso(Curso pCurso)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Dic_Codigo, Mat_Codigo, Mat_Nombre FROM Dictado, Materia, Curso WHERE Dic_Mat_Codigo = Mat_Codigo AND Dic_Cur_Codigo = Cur_Codigo AND Cur_Codigo = @pCurID";

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
        public DataTable Obtener_Curso_de_Materia(Materia pMateria)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Cur_Codigo, Cur_Nombre, Cur_Ano, Tur_Nombre FROM Curso, Materia, Turno WHERE Mat_Cur_Codigo = Cur_Codigo AND Mat_Codigo = @pID AND Cur_Tur_Codigo = Tur_Codigo";

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
        public DataTable Obtener_Curso_de_Dictado(Dictado pDictado) //Done
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Cur_Codigo, Cur_Nombre, Cur_Ano, Tur_Nombre FROM Curso, Dictado, Turno WHERE Cur_Codigo = Dic_Cur_Codigo AND Dic_Codigo = @pID AND Cur_Tur_Codigo = Tur_Codigo";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pDictado.Codigo);

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Cerrar_Inscripcion_Curso(Curso pCurso)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Curso SET Cur_Inscripciones_Abiertas = 0 WHERE Cur_Codigo = @pCurID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pCurID", pCurso.Codigo);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Cursos_Con_Inscripciones_Abiertas()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Cur_Codigo, Cur_Nombre, Cur_Ano, Tur_Nombre FROM Curso, Turno WHERE Cur_Inscripciones_Abiertas = 1 AND Cur_Activo = 1 AND Cur_Tur_Codigo = Tur_Codigo";

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Cursos_Con_Inscripciones_Cerradas()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Cur_Codigo, Cur_Nombre, Cur_Ano, Tur_Nombre FROM Curso, Turno WHERE Cur_Inscripciones_Abiertas = 0 AND Cur_Activo = 1 AND Cur_Tur_Codigo = Tur_Codigo";

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public bool Verificar_Docente_es_Alumno_del_Curso(Docente pDocente, Curso pCurso)
        {
            try
            {
                Conectarse();

                bool SePuedeAgregar = false; //False -> NO || True -> SÍ

                Comando.CommandText = "SELECT User_Codigo FROM Usuario, Docente WHERE User_Codigo = Doc_User_Codigo AND Doc_Legajo = @pDocID";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pDocID", pDocente.Legajo);

                int IDDocente = (int)Comando.ExecuteScalar();

                Comando.CommandText = "SELECT Alu_Legajo FROM Alumno WHERE Alu_User_Codigo = @pUserID";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pUserID", IDDocente);                

                SqlDataReader Reader = Comando.ExecuteReader();
                DataTable DT = new DataTable(); 
                DT.Load(Reader);

                if (DT.Rows.Count > 0)
                {
                    Comando.CommandText = "SELECT COUNT(CurAlu_Codigo) FROM Cursada_de_Alumno WHERE CurAlu_Alu_Legajo = @pAluID AND CurAlu_Cur_Codigo = @pCurID";
                    Comando.Parameters.Clear();
                    Comando.Parameters.AddWithValue("pCurID", pCurso.Codigo);
                    Comando.Parameters.AddWithValue("pAluID", DT.Rows[0].Field<string>(0));

                    int EstaEnCurso = (int)Comando.ExecuteScalar();

                    if (EstaEnCurso == 0)
                    {
                        SePuedeAgregar = true;                     
                    }
                    else
                    {
                        SePuedeAgregar = false;
                    }
                }
                else
                {
                    SePuedeAgregar = true;
                }

                Desconectarse();

                return SePuedeAgregar;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public bool Verificar_Alumno_es_Docente_del_Curso(Alumno pAlumno, Curso pCurso)
        {
            try
            {
                Conectarse();

                bool SePuedeAgregar = false; //False -> NO || True -> SÍ

                Comando.CommandText = "SELECT User_Codigo FROM Usuario, Alumno WHERE User_Codigo = Alu_User_Codigo AND Alu_Legajo = @pAluID";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pAluID", pAlumno.Legajo);

                int IDAlumno = (int)Comando.ExecuteScalar();

                Comando.CommandText = "SELECT Doc_Legajo FROM Docente WHERE Doc_User_Codigo = @pUserID";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pUserID", IDAlumno);

                SqlDataReader Reader = Comando.ExecuteReader();
                DataTable DT = new DataTable();
                DT.Load(Reader);

                if (DT.Rows.Count > 0)
                {
                    Comando.CommandText = "SELECT COUNT(Dic_Codigo) FROM Dictado, DocenteDictado WHERE Dic_Cur_Codigo = @pCurID AND DocDic_Doc_Legajo = @pDocID AND Dic_Codigo = DocDic_Dic_Codigo";
                    Comando.Parameters.Clear();
                    Comando.Parameters.AddWithValue("pCurID", pCurso.Codigo);
                    Comando.Parameters.AddWithValue("pDocID", DT.Rows[0].Field<string>(0));

                    int EstaEnCurso = (int)Comando.ExecuteScalar();

                    if (EstaEnCurso == 0)
                    {
                        SePuedeAgregar = true;
                    }
                    else
                    {
                        SePuedeAgregar = false;
                    }
                }
                else
                {
                    SePuedeAgregar = true;
                }

                Desconectarse();

                return SePuedeAgregar;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Cursos_Con_Inscripciones_Cerradas_Curso_Inactivo()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Cur_Codigo, Cur_Nombre, Cur_Ano, Tur_Nombre FROM Curso, Turno WHERE Cur_Inscripciones_Abiertas = 0 AND Cur_Activo = 0 AND Cur_Tur_Codigo = Tur_Codigo";

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Cursos_Con_Inscripciones_Abiertas_Curso_Inactivo()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Cur_Codigo, Cur_Nombre, Cur_Ano, Tur_Nombre FROM Curso, Turno WHERE Cur_Inscripciones_Abiertas = 1 AND Cur_Activo = 0 AND Cur_Tur_Codigo = Tur_Codigo";

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public int Obtener_Promedio_Curso(Curso pCurso)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT COALESCE(AVG(EvaAlu_Calificacion), 0) FROM Evaluacion_de_Alumno, Cursada_de_Alumno WHERE EvaAlu_CurAlu_Codigo = CurAlu_Codigo AND CurAlu_Cur_Codigo = @pCurID";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pCurID", pCurso.Codigo);

                int Promedio = (int)Comando.ExecuteScalar();

                Desconectarse();

                return Promedio;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Obtener_Materias_de_Evaluaciones_de_Curso(Curso pCurso)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT DISTINCT Mat_Codigo, Mat_Nombre FROM Evaluacion, Materia WHERE Eva_Mat_Codigo = Mat_Codigo AND Mat_Cur_Codigo = @pCurID";
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
        public DataTable Obtener_Evaluaciones_de_Curso(Curso pCurso)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Eva_Codigo, Eva_Titulo, Mat_Codigo, Mat_Nombre, Eva_Fecha FROM Evaluacion, Materia WHERE Eva_Mat_Codigo = Mat_Codigo AND Mat_Cur_Codigo = @pCurID";
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
        public DataTable Obtener_Cursos_de_Materias_Activas()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT DISTINCT Cur_Codigo, Cur_Nombre, Tur_Nombre FROM Turno, Materia LEFT OUTER JOIN Curso ON Mat_Cur_Codigo = Cur_Codigo AND Cur_Codigo = Mat_Cur_Codigo WHERE Mat_Activo = 1 AND Cur_Tur_Codigo = Tur_Codigo";
                Comando.Parameters.Clear();

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Obtener_Cursos_de_Materias_Inactivas()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT DISTINCT Cur_Codigo, Cur_Nombre, Tur_Nombre FROM Turno, Materia LEFT OUTER JOIN Curso ON Mat_Cur_Codigo = Cur_Codigo AND Cur_Codigo = Mat_Cur_Codigo WHERE Mat_Activo = 0 AND Cur_Tur_Codigo = Tur_Codigo";
                Comando.Parameters.Clear();

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
