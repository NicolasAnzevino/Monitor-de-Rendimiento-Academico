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
    public class DAL_Usuario : SQLKit
    {

        public DAL_Usuario() : base()
        {

        }

        public DataTable Login(string pUsername)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT * FROM Usuario WHERE User_Nombre = @USERNAME";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("@USERNAME", pUsername);

                DataTable DT = new DataTable();
                SqlDataReader DR = Comando.ExecuteReader();
                DT.Load(DR);

                if (DT.Rows.Count != 1) { DT = null; }
                else
                {
                    if (DT.Rows[0].ItemArray[5].ToString() == "False") { Desconectarse(); throw new Exception("Esta cuenta ha sido suspendida");  }
                }

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public DataTable Retornar_Usuarios()
        {
            try
            {
                Conectarse();

                DataTable DT = new DataTable();

                Comando.CommandText = "SELECT * FROM Usuario";

                SqlDataReader DR = Comando.ExecuteReader();
                DT.Load(DR);

                Desconectarse();

                return DT;
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

        public DataTable Bloquear_Cuenta(int pID)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Usuario SET User_Activo = 0 WHERE User_Codigo = @USR_ID";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("@USR_ID", pID);
                Comando.ExecuteNonQuery();

                Comando.CommandText = "SELECT * FROM Usuario WHERE User_Codigo = @USR_ID";

                DataTable DT = new DataTable();

                SqlDataReader Reader = Comando.ExecuteReader();

                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public DataTable Obtener_Rol(int pID)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT * FROM Rol Where Rol_Codigo = (SELECT User_Rol_Codigo FROM USUARIO WHERE User_Codigo = @ID)";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("@ID", pID);

                DataTable DT = new DataTable();
                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Obtener_Permisos(int pCodigo)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Perm_Codigo, Perm_Nombre, Perm_EsPadre FROM Permiso, PermisoRol WHERE PermRol_Perm_Codigo = Perm_Codigo and PermRol_Rol_Codigo = @ID";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("@ID", pCodigo);

                DataTable DT = new DataTable();
                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;

            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public DataTable Obtener_Familias()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT * FROM Compuesto";

                DataTable DT = new DataTable();
                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public DataTable Obtener_Hijos(int pID_Padre)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Perm_Codigo, Perm_Nombre, Perm_EsPadre FROM Permiso, Compuesto WHERE Comp_Perm_Codigo = Perm_Codigo AND Comp_Padre_Codigo = @ID";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("@ID", pID_Padre);

                DataTable DT = new DataTable();
                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public bool Verificar_Nombre(string pNombre)
        {
            try
            {
                bool ExisteUsuario = false;

                Conectarse();
                
                Comando.CommandText = "SELECT User_Nombre FROM Usuario WHERE User_Nombre = @pNombre";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("@pNombre", pNombre);

                DataTable DT = new DataTable();
                SqlDataReader Reader = Comando.ExecuteReader();

                DT.Load(Reader);

                if (DT.Rows.Count > 0)
                {
                    ExisteUsuario = true;
                }               

                Desconectarse();

                return ExisteUsuario;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public void Registrar_Usuario(DataRow pDR)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "INSERT INTO Usuario(User_Codigo, User_Nombre, User_Contraseña, User_Rol_Codigo, User_Idio_Codigo, User_Activo, User_DadoBaja, User_Nombre_Real, User_Apellido, User_DNI, User_DVH) VALUES (@pUserID, @pUsername, @pContraseña, @pRolID, @pIdioID, @pActivo, @pBaja, @pNombreReal, @pApellido, @pDNI, @pUserDVH)";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pUserID", pDR.ItemArray[0]);
                Comando.Parameters.AddWithValue("pUsername", pDR.ItemArray[1]);
                Comando.Parameters.AddWithValue("pContraseña", pDR.ItemArray[2]);
                Comando.Parameters.AddWithValue("pRolID", pDR.ItemArray[3]);
                Comando.Parameters.AddWithValue("pIdioID", pDR.ItemArray[4]);
                Comando.Parameters.AddWithValue("pActivo", pDR.ItemArray[5]);
                Comando.Parameters.AddWithValue("pBaja", pDR.ItemArray[6]);
                Comando.Parameters.AddWithValue("pNombreReal", pDR.ItemArray[7]);
                Comando.Parameters.AddWithValue("pApellido", pDR.ItemArray[8]);
                Comando.Parameters.AddWithValue("pDNI", pDR.ItemArray[9]);
                Comando.Parameters.AddWithValue("pUserDVH", pDR.ItemArray[10]);

                Comando.ExecuteNonQuery();

                Comando.CommandText = "INSERT INTO Intentos_Usuario(Int_Cant_Intentos, Int_User_Codigo) VALUES (0, @pUserID)";   
                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public void Actualizar_Digito_Verificador_Vertical(string pDigitoVerificador)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Digito_Verificador_Vertical SET DVV_DIGITO_HASH = @pHash WHERE DVV_Nombre_Tabla = 'Usuario'";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pHash", pDigitoVerificador);
                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public void Actualizar_Digito_Verificador_Horizontal(int pUserID, string pDigitoVerificador)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE USUARIO SET USER_DVH = @pHash WHERE USER_Codigo = @pCodigoUsuario";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pCodigoUsuario", pUserID);
                Comando.Parameters.AddWithValue("pHash", pDigitoVerificador);
                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public void Reestablecer_Cant_Intentos(int pCodigoUsuario)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Intentos_Usuario SET Int_Cant_Intentos = 0 WHERE Int_USER_Codigo = @pCodigoUsuario";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pCodigoUsuario", pCodigoUsuario);
                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public DataTable Obtener_Cant_Intentos()
        {
            try
            {
                DataTable DT = new DataTable();

                Conectarse();

                Comando.CommandText = "SELECT DISTINCT Int_User_Codigo, Int_Cant_Intentos FROM Usuario, Intentos_Usuario WHERE User_Codigo = Int_User_Codigo AND Int_Cant_Intentos > 0";

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public int Actualizar_Cant_Intentos(int pCodigoUsuario)
        {
            try
            {
                Conectarse();

                int Cant_Intentos = 0;

                Comando.CommandText = "SELECT Int_Cant_Intentos FROM Intentos_Usuario, Usuario WHERE Int_USER_Codigo = @pCodigoUsuario";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pCodigoUsuario", pCodigoUsuario);

                Cant_Intentos = (int)Comando.ExecuteScalar();

                Cant_Intentos++;

                Comando.CommandText = "UPDATE Intentos_Usuario SET Int_Cant_Intentos = @pCantIntentos WHERE Int_USER_Codigo = @pCodigoUsuario";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pCodigoUsuario", pCodigoUsuario);
                Comando.Parameters.AddWithValue("pCantIntentos", Cant_Intentos);
                Comando.ExecuteNonQuery();

                Desconectarse();

                return Cant_Intentos;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public int Obtener_Cant_Intentos(int pCodigoUsuario)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT Int_Cant_Intentos FROM Intentos_Usuario, Usuario WHERE Int_User_Codigo = @pCodigoUsuario";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pCodigoUsuario", pCodigoUsuario);

                int Cant_Intentos = (int)Comando.ExecuteScalar();

                Desconectarse();

                return Cant_Intentos;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public bool Comprobar_Primera_Vez()
        {
            try
            {
                bool PrimeraVez = true; //-> False YA HAY DIRECTOR DE ESTUDIOS, True NO HAY
                int CantRegistros = 0;

                Conectarse();

                Comando.CommandText = "SELECT COUNT (User_Codigo) FROM Usuario WHERE USER_Rol_Codigo = 2";            
                CantRegistros = (int)Comando.ExecuteScalar();

                if (CantRegistros != 0)
                {
                    PrimeraVez = false;
                }

                Desconectarse();

                return PrimeraVez;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public int Buscar_ID_Usuario(string pUsername)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT User_Codigo FROM Usuario WHERE User_Nombre = @pUsername";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("@pUsername", pUsername);

                int ID = (int)Comando.ExecuteScalar();
                
                Desconectarse();

                return ID;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public int Obtener_Max_ID_Usuario_Crear_Usuario()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT MAX(User_Codigo) FROM Usuario";              
                int ID = (int)Comando.ExecuteScalar();

                ID++;

                Desconectarse();

                return ID;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public int Obtener_Max_ID_Usuario()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT MAX(User_Codigo) FROM Usuario";
                int ID = (int)Comando.ExecuteScalar();

                Desconectarse();

                return ID;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public DataTable Buscar_Usuario(int pID)
        {
            try
            {
                DataTable DT = new DataTable();

                Conectarse();

                Comando.CommandText = "SELECT * FROM Usuario WHERE User_Codigo = @UserID";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("@UserID", pID);

                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public void Actualizar_Digito_Verificador_Horizontal(DataRow pDR)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Usuario SET USER_DVH = @pUserDVH WHERE User_Codigo = @pUserID";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pUserID", pDR.ItemArray[0]);
                Comando.Parameters.AddWithValue("pUserDVH", pDR.ItemArray[10]);
                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Usuarios_Bloqueados()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT User_Nombre, Rol_Nombre FROM Usuario, Rol WHERE User_Rol_Codigo = Rol_Codigo AND User_Activo = 0";

                SqlDataReader Reader = Comando.ExecuteReader();

                DataTable DT = new DataTable();

                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public int Desbloquear_Cuenta_Y_Devolver_ID(string pUsername)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Usuario SET User_Activo = 1 WHERE User_Nombre = @pUsername";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pUsername", pUsername);

                Comando.ExecuteNonQuery();

                Comando.CommandText = "SELECT User_Codigo FROM Usuario WHERE User_Nombre = @pUsername";

                int ID = (int)Comando.ExecuteScalar();

                Desconectarse();

                return ID;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public DataTable Ver_Usuarios_Disponibles_Alumno()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT User_Codigo, User_Nombre, User_Nombre_Real, User_Apellido, User_DNI, Rol_Nombre FROM Usuario, Rol WHERE User_Codigo in (SELECT User_Codigo FROM Usuario EXCEPT SELECT Alu_User_Codigo FROM Alumno) AND USER_Rol_Codigo != 1 AND USER_Rol_Codigo != 2 AND User_Rol_Codigo = Rol_Codigo";

                SqlDataReader Reader = Comando.ExecuteReader();

                DataTable DT = new DataTable();

                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Usuarios_Disponibles_Docente()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT User_Codigo, User_Nombre, User_Nombre_Real, User_Apellido, User_DNI, Rol_Nombre FROM Usuario, Rol WHERE User_Codigo in (SELECT User_Codigo FROM Usuario EXCEPT SELECT Doc_User_Codigo FROM Docente) AND USER_Rol_Codigo != 1 AND USER_Rol_Codigo != 2 AND User_Rol_Codigo = Rol_Codigo";

                SqlDataReader Reader = Comando.ExecuteReader();

                DataTable DT = new DataTable();

                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Modificar_Usuario(Usuario pUsuario)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Usuario SET User_Nombre_Real = @pNombre, User_Apellido = @pApellido, User_DNI = @pDNI, User_Rol_Codigo = @pRolID WHERE User_Codigo = @pUserID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pNombre", pUsuario.NombreReal);
                Comando.Parameters.AddWithValue("pApellido", pUsuario.Apellido);
                Comando.Parameters.AddWithValue("pDNI", pUsuario.DNI);
                Comando.Parameters.AddWithValue("pRolID", pUsuario.Rol.Codigo);
                Comando.Parameters.AddWithValue("pUserID", pUsuario.ID);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }

        public void Modificar_Usuario(Alumno pAlumno, int pID)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Usuario SET User_Nombre_Real = @pNombre, User_Apellido = @pApellido, User_DNI = @pDNI WHERE User_Codigo = @pUserID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pNombre", pAlumno.Nombre);
                Comando.Parameters.AddWithValue("pApellido", pAlumno.Apellido);
                Comando.Parameters.AddWithValue("pDNI", pAlumno.DNI);
                Comando.Parameters.AddWithValue("pUserID", pID);

                Comando.ExecuteNonQuery();

                Desconectarse();                
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Modificar_Usuario(Docente pDocente, int pID)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Usuario SET User_Nombre_Real = @pNombre, User_Apellido = @pApellido, User_DNI = @pDNI WHERE User_Codigo = @pUserID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pNombre", pDocente.Nombre);
                Comando.Parameters.AddWithValue("pApellido", pDocente.Apellido);
                Comando.Parameters.AddWithValue("pDNI", pDocente.DNI);
                Comando.Parameters.AddWithValue("pUserID", pID);

                Comando.ExecuteNonQuery();

                Desconectarse();

            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public bool Verificar_DNI(int pDNI)
        {
            try
            {
                bool ExisteDNI = false;

                Conectarse();

                Comando.CommandText = "SELECT User_DNI FROM Usuario WHERE User_DNI = @pDNI";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("@pDNI", pDNI);

                DataTable DT = new DataTable();
                SqlDataReader Reader = Comando.ExecuteReader();

                DT.Load(Reader);

                if (DT.Rows.Count > 0)
                {
                    ExisteDNI = true;
                }

                Desconectarse();

                return ExisteDNI;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Usuarios()
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT User_Codigo, User_Nombre, Rol_Codigo, Rol_Nombre, User_DNI, User_Apellido, User_Nombre_Real FROM Usuario, Rol WHERE Rol_Codigo = User_Rol_Codigo AND Rol_Codigo > 1";
                Comando.Parameters.Clear();

                DataTable DT = new DataTable();
                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;

            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Cambiar_Contraseña(string pPassword, Usuario pUsuario)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Usuario SET User_Contraseña = @pPass WHERE User_Codigo = @pUserID";

                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pUserID", pUsuario.ID);
                Comando.Parameters.AddWithValue("pPass", pPassword);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public DataTable Ver_Usuarios_Estado(bool pEstado)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "SELECT User_Codigo, User_Nombre, Rol_Codigo, Rol_Nombre, User_DNI, User_Apellido, User_Nombre_Real FROM Usuario, Rol WHERE Rol_Codigo = User_Rol_Codigo AND Rol_Codigo > 1 AND User_DadoBaja = @pEstado AND User_Activo = 1";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pEstado", pEstado);

                DataTable DT = new DataTable();
                SqlDataReader Reader = Comando.ExecuteReader();
                DT.Load(Reader);

                Desconectarse();

                return DT;
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Dar_de_Baja_Usuario(Usuario pUsuario)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Usuario SET User_DadoBaja = 1 WHERE User_Codigo = @pID";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pUsuario.ID);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
        public void Dar_de_Alta_Usuario(Usuario pUsuario)
        {
            try
            {
                Conectarse();

                Comando.CommandText = "UPDATE Usuario SET User_DadoBaja = 0 WHERE User_Codigo = @pID";
                Comando.Parameters.Clear();
                Comando.Parameters.AddWithValue("pID", pUsuario.ID);

                Comando.ExecuteNonQuery();

                Desconectarse();
            }
            catch (Exception ex) { Desconectarse(); throw new Exception(ex.Message); }
        }
    }
}
