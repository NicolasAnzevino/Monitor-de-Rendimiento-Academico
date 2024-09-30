using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data;
using Entidades;
using Servicios;
using DAL;

namespace Mapeador
{
    public class MAP_Usuario
    {
        DAL_Usuario Dal_Usuario;

        public MAP_Usuario()
        {
            Dal_Usuario = new DAL_Usuario();
        }

        public Usuario Login(string pUsername)
        {
            try
            {
                DataTable DT = Dal_Usuario.Login(pUsername);

                if (DT is null) { throw new Exception("No existe el usuario"); }

                Usuario U = new Usuario(DT.Rows[0].ItemArray);

                return U;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }        

        public void Bloquear_Cuenta(int pID)
        {
            try
            {
                DataTable DT = Dal_Usuario.Bloquear_Cuenta(pID);

                DT.Rows[0].SetField<string>(10, SecurityManager.HashearRegistro(DT.Rows[0]));

                Dal_Usuario.Actualizar_Digito_Verificador_Horizontal(DT.Rows[0].Field<int>(0), DT.Rows[0].Field<string>(10));

                string DigitoVerificadorVertical = SecurityManager.HashearTabla(Dal_Usuario.Retornar_Usuarios());
                Dal_Usuario.Actualizar_Digito_Verificador_Vertical(DigitoVerificadorVertical);

            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public Rol Asignar_Rol(Usuario pUsuario)
        {
            try
            {
                Rol R;

                DataTable DT = Dal_Usuario.Obtener_Rol(pUsuario.ID);

                R = new Rol(DT.Rows[0].ItemArray);

                AsignarPermisos(R);

                return R;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void AsignarPermisos(Rol pRol)
        {
            try
            {
                List<Permiso> LP = pRol.VerPermisos();

                DataTable DTPermisos = Dal_Usuario.Obtener_Permisos(pRol.Codigo);

                foreach (DataRow dr in DTPermisos.Rows) //Familias de Rol
                {
                    if (dr.Field<bool>(2) is true)
                    {
                        PermisoCompuesto fp = new PermisoCompuesto(dr.Field<int>(0), dr.Field<string>(1));
                        LP.Add(fp);
                    }
                }                

                foreach (PermisoCompuesto fp in LP) //Hijos de Familia
                {
                    DataTable DTHijos = Dal_Usuario.Obtener_Hijos(fp.ID);

                    foreach (DataRow hijo in DTHijos.Rows)
                    {
                        if (hijo.Field<bool>(2) is false)
                        {
                            fp.AgregarPermiso(new PermisoSimple(hijo.Field<int>(0), hijo.Field<string>(1)));
                        }
                        else
                        {
                            PermisoCompuesto permisoCompuesto = new PermisoCompuesto(hijo.Field<int>(0), hijo.Field<string>(1));
                            fp.AgregarPermiso(permisoCompuesto);
                            ObtenerPermisosRecursivo(permisoCompuesto);
                        }                        
                    }
                }

                DataTable DTFamilias = Dal_Usuario.Obtener_Familias();

                foreach (DataRow dr in DTPermisos.Rows) //Sueltos
                {
                    if (dr.Field<bool>(2) is false)
                    {
                        bool huerfano = true;
                        foreach (DataRow drfam in DTFamilias.Rows)
                        {
                            if (drfam.Field<int>(1) == dr.Field<int>(0) && LP.Exists(x => x.ID == drfam.Field<int>(2)))
                            {
                                huerfano = false;
                                break;
                            }
                        }
                        if (huerfano)
                        {
                            PermisoSimple ps = new PermisoSimple(dr.Field<int>(0), dr.Field<string>(1));
                            LP.Add(ps);
                        }
                    }
                }
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }       

        public void ObtenerPermisosRecursivo(PermisoCompuesto pFP)
        {
            DataTable DTHijos = Dal_Usuario.Obtener_Hijos(pFP.ID);

            foreach (DataRow hijo in DTHijos.Rows)
            {
                if (hijo.Field<bool>(2) is false)
                {
                    pFP.AgregarPermiso(new PermisoSimple(hijo.Field<int>(0), hijo.Field<string>(1)));
                }
                else
                {
                    PermisoCompuesto PC = new PermisoCompuesto(hijo.Field<int>(0), hijo.Field<string>(1));
                    pFP.AgregarPermiso(PC);
                    ObtenerPermisosRecursivo(PC);
                }
            }
        }

        public bool Verificar_Nombre(string pNombre)
        {
            try
            {
                return Dal_Usuario.Verificar_Nombre(pNombre);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void Registrar_Usuario(Usuario pUsuario, string pNombreReal, string pApellido, int pDNI)
        {
            try
            {
                DataTable DT = new DataTable();

                DataColumn DC1 = new DataColumn("USER_Codigo", typeof(int));
                DataColumn DC2 = new DataColumn("USER_Nombre", typeof(string));
                DataColumn DC3 = new DataColumn("USER_Contraseña", typeof(string));
                DataColumn DC4 = new DataColumn("USER_Rol_ID", typeof(string));
                DataColumn DC5 = new DataColumn("USER_Idio_Codigo", typeof(string));
                DataColumn DC6 = new DataColumn("USER_Activo", typeof(bool));
                DataColumn DC7 = new DataColumn("USER_DadoBaja", typeof(bool));
                DataColumn DC8 = new DataColumn("USER_Nombre_Real", typeof(string));
                DataColumn DC9 = new DataColumn("USER_Apellido", typeof(string));
                DataColumn DC10 = new DataColumn("USER_DNI", typeof(int));
                DataColumn DC11 = new DataColumn("USER_USER_DVH", typeof(string));

                DT.Columns.Add(DC1); DT.Columns.Add(DC2); DT.Columns.Add(DC3); DT.Columns.Add(DC4); DT.Columns.Add(DC5); DT.Columns.Add(DC6); DT.Columns.Add(DC7); DT.Columns.Add(DC8); DT.Columns.Add(DC9); DT.Columns.Add(DC10); DT.Columns.Add(DC11);

                DataRow DR = DT.NewRow();

                DR.ItemArray = new object[] { Dal_Usuario.Obtener_Max_ID_Usuario_Crear_Usuario(), pUsuario.Nombre, pUsuario.Contraseña, pUsuario.Rol.Codigo, "1", true, false, pNombreReal, pApellido, pDNI,"" };

                string DigitoVerificador = SecurityManager.HashearRegistro(DR);

                DR.SetField<string>(10, DigitoVerificador);

                Dal_Usuario.Registrar_Usuario(DR);

                string DigitoVerificadorVertical = SecurityManager.HashearTabla(Dal_Usuario.Retornar_Usuarios());
                Dal_Usuario.Actualizar_Digito_Verificador_Vertical(DigitoVerificadorVertical);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public void Reestablecer_Cant_Intentos(int pCodigoUsuario)
        {
            try
            {
                Dal_Usuario.Reestablecer_Cant_Intentos(pCodigoUsuario);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public int Actualizar_Cant_Intentos(int pCodigoUsuario)
        {
            try
            {
                return Dal_Usuario.Actualizar_Cant_Intentos(pCodigoUsuario);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public int Obtener_Cant_Intentos(int pCodigoUsuario)
        {
            try
            {
                return Dal_Usuario.Obtener_Cant_Intentos(pCodigoUsuario);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public Dictionary<int, int> Obtener_Cant_Intentos()
        {
            try
            {
                DataTable DT = Dal_Usuario.Obtener_Cant_Intentos();

                Dictionary<int, int> Diccionario = new Dictionary<int, int>();

                foreach (DataRow DR in DT.Rows)
                {
                    Diccionario.Add(DR.Field<int>(0), DR.Field<int>(1));
                }

                return Diccionario;               
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public bool Comprobar_Primera_Vez()
        {
            try
            {
                return Dal_Usuario.Comprobar_Primera_Vez();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public int Buscar_ID_Usuario(string pUsername)
        {
            try
            {
                return Dal_Usuario.Buscar_ID_Usuario(pUsername);                                
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Actualizar_Digitos_Verificadores(int pKey)
        {
            try
            {
                DataTable DT = Dal_Usuario.Buscar_Usuario(pKey);                

                DataRow DR = DT.NewRow();

                DR.ItemArray = new object[] { DT.Rows[0].Field<int>(0), DT.Rows[0].Field<string>(1), DT.Rows[0].Field<string>(2), DT.Rows[0].Field<int>(3), DT.Rows[0].Field<int>(4), DT.Rows[0].Field<bool>(5), DT.Rows[0].Field<bool>(6), DT.Rows[0].Field<string>(7), DT.Rows[0].Field<string>(8), DT.Rows[0].Field<int>(9), "" };

                string DigitoVerificador = SecurityManager.HashearRegistro(DR);

                DR.SetField<string>(10, DigitoVerificador);

                Dal_Usuario.Actualizar_Digito_Verificador_Horizontal(DR);

                string DigitoVerificadorVertical = SecurityManager.HashearTabla(Dal_Usuario.Retornar_Usuarios());
                Dal_Usuario.Actualizar_Digito_Verificador_Vertical(DigitoVerificadorVertical);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public List<Usuario> Ver_Usuarios_Bloqueados()
        {
            try
            {
                DataTable DT = Dal_Usuario.Ver_Usuarios_Bloqueados();

                List<Usuario> L = new List<Usuario>();

                foreach (DataRow DR in DT.Rows)
                {
                    Usuario U = new Usuario(DR.Field<string>(0));
                    U.Rol = new Rol(DR.Field<string>(1));

                    L.Add(U);
                }

                return L;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Desbloquear_Cuenta(string pUsername)
        {
            try
            {
                int ID = Dal_Usuario.Desbloquear_Cuenta_Y_Devolver_ID(pUsername);

                Dal_Usuario.Reestablecer_Cant_Intentos(ID);

                Actualizar_Digitos_Verificadores(ID);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public List<Usuario> Ver_Usuarios_Disponible_Alumno()
        {
            try
            {
                List<Usuario> LU = new List<Usuario>();
                DataTable DT = Dal_Usuario.Ver_Usuarios_Disponibles_Alumno();              

                foreach (DataRow DR in DT.Rows)
                {
                    Usuario U = new Usuario(DR.Field<int>(0), DR.Field<string>(1));
                    U.NombreReal = DR.Field<string>(2);
                    U.Apellido = DR.Field<string>(3);
                    U.DNI = DR.Field<int>(4);
                    U.Rol = new Rol(DR.Field<string>(5));
                    LU.Add(U);
                }

                return LU;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Usuario> Ver_Usuarios_Disponible_Docente()
        {
            try
            {
                List<Usuario> LU = new List<Usuario>();
                DataTable DT = Dal_Usuario.Ver_Usuarios_Disponibles_Docente();

                foreach (DataRow DR in DT.Rows)
                {
                    Usuario U = new Usuario(DR.Field<int>(0), DR.Field<string>(1));
                    U.NombreReal = DR.Field<string>(2);
                    U.Apellido = DR.Field<string>(3);
                    U.DNI = DR.Field<int>(4);
                    U.Rol = new Rol(DR.Field<string>(5));
                    LU.Add(U);
                }

                return LU;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public int Obtener_Max_ID()
        {
            try
            {
                return Dal_Usuario.Obtener_Max_ID_Usuario();
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Modificar_Usuario(Usuario pUsuario)
        {
            try
            {
                Dal_Usuario.Modificar_Usuario(pUsuario);
                Actualizar_Digitos_Verificadores(pUsuario.ID);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Modificar_Usuario(Alumno pAlumno, int pID)
        {
            try
            {
                Dal_Usuario.Modificar_Usuario(pAlumno, pID);
                Actualizar_Digitos_Verificadores(pID);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Modificar_Usuario(Docente pDocente, int pID)
        {
            try
            {
                Dal_Usuario.Modificar_Usuario(pDocente, pID);
                Actualizar_Digitos_Verificadores(pID);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

        public bool Verificar_DNI(int pDNI)
        {
            try
            {
                return Dal_Usuario.Verificar_DNI(pDNI);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public List<Usuario> Ver_Usuarios()
        {
            try
            {
                DataTable DT = Dal_Usuario.Ver_Usuarios();

                List<Usuario> LU = new List<Usuario>();

                foreach (DataRow DR in DT.Rows)
                {
                    Usuario U = new Usuario(DR.Field<int>(0), DR.Field<string>(1), DR.Field<int>(4), DR.Field<string>(5), DR.Field<string>(6));
                    U.Rol = new Rol(DR.Field<int>(2), DR.Field<string>(3));

                    LU.Add(U);
                }

                return LU;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Cambiar_Contraseña(string pPassword, Usuario pUsuario)
        {
            try
            {
                Dal_Usuario.Cambiar_Contraseña(pPassword, pUsuario);
                Actualizar_Digitos_Verificadores(pUsuario.ID);
            }
            catch (Exception ex) {  throw new Exception(ex.Message); }
        }
        public List<Usuario> Ver_Usuarios_Estado(bool pEstado)
        {
            try
            {
                DataTable DT = Dal_Usuario.Ver_Usuarios_Estado(pEstado);

                List<Usuario> LU = new List<Usuario>();

                foreach (DataRow DR in DT.Rows)
                {
                    Usuario U = new Usuario(DR.Field<int>(0), DR.Field<string>(1), DR.Field<int>(4), DR.Field<string>(5), DR.Field<string>(6));
                    U.Rol = new Rol(DR.Field<int>(2), DR.Field<string>(3));

                    LU.Add(U);
                }

                return LU;
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Dar_de_Baja_Usuario(Usuario pUsuario)
        {
            try
            {
                Dal_Usuario.Dar_de_Baja_Usuario(pUsuario);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }
        public void Dar_de_Alta_Usuario(Usuario pUsuario)
        {
            try
            {
                Dal_Usuario.Dar_de_Alta_Usuario(pUsuario);
            }
            catch (Exception ex) { throw new Exception(ex.Message); }
        }

    }
}
