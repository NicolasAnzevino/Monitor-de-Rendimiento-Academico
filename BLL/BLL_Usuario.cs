using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using Servicios;
using Mapeador;

namespace BLL
{
    public class BLL_Usuario
    {
        MAP_Usuario Map_Usuario;

        public BLL_Usuario()
        {
            Map_Usuario = new MAP_Usuario();
            IntentosIncorrectos = new Dictionary<int, int>();
        }

        Dictionary<int, int> IntentosIncorrectos;

        public int Login(string pUsername, string pPassword, bool pExistenInconsistencias)
        {
            try
            {
                Usuario U = Map_Usuario.Login(pUsername);

                string realPwd = SecurityManager.CreateMD5(pPassword);

                if (pExistenInconsistencias == true && U.ID != 1)
                {
                    throw new Exception("Se detectaron inconsistencias, no se permite el acceso al sistema");
                }
                else
                {
                    if (!IntentosIncorrectos.ContainsKey(U.ID))
                    {
                        IntentosIncorrectos.Add(U.ID, Obtener_Cant_Intentos(U.ID));
                    }
                    if (U.DadoDeBaja==true)
                    {
                        throw new Exception("Esta Cuenta se ha dado de baja");
                    }

                    if (realPwd == U.Contraseña)
                    {
                        if (IntentosIncorrectos.ContainsKey(U.ID))
                        {
                            IntentosIncorrectos.Remove(U.ID);
                        }

                        Reestablecer_Cant_Intentos(U.ID);

                        SessionManager.getInstance(U.ID).User = U;

                        Asignar_Rol(U);

                        MessageBox.Show("Bienvenido " + U.Nombre + " al Sistema", "Inicio de sesión", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        LogManager.Escribir(U.ID, "Ha iniciado sesión", 3);

                        return U.ID;
                    }
                    else //USR correcto, PWD no
                    {
                        if (IntentosIncorrectos.ContainsKey(U.ID))
                        {
                            IntentosIncorrectos[U.ID]++;
                            Actualizar_Cant_Intentos(U.ID);
                            LogManager.Escribir(U.ID, "Se intentó iniciar sesión a esta cuenta con credenciales incorrectas", 2);

                            if (IntentosIncorrectos[U.ID] >= 3 && U.ID != 1)
                            {
                                Map_Usuario.Bloquear_Cuenta(U.ID);
                                LogManager.Escribir(U.ID, "Se ha bloqueado la cuenta", 3);
                                throw new Exception("Usuario bloqueado");
                            }
                        }

                        throw new Exception("Contraseña incorrecta " + IntentosIncorrectos[U.ID]); //esto va a decir usuario o contraseña incorrectos, pero ahora pa verlo lo pongo así 
                    }
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }        

        public void Asignar_Rol(Usuario pUsuario)
        {
            try
            {
                pUsuario.Rol = Map_Usuario.Asignar_Rol(pUsuario);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public bool Verificar_Nombre(string pNombre)
        {
            try
            {
                return Map_Usuario.Verificar_Nombre(pNombre);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void Registrar_Usuario(string pUsername, string pContraseña, Rol pRol, string pNombreReal, string pApellido, int pDNI)
        {
            try
            {
                pContraseña = SecurityManager.CreateMD5(pContraseña);
                Usuario Usuario = new Usuario(pUsername, pContraseña);
                Usuario.Rol = pRol;

                Map_Usuario.Registrar_Usuario(Usuario, pNombreReal, pApellido, pDNI);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Reestablecer_Cant_Intentos(int pCodigoUsuario)
        {
            try
            {
                Map_Usuario.Reestablecer_Cant_Intentos(pCodigoUsuario);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public int Actualizar_Cant_Intentos(int pCodigoUsuario)
        {
            try
            {
                return Map_Usuario.Actualizar_Cant_Intentos(pCodigoUsuario);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public int Obtener_Cant_Intentos(int pCodigoUsuario)
        {
            try
            {
                return Map_Usuario.Obtener_Cant_Intentos(pCodigoUsuario);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public bool Comprobar_Primera_Vez()
        {
            try
            {
                return Map_Usuario.Comprobar_Primera_Vez();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }            
        }

        public int Buscar_ID_Usuario(string pUsername)
        {
            try
            {
                return Map_Usuario.Buscar_ID_Usuario(pUsername);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void Actualizar_Digitos_Verificadores(int pKey)
        {
            try
            {
                Map_Usuario.Actualizar_Digitos_Verificadores(pKey);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public List<Usuario> Ver_Usuarios_Bloqueados()
        {
            try
            {
                return Map_Usuario.Ver_Usuarios_Bloqueados();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void Desbloquear_Cuenta(string pUsername)
        {
            try
            {
                Map_Usuario.Desbloquear_Cuenta(pUsername);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public Dictionary<int, int> ObtenerIntententosIncorrectos()
        {
            try
            {
                return IntentosIncorrectos;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public Dictionary<int, int> Obtener_Cant_Intentos()
        {
            try
            {
                return Map_Usuario.Obtener_Cant_Intentos();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public List<Usuario> Ver_Usuarios_Disponible_Alumno()
        {
            return Map_Usuario.Ver_Usuarios_Disponible_Alumno();
        }

        public List<Usuario> Ver_Usuarios_Disponible_Docente()
        {
            return Map_Usuario.Ver_Usuarios_Disponible_Docente();
        }

        public int Obtener_Max_ID()
        {
            try
            {
                return Map_Usuario.Obtener_Max_ID();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Modificar_Usuario(Usuario pUsuario)
        {
            try
            {
                Map_Usuario.Modificar_Usuario(pUsuario);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Modificar_Usuario(Docente pDocente, int pUserID)
        {
            try
            {
                Map_Usuario.Modificar_Usuario(pDocente, pUserID);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Modificar_Usuario(Alumno pAlumno, int pID)
        {
            try
            {
                Map_Usuario.Modificar_Usuario(pAlumno, pID);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public bool Verificar_DNI(int pDNI)
        {
            try
            {
                return Map_Usuario.Verificar_DNI(pDNI);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Usuario> Ver_Usuarios()
        {
            try
            {
                return Map_Usuario.Ver_Usuarios();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Usuario> Ver_Usuarios_Nombre(List<Usuario> pLU, string pNombre)
        {
            IEnumerable<Usuario> IEU = from X in pLU
                                      where X.Nombre.StartsWith(pNombre)
                                      select X;

            List<Usuario> ListaDeConsulta = IEU.ToList();

            return ListaDeConsulta;
        }
        public List<Usuario> Ver_Usuarios_Nombre_Real(List<Usuario> pLU, string pNombre)
        {
            IEnumerable<Usuario> IEU = from X in pLU
                                       where X.NombreReal.StartsWith(pNombre)
                                       select X;

            List<Usuario> ListaDeConsulta = IEU.ToList();

            return ListaDeConsulta;
        }
        public List<Usuario> Ver_Usuarios_Apellido(List<Usuario> pLU, string pApellido)
        {
            IEnumerable<Usuario> IEU = from X in pLU
                                       where X.Apellido.StartsWith(pApellido)
                                       select X;

            List<Usuario> ListaDeConsulta = IEU.ToList();

            return ListaDeConsulta;
        }
        public List<Usuario> Ver_Usuarios_DNI(List<Usuario> pLU, int pDNI)
        {
            IEnumerable<Usuario> IEU = from X in pLU
                                       where X.DNI.ToString().StartsWith(pDNI.ToString())
                                       select X;

            List<Usuario> ListaDeConsulta = IEU.ToList();

            return ListaDeConsulta;
        }
        public List<Usuario> Ver_Usuarios_Rol(List<Usuario> pLU, string pRol)
        {
            IEnumerable<Usuario> IEU = from X in pLU
                                       where X.Rol.Nombre.StartsWith(pRol)
                                       select X;

            List<Usuario> ListaDeConsulta = IEU.ToList();

            return ListaDeConsulta;
        }

        public bool Verificar_Permiso(Usuario pUsuario, string pTag)
        {
            List<Permiso> LP = pUsuario.Rol.VerPermisos();
            bool B = false; //False -> No puede || True -> Tiene permiso

            if (LP.Exists(X=> X.Codigo == pTag))
            {
                B = true;
            }

            if (B==false)
            {
                foreach (Permiso P in LP)
                {
                    if (P is PermisoCompuesto)
                    {
                        PermisoCompuesto PC = P as PermisoCompuesto;

                        foreach (Permiso permiso in PC.RetornaPermisos())
                        {
                            if (permiso.Codigo == pTag)
                            {
                                B = true;
                                break;
                            }
                        }

                        if (B == true)
                        {
                            break;
                        }
                    }

                    if (B == true)
                    {
                        break;
                    }
                }
            }          

            return B;
        }
        public void Cambiar_Contraseña(string pPassword, Usuario pUsuario)
        {
            try
            {
                pPassword = SecurityManager.CreateMD5(pPassword);
                Map_Usuario.Cambiar_Contraseña(pPassword, pUsuario);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Usuario> Ver_Usuarios_Estado(bool pEstado)
        {
            try
            {
                return Map_Usuario.Ver_Usuarios_Estado(pEstado);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Dar_de_Alta_Usuario(Usuario pUsuario)
        {
            try
            {
                Map_Usuario.Dar_de_Alta_Usuario(pUsuario);
                Actualizar_Digitos_Verificadores(pUsuario.ID);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Dar_de_Baja_Usuario(Usuario pUsuario)
        {
            try
            {
                Map_Usuario.Dar_de_Baja_Usuario(pUsuario);
                Actualizar_Digitos_Verificadores(pUsuario.ID);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

    }
}
