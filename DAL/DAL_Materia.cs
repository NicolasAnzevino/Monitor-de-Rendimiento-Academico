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
    public class DAL_Materia : SQLKit
    {
        public DAL_Materia() : base()
        {

        }

        public int Comprobar_Unicidad_Nombre(string pNombre)
        {
            try
            {
                Conectarse();

                int Count = 0;

                Comando.CommandText = "SELECT COUNT(Mat_Nombre) FROM Materia WHERE Mat_Nombre = @pMatNombre";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pMatNombre", pNombre);

                Count = (int)Comando.ExecuteScalar();

                Desconectarse();

                return Count;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public void Crear_Materia(Materia pMateria)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "INSERT INTO Materia(Mat_Nombre, Mat_Cantidad_Horas_Semanales, Mat_Activo) VALUES(@pMatNombre, @pMatCantHoras, 1)";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pMatNombre", pMateria.Nombre);
                Comando.Parameters.AddWithValue("pMatCantHoras", pMateria.Cant_Horas_Semanales);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public DataTable Ver_Materias_Activas()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Mat_Codigo, Mat_Nombre, Mat_Cantidad_Horas_Semanales, Mat_Activo, Mat_Cur_Codigo FROM Materia WHERE Mat_Activo = 1";

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Materias_Activas_Sin_Curso()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT * FROM Materia WHERE Mat_Activo = 1 AND Mat_Cur_Codigo IS NULL";

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public DataTable Ver_Materias_Inactivas()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Mat_Codigo, Mat_Nombre, Mat_Cantidad_Horas_Semanales, Mat_Activo, Mat_Cur_Codigo FROM Materia WHERE Mat_Activo = 0";

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public void Agregar_Tema_A_Materia(Materia pMateria, Tema pTema)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "INSERT INTO MateriaTema(MatTem_Mat_Codigo, MatTem_Tem_Codigo) VALUES (@pIDMat, @pIDTem)";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pIDMat", pMateria.Codigo);
                Comando.Parameters.AddWithValue("pIDTem", pTema.Codigo);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Quitar_Tema_De_Materia(Materia pMateria, Tema pTema)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "DELETE MateriaTema WHERE MatTem_Mat_Codigo = @pIDMat AND MatTem_Tem_Codigo = @pIDTem";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pIDMat", pMateria.Codigo);
                Comando.Parameters.AddWithValue("pIDTem", pTema.Codigo);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Dar_De_Baja_Materia(Materia pMateria)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Materia SET Mat_Activo = 0 WHERE Mat_Codigo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pMateria.Codigo);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Modificar_Materia(Materia pMateria)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Materia SET Mat_Nombre = @pNombre, Mat_Cantidad_Horas_Semanales = @pCant WHERE Mat_Codigo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pMateria.Codigo);
                Comando.Parameters.AddWithValue("pNombre", pMateria.Nombre);
                Comando.Parameters.AddWithValue("pCant", pMateria.Cant_Horas_Semanales);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Obtener_Materia_de_Dictado(Dictado pDictado)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Mat_Codigo, Mat_Nombre, Mat_Cantidad_Horas_Semanales, Mat_Activo FROM Materia, Dictado WHERE Mat_Codigo = Dic_Mat_Codigo AND Dic_Codigo = @pID";

                DataTable DT = new DataTable();                

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pDictado.Codigo);

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Dar_De_Baja_Materias_de_Curso(List<Dictado> pLD)
        {
            try
            {
                Conectarse();

                foreach (Dictado D in pLD)
                {
                    Comando.CommandText = "UPDATE Materia SET Mat_Activo = 0 WHERE Mat_Codigo = @pID";

                    Comando.Parameters.Clear();
                    Comando.Parameters.AddWithValue("pID", D.Materia.Codigo);

                    Comando.ExecuteNonQuery();
                }                

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public bool Verificar_Evaluaciones_Materia(Materia pMateria)
        {
            try
            {
                Conectarse();

                int Count = 0;

                bool B = false; //False no hay || True sí

                Comando.CommandText = "SELECT COUNT(Eva_Codigo) FROM Evaluacion WHERE Eva_Mat_Codigo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pMateria.Codigo);

                Count = (int)Comando.ExecuteScalar();

                if (Count>0)
                {
                    B = true;
                }

                Desconectarse();

                return B;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Quitar_Curso_de_Materia(Materia pMateria)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Materia SET Mat_Cur_Codigo = NULL WHERE Mat_Codigo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pMateria.Codigo);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Asignar_Curso_a_Materia(Materia pMateria, Curso pCurso)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Materia SET Mat_Cur_Codigo = @pCurID WHERE Mat_Codigo = @pMatID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pMatID", pMateria.Codigo);
                Comando.Parameters.AddWithValue("pCurID", pCurso.Codigo);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Materias_Activas_Con_Curso()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Mat_Codigo, Mat_Nombre, Mat_Cantidad_Horas_Semanales, Mat_Activo, Mat_Cur_Codigo, Cur_Nombre FROM Materia, Curso WHERE Mat_Cur_Codigo IS NOT NULL AND Mat_Activo = 1 AND Mat_Cur_Codigo = Cur_Codigo";

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Materias_Inactivas_Con_Curso()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Mat_Codigo, Mat_Nombre, Mat_Cantidad_Horas_Semanales, Mat_Activo, Mat_Cur_Codigo, Cur_Nombre FROM Materia, Curso WHERE Mat_Cur_Codigo IS NOT NULL AND Mat_Activo = 0 AND Mat_Cur_Codigo = Cur_Codigo";

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
