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
    public class DAL_Docente : SQLKit
    {
        public DAL_Docente() : base()
        {

        }

        public void Agregar_Docente(Docente pDocente, int pUserID)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "INSERT INTO Docente(Doc_Legajo, Doc_DNI, Doc_Nombre, Doc_Apellido, Doc_Activo, Doc_User_Codigo) VALUES (@pLegajo, @pDNI, @pNombre, @pApellido, 1, @pUserID)";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pLegajo", pDocente.Legajo);
                Comando.Parameters.AddWithValue("pDNI", pDocente.DNI);
                Comando.Parameters.AddWithValue("pNombre", pDocente.Nombre);
                Comando.Parameters.AddWithValue("pApellido", pDocente.Apellido);
                Comando.Parameters.AddWithValue("pUserID", pUserID);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Modificar_Docente(Docente pDocente, int pID)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Docente SET Doc_DNI = @pDNI, Doc_Nombre = @pNombre, Doc_Apellido = @pApellido WHERE Doc_User_Codigo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pDNI", pDocente.DNI);
                Comando.Parameters.AddWithValue("pNombre", pDocente.Nombre);
                Comando.Parameters.AddWithValue("pApellido", pDocente.Apellido);
                Comando.Parameters.AddWithValue("pID", pID);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Modificar_Docente(Usuario pUsuario)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Docente SET Doc_DNI = @pDNI, Doc_Nombre = @pNombre, Doc_Apellido = @pApellido WHERE Doc_User_Codigo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pDNI", pUsuario.DNI);
                Comando.Parameters.AddWithValue("pNombre", pUsuario.NombreReal);
                Comando.Parameters.AddWithValue("pApellido", pUsuario.Apellido);
                Comando.Parameters.AddWithValue("pID", pUsuario.ID);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Modificar_Docente(Alumno pAlumno, int pID)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Docente SET Doc_DNI = @pDNI, Doc_Nombre = @pNombre, Doc_Apellido = @pApellido WHERE Doc_User_Codigo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pDNI", pAlumno.DNI);
                Comando.Parameters.AddWithValue("pNombre", pAlumno.Nombre);
                Comando.Parameters.AddWithValue("pApellido", pAlumno.Apellido);
                Comando.Parameters.AddWithValue("pID", pID);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public bool Verificar_Unicidad_Legajo(string pLegajo)
        {
            try
            {
                Conectarse();

                bool B = false; //false -> no existe, true -> sí

                Comando.CommandText = "SELECT COUNT(Doc_Legajo) FROM Docente WHERE Doc_Legajo = @pLegajo";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pLegajo", pLegajo);

                int Total = (int)Comando.ExecuteScalar();

                if (Total != 0) { B = true; }
                else { B = false; }

                Desconectarse();

                return B;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Docentes_Activos()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Doc_Legajo, Doc_DNI, Doc_Nombre, Doc_Apellido FROM Docente WHERE Doc_Activo = 1";

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Docentes_Inactivos()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Doc_Legajo, Doc_DNI, Doc_Nombre, Doc_Apellido FROM Docente WHERE Doc_Activo = 0";

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Dar_De_Baja_Docente(Docente pDocente)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Docente SET Doc_Activo= 0 WHERE Doc_Legajo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pDocente.Legajo);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Dar_De_Alta_Docente(Docente pDocente)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Docente SET Doc_Activo= 1 WHERE Doc_Legajo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pDocente.Legajo);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public int Obtener_ID_Usuario_Docente(Docente pDocente)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Doc_User_Codigo FROM Docente WHERE Doc_Legajo= @pLegajo";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pLegajo", pDocente.Legajo);

                int ID = (int)Comando.ExecuteScalar();

                Desconectarse();

                return ID;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Obtener_Docente_Por_ID_Usuario(int pID)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Doc_Legajo, Doc_DNI, Doc_Nombre, Doc_Apellido, Doc_Activo FROM Docente WHERE Doc_User_Codigo = @pID";

                DataTable DT = new DataTable();

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pID);

                string ID = (string)Comando.ExecuteScalar();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Docentes_Evaluaron_Tema(Tema pTema)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT DISTINCT Doc_Legajo, Doc_Activo, Doc_DNI, Doc_Nombre, Doc_Apellido FROM Docente, Evaluacion, EvaluacionTema, Tema, Materia, Evaluacion_de_Alumno WHERE Eva_Mat_Codigo = Mat_Codigo AND EvaTem_Eva_Codigo = Eva_Codigo AND EvaTem_Tem_Codigo = Tem_Codigo AND EvaAlu_Doc_Legajo = Doc_Legajo AND EvaAlu_Eva_Codigo = Eva_Codigo AND Tem_Codigo = @pID";

                DataTable DT = new DataTable();

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pTema.Codigo);

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Dar_De_Baja_Docente(Usuario pUsuario)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT COUNT(Doc_Legajo) FROM Docente WHERE Doc_User_Codigo = @pID";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pUsuario.ID);

                int Cantidad = (int)Comando.ExecuteScalar();

                if (Cantidad == 1)
                {
                    Comando.CommandText = "UPDATE Docente SET Doc_Activo = 0 WHERE Doc_User_Codigo = @pID";

                    Comando.Parameters.Clear();
                    Comando.Parameters.AddWithValue("pID", pUsuario.ID);

                    Comando.ExecuteNonQuery();
                }               

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Dar_De_Alta_Docente(Usuario pUsuario)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT COUNT(Doc_Legajo) FROM Docente WHERE Doc_User_Codigo = @pID";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pUsuario.ID);

                int Cantidad = (int)Comando.ExecuteScalar();

                if (Cantidad == 1)
                {
                    Comando.CommandText = "UPDATE Docente SET Doc_Activo = 1 WHERE Doc_User_Codigo = @pID";

                    Comando.Parameters.Clear();
                    Comando.Parameters.AddWithValue("pID", pUsuario.ID);

                    Comando.ExecuteNonQuery();
                }               

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public int Obtener_Promedio_Docente(Docente pDocente)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT COALESCE(AVG(EvaAlu_Calificacion), 0) FROM Evaluacion_de_Alumno WHERE EvaAlu_Doc_Legajo = @pLegajo";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pLegajo", pDocente.Legajo);

                int ID = (int)Comando.ExecuteScalar();

                Desconectarse();

                return ID;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public int Obtener_Cant_Evaluaciones_Corregidas(Docente pDocente)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT COALESCE(COUNT(EvaAlu_Codigo), 0) FROM Evaluacion_de_Alumno WHERE EvaAlu_Doc_Legajo = @pLegajo";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pLegajo", pDocente.Legajo);

                int ID = (int)Comando.ExecuteScalar();

                Desconectarse();

                return ID;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public int Obtener_Promedio_Docente_Hasta_Fecha(Docente pDocente, DateTime pDateTime)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT COALESCE(AVG(EvaAlu_Calificacion), 0) FROM Evaluacion_de_Alumno WHERE EvaAlu_Doc_Legajo = @pLegajo AND EvaAlu_Fecha <= @pFecha";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pLegajo", pDocente.Legajo);
                Comando.Parameters.AddWithValue("pFecha", pDateTime.Date);

                int ID = (int)Comando.ExecuteScalar();

                Desconectarse();

                return ID;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
    }

}
