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
    public class DAL_Tema : SQLKit
    {
        public DAL_Tema() : base()
        {

        }

        public DataTable Ver_Temas()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT * FROM Tema";

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Temas_De_Materia(Materia pMateria)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Tem_Codigo, Tem_Nombre, Tem_Descripcion FROM Tema, MateriaTema WHERE MatTem_Mat_Codigo = @pID AND Tem_Codigo = MatTem_Tem_Codigo";

                DataTable DT = new DataTable();

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pMateria.Codigo);
                Comando.ExecuteNonQuery();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Agregar_Tema(Tema pTema)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT COALESCE(MAX(Tem_Codigo),0) FROM Tema";

                pTema.Codigo = (int)Comando.ExecuteScalar() +1;

                Comando.CommandText = "INSERT INTO Tema(Tem_Codigo, Tem_Nombre, Tem_Descripcion) VALUES (@pID, @pNombre, @pDesc)";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pTema.Codigo);
                Comando.Parameters.AddWithValue("pNombre", pTema.Nombre);
                Comando.Parameters.AddWithValue("pDesc", pTema.Descripcion);
                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public int Comprobar_Unicidad_Nombre(string pNombre)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT COUNT(Tem_Nombre) FROM Tema WHERE Tem_Nombre = @pNombre";

                DataTable DT = new DataTable();

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pNombre", pNombre);
                int Count = (int)Comando.ExecuteScalar();

                Desconectarse();

                return Count;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Modificar_Tema(Tema pTema)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Tema SET Tem_Nombre = @pNombre, Tem_Descripcion = @pDesc WHERE Tem_Codigo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pNombre", pTema.Nombre);
                Comando.Parameters.AddWithValue("pDesc", pTema.Descripcion);
                Comando.Parameters.AddWithValue("pID", pTema.Codigo);
                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Temas_de_Evaluacion(Evaluacion pEvaluacion)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Tem_Codigo, Tem_Nombre FROM Tema, Evaluacion, EvaluacionTema WHERE Tem_Codigo = EvaTem_Tem_Codigo AND Eva_Codigo = EvaTem_Eva_Codigo AND Eva_Codigo = @pID";

                DataTable DT = new DataTable();

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pEvaluacion.Codigo);
                Comando.ExecuteNonQuery();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Temas_de_Evaluacion_Completo(Evaluacion pEvaluacion)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Tem_Codigo, Tem_Nombre, Tem_Descripcion FROM Tema, Evaluacion, EvaluacionTema WHERE Tem_Codigo = EvaTem_Tem_Codigo AND Eva_Codigo = EvaTem_Eva_Codigo AND Eva_Codigo = @pID";

                DataTable DT = new DataTable();

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pEvaluacion.Codigo);
                Comando.ExecuteNonQuery();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Temas_de_Clase(Clase pClase)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Tem_Codigo, Tem_Nombre, Tem_Descripcion FROM Tema, Clase, ClaseTema WHERE Tem_Codigo = ClaTem_Tem_Codigo AND Cla_Codigo = ClaTem_Cla_Codigo AND Cla_Codigo = @pID";

                DataTable DT = new DataTable();

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pClase.Codigo);
                Comando.ExecuteNonQuery();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public int Comprobar_Existencia_Clases(Tema pTema)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT COUNT(ClaTem_Codigo) FROM ClaseTema WHERE ClaTem_Tem_Codigo = @pID";

                DataTable DT = new DataTable();

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pTema.Codigo);
                int Count = (int)Comando.ExecuteScalar();

                Desconectarse();

                return Count;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public int Comprobar_Existencia_Evaluaciones(Tema pTema)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT COUNT(EvaTem_Codigo) FROM EvaluacionTema WHERE EvaTem_Tem_Codigo = @pID";

                DataTable DT = new DataTable();

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pTema.Codigo);
                int Count = (int)Comando.ExecuteScalar();

                Desconectarse();

                return Count;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

    }
}
