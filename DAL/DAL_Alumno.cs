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
    public class DAL_Alumno : SQLKit
    {
        public DAL_Alumno() : base()
        {

        }

        public void Agregar_Alumno(string pLegajo, int pDNI, string pCorreoElectronico, string pNombre, string pApellido, int pTurno, DateTime pFechaIngreso, DateTime pFechaNacimiento, Usuario pUsuario)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "INSERT INTO Alumno(Alu_Legajo, Alu_DNI, Alu_Nombre, Alu_Apellido, Alu_Correo_Electronico, Alu_Fecha_Ingreso, Alu_Fecha_Nacimiento, Alu_Tur_Codigo, Alu_Activo, Alu_User_Codigo) VALUES(@pLegajo, @pDNI, @pNombre, @pApellido, @pCorreo, @pFechaIng, @pFechaNac, @pTurno, 1, @pUserID)";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pLegajo", pLegajo);
                Comando.Parameters.AddWithValue("pDNI", pDNI);
                Comando.Parameters.AddWithValue("pNombre", pNombre);
                Comando.Parameters.AddWithValue("pApellido", pApellido);
                Comando.Parameters.AddWithValue("pCorreo", pCorreoElectronico);
                Comando.Parameters.AddWithValue("pTurno", pTurno);
                Comando.Parameters.AddWithValue("pFechaIng", pFechaIngreso);
                Comando.Parameters.AddWithValue("pFechaNac", pFechaNacimiento);
                Comando.Parameters.AddWithValue("pUserID", pUsuario.ID);

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

                Comando.CommandText = "SELECT COUNT(Alu_Legajo) FROM Alumno WHERE Alu_Legajo = @pLegajo";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pLegajo", pLegajo);

                int Total = (int)Comando.ExecuteScalar();

                if (Total!=0) { B = true; }
                else { B = false; }

                Desconectarse();

                return B;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Alumnos_Activos()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Alu_legajo, Alu_DNI, Alu_Nombre, Alu_Apellido, Alu_Correo_Electronico, Alu_Fecha_Ingreso, Alu_Fecha_Nacimiento, Tur_Nombre FROM Alumno, Turno WHERE Alu_Activo = 1 AND Alu_Tur_Codigo = Tur_Codigo";

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Alumnos_Inactivos()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Alu_legajo, Alu_DNI, Alu_Nombre, Alu_Apellido, Alu_Correo_Electronico, Alu_Fecha_Ingreso, Alu_Fecha_Nacimiento, Tur_Nombre FROM Alumno, Turno WHERE Alu_Activo = 0 AND Alu_Tur_Codigo = Tur_Codigo";

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public void Dar_De_Baja_Alumno(Alumno pAlumno)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Alumno SET Alu_Activo= 0 WHERE Alu_Legajo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pAlumno.Legajo);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Modificar_Alumno(Alumno pAlumno)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Alumno SET Alu_DNI = @pDNI, Alu_Nombre = @pNombre, Alu_Apellido = @pApellido, Alu_Correo_Electronico = @pEmail, Alu_Fecha_Ingreso = @pFechaIng, Alu_Fecha_Nacimiento = @pFechaNac, Alu_Tur_Codigo = @pTurno WHERE Alu_Legajo = @pLegajo";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pLegajo", pAlumno.Legajo);
                Comando.Parameters.AddWithValue("pDNI", pAlumno.DNI);
                Comando.Parameters.AddWithValue("pNombre", pAlumno.Nombre);
                Comando.Parameters.AddWithValue("pApellido", pAlumno.Apellido);
                Comando.Parameters.AddWithValue("pEmail", pAlumno.Correo_Electronico);
                Comando.Parameters.AddWithValue("pFechaIng", pAlumno.Fecha_Ingreso);
                Comando.Parameters.AddWithValue("pFechaNac", pAlumno.Fecha_Nacimiento);
                Comando.Parameters.AddWithValue("pTurno", pAlumno.Turno.ID);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Modificar_Alumno(Usuario pUsuario)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Alumno SET Alu_DNI = @pDNI, Alu_Nombre = @pNombre, Alu_Apellido = @pApellido WHERE Alu_User_Codigo = @pID";

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
        public void Modificar_Alumno(Docente pDocente, int pID)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Alumno SET Alu_DNI = @pDNI, Alu_Nombre = @pNombre, Alu_Apellido = @pApellido WHERE Alu_User_Codigo = @pID";

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
        public int Obtener_ID_Usuario_Alumno(Alumno pAlumno)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Alu_User_Codigo FROM Alumno WHERE Alu_Legajo = @pLegajo";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pLegajo", pAlumno.Legajo);

                int ID = (int)Comando.ExecuteScalar();

                Desconectarse();

                return ID;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public void Dar_De_Alta_Alumno(Alumno pAlumno)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Alumno SET Alu_Activo= 1 WHERE Alu_Legajo = @pID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pAlumno.Legajo);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Alumnos_de_Materia(Materia pMateria)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Alu_Legajo, Alu_DNI, Alu_Apellido, Alu_Nombre FROM Alumno, Cursada_de_Alumno, Materia, Curso WHERE CurAlu_Alu_Legajo = Alu_Legajo AND CurAlu_Cur_Codigo = Cur_Codigo AND Mat_Cur_Codigo = Cur_Codigo AND Mat_Codigo = @pID";

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
        public DataTable Obtener_Alumno_Por_ID_Usuario(int pID)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Alu_Legajo, Alu_DNI, Alu_Nombre, Alu_Correo_Electronico, Alu_Apellido, Alu_Fecha_Ingreso, Alu_Fecha_Nacimiento, Alu_Fecha_Nacimiento, Tur_Nombre, Alu_Activo FROM Alumno, Turno WHERE Alu_User_Codigo = @pID AND Alu_Tur_Codigo = Tur_Codigo";

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
        public void Dar_De_Baja_Alumno(Usuario pUsuario)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT COUNT(Alu_Legajo) FROM Alumno WHERE Alu_User_Codigo = @pID";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pUsuario.ID);

                int Cantidad = (int)Comando.ExecuteScalar();

                if (Cantidad == 1)
                {
                    Comando.CommandText = "UPDATE Alumno SET Alu_Activo = 0 WHERE Alu_User_Codigo = @pID";

                    Comando.Parameters.Clear();
                    Comando.Parameters.AddWithValue("pID", pUsuario.ID);

                    Comando.ExecuteNonQuery();
                }               

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Dar_De_Alta_Alumno(Usuario pUsuario)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT COUNT(Alu_Legajo) FROM Alumno WHERE Alu_User_Codigo = @pID";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pUsuario.ID);

                int Cantidad = (int)Comando.ExecuteScalar();

                if (Cantidad == 1)
                {
                    Comando.CommandText = "UPDATE Alumno SET Alu_Activo = 1 WHERE Alu_User_Codigo = @pID";

                    Comando.Parameters.Clear();
                    Comando.Parameters.AddWithValue("pID", pUsuario.ID);

                    Comando.ExecuteNonQuery();
                }                

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

    }
}
