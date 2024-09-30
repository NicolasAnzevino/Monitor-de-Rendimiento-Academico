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
    public class DAL_Dictado : SQLKit
    {
        public DAL_Dictado() : base()
        {

        }

        public void Crear_Dictado(Dictado pDictado)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "INSERT INTO Dictado (Dic_Cur_Codigo, Dic_Mat_Codigo) VALUES (@pCurCodigo, @pMatCodigo)";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pCurCodigo", pDictado.Curso.Codigo);
                Comando.Parameters.AddWithValue("pMatCodigo", pDictado.Materia.Codigo);

                Comando.ExecuteNonQuery();

                Comando.CommandText = "UPDATE Materia SET Mat_Cur_Codigo = @pCurCodigo WHERE Mat_Codigo = @pMatCodigo";
                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Asignar_Docente_Dictado(Docente pDocente, int pID, Curso pCurso)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "INSERT INTO DocenteDictado (DocDic_Doc_Legajo, DocDic_Dic_Codigo) VALUES (@pDocID, @pDicID)";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pDocID", pDocente.Legajo);
                Comando.Parameters.AddWithValue("pDicID", pID);
                Comando.ExecuteNonQuery();              

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public int Obtener_ID_Dictado(Dictado pDictado)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Dic_Codigo FROM Dictado WHERE Dic_Cur_Codigo = @pCurID AND Dic_Mat_Codigo = @pMatID";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pCurID", pDictado.Curso.Codigo);
                Comando.Parameters.AddWithValue("pMatID", pDictado.Materia.Codigo);

                int ID = (int)Comando.ExecuteScalar();

                Desconectarse();

                return ID;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Dictados_Activos()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Dic_Codigo, Mat_Nombre, Cur_Nombre FROM Materia, Dictado, Curso WHERE Dic_Cur_Codigo = Cur_Codigo AND Dic_Mat_Codigo = Mat_Codigo AND Mat_Activo = 1";

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Dictados_Inactivos()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Dic_Codigo, Mat_Nombre, Cur_Nombre FROM Materia, Dictado, Curso WHERE Dic_Cur_Codigo = Cur_Codigo AND Dic_Mat_Codigo = Mat_Codigo AND Mat_Activo = 0";

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Docentes_De_Dictado(Dictado pDictado)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT DISTINCT Doc_Legajo, Doc_Nombre, Doc_Apellido FROM Docente, DocenteDictado, Dictado WHERE DocDic_Doc_Legajo = Doc_Legajo AND DocDic_Dic_Codigo = @pID";
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
        public DataTable Ver_Dictados_del_Docente_Activos(int pID)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Dic_Codigo, Mat_Codigo, Mat_Nombre, Cur_Codigo, Cur_Nombre, Cur_Ano, Tur_Nombre FROM Dictado, Materia, Curso, Docente, DocenteDictado, Turno WHERE Dic_Cur_Codigo = Cur_Codigo AND Dic_Mat_Codigo = Mat_Codigo AND DocDic_Doc_Legajo = Doc_Legajo AND DocDic_Dic_Codigo = Dic_Codigo AND Doc_User_Codigo = @pID AND Mat_Activo = 1 AND Cur_Tur_Codigo = Tur_Codigo";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pID);

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Dictados_del_Docente_Inactivos(int pID)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Dic_Codigo, Mat_Codigo, Mat_Nombre, Cur_Codigo, Cur_Nombre, Cur_Ano, Tur_Nombre FROM Dictado, Materia, Curso, Docente, DocenteDictado, Turno WHERE Dic_Cur_Codigo = Cur_Codigo AND Dic_Mat_Codigo = Mat_Codigo AND DocDic_Doc_Legajo = Doc_Legajo AND DocDic_Dic_Codigo = Dic_Codigo AND Doc_User_Codigo = @pID AND Mat_Activo = 0 AND Cur_Tur_Codigo = Tur_Codigo";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pID);

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Limpiar_Docentes_de_Dictado(Dictado pDictado)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "DELETE DocenteDictado WHERE DocDic_Dic_Codigo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pDictado.Codigo);
                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Actualizar_Dictado(Dictado pDictado, Materia pMateria, Curso pCurso)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Dictado SET Dic_Cur_Codigo = @pCurID, Dic_Mat_Codigo = @pMatID WHERE Dic_Codigo = @pDicID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pDicID", pDictado.Codigo);
                Comando.Parameters.AddWithValue("pCurID", pCurso.Codigo);
                Comando.Parameters.AddWithValue("pMatID", pMateria.Codigo);
                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public int Agregar_Clase(Clase pClase)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "INSERT INTO Clase(Cla_Descripcion, Cla_Fecha, Cla_Dic_Codigo) VALUES (@pDesc, @pFecha, @pDicID)";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pDesc", pClase.Descripcion);
                Comando.Parameters.AddWithValue("pFecha", pClase.Fecha);
                //Comando.Parameters.AddWithValue("pFecha", pClase.Fecha.ToShortDateString());
                Comando.Parameters.AddWithValue("pDicID", pClase.Dictado.Codigo.ToString());

                Comando.ExecuteNonQuery();

                Comando.CommandText = "SELECT MAX(Cla_Codigo) FROM Clase";
                int ID = (int)Comando.ExecuteScalar();

                Comando.ExecuteNonQuery();

                Desconectarse();

                return ID;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Establecer_Temas_de_Clase(Tema pTema, int pIDClase)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "INSERT INTO ClaseTema(ClaTem_Cla_Codigo, ClaTem_Tem_Codigo) VALUES (@pClaseID, @pTemID)";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pClaseID", pIDClase);
                Comando.Parameters.AddWithValue("pTemID", pTema.Codigo);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Clases_de_Dictado(Dictado pDictado)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Cla_Codigo, Cla_Fecha, Cla_Descripcion FROM Clase WHERE Cla_Dic_Codigo = @pDicID";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pDicID", pDictado.Codigo);

                DataTable DT = new DataTable();
                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public int Verificar_Existencia_de_Clase(DateTime pDateTime, Dictado pDictado)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT COUNT(Cla_Codigo) FROM Clase WHERE Cla_Fecha = @pClaFecha AND Cla_Dic_Codigo = @pDicID";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pDicID", pDictado.Codigo);
                Comando.Parameters.AddWithValue("pClaFecha", pDateTime);

                int Existe = (int)Comando.ExecuteScalar(); //Si hay más de 1, no lo dejamos pasar  

                Desconectarse();

                return Existe;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
    }
}
